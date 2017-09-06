//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/PlayerStart.h"
#include "PlayerStart_script.generated.h"

UCLASS()
class MONOPLUGIN_API APlayerStart_ : public APlayerStart
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return APlayerStart::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlayerStart::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;