//GENERATED: C++ Code
#pragma once

class UBrushBinding_
{
	static FSlateBrush GetValue(UBrushBinding* _this)
	{
		FSlateBrush ___ret = _this->GetValue();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UBrushBinding::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UBrushBinding::GetValue",(const void*)GetValue);
		mono_add_internal_call("UnrealEngine.UBrushBinding::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;