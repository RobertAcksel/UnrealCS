﻿// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoBlueprintGeneratedClass.h"
#include "MonoPluginPrivatePCH.h"

#include "MonoIntegration.h"
#include "MonoScriptBind_Component.h"

UMonoScriptClass::UMonoScriptClass(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	InSerialize = false;
}

void UMonoScriptClass::AddUniqueNativeFunction(const FName& InName, Native InPointer)
{
	// Find the function in the class's native function lookup table.
	for (int32 FunctionIndex = 0; FunctionIndex < NativeFunctionLookupTable.Num(); ++FunctionIndex)
	{
		FNativeFunctionLookup& NativeFunctionLookup = NativeFunctionLookupTable[FunctionIndex];
		if (NativeFunctionLookup.Name == InName)
		{
			return;
		}
	}
    //TODO:what is this??? where does it go? it seems to just to leak!
	new(NativeFunctionLookupTable)FNativeFunctionLookup(InName, InPointer);
}

void UMonoScriptClass::RemoveNativeFunction(const FName& InName)
{
	// Find the function in the class's native function lookup table.
	for (int32 FunctionIndex = 0; FunctionIndex < NativeFunctionLookupTable.Num(); ++FunctionIndex)
	{
		FNativeFunctionLookup& NativeFunctionLookup = NativeFunctionLookupTable[FunctionIndex];
		if (NativeFunctionLookup.Name == InName)
		{
			NativeFunctionLookupTable.RemoveAt(FunctionIndex);
			return;
		}
	}
}
void UMonoScriptClass::Link(FArchive& Ar, bool bRelinkExistingProperties)
{
	for (auto Function : ScriptFunctions)
	{
		AddUniqueNativeFunction(Function->GetFName(), (Native)&UMonoScriptBind_Component::InvokeMonoEventThunk);
	}
	Super::Link(Ar, bRelinkExistingProperties);
}

void UMonoScriptClass::Bind()
{
	Super::Bind();
}

void UMonoScriptClass::PurgeClass(bool bRecompilingOnLoad)
{
	Super::PurgeClass(bRecompilingOnLoad);
	ScriptProperties.Empty();
}

FScriptContextBase* FScriptContextBase::CreateContext(const FString& SourceCode, UMonoScriptClass* Class, UObject* Owner)
{
	FScriptContextBase* NewContext = NULL;
	NewContext = new FMonoContext();
	if (NewContext)
	{
		if (NewContext->Initialize(SourceCode, Owner))
		{
			//// Push values set by CDO
			//if (Class && Owner)
			//{
			//	NewContext->PushScriptPropertyValues(Class, Owner);
			//}
		}
		else
		{
			delete NewContext;
			NewContext = NULL;
		}
	}
	return NewContext;
}

void FScriptContextBase::GetSupportedScriptFileFormats(TArray<FString>& OutFormats)
{
}


void UMonoScriptClass::Serialize(FArchive& Ar)
{
	InSerialize = true;
	Super::Serialize(Ar);
}
void UMonoScriptClass::PostLoad()
{
	Super::PostLoad();
	InSerialize = false;
}
#if WITH_EDITOR
void UMonoScriptClass::Init(FScriptContextBase* Context)
{
	ScriptFunctions.Empty();
	FMonoContext* MonoContext = (FMonoContext*)Context;
	MonoContext->CreateFunctions(this);
}
#endif


UObject* UMonoScriptClass::CreateDefaultObject()
{
	auto obj = Super::CreateDefaultObject();
	if (obj != nullptr && !InSerialize)	{
        //its a possibility to perform custom init code for specialized classes.
		UMonoScriptBind_Component* Com = Cast<UMonoScriptBind_Component>(obj);
	    if(Com) {
    		Com->InitDefault();
	    }
	}
	return obj;
}
