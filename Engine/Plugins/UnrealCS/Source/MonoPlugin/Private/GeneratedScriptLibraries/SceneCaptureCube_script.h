//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/SceneCaptureCube.h"
#include "SceneCaptureCube_script.generated.h"

UCLASS()
class MONOPLUGIN_API ASceneCaptureCube_ : public ASceneCaptureCube
{
	GENERATED_BODY()
	static void OnInterpToggle(ASceneCaptureCube* _this,int32 bEnable)
	{
		_this->OnInterpToggle(bEnable>0?true:false);
		
	}
	static UClass* _StaticClassForProxy(){return ASceneCaptureCube::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASceneCaptureCube::OnInterpToggle",(const void*)OnInterpToggle);
		mono_add_internal_call("UnrealEngine.ASceneCaptureCube::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;