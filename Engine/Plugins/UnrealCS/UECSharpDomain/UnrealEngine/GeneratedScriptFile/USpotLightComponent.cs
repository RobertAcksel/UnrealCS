//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USpotLightComponent:UPointLightComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOuterConeAngle(IntPtr _this,float NewOuterConeAngle);
	
	public  void SetOuterConeAngle(float NewOuterConeAngle)
	{
		CheckIsValid();
		SetOuterConeAngle(_this.Get(),NewOuterConeAngle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetInnerConeAngle(IntPtr _this,float NewInnerConeAngle);
	
	public  void SetInnerConeAngle(float NewInnerConeAngle)
	{
		CheckIsValid();
		SetInnerConeAngle(_this.Get(),NewInnerConeAngle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
