//GENERATED: C++ Code

#pragma once

#include "TriggerSphere_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATriggerSphere_ : public ATriggerSphere
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATriggerSphere::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerSphere::StaticClass",(const void*)StaticClass);
		
	}
	
}
;