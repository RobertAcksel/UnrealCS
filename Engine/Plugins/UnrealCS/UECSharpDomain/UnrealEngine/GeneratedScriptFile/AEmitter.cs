//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AEmitter:AActor 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_bCurrentlyActive(IntPtr _this);
	
	/// <summary>Replication Notification Callbacks</summary>
	public  void OnRep_bCurrentlyActive()
	{
		CheckIsValid();
		OnRep_bCurrentlyActive(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnParticleSystemFinished(IntPtr _this,IntPtr FinishedComponent);
	
	public  void OnParticleSystemFinished(UParticleSystemComponent FinishedComponent)
	{
		CheckIsValid();
		OnParticleSystemFinished(_this.Get(),FinishedComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
