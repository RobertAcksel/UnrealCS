//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/InputComponent.h"
#include "InputComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UInputComponent_ : public UInputComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UInputComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UInputComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;