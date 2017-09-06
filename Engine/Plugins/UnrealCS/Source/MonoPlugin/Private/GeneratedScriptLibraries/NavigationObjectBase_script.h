//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/NavigationObjectBase.h"
#include "NavigationObjectBase_script.generated.h"

UCLASS()
class MONOPLUGIN_API ANavigationObjectBase_ : public ANavigationObjectBase
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ANavigationObjectBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationObjectBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;