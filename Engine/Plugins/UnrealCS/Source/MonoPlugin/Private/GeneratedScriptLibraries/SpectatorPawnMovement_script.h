//GENERATED: C++ Code

#pragma once

#include "SpectatorPawnMovement_script.generated.h"
UCLASS()
class MONOPLUGIN_API USpectatorPawnMovement_ : public USpectatorPawnMovement
{
	GENERATED_BODY()
	static UClass* StaticClass(){return USpectatorPawnMovement::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USpectatorPawnMovement::StaticClass",(const void*)StaticClass);
		
	}
	
}
;