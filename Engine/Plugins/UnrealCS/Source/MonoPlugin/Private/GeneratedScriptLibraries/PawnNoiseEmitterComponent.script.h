//GENERATED: C++ Code

#pragma once

namespace UnrealEngine
{
	class UPawnNoiseEmitterComponent_
	{
		static void MakeNoise(UPawnNoiseEmitterComponent* _this,AActor* NoiseMaker,float Loudness,FVector* NoiseLocation)
		{
			_this->MakeNoise(NoiseMaker,Loudness,*NoiseLocation);
			
		}
		static UClass* StaticClass(){return UPawnNoiseEmitterComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPawnNoiseEmitterComponent::MakeNoise",(const void*)MakeNoise);
			mono_add_internal_call("UnrealEngine.UPawnNoiseEmitterComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
