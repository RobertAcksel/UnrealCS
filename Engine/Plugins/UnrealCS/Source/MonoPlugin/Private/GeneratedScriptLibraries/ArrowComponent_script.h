//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/ArrowComponent.h"
#include "ArrowComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UArrowComponent_ : public UArrowComponent
{
	GENERATED_BODY()
	static void SetArrowColor(UArrowComponent* _this,FLinearColor* NewColor)
	{
		_this->SetArrowColor(*NewColor);
		
	}
	static UClass* _StaticClassForProxy(){return UArrowComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UArrowComponent::SetArrowColor",(const void*)SetArrowColor);
		mono_add_internal_call("UnrealEngine.UArrowComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;