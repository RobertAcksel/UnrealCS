//GENERATED: C++ Code

#pragma once

#include "VectorFieldVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API AVectorFieldVolume_ : public AVectorFieldVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AVectorFieldVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AVectorFieldVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;