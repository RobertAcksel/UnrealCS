//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/SkyLight.h"
#include "SkyLight_script.generated.h"

UCLASS()
class MONOPLUGIN_API ASkyLight_ : public ASkyLight
{
	GENERATED_BODY()
	static void OnRep_bEnabled(ASkyLight* _this)
	{
		_this->OnRep_bEnabled();
		
	}
	static UClass* _StaticClassForProxy(){return ASkyLight::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ASkyLight::OnRep_bEnabled",(const void*)OnRep_bEnabled);
		mono_add_internal_call("UnrealEngine.ASkyLight::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;