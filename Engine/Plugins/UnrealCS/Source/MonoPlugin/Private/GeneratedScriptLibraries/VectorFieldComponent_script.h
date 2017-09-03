//GENERATED: C++ Code

#pragma once

#include "VectorFieldComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UVectorFieldComponent_ : public UVectorFieldComponent
{
	GENERATED_BODY()
	static void SetIntensity(UVectorFieldComponent* _this,float NewIntensity)
	{
		_this->SetIntensity(NewIntensity);
		
	}
	static UClass* StaticClass(){return UVectorFieldComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UVectorFieldComponent::SetIntensity",(const void*)SetIntensity);
		mono_add_internal_call("UnrealEngine.UVectorFieldComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;