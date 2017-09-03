//GENERATED: C++ Code

#pragma once

#include "ShapeComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UShapeComponent_ : public UShapeComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UShapeComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UShapeComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;