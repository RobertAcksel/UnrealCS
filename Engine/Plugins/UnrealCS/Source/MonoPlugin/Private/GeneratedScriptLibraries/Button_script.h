//GENERATED: C++ Code
#pragma once

class UButton_
{
	static int32 IsPressed(UButton* _this)
	{
		bool ___ret = _this->IsPressed();
		return ___ret?1:0;
		
	}
	static void SetBackgroundColor(UButton* _this,FLinearColor* InBackgroundColor)
	{
		_this->SetBackgroundColor(*InBackgroundColor);
		
	}
	static void SetColorAndOpacity(UButton* _this,FLinearColor* InColorAndOpacity)
	{
		_this->SetColorAndOpacity(*InColorAndOpacity);
		
	}
	static void SetStyle(UButton* _this,FButtonStyle* InStyle)
	{
		_this->SetStyle(*InStyle);
		
	}
	static UClass* _StaticClassForProxy(){return UButton::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UButton::IsPressed",(const void*)IsPressed);
		mono_add_internal_call("UnrealEngine.UButton::SetBackgroundColor",(const void*)SetBackgroundColor);
		mono_add_internal_call("UnrealEngine.UButton::SetColorAndOpacity",(const void*)SetColorAndOpacity);
		mono_add_internal_call("UnrealEngine.UButton::SetStyle",(const void*)SetStyle);
		mono_add_internal_call("UnrealEngine.UButton::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;