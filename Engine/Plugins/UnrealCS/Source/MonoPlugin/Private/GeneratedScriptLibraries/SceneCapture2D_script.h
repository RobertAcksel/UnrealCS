//GENERATED: C++ Code

#pragma once

#include "SceneCapture2D_script.generated.h"
UCLASS()
class MONOPLUGIN_API ASceneCapture2D_ : public ASceneCapture2D
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ASceneCapture2D::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASceneCapture2D::StaticClass",(const void*)StaticClass);
		
	}
	
}
;