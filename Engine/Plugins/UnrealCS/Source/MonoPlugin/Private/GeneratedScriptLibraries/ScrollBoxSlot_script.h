//GENERATED: C++ Code
#pragma once

class UScrollBoxSlot_
{
	static void SetHorizontalAlignment(UScrollBoxSlot* _this,int32 InHorizontalAlignment)
	{
		_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
		
	}
	static void SetPadding(UScrollBoxSlot* _this,FMargin* InPadding)
	{
		_this->SetPadding(*InPadding);
		
	}
	static UClass* _StaticClassForProxy(){return UScrollBoxSlot::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UScrollBoxSlot::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
		mono_add_internal_call("UnrealEngine.UScrollBoxSlot::SetPadding",(const void*)SetPadding);
		mono_add_internal_call("UnrealEngine.UScrollBoxSlot::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;