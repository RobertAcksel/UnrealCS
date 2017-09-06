//GENERATED: C++ Code
#pragma once

class UContentWidget_
{
	static UWidget* GetContent(UContentWidget* _this)
	{
		UWidget* ___ret = _this->GetContent();
		return ___ret;
		
	}
	static UPanelSlot* SetContent(UContentWidget* _this,UWidget* Content)
	{
		UPanelSlot* ___ret = _this->SetContent(Content);
		return ___ret;
		
	}
	static UPanelSlot* GetContentSlot(UContentWidget* _this)
	{
		UPanelSlot* ___ret = _this->GetContentSlot();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UContentWidget::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UContentWidget::GetContent",(const void*)GetContent);
		mono_add_internal_call("UnrealEngine.UContentWidget::SetContent",(const void*)SetContent);
		mono_add_internal_call("UnrealEngine.UContentWidget::GetContentSlot",(const void*)GetContentSlot);
		mono_add_internal_call("UnrealEngine.UContentWidget::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;