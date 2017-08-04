//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAtmosphericFogComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPrecomputeParams(IntPtr _this,float DensityHeight,int MaxScatteringOrder,int InscatterAltitudeSampleNum);
public  void SetPrecomputeParams(float DensityHeight,int MaxScatteringOrder,int InscatterAltitudeSampleNum)
{
	CheckIsValid();
	SetPrecomputeParams(_this.Get(),DensityHeight,MaxScatteringOrder,InscatterAltitudeSampleNum);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableGroundScattering(IntPtr _this,int NewGroundScattering);
public  void DisableGroundScattering(bool NewGroundScattering)
{
	CheckIsValid();
	DisableGroundScattering(_this.Get(),NewGroundScattering?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableSunDisk(IntPtr _this,int NewSunDisk);
public  void DisableSunDisk(bool NewSunDisk)
{
	CheckIsValid();
	DisableSunDisk(_this.Get(),NewSunDisk?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDistanceOffset(IntPtr _this,float NewDistanceOffset);
public  void SetDistanceOffset(float NewDistanceOffset)
{
	CheckIsValid();
	SetDistanceOffset(_this.Get(),NewDistanceOffset);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartDistance(IntPtr _this,float NewStartDistance);
public  void SetStartDistance(float NewStartDistance)
{
	CheckIsValid();
	SetStartDistance(_this.Get(),NewStartDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAltitudeScale(IntPtr _this,float NewAltitudeScale);
public  void SetAltitudeScale(float NewAltitudeScale)
{
	CheckIsValid();
	SetAltitudeScale(_this.Get(),NewAltitudeScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDistanceScale(IntPtr _this,float NewDistanceScale);
public  void SetDistanceScale(float NewDistanceScale)
{
	CheckIsValid();
	SetDistanceScale(_this.Get(),NewDistanceScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDensityOffset(IntPtr _this,float NewDensityOffset);
public  void SetDensityOffset(float NewDensityOffset)
{
	CheckIsValid();
	SetDensityOffset(_this.Get(),NewDensityOffset);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDensityMultiplier(IntPtr _this,float NewDensityMultiplier);
public  void SetDensityMultiplier(float NewDensityMultiplier)
{
	CheckIsValid();
	SetDensityMultiplier(_this.Get(),NewDensityMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogMultiplier(IntPtr _this,float NewFogMultiplier);
public  void SetFogMultiplier(float NewFogMultiplier)
{
	CheckIsValid();
	SetFogMultiplier(_this.Get(),NewFogMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSunMultiplier(IntPtr _this,float NewSunMultiplier);
public  void SetSunMultiplier(float NewSunMultiplier)
{
	CheckIsValid();
	SetSunMultiplier(_this.Get(),NewSunMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDefaultLightColor(IntPtr _this,ref FLinearColor NewLightColor);
public  void SetDefaultLightColor(FLinearColor NewLightColor)
{
	CheckIsValid();
	SetDefaultLightColor(_this.Get(),ref NewLightColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDefaultBrightness(IntPtr _this,float NewBrightness);
public  void SetDefaultBrightness(float NewBrightness)
{
	CheckIsValid();
	SetDefaultBrightness(_this.Get(),NewBrightness);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
