//GENERATED: C++ Code

#pragma once

#include "PlanarReflection_script.generated.h"
UCLASS()
class MONOPLUGIN_API APlanarReflection_ : public APlanarReflection
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APlanarReflection::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APlanarReflection::StaticClass",(const void*)StaticClass);
		
	}
	
}
;