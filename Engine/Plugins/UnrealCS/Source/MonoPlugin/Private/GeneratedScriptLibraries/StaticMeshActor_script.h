//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/StaticMeshActor.h"
#include "StaticMeshActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API AStaticMeshActor_ : public AStaticMeshActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AStaticMeshActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AStaticMeshActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;