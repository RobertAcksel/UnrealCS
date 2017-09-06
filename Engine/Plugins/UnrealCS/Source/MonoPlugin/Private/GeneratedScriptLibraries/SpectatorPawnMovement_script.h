//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/SpectatorPawnMovement.h"
#include "SpectatorPawnMovement_script.generated.h"

UCLASS()
class MONOPLUGIN_API USpectatorPawnMovement_ : public USpectatorPawnMovement
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return USpectatorPawnMovement::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USpectatorPawnMovement::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;