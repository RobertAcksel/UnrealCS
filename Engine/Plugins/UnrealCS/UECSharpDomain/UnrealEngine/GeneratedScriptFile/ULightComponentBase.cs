//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ULightComponentBase:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCastVolumetricShadow(IntPtr _this,int bNewValue);
	public  void SetCastVolumetricShadow(bool bNewValue)
	{
		CheckIsValid();
		SetCastVolumetricShadow(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor GetLightColor(IntPtr _this);
	public  FLinearColor GetLightColor()
	{
		CheckIsValid();
		FLinearColor ___ret = GetLightColor(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCastShadows(IntPtr _this,int bNewValue);
	public  void SetCastShadows(bool bNewValue)
	{
		CheckIsValid();
		SetCastShadows(_this.Get(),bNewValue?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
