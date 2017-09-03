// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoBlueprintGeneratedClass.h"
#include "MonoPluginPrivatePCH.h"

#include "MonoContext.h"
#include "MonoScriptBind_Component.h"
#include <functional>

UMonoScriptBlueprintGeneratedClass::UMonoScriptBlueprintGeneratedClass(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	InSerialize = false;
}

void UMonoScriptBlueprintGeneratedClass::AddUniqueNativeFunction(const FName& InName, Native InPointer)
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

void UMonoScriptBlueprintGeneratedClass::RemoveNativeFunction(const FName& InName)
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
void UMonoScriptBlueprintGeneratedClass::Link(FArchive& Ar, bool bRelinkExistingProperties)
{
	for (auto Function : ScriptFunctions)
	{
	    //TODO: link to the correct code for every instantiation
		AddUniqueNativeFunction(Function->GetFName(), (Native)&UMonoScriptBind_Component::InvokeMonoEventThunk);
	}
	Super::Link(Ar, bRelinkExistingProperties);
}

void UMonoScriptBlueprintGeneratedClass::Bind()
{
	Super::Bind();
}

void UMonoScriptBlueprintGeneratedClass::PurgeClass(bool bRecompilingOnLoad)
{
	Super::PurgeClass(bRecompilingOnLoad);
	ScriptProperties.Empty();
}

FScriptContextBase* FScriptContextBase::CreateContext(const FString& SourceCode, UMonoScriptBlueprintGeneratedClass* Class, UObject* Owner)
{
	FScriptContextBase* NewContext = new FMonoContext();
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


void UMonoScriptBlueprintGeneratedClass::Serialize(FArchive& Ar)
{
	InSerialize = true;
	Super::Serialize(Ar);
}
void UMonoScriptBlueprintGeneratedClass::PostLoad()
{
	Super::PostLoad();
	InSerialize = false;
}
#if WITH_EDITOR
void UMonoScriptBlueprintGeneratedClass::Init(FScriptContextBase* Context)
{
	ScriptFunctions.Empty();
	FMonoContext* MonoContext = (FMonoContext*)Context;
    if(Context) {
    	MonoContext->CreateFunctions(this);
    }
}
#endif


UObject* UMonoScriptBlueprintGeneratedClass::CreateDefaultObject()
{
	auto obj = Super::CreateDefaultObject();
	if (obj != nullptr && !InSerialize)	{
        //TODO: this is the place for proper binding of c# and c++ objects
        //its a possibility to perform custom init code for specialized classes.
	    auto Com = Cast<UMonoScriptBind_Component>(obj);
	    if(Com) {
    		Com->InitDefault();
	    }
	}
	return obj;
}
