//GENERATED: C++ Code

#pragma once

#include "NavigationGraphNode_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavigationGraphNode_ : public ANavigationGraphNode
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavigationGraphNode::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationGraphNode::StaticClass",(const void*)StaticClass);
		
	}
	
}
;