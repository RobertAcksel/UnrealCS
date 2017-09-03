//GENERATED: C++ Code

#pragma once

#include "NavigationGraph_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavigationGraph_ : public ANavigationGraph
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavigationGraph::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationGraph::StaticClass",(const void*)StaticClass);
		
	}
	
}
;