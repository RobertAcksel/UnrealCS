//GENERATED: C++ Code

#pragma once

#include "NavigationData_script.generated.h"
UCLASS()
class MONOPLUGIN_API ANavigationData_ : public ANavigationData
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ANavigationData::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ANavigationData::StaticClass",(const void*)StaticClass);
		
	}
	
}
;