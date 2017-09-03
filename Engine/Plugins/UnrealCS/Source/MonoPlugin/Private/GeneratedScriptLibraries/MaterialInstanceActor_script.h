//GENERATED: C++ Code

#pragma once

#include "MaterialInstanceActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API AMaterialInstanceActor_ : public AMaterialInstanceActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AMaterialInstanceActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AMaterialInstanceActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;