//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/TriggerCapsule.h"
#include "TriggerCapsule_script.generated.h"

UCLASS()
class MONOPLUGIN_API ATriggerCapsule_ : public ATriggerCapsule
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ATriggerCapsule::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerCapsule::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;