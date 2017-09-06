//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/SphereComponent.h"
#include "SphereComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API USphereComponent_ : public USphereComponent
{
	GENERATED_BODY()
	static float GetShapeScale(USphereComponent* _this)
	{
		float ___ret = _this->GetShapeScale();
		return ___ret;
		
	}
	static float GetUnscaledSphereRadius(USphereComponent* _this)
	{
		float ___ret = _this->GetUnscaledSphereRadius();
		return ___ret;
		
	}
	static float GetScaledSphereRadius(USphereComponent* _this)
	{
		float ___ret = _this->GetScaledSphereRadius();
		return ___ret;
		
	}
	static void SetSphereRadius(USphereComponent* _this,float InSphereRadius,int32 bUpdateOverlaps)
	{
		_this->SetSphereRadius(InSphereRadius,bUpdateOverlaps>0?true:false);
		
	}
	static UClass* _StaticClassForProxy(){return USphereComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USphereComponent::GetShapeScale",(const void*)GetShapeScale);
		mono_add_internal_call("UnrealEngine.USphereComponent::GetUnscaledSphereRadius",(const void*)GetUnscaledSphereRadius);
		mono_add_internal_call("UnrealEngine.USphereComponent::GetScaledSphereRadius",(const void*)GetScaledSphereRadius);
		mono_add_internal_call("UnrealEngine.USphereComponent::SetSphereRadius",(const void*)SetSphereRadius);
		mono_add_internal_call("UnrealEngine.USphereComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;