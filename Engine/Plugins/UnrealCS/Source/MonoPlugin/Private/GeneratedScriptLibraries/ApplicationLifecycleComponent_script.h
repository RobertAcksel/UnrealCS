//GENERATED: C++ Code

#pragma once

#include "ApplicationLifecycleComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UApplicationLifecycleComponent_ : public UApplicationLifecycleComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UApplicationLifecycleComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UApplicationLifecycleComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;