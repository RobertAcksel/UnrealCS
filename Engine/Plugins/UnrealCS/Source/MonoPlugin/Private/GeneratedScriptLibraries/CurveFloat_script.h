//GENERATED: C++ Code
#pragma once

class UCurveFloat_
{
	static float GetFloatValue(UCurveFloat* _this,float InTime)
	{
		float ___ret = _this->GetFloatValue(InTime);
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UCurveFloat::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UCurveFloat::GetFloatValue",(const void*)GetFloatValue);
		mono_add_internal_call("UnrealEngine.UCurveFloat::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;