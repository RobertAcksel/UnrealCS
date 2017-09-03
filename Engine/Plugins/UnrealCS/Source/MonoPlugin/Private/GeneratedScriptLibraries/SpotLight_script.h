//GENERATED: C++ Code

#pragma once

#include "SpotLight_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASpotLight_ : public ASpotLight
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASpotLight::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASpotLight::StaticClass",(const void*)StaticClass);
		
	}
	
}
;