//GENERATED: C++ Code

#pragma once

#include "TriggerCapsule_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATriggerCapsule_ : public ATriggerCapsule
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATriggerCapsule::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerCapsule::StaticClass",(const void*)StaticClass);
		
	}
	
}
;