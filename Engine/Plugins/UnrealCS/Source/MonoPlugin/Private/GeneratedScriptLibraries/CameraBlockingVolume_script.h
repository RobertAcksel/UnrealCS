//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/CameraBlockingVolume.h"
#include "CameraBlockingVolume_script.generated.h"

UCLASS()
class MONOPLUGIN_API ACameraBlockingVolume_ : public ACameraBlockingVolume
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ACameraBlockingVolume::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ACameraBlockingVolume::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;