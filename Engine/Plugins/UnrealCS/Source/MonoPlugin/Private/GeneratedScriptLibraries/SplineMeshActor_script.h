//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/SplineMeshActor.h"
#include "SplineMeshActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ASplineMeshActor_ : public ASplineMeshActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ASplineMeshActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASplineMeshActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;