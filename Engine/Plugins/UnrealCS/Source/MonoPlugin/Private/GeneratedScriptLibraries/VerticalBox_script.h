//GENERATED: C++ Code
#pragma once

class UVerticalBox_
{
	static UVerticalBoxSlot* AddChildToVerticalBox(UVerticalBox* _this,UWidget* Content)
	{
		UVerticalBoxSlot* ___ret = _this->AddChildToVerticalBox(Content);
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UVerticalBox::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UVerticalBox::AddChildToVerticalBox",(const void*)AddChildToVerticalBox);
		mono_add_internal_call("UnrealEngine.UVerticalBox::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;