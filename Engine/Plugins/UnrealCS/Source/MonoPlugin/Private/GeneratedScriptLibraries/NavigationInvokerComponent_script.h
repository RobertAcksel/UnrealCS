//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavigationInvokerComponent.h"
#include "NavigationInvokerComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavigationInvokerComponent_ : public UNavigationInvokerComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UNavigationInvokerComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavigationInvokerComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;