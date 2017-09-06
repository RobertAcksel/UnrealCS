//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/TriggerBox.h"
#include "TriggerBox_script.generated.h"

UCLASS()
class MONOPLUGIN_API ATriggerBox_ : public ATriggerBox
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ATriggerBox::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATriggerBox::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;