//GENERATED: C++ Code

#pragma once

#include "ReflectionCaptureComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UReflectionCaptureComponent_ : public UReflectionCaptureComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UReflectionCaptureComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UReflectionCaptureComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;