//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsSpringComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSpringDirection(IntPtr _this);
	public  FVector GetSpringDirection()
	{
		CheckIsValid();
		FVector ___ret = GetSpringDirection(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSpringCurrentEndPoint(IntPtr _this);
	public  FVector GetSpringCurrentEndPoint()
	{
		CheckIsValid();
		FVector ___ret = GetSpringCurrentEndPoint(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSpringRestingPoint(IntPtr _this);
	public  FVector GetSpringRestingPoint()
	{
		CheckIsValid();
		FVector ___ret = GetSpringRestingPoint(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetNormalizedCompressionScalar(IntPtr _this);
	public  float GetNormalizedCompressionScalar()
	{
		CheckIsValid();
		float ___ret = GetNormalizedCompressionScalar(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
