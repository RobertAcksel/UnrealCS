//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UExponentialHeightFogComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFogDistance(IntPtr _this,float NewValue);
public  void SetVolumetricFogDistance(float NewValue)
{
	CheckIsValid();
	SetVolumetricFogDistance(_this.Get(),NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFogEmissive(IntPtr _this,ref FLinearColor NewValue);
public  void SetVolumetricFogEmissive(FLinearColor NewValue)
{
	CheckIsValid();
	SetVolumetricFogEmissive(_this.Get(),ref NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFogAlbedo(IntPtr _this,ref FColor NewValue);
public  void SetVolumetricFogAlbedo(FColor NewValue)
{
	CheckIsValid();
	SetVolumetricFogAlbedo(_this.Get(),ref NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFogExtinctionScale(IntPtr _this,float NewValue);
public  void SetVolumetricFogExtinctionScale(float NewValue)
{
	CheckIsValid();
	SetVolumetricFogExtinctionScale(_this.Get(),NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFogScatteringDistribution(IntPtr _this,float NewValue);
public  void SetVolumetricFogScatteringDistribution(float NewValue)
{
	CheckIsValid();
	SetVolumetricFogScatteringDistribution(_this.Get(),NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricFog(IntPtr _this,int bNewValue);
public  void SetVolumetricFog(bool bNewValue)
{
	CheckIsValid();
	SetVolumetricFog(_this.Get(),bNewValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogCutoffDistance(IntPtr _this,float Value);
public  void SetFogCutoffDistance(float Value)
{
	CheckIsValid();
	SetFogCutoffDistance(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStartDistance(IntPtr _this,float Value);
public  void SetStartDistance(float Value)
{
	CheckIsValid();
	SetStartDistance(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogMaxOpacity(IntPtr _this,float Value);
public  void SetFogMaxOpacity(float Value)
{
	CheckIsValid();
	SetFogMaxOpacity(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogHeightFalloff(IntPtr _this,float Value);
public  void SetFogHeightFalloff(float Value)
{
	CheckIsValid();
	SetFogHeightFalloff(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDirectionalInscatteringColor(IntPtr _this,ref FLinearColor Value);
public  void SetDirectionalInscatteringColor(FLinearColor Value)
{
	CheckIsValid();
	SetDirectionalInscatteringColor(_this.Get(),ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDirectionalInscatteringStartDistance(IntPtr _this,float Value);
public  void SetDirectionalInscatteringStartDistance(float Value)
{
	CheckIsValid();
	SetDirectionalInscatteringStartDistance(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDirectionalInscatteringExponent(IntPtr _this,float Value);
public  void SetDirectionalInscatteringExponent(float Value)
{
	CheckIsValid();
	SetDirectionalInscatteringExponent(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInscatteringTextureTint(IntPtr _this,ref FLinearColor Value);
public  void SetInscatteringTextureTint(FLinearColor Value)
{
	CheckIsValid();
	SetInscatteringTextureTint(_this.Get(),ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNonDirectionalInscatteringColorDistance(IntPtr _this,float Value);
public  void SetNonDirectionalInscatteringColorDistance(float Value)
{
	CheckIsValid();
	SetNonDirectionalInscatteringColorDistance(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFullyDirectionalInscatteringColorDistance(IntPtr _this,float Value);
public  void SetFullyDirectionalInscatteringColorDistance(float Value)
{
	CheckIsValid();
	SetFullyDirectionalInscatteringColorDistance(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInscatteringColorCubemapAngle(IntPtr _this,float Value);
public  void SetInscatteringColorCubemapAngle(float Value)
{
	CheckIsValid();
	SetInscatteringColorCubemapAngle(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInscatteringColorCubemap(IntPtr _this,IntPtr Value);
public  void SetInscatteringColorCubemap(UTextureCube Value)
{
	CheckIsValid();
	SetInscatteringColorCubemap(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogInscatteringColor(IntPtr _this,ref FLinearColor Value);
public  void SetFogInscatteringColor(FLinearColor Value)
{
	CheckIsValid();
	SetFogInscatteringColor(_this.Get(),ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFogDensity(IntPtr _this,float Value);
public  void SetFogDensity(float Value)
{
	CheckIsValid();
	SetFogDensity(_this.Get(),Value);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
