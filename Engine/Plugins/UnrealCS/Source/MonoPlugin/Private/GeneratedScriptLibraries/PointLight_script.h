//GENERATED: C++ Code

#pragma once

#include "PointLight_script.generated.h"
UCLASS()
class MONOPLUGIN_API APointLight_ : public APointLight
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APointLight::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APointLight::StaticClass",(const void*)StaticClass);
		
	}
	
}
;