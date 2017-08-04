//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInterpToMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FinaliseControlPoints(IntPtr _this);
	public  void FinaliseControlPoints()
	{
		CheckIsValid();
		FinaliseControlPoints(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RestartMovement(IntPtr _this,float InitialDirection);
	public  void RestartMovement(float InitialDirection=1.000000f)
	{
		CheckIsValid();
		RestartMovement(_this.Get(),InitialDirection);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StopSimulating(IntPtr _this,ref FHitResult HitResult);
	public  void StopSimulating(FHitResult HitResult)
	{
		CheckIsValid();
		StopSimulating(_this.Get(),ref HitResult);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
