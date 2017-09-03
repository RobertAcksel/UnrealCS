//GENERATED: C++ Code

#pragma once

#include "ExponentialHeightFog_script.generated.h"
UCLASS()
class MONOPLUGIN_API AExponentialHeightFog_ : public AExponentialHeightFog
{
	GENERATED_BODY()
	static void OnRep_bEnabled(AExponentialHeightFog* _this)
	{
		_this->OnRep_bEnabled();
		
	}
	static UClass* StaticClass(){return AExponentialHeightFog::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AExponentialHeightFog::OnRep_bEnabled",(const void*)OnRep_bEnabled);
		mono_add_internal_call("UnrealEngine.AExponentialHeightFog::StaticClass",(const void*)StaticClass);
		
	}
	
}
;