//GENERATED: C++ Code

#pragma once

#include "SphereReflectionCapture_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASphereReflectionCapture_ : public ASphereReflectionCapture
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASphereReflectionCapture::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASphereReflectionCapture::StaticClass",(const void*)StaticClass);
		
	}
	
}
;