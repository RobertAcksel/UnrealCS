//GENERATED: C++ Code

#pragma once

#include "LevelStreamingVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ALevelStreamingVolume_ : public ALevelStreamingVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ALevelStreamingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALevelStreamingVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;