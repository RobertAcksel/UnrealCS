//GENERATED: C++ Code

#pragma once

#include "PainCausingVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API APainCausingVolume_ : public APainCausingVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APainCausingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APainCausingVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;