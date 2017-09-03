//GENERATED: C++ Code

#pragma once

#include "PostProcessVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API APostProcessVolume_ : public APostProcessVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APostProcessVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APostProcessVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;