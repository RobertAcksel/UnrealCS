//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPawnMovementComponent:UNavMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPawnOwner(IntPtr _this);
public  APawn GetPawnOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetPawnOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMoveInputIgnored(IntPtr _this);
public  bool IsMoveInputIgnored()
{
	CheckIsValid();
	int ___ret = IsMoveInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ConsumeInputVector(IntPtr _this);
public  FVector ConsumeInputVector()
{
	CheckIsValid();
	FVector ___ret = ConsumeInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetLastInputVector(IntPtr _this);
public  FVector GetLastInputVector()
{
	CheckIsValid();
	FVector ___ret = GetLastInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPendingInputVector(IntPtr _this);
public  FVector GetPendingInputVector()
{
	CheckIsValid();
	FVector ___ret = GetPendingInputVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddInputVector(IntPtr _this,ref FVector WorldVector,int bForce);
public  void AddInputVector(FVector WorldVector,bool bForce=false)
{
	CheckIsValid();
	AddInputVector(_this.Get(),ref WorldVector,bForce?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
