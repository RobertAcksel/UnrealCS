//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/SpectatorPawn.h"
#include "SpectatorPawn_script.generated.h"

UCLASS()
class MONOPLUGIN_API ASpectatorPawn_ : public ASpectatorPawn
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ASpectatorPawn::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASpectatorPawn::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;