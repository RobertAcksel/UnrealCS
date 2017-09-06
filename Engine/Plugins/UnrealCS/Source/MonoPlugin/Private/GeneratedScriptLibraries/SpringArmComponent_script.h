//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/SpringArmComponent.h"
#include "SpringArmComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API USpringArmComponent_ : public USpringArmComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return USpringArmComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USpringArmComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;