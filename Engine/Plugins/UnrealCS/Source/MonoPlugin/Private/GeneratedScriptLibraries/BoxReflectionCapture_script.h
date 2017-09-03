//GENERATED: C++ Code

#pragma once

#include "BoxReflectionCapture_script.generated.h"
UCLASS()
class MONOPLUGIN_API ABoxReflectionCapture_ : public ABoxReflectionCapture
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ABoxReflectionCapture::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ABoxReflectionCapture::StaticClass",(const void*)StaticClass);
		
	}
	
}
;