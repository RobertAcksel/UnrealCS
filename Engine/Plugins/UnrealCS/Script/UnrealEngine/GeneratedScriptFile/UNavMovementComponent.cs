//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsFlying(IntPtr _this);
public  bool IsFlying()
{
	CheckIsValid();
	int ___ret = IsFlying(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSwimming(IntPtr _this);
public  bool IsSwimming()
{
	CheckIsValid();
	int ___ret = IsSwimming(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMovingOnGround(IntPtr _this);
public  bool IsMovingOnGround()
{
	CheckIsValid();
	int ___ret = IsMovingOnGround(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsFalling(IntPtr _this);
public  bool IsFalling()
{
	CheckIsValid();
	int ___ret = IsFalling(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsCrouching(IntPtr _this);
public  bool IsCrouching()
{
	CheckIsValid();
	int ___ret = IsCrouching(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopMovementKeepPathing(IntPtr _this);
public  void StopMovementKeepPathing()
{
	CheckIsValid();
	StopMovementKeepPathing(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopActiveMovement(IntPtr _this);
public  void StopActiveMovement()
{
	CheckIsValid();
	StopActiveMovement(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
