//GENERATED: C++ Code

#pragma once

#include "NavLinkCustomComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UNavLinkCustomComponent_ : public UNavLinkCustomComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UNavLinkCustomComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavLinkCustomComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;