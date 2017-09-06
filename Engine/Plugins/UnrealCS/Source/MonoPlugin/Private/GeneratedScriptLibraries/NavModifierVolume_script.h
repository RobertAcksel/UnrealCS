//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavModifierVolume.h"
#include "NavModifierVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API ANavModifierVolume_ : public ANavModifierVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ANavModifierVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavModifierVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;