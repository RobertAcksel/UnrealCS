//GENERATED: C++ Code

#pragma once

#include "TriggerBase_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATriggerBase_ : public ATriggerBase
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATriggerBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerBase::StaticClass",(const void*)StaticClass);
		
	}
	
}
;