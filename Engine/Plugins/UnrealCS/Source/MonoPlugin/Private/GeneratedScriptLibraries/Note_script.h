//GENERATED: C++ Code

#pragma once

#include "Note_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANote_ : public ANote
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANote::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANote::StaticClass",(const void*)StaticClass);
		
	}
	
}
;