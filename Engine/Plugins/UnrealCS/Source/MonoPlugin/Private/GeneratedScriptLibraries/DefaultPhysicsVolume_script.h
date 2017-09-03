//GENERATED: C++ Code

#pragma once

#include "DefaultPhysicsVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADefaultPhysicsVolume_ : public ADefaultPhysicsVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADefaultPhysicsVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADefaultPhysicsVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;