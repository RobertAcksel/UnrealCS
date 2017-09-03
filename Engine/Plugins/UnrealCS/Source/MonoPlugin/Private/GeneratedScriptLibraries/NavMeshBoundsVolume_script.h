//GENERATED: C++ Code

#pragma once

#include "NavMeshBoundsVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavMeshBoundsVolume_ : public ANavMeshBoundsVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavMeshBoundsVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavMeshBoundsVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;