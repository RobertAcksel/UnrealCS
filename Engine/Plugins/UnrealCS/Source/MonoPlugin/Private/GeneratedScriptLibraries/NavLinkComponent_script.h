//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavLinkComponent.h"
#include "NavLinkComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavLinkComponent_ : public UNavLinkComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UNavLinkComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavLinkComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;