// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "MonoBlueprintGeneratedClass.h"
#include "MonoDomain.h"

#if WITH_MONO

struct FFunctionField
{
	/** Field name */
	FName Name;
	TArray<UProperty*> Params;
	UProperty* ReturnValue;
};

class UMonoScriptBlueprintGeneratedClass;

class FMonoContext : public FScriptContextBase
{
protected:

	void UpdateData();


	MonoClass* Class = nullptr;
	MonoObject* Obj = nullptr;
	uint32 handle = 0;
	MonoMethod* method_BeginPlay = nullptr;
	MonoMethod* method_Tick = nullptr;
	MonoMethod* method_EndPlay = nullptr;
	MonoMethod* method_Destroy = nullptr;
	TWeakObjectPtr<UObject> ObjectPtr;
	FString ClassName;
public:
	FMonoContext();
	virtual ~FMonoContext();

	MonoObject* GetManagedObject() const { return Obj; }

	// FScriptContextBase interface
	virtual bool Initialize(const FString& Code, UObject* Owner) override;
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaTime) override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	virtual void Destroy() override;

	virtual bool SetFloatProperty(const FString& PropertyName, float NewValue) override;
	virtual float GetFloatProperty(const FString& PropertyName) override;
	virtual bool SetIntProperty(const FString& PropertyName, int32 NewValue) override;
	virtual int32 GetIntProperty(const FString& PropertyName) override;
    virtual bool SetObjectProperty(const FString& PropertyName, UObject* NewValue) override;
	virtual UObject* GetObjectProperty(const FString& PropertyName) override;
	virtual bool SetBoolProperty(const FString& PropertyName, bool NewValue) override;
	virtual bool GetBoolProperty(const FString& PropertyName) override;
	virtual bool SetStringProperty(const FString& PropertyName, const FString& NewValue) override;
	virtual FString GetStringProperty(const FString& PropertyName) override;
	virtual bool SetArrayProperty(const FString& PropertyName, const  UObject* CppObj, UArrayProperty* Property) override;
	virtual bool GetArrayProperty(const FString& PropertyName, UObject* CppObj, UArrayProperty* Property) override;
	virtual bool SetStructProperty(const FString& PropertyName, const UObject* CppObj, UStructProperty* Property) override;
	virtual bool GetStructProperty(const FString& PropertyName, UObject* CppObj, UStructProperty* Property) override;

	virtual bool SetClassProperty(const FString& PropertyName, UClass* NewValue);
	virtual UClass* GetClassProperty(const FString& PropertyName);

	virtual void InvokeScriptFunction(FFrame& Stack, RESULT_DECL) override;

#if WITH_EDITOR
	virtual void GetScriptDefinedFields(TArray<FScriptField>& OutFields) override;
	virtual void BeginHotReload() override;
	virtual void EndHotReload() override;
	void CreateFunctions(UMonoScriptBlueprintGeneratedClass* NewClass);
#endif

	MonoMethod* FindMethod(const char* name, int paramCount);
	virtual void* Invoke(void* method, void** param) override;

	/**
	* Pushes all property values from class instance to script.
	*/
	virtual void PushScriptPropertyValues(UMonoScriptBlueprintGeneratedClass* Class, const UObject* Obj) override;

	/**
	* Fetches all property values from script to class instance.
	*/
	virtual void FetchScriptPropertyValues(UMonoScriptBlueprintGeneratedClass* Class, UObject* Obj) override;
};

#endif