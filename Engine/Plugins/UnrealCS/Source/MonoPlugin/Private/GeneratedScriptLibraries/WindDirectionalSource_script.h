//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/WindDirectionalSource.h"
#include "WindDirectionalSource_script.generated.h"

UCLASS()
class MONOPLUGIN_API AWindDirectionalSource_ : public AWindDirectionalSource
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AWindDirectionalSource::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AWindDirectionalSource::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;