//GENERATED: C++ Code

#pragma once

#include "DrawSphereComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UDrawSphereComponent_ : public UDrawSphereComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UDrawSphereComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UDrawSphereComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;