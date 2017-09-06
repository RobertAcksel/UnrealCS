//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavLinkCustomComponent.h"
#include "NavLinkCustomComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavLinkCustomComponent_ : public UNavLinkCustomComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UNavLinkCustomComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavLinkCustomComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;