//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/PhysicsEngine/DestructibleActor.h"
#include "DestructibleActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADestructibleActor_ : public ADestructibleActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ADestructibleActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADestructibleActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;