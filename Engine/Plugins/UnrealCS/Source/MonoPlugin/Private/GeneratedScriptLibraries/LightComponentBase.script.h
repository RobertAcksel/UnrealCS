#pragma once

namespace UnrealEngine
{
	class _ULightComponentBase
	{
		static void SetCastVolumetricShadow(ULightComponentBase* _this,int32 bNewValue)
		{
			_this->SetCastVolumetricShadow(bNewValue>0?true:false);
			
		}
		static FLinearColor GetLightColor(ULightComponentBase* _this)
		{
			FLinearColor ___ret = _this->GetLightColor();
			return ___ret;
			
		}
		static void SetCastShadows(ULightComponentBase* _this,int32 bNewValue)
		{
			_this->SetCastShadows(bNewValue>0?true:false);
			
		}
		static UClass* StaticClass(){return ULightComponentBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightComponentBase::SetCastVolumetricShadow",(const void*)SetCastVolumetricShadow);
			mono_add_internal_call("UnrealEngine.ULightComponentBase::GetLightColor",(const void*)GetLightColor);
			mono_add_internal_call("UnrealEngine.ULightComponentBase::SetCastShadows",(const void*)SetCastShadows);
			mono_add_internal_call("UnrealEngine.ULightComponentBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
