//GENERATED: C++ Code
#pragma once

class UInt32Binding_
{
	static int32 GetValue(UInt32Binding* _this)
	{
		int32 ___ret = _this->GetValue();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UInt32Binding::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UInt32Binding::GetValue",(const void*)GetValue);
		mono_add_internal_call("UnrealEngine.UInt32Binding::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;