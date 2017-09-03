//GENERATED: C++ Code

#pragma once

#include "NavigationInvokerComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UNavigationInvokerComponent_ : public UNavigationInvokerComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UNavigationInvokerComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavigationInvokerComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;