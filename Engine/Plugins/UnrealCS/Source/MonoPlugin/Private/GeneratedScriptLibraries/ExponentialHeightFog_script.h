//GENERATED: C++ Code
#pragma once

class AExponentialHeightFog_
{
	static void OnRep_bEnabled(AExponentialHeightFog* _this)
	{
		_this->OnRep_bEnabled();
		
	}
	static UClass* _StaticClassForProxy(){return AExponentialHeightFog::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AExponentialHeightFog::OnRep_bEnabled",(const void*)OnRep_bEnabled);
		mono_add_internal_call("UnrealEngine.AExponentialHeightFog::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;