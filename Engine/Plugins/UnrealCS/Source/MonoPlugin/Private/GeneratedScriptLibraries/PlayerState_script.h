//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/PlayerState.h"
#include "PlayerState_script.generated.h"

UCLASS()
class MONOPLUGIN_API APlayerState_ : public APlayerState
{
	GENERATED_BODY()
	static void OnRep_UniqueId(APlayerState* _this)
	{
		_this->OnRep_UniqueId();
		
	}
	static void OnRep_bIsInactive(APlayerState* _this)
	{
		_this->OnRep_bIsInactive();
		
	}
	static void OnRep_PlayerName(APlayerState* _this)
	{
		_this->OnRep_PlayerName();
		
	}
	static void OnRep_Score(APlayerState* _this)
	{
		_this->OnRep_Score();
		
	}
	static UClass* _StaticClassForProxy(){return APlayerState::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlayerState::OnRep_UniqueId",(const void*)OnRep_UniqueId);
		mono_add_internal_call("UnrealEngine.APlayerState::OnRep_bIsInactive",(const void*)OnRep_bIsInactive);
		mono_add_internal_call("UnrealEngine.APlayerState::OnRep_PlayerName",(const void*)OnRep_PlayerName);
		mono_add_internal_call("UnrealEngine.APlayerState::OnRep_Score",(const void*)OnRep_Score);
		mono_add_internal_call("UnrealEngine.APlayerState::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;