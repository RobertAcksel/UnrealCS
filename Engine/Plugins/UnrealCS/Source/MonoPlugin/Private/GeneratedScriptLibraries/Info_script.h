//GENERATED: C++ Code

#pragma once

#include "Info_script.generated.h"
UCLASS()
class MONOPLUGIN_API AInfo_ : public AInfo
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AInfo::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AInfo::StaticClass",(const void*)StaticClass);
		
	}
	
}
;