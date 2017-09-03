//GENERATED: C++ Code

#pragma once

#include "PlanarReflectionComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UPlanarReflectionComponent_ : public UPlanarReflectionComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UPlanarReflectionComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UPlanarReflectionComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;