//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavRelevantComponent.h"
#include "NavRelevantComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavRelevantComponent_ : public UNavRelevantComponent
{
	GENERATED_BODY()
	static void SetNavigationRelevancy(UNavRelevantComponent* _this,int32 bRelevant)
	{
		_this->SetNavigationRelevancy(bRelevant>0?true:false);
		
	}
	static UClass* _StaticClassForProxy(){return UNavRelevantComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavRelevantComponent::SetNavigationRelevancy",(const void*)SetNavigationRelevancy);
		mono_add_internal_call("UnrealEngine.UNavRelevantComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;