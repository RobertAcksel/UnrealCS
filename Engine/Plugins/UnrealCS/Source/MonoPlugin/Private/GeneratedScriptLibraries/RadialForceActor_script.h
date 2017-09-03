//GENERATED: C++ Code

#pragma once

#include "RadialForceActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ARadialForceActor_ : public ARadialForceActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ARadialForceActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ARadialForceActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;