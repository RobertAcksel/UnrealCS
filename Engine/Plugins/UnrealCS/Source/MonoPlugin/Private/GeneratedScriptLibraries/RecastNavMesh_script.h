//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/RecastNavMesh.h"
#include "RecastNavMesh_script.generated.h"

UCLASS()
class MONOPLUGIN_API ARecastNavMesh_ : public ARecastNavMesh
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ARecastNavMesh::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ARecastNavMesh::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;