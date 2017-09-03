//GENERATED: C++ Code

#pragma once

#include "PlaneReflectionCapture_script.generated.h"
UCLASS()
class MONOPLUGIN_API APlaneReflectionCapture_ : public APlaneReflectionCapture
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APlaneReflectionCapture::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlaneReflectionCapture::StaticClass",(const void*)StaticClass);
		
	}
	
}
;