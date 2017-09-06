//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/GameNetworkManager.h"
#include "GameNetworkManager_script.generated.h"

UCLASS()
class MONOPLUGIN_API AGameNetworkManager_ : public AGameNetworkManager
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AGameNetworkManager::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameNetworkManager::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;