//GENERATED: C++ Code

#pragma once

#include "RigidBodyBase_script.generated.h"
UCLASS()
class MONOPLUGIN_API ARigidBodyBase_ : public ARigidBodyBase
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ARigidBodyBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ARigidBodyBase::StaticClass",(const void*)StaticClass);
		
	}
	
}
;