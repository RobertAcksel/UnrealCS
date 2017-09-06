//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/LODActor.h"
#include "LODActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ALODActor_ : public ALODActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ALODActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALODActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;