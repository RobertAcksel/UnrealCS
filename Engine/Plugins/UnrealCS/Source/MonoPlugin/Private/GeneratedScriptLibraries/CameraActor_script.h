//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Camera/CameraActor.h"
#include "CameraActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ACameraActor_ : public ACameraActor
{
	GENERATED_BODY()
	static int32 GetAutoActivatePlayerIndex(ACameraActor* _this)
	{
		int32 ___ret = _this->GetAutoActivatePlayerIndex();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return ACameraActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ACameraActor::GetAutoActivatePlayerIndex",(const void*)GetAutoActivatePlayerIndex);
		mono_add_internal_call("UnrealEngine.ACameraActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;