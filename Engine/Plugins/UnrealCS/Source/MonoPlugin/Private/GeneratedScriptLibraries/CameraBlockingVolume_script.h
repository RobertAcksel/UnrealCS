//GENERATED: C++ Code

#pragma once

#include "CameraBlockingVolume_script.generated.h"
UCLASS()
class MONOPLUGIN_API ACameraBlockingVolume_ : public ACameraBlockingVolume
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ACameraBlockingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ACameraBlockingVolume::StaticClass",(const void*)StaticClass);
		
	}
	
}
;