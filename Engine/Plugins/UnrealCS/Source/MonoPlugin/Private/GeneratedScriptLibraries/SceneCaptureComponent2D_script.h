//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/SceneCaptureComponent2D.h"
#include "SceneCaptureComponent2D_script.generated.h"

UCLASS()
class MONOPLUGIN_API USceneCaptureComponent2D_ : public USceneCaptureComponent2D
{
	GENERATED_BODY()
	static void CaptureScene(USceneCaptureComponent2D* _this)
	{
		_this->CaptureScene();
		
	}
	static UClass* _StaticClassForProxy(){return USceneCaptureComponent2D::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::CaptureScene",(const void*)CaptureScene);
		mono_add_internal_call("UnrealEngine.USceneCaptureComponent2D::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;