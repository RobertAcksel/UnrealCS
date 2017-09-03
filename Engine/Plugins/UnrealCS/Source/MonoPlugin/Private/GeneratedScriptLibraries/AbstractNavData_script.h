//GENERATED: C++ Code

#pragma once

#include "AbstractNavData_script.generated.h"
UCLASS()
class MONOPLUGIN_API AAbstractNavData_ : public AAbstractNavData
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AAbstractNavData::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AAbstractNavData::StaticClass",(const void*)StaticClass);
		
	}
	
}
;