//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPointLightComponent:ULightComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSourceLength(IntPtr _this,float NewValue);
	public  void SetSourceLength(float NewValue)
	{
		CheckIsValid();
		SetSourceLength(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSourceRadius(IntPtr _this,float bNewValue);
	public  void SetSourceRadius(float bNewValue)
	{
		CheckIsValid();
		SetSourceRadius(_this.Get(),bNewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLightFalloffExponent(IntPtr _this,float NewLightFalloffExponent);
	public  void SetLightFalloffExponent(float NewLightFalloffExponent)
	{
		CheckIsValid();
		SetLightFalloffExponent(_this.Get(),NewLightFalloffExponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAttenuationRadius(IntPtr _this,float NewRadius);
	public  void SetAttenuationRadius(float NewRadius)
	{
		CheckIsValid();
		SetAttenuationRadius(_this.Get(),NewRadius);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
