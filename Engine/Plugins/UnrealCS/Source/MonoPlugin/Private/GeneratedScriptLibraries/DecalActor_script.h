//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/DecalActor.h"
#include "DecalActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADecalActor_ : public ADecalActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ADecalActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADecalActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;