//GENERATED: C++ Code

#pragma once

#include "FloatingPawnMovement_script.generated.h"
UCLASS()
class MONOPLUGIN_API UFloatingPawnMovement_ : public UFloatingPawnMovement
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UFloatingPawnMovement::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UFloatingPawnMovement::StaticClass",(const void*)StaticClass);
		
	}
	
}
;