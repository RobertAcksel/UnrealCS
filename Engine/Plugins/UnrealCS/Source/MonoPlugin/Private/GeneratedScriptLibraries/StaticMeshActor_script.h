//GENERATED: C++ Code

#pragma once

#include "StaticMeshActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API AStaticMeshActor_ : public AStaticMeshActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AStaticMeshActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AStaticMeshActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;