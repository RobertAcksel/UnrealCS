//GENERATED: C++ Code

#pragma once

#include "AmbientSound_script.generated.h"
UCLASS()
class MONOPLUGIN_API AAmbientSound_ : public AAmbientSound
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AAmbientSound::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AAmbientSound::StaticClass",(const void*)StaticClass);
		
	}
	
}
;