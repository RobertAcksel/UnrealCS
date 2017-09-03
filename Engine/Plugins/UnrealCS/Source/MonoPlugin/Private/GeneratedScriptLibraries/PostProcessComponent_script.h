//GENERATED: C++ Code

#pragma once

#include "PostProcessComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UPostProcessComponent_ : public UPostProcessComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UPostProcessComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UPostProcessComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;