//GENERATED: C++ Code

#pragma once

#include "DecalActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADecalActor_ : public ADecalActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADecalActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADecalActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;