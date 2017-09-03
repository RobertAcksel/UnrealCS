//GENERATED: C++ Code

#pragma once

#include "BrushShape_script.generated.h"
UCLASS()
class MONOPLUGIN_API ABrushShape_ : public ABrushShape
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ABrushShape::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ABrushShape::StaticClass",(const void*)StaticClass);
		
	}
	
}
;