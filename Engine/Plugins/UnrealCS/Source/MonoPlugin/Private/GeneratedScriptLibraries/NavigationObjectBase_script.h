//GENERATED: C++ Code

#pragma once

#include "NavigationObjectBase_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavigationObjectBase_ : public ANavigationObjectBase
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavigationObjectBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationObjectBase::StaticClass",(const void*)StaticClass);
		
	}
	
}
;