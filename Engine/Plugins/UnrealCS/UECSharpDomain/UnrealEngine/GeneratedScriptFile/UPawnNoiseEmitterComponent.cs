//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPawnNoiseEmitterComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MakeNoise(IntPtr _this,IntPtr NoiseMaker,float Loudness,ref FVector NoiseLocation);
public  void MakeNoise(AActor NoiseMaker,float Loudness,FVector NoiseLocation)
{
	CheckIsValid();
	MakeNoise(_this.Get(),NoiseMaker,Loudness,ref NoiseLocation);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
