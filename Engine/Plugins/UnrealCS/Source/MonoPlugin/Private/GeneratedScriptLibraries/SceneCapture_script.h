//GENERATED: C++ Code

#pragma once

#include "SceneCapture_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASceneCapture_ : public ASceneCapture
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASceneCapture::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASceneCapture::StaticClass",(const void*)StaticClass);
		
	}
	
}
;