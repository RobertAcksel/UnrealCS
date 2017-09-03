//GENERATED: C++ Code

#pragma once

#include "SceneCaptureComponentCube_script.generated.h"
UCLASS()
class MONOPLUGIN_API USceneCaptureComponentCube_ : public USceneCaptureComponentCube
{
	GENERATED_BODY()
	static void CaptureScene(USceneCaptureComponentCube* _this)
	{
		_this->CaptureScene();
		
	}
	static UClass* StaticClass(){return USceneCaptureComponentCube::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USceneCaptureComponentCube::CaptureScene",(const void*)CaptureScene);
		mono_add_internal_call("UnrealEngine.USceneCaptureComponentCube::StaticClass",(const void*)StaticClass);
		
	}
	
}
;