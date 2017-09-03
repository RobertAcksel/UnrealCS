//GENERATED: C++ Code

#pragma once

#include "KillZVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API AKillZVolume_ : public AKillZVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AKillZVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AKillZVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;