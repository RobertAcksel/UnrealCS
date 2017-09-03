//GENERATED: C++ Code

#pragma once

#include "DebugCameraHUD_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADebugCameraHUD_ : public ADebugCameraHUD
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADebugCameraHUD::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADebugCameraHUD::StaticClass",(const void*)StaticClass);
		
	}
	
}
;