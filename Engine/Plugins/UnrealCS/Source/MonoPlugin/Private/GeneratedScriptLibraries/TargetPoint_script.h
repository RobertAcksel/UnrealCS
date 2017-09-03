//GENERATED: C++ Code

#pragma once

#include "TargetPoint_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATargetPoint_ : public ATargetPoint
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATargetPoint::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATargetPoint::StaticClass",(const void*)StaticClass);
		
	}
	
}
;