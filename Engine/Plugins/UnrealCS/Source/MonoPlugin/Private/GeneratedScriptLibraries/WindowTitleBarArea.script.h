//GENERATED: C++ Code

#pragma once

namespace UnrealEngine
{
	class UWindowTitleBarArea_
	{
		static void SetVerticalAlignment(UWindowTitleBarArea* _this,int32 InVerticalAlignment)
		{
			_this->SetVerticalAlignment((TEnumAsByte<EVerticalAlignment>)InVerticalAlignment);
			
		}
		static void SetHorizontalAlignment(UWindowTitleBarArea* _this,int32 InHorizontalAlignment)
		{
			_this->SetHorizontalAlignment((TEnumAsByte<EHorizontalAlignment>)InHorizontalAlignment);
			
		}
		static void SetPadding(UWindowTitleBarArea* _this,FMargin* InPadding)
		{
			_this->SetPadding(*InPadding);
			
		}
		static UClass* StaticClass(){return UWindowTitleBarArea::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWindowTitleBarArea::SetVerticalAlignment",(const void*)SetVerticalAlignment);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarArea::SetHorizontalAlignment",(const void*)SetHorizontalAlignment);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarArea::SetPadding",(const void*)SetPadding);
			mono_add_internal_call("UnrealEngine.UWindowTitleBarArea::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
