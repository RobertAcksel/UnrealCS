//GENERATED: C++ Code

#pragma once

#include "Emitter_script.generated.h"
UCLASS()
class MONOPLUGIN_API AEmitter_ : public AEmitter
{
	GENERATED_BODY()
	static void OnRep_bCurrentlyActive(AEmitter* _this)
	{
		_this->OnRep_bCurrentlyActive();
		
	}
	static void OnParticleSystemFinished(AEmitter* _this,UParticleSystemComponent* FinishedComponent)
	{
		_this->OnParticleSystemFinished(FinishedComponent);
		
	}
	static UClass* StaticClass(){return AEmitter::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AEmitter::OnRep_bCurrentlyActive",(const void*)OnRep_bCurrentlyActive);
		mono_add_internal_call("UnrealEngine.AEmitter::OnParticleSystemFinished",(const void*)OnParticleSystemFinished);
		mono_add_internal_call("UnrealEngine.AEmitter::StaticClass",(const void*)StaticClass);
		
	}
	
}
;