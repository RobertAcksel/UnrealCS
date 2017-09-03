//GENERATED: C++ Code

#pragma once

#include "PhysicsVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API APhysicsVolume_ : public APhysicsVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APhysicsVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APhysicsVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;