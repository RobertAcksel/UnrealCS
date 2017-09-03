//GENERATED: C++ Code

#pragma once

#include "SpectatorPawn_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASpectatorPawn_ : public ASpectatorPawn
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASpectatorPawn::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASpectatorPawn::StaticClass",(const void*)StaticClass);
		
	}
	
}
;