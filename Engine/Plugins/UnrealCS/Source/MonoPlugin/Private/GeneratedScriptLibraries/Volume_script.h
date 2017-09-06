//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/Volume.h"
#include "Volume_script.generated.h"

UCLASS()
class MONOPLUGIN_API AVolume_ : public AVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return AVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;