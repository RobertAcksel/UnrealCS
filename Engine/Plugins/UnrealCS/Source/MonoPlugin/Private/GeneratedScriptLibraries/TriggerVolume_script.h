//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/TriggerVolume.h"
#include "TriggerVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API ATriggerVolume_ : public ATriggerVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ATriggerVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;