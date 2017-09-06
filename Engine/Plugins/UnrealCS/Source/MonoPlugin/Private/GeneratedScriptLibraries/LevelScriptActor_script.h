//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/LevelScriptActor.h"
#include "LevelScriptActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ALevelScriptActor_ : public ALevelScriptActor
{
	GENERATED_BODY()
	static void SetCinematicMode(ALevelScriptActor* _this,int32 bCinematicMode,int32 bHidePlayer,int32 bAffectsHUD,int32 bAffectsMovement,int32 bAffectsTurning)
	{
		_this->SetCinematicMode(bCinematicMode>0?true:false,bHidePlayer>0?true:false,bAffectsHUD>0?true:false,bAffectsMovement>0?true:false,bAffectsTurning>0?true:false);
		
	}
	static int32 RemoteEvent(ALevelScriptActor* _this,MonoString* EventName)
	{
		FName EventName_temp=MonoStringToFName(EventName);
		bool ___ret = _this->RemoteEvent(EventName_temp);
		return ___ret?1:0;
		
	}
	static UClass* _StaticClassForProxy(){return ALevelScriptActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALevelScriptActor::SetCinematicMode",(const void*)SetCinematicMode);
		mono_add_internal_call("UnrealEngine.ALevelScriptActor::RemoteEvent",(const void*)RemoteEvent);
		mono_add_internal_call("UnrealEngine.ALevelScriptActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;