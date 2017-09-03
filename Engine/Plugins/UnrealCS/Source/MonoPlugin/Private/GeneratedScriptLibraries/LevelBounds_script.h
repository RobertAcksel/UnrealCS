//GENERATED: C++ Code

#pragma once

#include "LevelBounds_script.generated.h"
UCLASS()
class MONOPLUGIN_API ALevelBounds_ : public ALevelBounds
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ALevelBounds::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALevelBounds::StaticClass",(const void*)StaticClass);
		
	}
	
}
;