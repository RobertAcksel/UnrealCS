//GENERATED: C++ Code

#pragma once

#include "SpringArmComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API USpringArmComponent_ : public USpringArmComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return USpringArmComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USpringArmComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;