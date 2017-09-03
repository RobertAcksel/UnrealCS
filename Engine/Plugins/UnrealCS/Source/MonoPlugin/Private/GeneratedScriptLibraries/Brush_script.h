//GENERATED: C++ Code

#pragma once

#include "Brush_script.generated.h"
UCLASS()
class MONOPLUGIN_API ABrush_ : public ABrush
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ABrush::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ABrush::StaticClass",(const void*)StaticClass);
		
	}
	
}
;