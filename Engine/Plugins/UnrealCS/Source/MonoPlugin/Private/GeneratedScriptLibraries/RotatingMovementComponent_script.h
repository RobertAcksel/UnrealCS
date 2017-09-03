//GENERATED: C++ Code

#pragma once

#include "RotatingMovementComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API URotatingMovementComponent_ : public URotatingMovementComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return URotatingMovementComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.URotatingMovementComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;