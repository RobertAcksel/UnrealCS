//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavigationData.h"
#include "NavigationData_script.generated.h"

UCLASS()
class MONOPLUGIN_API ANavigationData_ : public ANavigationData
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ANavigationData::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationData::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;