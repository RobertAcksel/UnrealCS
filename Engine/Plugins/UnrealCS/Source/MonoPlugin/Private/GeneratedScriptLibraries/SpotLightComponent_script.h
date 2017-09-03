//GENERATED: C++ Code

#pragma once

#include "SpotLightComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API USpotLightComponent_ : public USpotLightComponent
{
	GENERATED_BODY()
	static void SetOuterConeAngle(USpotLightComponent* _this,float NewOuterConeAngle)
	{
		_this->SetOuterConeAngle(NewOuterConeAngle);
		
	}
	static void SetInnerConeAngle(USpotLightComponent* _this,float NewInnerConeAngle)
	{
		_this->SetInnerConeAngle(NewInnerConeAngle);
		
	}
	static UClass* StaticClass(){return USpotLightComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USpotLightComponent::SetOuterConeAngle",(const void*)SetOuterConeAngle);
		mono_add_internal_call("UnrealEngine.USpotLightComponent::SetInnerConeAngle",(const void*)SetInnerConeAngle);
		mono_add_internal_call("UnrealEngine.USpotLightComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;