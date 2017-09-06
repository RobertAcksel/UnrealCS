//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/WorldSettings.h"
#include "WorldSettings_script.generated.h"

UCLASS()
class MONOPLUGIN_API AWorldSettings_ : public AWorldSettings
{
	GENERATED_BODY()
	static void OnRep_WorldGravityZ(AWorldSettings* _this)
	{
		_this->OnRep_WorldGravityZ();
		
	}
	static UClass* _StaticClassForProxy(){return AWorldSettings::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AWorldSettings::OnRep_WorldGravityZ",(const void*)OnRep_WorldGravityZ);
		mono_add_internal_call("UnrealEngine.AWorldSettings::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;