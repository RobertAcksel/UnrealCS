//GENERATED: C++ Code

#pragma once

#include "TriggerBox_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATriggerBox_ : public ATriggerBox
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATriggerBox::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerBox::StaticClass",(const void*)StaticClass);
		
	}
	
}
;