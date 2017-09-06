//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/RotatingMovementComponent.h"
#include "RotatingMovementComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API URotatingMovementComponent_ : public URotatingMovementComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return URotatingMovementComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.URotatingMovementComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;