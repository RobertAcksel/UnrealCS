//GENERATED: C++ Code

#pragma once

#include "LightmassPortalComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API ULightmassPortalComponent_ : public ULightmassPortalComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ULightmassPortalComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ULightmassPortalComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;