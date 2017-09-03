//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ULightComponent:ULightComponentBase 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIESTexture(IntPtr _this,IntPtr NewValue);
	
	public  void SetIESTexture(UTextureLightProfile NewValue)
	{
		CheckIsValid();
		SetIESTexture(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBloomTint(IntPtr _this,ref FColor NewValue);
	
	public  void SetBloomTint(FColor NewValue)
	{
		CheckIsValid();
		SetBloomTint(_this.Get(),ref NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBloomThreshold(IntPtr _this,float NewValue);
	
	public  void SetBloomThreshold(float NewValue)
	{
		CheckIsValid();
		SetBloomThreshold(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBloomScale(IntPtr _this,float NewValue);
	
	public  void SetBloomScale(float NewValue)
	{
		CheckIsValid();
		SetBloomScale(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableLightShaftBloom(IntPtr _this,int bNewValue);
	
	public  void SetEnableLightShaftBloom(bool bNewValue)
	{
		CheckIsValid();
		SetEnableLightShaftBloom(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAffectTranslucentLighting(IntPtr _this,int bNewValue);
	
	public  void SetAffectTranslucentLighting(bool bNewValue)
	{
		CheckIsValid();
		SetAffectTranslucentLighting(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAffectDynamicIndirectLighting(IntPtr _this,int bNewValue);
	
	public  void SetAffectDynamicIndirectLighting(bool bNewValue)
	{
		CheckIsValid();
		SetAffectDynamicIndirectLighting(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightFunctionDisabledBrightness(IntPtr _this,float NewValue);
	
	public  void SetLightFunctionDisabledBrightness(float NewValue)
	{
		CheckIsValid();
		SetLightFunctionDisabledBrightness(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightFunctionFadeDistance(IntPtr _this,float NewLightFunctionFadeDistance);
	
	public  void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
	{
		CheckIsValid();
		SetLightFunctionFadeDistance(_this.Get(),NewLightFunctionFadeDistance);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightFunctionScale(IntPtr _this,ref FVector NewLightFunctionScale);
	
	public  void SetLightFunctionScale(FVector NewLightFunctionScale)
	{
		CheckIsValid();
		SetLightFunctionScale(_this.Get(),ref NewLightFunctionScale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightFunctionMaterial(IntPtr _this,IntPtr NewLightFunctionMaterial);
	
	public  void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
	{
		CheckIsValid();
		SetLightFunctionMaterial(_this.Get(),NewLightFunctionMaterial);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTemperature(IntPtr _this,float NewTemperature);
	
	public  void SetTemperature(float NewTemperature)
	{
		CheckIsValid();
		SetTemperature(_this.Get(),NewTemperature);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightColor(IntPtr _this,ref FLinearColor NewLightColor,int bSRGB);
	
	/// <summary>Set color of the light</summary>
	public  void SetLightColor(FLinearColor NewLightColor,bool bSRGB=true)
	{
		CheckIsValid();
		SetLightColor(_this.Get(),ref NewLightColor,bSRGB?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVolumetricScatteringIntensity(IntPtr _this,float NewIntensity);
	
	public  void SetVolumetricScatteringIntensity(float NewIntensity)
	{
		CheckIsValid();
		SetVolumetricScatteringIntensity(_this.Get(),NewIntensity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIndirectLightingIntensity(IntPtr _this,float NewIntensity);
	
	public  void SetIndirectLightingIntensity(float NewIntensity)
	{
		CheckIsValid();
		SetIndirectLightingIntensity(_this.Get(),NewIntensity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIntensity(IntPtr _this,float NewIntensity);
	
	/// <summary>Set intensity of the light</summary>
	public  void SetIntensity(float NewIntensity)
	{
		CheckIsValid();
		SetIntensity(_this.Get(),NewIntensity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
