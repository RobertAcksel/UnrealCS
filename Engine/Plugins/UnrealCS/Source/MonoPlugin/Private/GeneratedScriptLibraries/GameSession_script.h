//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/GameSession.h"
#include "GameSession_script.generated.h"

UCLASS()
class MONOPLUGIN_API AGameSession_ : public AGameSession
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AGameSession::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameSession::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;