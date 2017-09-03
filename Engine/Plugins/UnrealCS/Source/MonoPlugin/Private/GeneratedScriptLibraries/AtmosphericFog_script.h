//GENERATED: C++ Code

#pragma once

#include "AtmosphericFog_script.generated.h"
UCLASS()
class MONOPLUGIN_API AAtmosphericFog_ : public AAtmosphericFog
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AAtmosphericFog::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AAtmosphericFog::StaticClass",(const void*)StaticClass);
		
	}
	
}
;