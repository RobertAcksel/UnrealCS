//GENERATED: C++ Code

#pragma once

#include "SplineMeshActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASplineMeshActor_ : public ASplineMeshActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASplineMeshActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASplineMeshActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;