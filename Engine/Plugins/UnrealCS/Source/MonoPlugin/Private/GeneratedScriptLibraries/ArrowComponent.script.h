//GENERATED: 

#pragma once

namespace UnrealEngine
{
	class _UArrowComponent
	{
		static void SetArrowColor(UArrowComponent* _this,FLinearColor* NewColor)
		{
			_this->SetArrowColor(*NewColor);
			
		}
		static UClass* StaticClass(){return UArrowComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UArrowComponent::SetArrowColor",(const void*)SetArrowColor);
			mono_add_internal_call("UnrealEngine.UArrowComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
