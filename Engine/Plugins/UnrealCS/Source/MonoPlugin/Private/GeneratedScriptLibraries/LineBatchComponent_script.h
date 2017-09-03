//GENERATED: C++ Code

#pragma once

#include "LineBatchComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API ULineBatchComponent_ : public ULineBatchComponent
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ULineBatchComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ULineBatchComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;