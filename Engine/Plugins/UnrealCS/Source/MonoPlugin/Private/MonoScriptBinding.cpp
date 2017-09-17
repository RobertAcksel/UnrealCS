// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoScriptBinding.h"
#include "MonoPluginPrivatePCH.h"

//#if WITH_MONO
#include "MonoDomain.h"
#include "MonoContext.h"

IMonoScriptBinding::IMonoScriptBinding()
{
	PrimaryComponentTick.bCanEverTick = true;
	bTickInEditor = false;
	bAutoActivate = true;
	bWantsInitializeComponent = true;
}

void IMonoScriptBinding::OnRegister()
{
#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventBeginHotReload.AddUObject(this, &IMonoScriptBinding::BeginHotReload);
		FMonoDomain::Get()->eventEndHotReload.AddUObject(this, &IMonoScriptBinding::EndHotReload);
	}
#endif
	auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
	if (ScriptClass && GetWorld() && GetWorld()->WorldType != EWorldType::Editor)
	{
		Context.Reset(FScriptContextBase::CreateContext(ScriptClass->ClassName, ScriptClass, GetSelf()));
		if (!Context)
		{
			bAutoActivate = false;
			PrimaryComponentTick.bCanEverTick = false;
		}
		else
		{

			//When initializing, synchronize the attribute once
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());

			HotReloadData();
			if (methodOnRegister)
			{
				Context->Invoke(methodOnRegister, nullptr);
				if(GetSyncProperty())
					Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
			}
		}
	}
}

//Initialize the default parameters
void IMonoScriptBinding::InitDefault()
{
	auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
	if (ScriptClass)
	{
		TUniquePtr<FScriptContextBase> TempContext;
		TempContext.Reset(FScriptContextBase::CreateContext(ScriptClass->ClassName, ScriptClass, GetSelf()));
		if (!TempContext)
		{
			bAutoActivate = false;
			PrimaryComponentTick.bCanEverTick = false;
		}
		else
		{
			if (GetSelf()->HasAnyFlags(RF_ClassDefaultObject))
				TempContext->FetchScriptPropertyValues(ScriptClass, GetSelf());

			//Remove the context, so there is no need to hot update (the default object only need attributes)
			TempContext = nullptr;
		}
	}
}
void IMonoScriptBinding::OnUnregister()
{
	if (Context && methodOnUnregister)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->Invoke(methodOnUnregister, nullptr);
		if (GetSyncProperty())
			Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
	}
	Super::OnUnregister();
}

void IMonoScriptBinding::InitializeComponent()
{
	Super::InitializeComponent();
	if (Context && methodInitializeComponent)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->Invoke(methodInitializeComponent, nullptr);
		if (GetSyncProperty())
			Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
	}
}

void IMonoScriptBinding::BeginPlay()
{
	Super::BeginPlay();
	if (Context)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->BeginPlay();
		if (GetSyncProperty())
			Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
	}
}

void IMonoScriptBinding::TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction *ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	if (Context)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->Tick(DeltaTime);
		if (GetSyncProperty())
			Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
	}
};

void IMonoScriptBinding::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (Context)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->EndPlay(EndPlayReason);
		if (GetSyncProperty())
			Context->FetchScriptPropertyValues(ScriptClass, GetSelf());
	}

	Super::EndPlay(EndPlayReason);
}

void IMonoScriptBinding::BeginDestroy()
{
	if (Context)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		if (GetSyncProperty())
			Context->PushScriptPropertyValues(ScriptClass, GetSelf());
		Context->Destroy();
		Context = NULL;
	}

#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventBeginHotReload.RemoveAll(GetSelf());
		FMonoDomain::Get()->eventEndHotReload.RemoveAll(GetSelf());
	}
#endif
	Super::BeginDestroy();
}

void IMonoScriptBinding::InvokeMonoEventThunk(FFrame& Stack, RESULT_DECL)
{
	if (Context)
	{
		Context->InvokeScriptFunction(Stack, RESULT_PARAM);
	}

	P_FINISH;
}

void IMonoScriptBinding::HotReloadData()
{
	//查找方法
	FMonoContext* MonoContext = (FMonoContext*)Context.Get();
	methodInitializeComponent = MonoContext->FindMethod("InitializeComponent", 0);
	methodOnRegister = MonoContext->FindMethod("OnRegister", 0);
	methodOnUnregister = MonoContext->FindMethod("OnUnregister", 0);
}
#if WITH_MONO_HOTRELOAD
void IMonoScriptBinding::EndHotReload()
{
	if (Context)
	{
		Context->EndHotReload();
		HotReloadData();
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		Context->PushScriptPropertyValues(ScriptClass, GetSelf());
	}
}

void IMonoScriptBinding::BeginHotReload()
{
	if (Context)
	{
		Context->BeginHotReload();
	}
}
#endif

#if WITH_EDITOR
void IMonoScriptBinding::PostEditChangeProperty(struct FPropertyChangedEvent & PropertyChangedEvent){
	if (Context)
	{
		auto ScriptClass = UMonoScriptBlueprintGeneratedClass::GetScriptGeneratedClass(GetClass());
		Context->PushScriptPropertyValues(ScriptClass, GetSelf());
	}
}
#endif

//#endif