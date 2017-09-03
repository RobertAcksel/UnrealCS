//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UDirectionalLightComponent:ULightComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightShaftOverrideDirection(IntPtr _this,ref FVector NewValue);
	
	public  void SetLightShaftOverrideDirection(FVector NewValue)
	{
		CheckIsValid();
		SetLightShaftOverrideDirection(_this.Get(),ref NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOcclusionMaskDarkness(IntPtr _this,float NewValue);
	
	public  void SetOcclusionMaskDarkness(float NewValue)
	{
		CheckIsValid();
		SetOcclusionMaskDarkness(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableLightShaftOcclusion(IntPtr _this,int bNewValue);
	
	public  void SetEnableLightShaftOcclusion(bool bNewValue)
	{
		CheckIsValid();
		SetEnableLightShaftOcclusion(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetShadowDistanceFadeoutFraction(IntPtr _this,float NewValue);
	
	public  void SetShadowDistanceFadeoutFraction(float NewValue)
	{
		CheckIsValid();
		SetShadowDistanceFadeoutFraction(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCascadeTransitionFraction(IntPtr _this,float NewValue);
	
	public  void SetCascadeTransitionFraction(float NewValue)
	{
		CheckIsValid();
		SetCascadeTransitionFraction(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCascadeDistributionExponent(IntPtr _this,float NewValue);
	
	public  void SetCascadeDistributionExponent(float NewValue)
	{
		CheckIsValid();
		SetCascadeDistributionExponent(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDynamicShadowCascades(IntPtr _this,int NewValue);
	
	public  void SetDynamicShadowCascades(int NewValue)
	{
		CheckIsValid();
		SetDynamicShadowCascades(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDynamicShadowDistanceStationaryLight(IntPtr _this,float NewValue);
	
	public  void SetDynamicShadowDistanceStationaryLight(float NewValue)
	{
		CheckIsValid();
		SetDynamicShadowDistanceStationaryLight(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDynamicShadowDistanceMovableLight(IntPtr _this,float NewValue);
	
	public  void SetDynamicShadowDistanceMovableLight(float NewValue)
	{
		CheckIsValid();
		SetDynamicShadowDistanceMovableLight(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
