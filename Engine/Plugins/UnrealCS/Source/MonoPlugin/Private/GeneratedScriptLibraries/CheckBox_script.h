//GENERATED: C++ Code
#pragma once

class UCheckBox_
{
	static void SetIsChecked(UCheckBox* _this,int32 InIsChecked)
	{
		_this->SetIsChecked(InIsChecked>0?true:false);
		
	}
	static int32 IsChecked(UCheckBox* _this)
	{
		bool ___ret = _this->IsChecked();
		return ___ret?1:0;
		
	}
	static int32 IsPressed(UCheckBox* _this)
	{
		bool ___ret = _this->IsPressed();
		return ___ret?1:0;
		
	}
	static UClass* _StaticClassForProxy(){return UCheckBox::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UCheckBox::SetIsChecked",(const void*)SetIsChecked);
		mono_add_internal_call("UnrealEngine.UCheckBox::IsChecked",(const void*)IsChecked);
		mono_add_internal_call("UnrealEngine.UCheckBox::IsPressed",(const void*)IsPressed);
		mono_add_internal_call("UnrealEngine.UCheckBox::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;