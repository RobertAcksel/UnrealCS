//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/KillZVolume.h"
#include "KillZVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API AKillZVolume_ : public AKillZVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AKillZVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AKillZVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;