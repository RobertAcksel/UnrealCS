//GENERATED: C++ Code

#pragma once

#include "NavigationTestingActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavigationTestingActor_ : public ANavigationTestingActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavigationTestingActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationTestingActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;