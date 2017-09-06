//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavigationTestingActor.h"
#include "NavigationTestingActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ANavigationTestingActor_ : public ANavigationTestingActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ANavigationTestingActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationTestingActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;