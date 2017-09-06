//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/Light.h"
#include "Light_script.generated.h"

UCLASS()
class MONOPLUGIN_API ALight_ : public ALight
{
	GENERATED_BODY()
	static void OnRep_bEnabled(ALight* _this)
	{
		_this->OnRep_bEnabled();
		
	}
	static UClass* _StaticClassForProxy(){return ALight::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALight::OnRep_bEnabled",(const void*)OnRep_bEnabled);
		mono_add_internal_call("UnrealEngine.ALight::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;