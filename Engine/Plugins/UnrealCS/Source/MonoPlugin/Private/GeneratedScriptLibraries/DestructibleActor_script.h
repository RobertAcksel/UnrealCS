//GENERATED: C++ Code

#pragma once

#include "DestructibleActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADestructibleActor_ : public ADestructibleActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADestructibleActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADestructibleActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;