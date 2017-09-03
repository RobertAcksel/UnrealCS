//GENERATED: C++ Code

#pragma once

#include "Volume_script.generated.h"
UCLASS()
class MONOPLUGIN_API AVolume_ : public AVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;