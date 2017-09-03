//GENERATED: C++ Code

#pragma once

#include "PrecomputedVisibilityVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API APrecomputedVisibilityVolume_ : public APrecomputedVisibilityVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return APrecomputedVisibilityVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.APrecomputedVisibilityVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;