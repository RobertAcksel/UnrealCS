//GENERATED: C++ Code

#pragma once

#include "NavigationGraphNodeComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UNavigationGraphNodeComponent_ : public UNavigationGraphNodeComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UNavigationGraphNodeComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavigationGraphNodeComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;