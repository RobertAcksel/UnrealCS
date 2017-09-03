//GENERATED: C++ Code

#pragma once

#include "BlockingVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ABlockingVolume_ : public ABlockingVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ABlockingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ABlockingVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;