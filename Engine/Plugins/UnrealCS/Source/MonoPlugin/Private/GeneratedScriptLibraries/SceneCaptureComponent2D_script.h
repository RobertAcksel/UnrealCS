//GENERATED: C++ Code

#pragma once

#include "SceneCaptureComponent2D_script.generated.h"
UCLASS()
class MONOPLUGIN_API USceneCaptureComponent2D_ : public USceneCaptureComponent2D
{
	GENERATED_BODY()
	static void CaptureScene(USceneCaptureComponent2D* _this)
	{
		_this->CaptureScene();
		
	}
	static UClass* StaticClass(){return USceneCaptureComponent2D::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::CaptureScene",(const void*)CaptureScene);
		mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::StaticClass",(const void*)StaticClass);
		
	}
	
}
;