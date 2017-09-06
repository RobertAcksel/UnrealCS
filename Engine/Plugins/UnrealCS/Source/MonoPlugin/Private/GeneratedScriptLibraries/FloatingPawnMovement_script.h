//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/FloatingPawnMovement.h"
#include "FloatingPawnMovement_script.generated.h"

UCLASS()
class MONOPLUGIN_API UFloatingPawnMovement_ : public UFloatingPawnMovement
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UFloatingPawnMovement::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UFloatingPawnMovement::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;