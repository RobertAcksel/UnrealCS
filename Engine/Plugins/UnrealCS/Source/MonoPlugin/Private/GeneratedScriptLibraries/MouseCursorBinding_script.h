//GENERATED: C++ Code
#pragma once

class UMouseCursorBinding_
{
	static int32 GetValue(UMouseCursorBinding* _this)
	{
		TEnumAsByte<EMouseCursor::Type> ___ret = _this->GetValue();
		return (int32)___ret.GetValue();
		
	}
	static UClass* _StaticClassForProxy(){return UMouseCursorBinding::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UMouseCursorBinding::GetValue",(const void*)GetValue);
		mono_add_internal_call("UnrealEngine.UMouseCursorBinding::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;