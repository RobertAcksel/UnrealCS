//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/DebugCameraHUD.h"
#include "DebugCameraHUD_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADebugCameraHUD_ : public ADebugCameraHUD
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ADebugCameraHUD::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADebugCameraHUD::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;