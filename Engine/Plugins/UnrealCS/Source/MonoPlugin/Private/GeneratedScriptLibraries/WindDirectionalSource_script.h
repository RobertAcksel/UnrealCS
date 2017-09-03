//GENERATED: C++ Code

#pragma once

#include "WindDirectionalSource_script.generated.h"
UCLASS()
class MONOPLUGIN_API AWindDirectionalSource_ : public AWindDirectionalSource
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AWindDirectionalSource::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AWindDirectionalSource::StaticClass",(const void*)StaticClass);
		
	}
	
}
;