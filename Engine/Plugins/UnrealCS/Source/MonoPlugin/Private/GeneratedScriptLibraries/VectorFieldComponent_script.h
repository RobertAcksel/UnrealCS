//GENERATED: C++ Code
#pragma once

class UVectorFieldComponent_
{
	static void SetIntensity(UVectorFieldComponent* _this,float NewIntensity)
	{
		_this->SetIntensity(NewIntensity);
		
	}
	static UClass* _StaticClassForProxy(){return UVectorFieldComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UVectorFieldComponent::SetIntensity",(const void*)SetIntensity);
		mono_add_internal_call("UnrealEngine.UVectorFieldComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;