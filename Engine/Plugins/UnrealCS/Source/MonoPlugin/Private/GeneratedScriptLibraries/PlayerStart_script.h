//GENERATED: C++ Code

#pragma once

#include "PlayerStart_script.generated.h"
UCLASS()
class MONOPLUGIN_API APlayerStart_ : public APlayerStart
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APlayerStart::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlayerStart::StaticClass",(const void*)StaticClass);
		
	}
	
}
;