//GENERATED: C++ Code

#pragma once

#include "DirectionalLight_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADirectionalLight_ : public ADirectionalLight
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADirectionalLight::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADirectionalLight::StaticClass",(const void*)StaticClass);
		
	}
	
}
;