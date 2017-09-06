//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/PhysicsVolume.h"
#include "PhysicsVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API APhysicsVolume_ : public APhysicsVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return APhysicsVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APhysicsVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;