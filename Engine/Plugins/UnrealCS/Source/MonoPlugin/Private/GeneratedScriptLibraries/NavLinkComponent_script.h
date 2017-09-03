//GENERATED: C++ Code

#pragma once

#include "NavLinkComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UNavLinkComponent_ : public UNavLinkComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UNavLinkComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavLinkComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;