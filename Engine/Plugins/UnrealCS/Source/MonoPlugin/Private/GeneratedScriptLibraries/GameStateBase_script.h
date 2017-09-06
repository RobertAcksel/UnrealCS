//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/GameStateBase.h"
#include "GameStateBase_script.generated.h"

UCLASS()
class MONOPLUGIN_API AGameStateBase_ : public AGameStateBase
{
	GENERATED_BODY()
	static float GetPlayerRespawnDelay(AGameStateBase* _this,AController* Controller)
	{
		float ___ret = _this->GetPlayerRespawnDelay(Controller);
		return ___ret;
		
	}
	static float GetPlayerStartTime(AGameStateBase* _this,AController* Controller)
	{
		float ___ret = _this->GetPlayerStartTime(Controller);
		return ___ret;
		
	}
	static int32 HasMatchStarted(AGameStateBase* _this)
	{
		bool ___ret = _this->HasMatchStarted();
		return ___ret?1:0;
		
	}
	static int32 HasBegunPlay(AGameStateBase* _this)
	{
		bool ___ret = _this->HasBegunPlay();
		return ___ret?1:0;
		
	}
	static float GetServerWorldTimeSeconds(AGameStateBase* _this)
	{
		float ___ret = _this->GetServerWorldTimeSeconds();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return AGameStateBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameStateBase::GetPlayerRespawnDelay",(const void*)GetPlayerRespawnDelay);
		mono_add_internal_call("UnrealEngine.AGameStateBase::GetPlayerStartTime",(const void*)GetPlayerStartTime);
		mono_add_internal_call("UnrealEngine.AGameStateBase::HasMatchStarted",(const void*)HasMatchStarted);
		mono_add_internal_call("UnrealEngine.AGameStateBase::HasBegunPlay",(const void*)HasBegunPlay);
		mono_add_internal_call("UnrealEngine.AGameStateBase::GetServerWorldTimeSeconds",(const void*)GetServerWorldTimeSeconds);
		mono_add_internal_call("UnrealEngine.AGameStateBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;