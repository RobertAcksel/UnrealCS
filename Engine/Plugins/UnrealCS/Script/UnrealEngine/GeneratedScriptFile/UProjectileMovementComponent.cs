//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UProjectileMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopSimulating(IntPtr _this,ref FHitResult HitResult);
public  void StopSimulating(FHitResult HitResult)
{
	CheckIsValid();
	StopSimulating(_this.Get(),ref HitResult);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVelocityInLocalSpace(IntPtr _this,ref FVector NewVelocity);
public  void SetVelocityInLocalSpace(FVector NewVelocity)
{
	CheckIsValid();
	SetVelocityInLocalSpace(_this.Get(),ref NewVelocity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
