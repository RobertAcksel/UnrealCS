//GENERATED: C++ Code

#pragma once

#include "LightmassImportanceVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ALightmassImportanceVolume_ : public ALightmassImportanceVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ALightmassImportanceVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ALightmassImportanceVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;