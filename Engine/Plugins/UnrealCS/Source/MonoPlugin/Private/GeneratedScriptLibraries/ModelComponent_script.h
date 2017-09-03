//GENERATED: C++ Code

#pragma once

#include "ModelComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UModelComponent_ : public UModelComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return UModelComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UModelComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;