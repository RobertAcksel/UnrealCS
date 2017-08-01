//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkyLightComponent:ULightComponentBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RecaptureSky(IntPtr _this);
public  void RecaptureSky()
{
	CheckIsValid();
	RecaptureSky(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinOcclusion(IntPtr _this,float InMinOcclusion);
public  void SetMinOcclusion(float InMinOcclusion)
{
	CheckIsValid();
	SetMinOcclusion(_this.Get(),InMinOcclusion);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOcclusionExponent(IntPtr _this,float InOcclusionExponent);
public  void SetOcclusionExponent(float InOcclusionExponent)
{
	CheckIsValid();
	SetOcclusionExponent(_this.Get(),InOcclusionExponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOcclusionContrast(IntPtr _this,float InOcclusionContrast);
public  void SetOcclusionContrast(float InOcclusionContrast)
{
	CheckIsValid();
	SetOcclusionContrast(_this.Get(),InOcclusionContrast);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOcclusionTint(IntPtr _this,ref FColor InTint);
public  void SetOcclusionTint(FColor InTint)
{
	CheckIsValid();
	SetOcclusionTint(_this.Get(),ref InTint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCubemapBlend(IntPtr _this,IntPtr SourceCubemap,IntPtr DestinationCubemap,float InBlendFraction);
public  void SetCubemapBlend(UTextureCube SourceCubemap,UTextureCube DestinationCubemap,float InBlendFraction)
{
	CheckIsValid();
	SetCubemapBlend(_this.Get(),SourceCubemap,DestinationCubemap,InBlendFraction);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCubemap(IntPtr _this,IntPtr NewCubemap);
public  void SetCubemap(UTextureCube NewCubemap)
{
	CheckIsValid();
	SetCubemap(_this.Get(),NewCubemap);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLightColor(IntPtr _this,ref FLinearColor NewLightColor);
public  void SetLightColor(FLinearColor NewLightColor)
{
	CheckIsValid();
	SetLightColor(_this.Get(),ref NewLightColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumetricScatteringIntensity(IntPtr _this,float NewIntensity);
public  void SetVolumetricScatteringIntensity(float NewIntensity)
{
	CheckIsValid();
	SetVolumetricScatteringIntensity(_this.Get(),NewIntensity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIndirectLightingIntensity(IntPtr _this,float NewIntensity);
public  void SetIndirectLightingIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIndirectLightingIntensity(_this.Get(),NewIntensity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensity(IntPtr _this,float NewIntensity);
public  void SetIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIntensity(_this.Get(),NewIntensity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}