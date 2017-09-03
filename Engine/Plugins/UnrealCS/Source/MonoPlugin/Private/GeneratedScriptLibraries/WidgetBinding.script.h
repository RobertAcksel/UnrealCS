//GENERATED: C++ Code

#pragma once

namespace UnrealEngine
{
	class UWidgetBinding_
	{
		static UWidget* GetValue(UWidgetBinding* _this)
		{
			UWidget* ___ret = _this->GetValue();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UWidgetBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWidgetBinding::GetValue",(const void*)GetValue);
			mono_add_internal_call("UnrealEngine.UWidgetBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
