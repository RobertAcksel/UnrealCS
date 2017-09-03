//GENERATED: C++ Code

#pragma once

#include "ReflectionCapture_script.generated.h"
UCLASS()
class MONOPLUGIN_API AReflectionCapture_ : public AReflectionCapture
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AReflectionCapture::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AReflectionCapture::StaticClass",(const void*)StaticClass);
		
	}
	
}
;