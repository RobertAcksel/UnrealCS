//GENERATED: C++ Code

#pragma once

#include "RecastNavMesh_script.generated.h"
UCLASS()
class MONOPLUGIN_API ARecastNavMesh_ : public ARecastNavMesh
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ARecastNavMesh::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ARecastNavMesh::StaticClass",(const void*)StaticClass);
		
	}
	
}
;