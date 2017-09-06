//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/LightComponentBase.h"
#include "LightComponentBase_script.generated.h"

UCLASS()
class MONOPLUGIN_API ULightComponentBase_ : public ULightComponentBase
{
	GENERATED_BODY()
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
	static UClass* _StaticClassForProxy(){return ULightComponentBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ULightComponentBase::SetCastVolumetricShadow",(const void*)SetCastVolumetricShadow);
		mono_add_internal_call("UnrealEngine.ULightComponentBase::GetLightColor",(const void*)GetLightColor);
		mono_add_internal_call("UnrealEngine.ULightComponentBase::SetCastShadows",(const void*)SetCastShadows);
		mono_add_internal_call("UnrealEngine.ULightComponentBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;