//GENERATED: C++ Code

#pragma once

#include "TriggerVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATriggerVolume_ : public ATriggerVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATriggerVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;