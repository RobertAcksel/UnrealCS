//GENERATED: C++ Code
#pragma once

class UBoolBinding_
{
	static int32 GetValue(UBoolBinding* _this)
	{
		bool ___ret = _this->GetValue();
		return ___ret?1:0;
		
	}
	static UClass* _StaticClassForProxy(){return UBoolBinding::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UBoolBinding::GetValue",(const void*)GetValue);
		mono_add_internal_call("UnrealEngine.UBoolBinding::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;