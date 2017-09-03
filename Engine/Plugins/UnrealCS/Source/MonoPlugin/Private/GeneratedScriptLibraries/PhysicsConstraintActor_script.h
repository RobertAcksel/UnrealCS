//GENERATED: C++ Code

#pragma once

#include "PhysicsConstraintActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API APhysicsConstraintActor_ : public APhysicsConstraintActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APhysicsConstraintActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APhysicsConstraintActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;