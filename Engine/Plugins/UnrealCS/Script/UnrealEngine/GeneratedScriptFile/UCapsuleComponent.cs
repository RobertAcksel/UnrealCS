//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCapsuleComponent:UShapeComponent 
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
extern static void GetUnscaledCapsuleSize_WithoutHemisphere(IntPtr _this,out float OutRadius,out float OutHalfHeightWithoutHemisphere);
public  void GetUnscaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere)
{
	CheckIsValid();
	GetUnscaledCapsuleSize_WithoutHemisphere(_this.Get(),out OutRadius,out OutHalfHeightWithoutHemisphere);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetUnscaledCapsuleSize(IntPtr _this,out float OutRadius,out float OutHalfHeight);
public  void GetUnscaledCapsuleSize(out float OutRadius,out float OutHalfHeight)
{
	CheckIsValid();
	GetUnscaledCapsuleSize(_this.Get(),out OutRadius,out OutHalfHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleHalfHeight_WithoutHemisphere(IntPtr _this);
public  float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleHalfHeight_WithoutHemisphere(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleHalfHeight(IntPtr _this);
public  float GetUnscaledCapsuleHalfHeight()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleHalfHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnscaledCapsuleRadius(IntPtr _this);
public  float GetUnscaledCapsuleRadius()
{
	CheckIsValid();
	float ___ret = GetUnscaledCapsuleRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetScaledCapsuleSize_WithoutHemisphere(IntPtr _this,out float OutRadius,out float OutHalfHeightWithoutHemisphere);
public  void GetScaledCapsuleSize_WithoutHemisphere(out float OutRadius,out float OutHalfHeightWithoutHemisphere)
{
	CheckIsValid();
	GetScaledCapsuleSize_WithoutHemisphere(_this.Get(),out OutRadius,out OutHalfHeightWithoutHemisphere);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetScaledCapsuleSize(IntPtr _this,out float OutRadius,out float OutHalfHeight);
public  void GetScaledCapsuleSize(out float OutRadius,out float OutHalfHeight)
{
	CheckIsValid();
	GetScaledCapsuleSize(_this.Get(),out OutRadius,out OutHalfHeight);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleHalfHeight_WithoutHemisphere(IntPtr _this);
public  float GetScaledCapsuleHalfHeight_WithoutHemisphere()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleHalfHeight_WithoutHemisphere(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleHalfHeight(IntPtr _this);
public  float GetScaledCapsuleHalfHeight()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleHalfHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScaledCapsuleRadius(IntPtr _this);
public  float GetScaledCapsuleRadius()
{
	CheckIsValid();
	float ___ret = GetScaledCapsuleRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleHalfHeight(IntPtr _this,float HalfHeight,int bUpdateOverlaps);
public  void SetCapsuleHalfHeight(float HalfHeight,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleHalfHeight(_this.Get(),HalfHeight,bUpdateOverlaps?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleRadius(IntPtr _this,float Radius,int bUpdateOverlaps);
public  void SetCapsuleRadius(float Radius,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleRadius(_this.Get(),Radius,bUpdateOverlaps?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCapsuleSize(IntPtr _this,float InRadius,float InHalfHeight,int bUpdateOverlaps);
public  void SetCapsuleSize(float InRadius,float InHalfHeight,bool bUpdateOverlaps=true)
{
	CheckIsValid();
	SetCapsuleSize(_this.Get(),InRadius,InHalfHeight,bUpdateOverlaps?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
