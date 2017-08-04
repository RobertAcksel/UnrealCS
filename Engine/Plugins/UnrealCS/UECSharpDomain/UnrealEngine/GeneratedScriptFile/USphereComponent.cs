//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USphereComponent:UShapeComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetShapeScale(IntPtr _this);
public  float GetShapeScale()
{
	CheckIsValid();
	float ___ret = GetShapeScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledSphereRadius(IntPtr _this);
public  float GetUnscaledSphereRadius()
{
	CheckIsValid();
	float ___ret = GetUnscaledSphereRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledSphereRadius(IntPtr _this);
public  float GetScaledSphereRadius()
{
	CheckIsValid();
	float ___ret = GetScaledSphereRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSphereRadius(IntPtr _this,float InSphereRadius,int bUpdateOverlaps);
public  void SetSphereRadius(float InSphereRadius,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetSphereRadius(_this.Get(),InSphereRadius,bUpdateOverlaps?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
