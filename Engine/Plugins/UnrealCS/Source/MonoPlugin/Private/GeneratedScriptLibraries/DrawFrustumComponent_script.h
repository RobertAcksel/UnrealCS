//GENERATED: C++ Code

#pragma once

#include "DrawFrustumComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UDrawFrustumComponent_ : public UDrawFrustumComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UDrawFrustumComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UDrawFrustumComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;