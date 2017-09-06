//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/ApplicationLifecycleComponent.h"
#include "ApplicationLifecycleComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UApplicationLifecycleComponent_ : public UApplicationLifecycleComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UApplicationLifecycleComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UApplicationLifecycleComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;