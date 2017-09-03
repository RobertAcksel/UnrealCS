//GENERATED: C++ Code

#pragma once

#include "NavMeshRenderingComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UNavMeshRenderingComponent_ : public UNavMeshRenderingComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UNavMeshRenderingComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavMeshRenderingComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;