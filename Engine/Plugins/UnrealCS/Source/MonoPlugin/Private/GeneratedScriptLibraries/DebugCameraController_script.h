//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/DebugCameraController.h"
#include "DebugCameraController_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADebugCameraController_ : public ADebugCameraController
{
	GENERATED_BODY()
	static void SetPawnMovementSpeedScale(ADebugCameraController* _this,float NewSpeedScale)
	{
		_this->SetPawnMovementSpeedScale(NewSpeedScale);
		
	}
	static AActor* GetSelectedActor(ADebugCameraController* _this)
	{
		AActor* ___ret = _this->GetSelectedActor();
		return ___ret;
		
	}
	static void ToggleDisplay(ADebugCameraController* _this)
	{
		_this->ToggleDisplay();
		
	}
	static void ShowDebugSelectedInfo(ADebugCameraController* _this)
	{
		_this->ShowDebugSelectedInfo();
		
	}
	static UClass* _StaticClassForProxy(){return ADebugCameraController::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADebugCameraController::SetPawnMovementSpeedScale",(const void*)SetPawnMovementSpeedScale);
		mono_add_internal_call("UnrealEngine.ADebugCameraController::GetSelectedActor",(const void*)GetSelectedActor);
		mono_add_internal_call("UnrealEngine.ADebugCameraController::ToggleDisplay",(const void*)ToggleDisplay);
		mono_add_internal_call("UnrealEngine.ADebugCameraController::ShowDebugSelectedInfo",(const void*)ShowDebugSelectedInfo);
		mono_add_internal_call("UnrealEngine.ADebugCameraController::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;