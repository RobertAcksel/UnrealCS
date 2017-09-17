// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "Components/ActorComponent.h"

class FScriptContextBase;
typedef struct _MonoMethod MonoMethod;

/**
* Script-extendable class basics
*/
class MONOPLUGIN_API IMonoScriptBinding
{
public:
	void InvokeMonoEventThunk(FFrame& Stack, RESULT_DECL);

#if WITH_MONO_HOTRELOAD
	void BeginHotReload();
    void EndHotReload();
#endif

	//初始化默认参数
	void InitDefault();

    //_UObject需要用到这个方法
	FScriptContextBase* GetContext() const { return Context.Get(); }

    virtual UWorld * GetWorld() const = 0;
    virtual UClass * GetClass() const = 0;
    virtual UObject * GetSelf() const = 0;
protected:
    virtual bool & GetSyncProperty() const = 0;

    virtual void PostEditChangeProperty(FPropertyChangedEvent & PropertyChangedEvent);

    IMonoScriptBinding();

    void InitializeComponent();
    void BeginPlay();
    void EndPlay(const EEndPlayReason::Type EndPlayReason);

    void BeginDestroy();

    void HotReloadData();

    void OnRegister();
    void OnUnregister();

	MonoMethod* methodInitializeComponent;
	MonoMethod* methodOnRegister;
	MonoMethod* methodOnUnregister;

	TUniquePtr<FScriptContextBase> Context;
};
