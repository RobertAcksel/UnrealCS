//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/AbstractNavData.h"
#include "AbstractNavData_script.generated.h"

UCLASS()
class MONOPLUGIN_API AAbstractNavData_ : public AAbstractNavData
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AAbstractNavData::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AAbstractNavData::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;