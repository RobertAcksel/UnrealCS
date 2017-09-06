//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/GameState.h"
#include "GameState_script.generated.h"

UCLASS()
class MONOPLUGIN_API AGameState_ : public AGameState
{
	GENERATED_BODY()
	static void OnRep_ElapsedTime(AGameState* _this)
	{
		_this->OnRep_ElapsedTime();
		
	}
	static void OnRep_MatchState(AGameState* _this)
	{
		_this->OnRep_MatchState();
		
	}
	static UClass* _StaticClassForProxy(){return AGameState::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameState::OnRep_ElapsedTime",(const void*)OnRep_ElapsedTime);
		mono_add_internal_call("UnrealEngine.AGameState::OnRep_MatchState",(const void*)OnRep_MatchState);
		mono_add_internal_call("UnrealEngine.AGameState::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;