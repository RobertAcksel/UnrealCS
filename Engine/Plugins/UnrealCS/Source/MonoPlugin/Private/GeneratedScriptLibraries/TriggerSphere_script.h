//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/TriggerSphere.h"
#include "TriggerSphere_script.generated.h"

UCLASS()
class MONOPLUGIN_API ATriggerSphere_ : public ATriggerSphere
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ATriggerSphere::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerSphere::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;