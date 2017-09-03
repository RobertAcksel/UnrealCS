//GENERATED: C++ Code

#pragma once

#include "NavModifierVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavModifierVolume_ : public ANavModifierVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavModifierVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavModifierVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;