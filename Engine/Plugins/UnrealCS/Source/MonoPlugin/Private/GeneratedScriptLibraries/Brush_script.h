//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/Brush.h"
#include "Brush_script.generated.h"

UCLASS()
class MONOPLUGIN_API ABrush_ : public ABrush
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ABrush::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ABrush::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;