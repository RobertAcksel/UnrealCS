//GENERATED: C++ Code

#pragma once

#include "PlayerStartPIE_script.generated.h"
UCLASS()
class MONOPLUGIN_API APlayerStartPIE_ : public APlayerStartPIE
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APlayerStartPIE::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlayerStartPIE::StaticClass",(const void*)StaticClass);
		
	}
	
}
;