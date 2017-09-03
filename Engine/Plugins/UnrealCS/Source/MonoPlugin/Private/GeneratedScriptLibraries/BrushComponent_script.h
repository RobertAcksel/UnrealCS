//GENERATED: C++ Code

#pragma once

#include "BrushComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UBrushComponent_ : public UBrushComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UBrushComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UBrushComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;