//GENERATED: C++ Code

#pragma once

#include "ChildActorComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UChildActorComponent_ : public UChildActorComponent
{
	GENERATED_BODY()
	static void SetChildActorClass(UChildActorComponent* _this,TSubclassOf<AActor>  InClass)
	{
		_this->SetChildActorClass(InClass);
		
	}
	static UClass* StaticClass(){return UChildActorComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UChildActorComponent::SetChildActorClass",(const void*)SetChildActorClass);
		mono_add_internal_call("UnrealEngine.UChildActorComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;