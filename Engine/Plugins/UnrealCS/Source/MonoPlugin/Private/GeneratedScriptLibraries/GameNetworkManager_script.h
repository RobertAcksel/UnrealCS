//GENERATED: C++ Code

#pragma once

#include "GameNetworkManager_script.generated.h"
UCLASS()
class MONOPLUGIN_API AGameNetworkManager_ : public AGameNetworkManager
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AGameNetworkManager::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameNetworkManager::StaticClass",(const void*)StaticClass);
		
	}
	
}
;