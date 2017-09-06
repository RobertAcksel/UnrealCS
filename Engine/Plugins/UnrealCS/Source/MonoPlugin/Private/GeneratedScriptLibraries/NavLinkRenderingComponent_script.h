//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavLinkRenderingComponent.h"
#include "NavLinkRenderingComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavLinkRenderingComponent_ : public UNavLinkRenderingComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UNavLinkRenderingComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavLinkRenderingComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;