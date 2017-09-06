//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Components/ShapeComponent.h"
#include "ShapeComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UShapeComponent_ : public UShapeComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UShapeComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UShapeComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;