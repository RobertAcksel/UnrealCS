//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/PainCausingVolume.h"
#include "PainCausingVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API APainCausingVolume_ : public APainCausingVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return APainCausingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APainCausingVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;