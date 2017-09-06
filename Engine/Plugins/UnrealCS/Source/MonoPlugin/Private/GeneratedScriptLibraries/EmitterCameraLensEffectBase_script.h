//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Particles/EmitterCameraLensEffectBase.h"
#include "EmitterCameraLensEffectBase_script.generated.h"

UCLASS()
class MONOPLUGIN_API AEmitterCameraLensEffectBase_ : public AEmitterCameraLensEffectBase
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AEmitterCameraLensEffectBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AEmitterCameraLensEffectBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;