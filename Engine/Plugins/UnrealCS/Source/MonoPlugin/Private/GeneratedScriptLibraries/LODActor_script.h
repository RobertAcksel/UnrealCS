//GENERATED: C++ Code

#pragma once

#include "LODActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ALODActor_ : public ALODActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ALODActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALODActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;