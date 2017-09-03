//GENERATED: C++ Code

#pragma once

#include "InputComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UInputComponent_ : public UInputComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UInputComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UInputComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;