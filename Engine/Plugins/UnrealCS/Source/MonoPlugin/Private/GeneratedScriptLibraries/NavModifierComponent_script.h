//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavModifierComponent.h"
#include "NavModifierComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavModifierComponent_ : public UNavModifierComponent
{
	GENERATED_BODY()
	static void SetAreaClass(UNavModifierComponent* _this,TSubclassOf<UNavArea>  NewAreaClass)
	{
		_this->SetAreaClass(NewAreaClass);
		
	}
	static UClass* _StaticClassForProxy(){return UNavModifierComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavModifierComponent::SetAreaClass",(const void*)SetAreaClass);
		mono_add_internal_call("UnrealEngine.UNavModifierComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;