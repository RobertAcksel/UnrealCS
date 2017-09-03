//GENERATED: C++ Code

#pragma once

#include "LightmassPortal_script.generated.h"
UCLASS()
class MONOPLUGIN_API ALightmassPortal_ : public ALightmassPortal
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ALightmassPortal::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALightmassPortal::StaticClass",(const void*)StaticClass);
		
	}
	
}
;