//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Sound/AmbientSound.h"
#include "AmbientSound_script.generated.h"

UCLASS()
class MONOPLUGIN_API AAmbientSound_ : public AAmbientSound
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AAmbientSound::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AAmbientSound::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;