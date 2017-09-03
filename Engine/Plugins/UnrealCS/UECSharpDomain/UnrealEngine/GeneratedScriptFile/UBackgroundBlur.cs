//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBackgroundBlur:UContentWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLowQualityFallbackBrush(IntPtr _this,ref FSlateBrush InBrush);
	
	public  void SetLowQualityFallbackBrush(FSlateBrush InBrush)
	{
		CheckIsValid();
		SetLowQualityFallbackBrush(_this.Get(),ref InBrush);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBlurStrength(IntPtr _this,float InStrength);
	
	public  void SetBlurStrength(float InStrength)
	{
		CheckIsValid();
		SetBlurStrength(_this.Get(),InStrength);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBlurRadius(IntPtr _this,int InBlurRadius);
	
	public  void SetBlurRadius(int InBlurRadius)
	{
		CheckIsValid();
		SetBlurRadius(_this.Get(),InBlurRadius);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetApplyAlphaToBlur(IntPtr _this,int bInApplyAlphaToBlur);
	
	public  void SetApplyAlphaToBlur(bool bInApplyAlphaToBlur)
	{
		CheckIsValid();
		SetApplyAlphaToBlur(_this.Get(),bInApplyAlphaToBlur?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVerticalAlignment(IntPtr _this,int InVerticalAlignment);
	
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckIsValid();
		SetVerticalAlignment(_this.Get(),(int)InVerticalAlignment);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetHorizontalAlignment(IntPtr _this,int InHorizontalAlignment);
	
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckIsValid();
		SetHorizontalAlignment(_this.Get(),(int)InHorizontalAlignment);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPadding(IntPtr _this,ref FMargin InPadding);
	
	public  void SetPadding(FMargin InPadding)
	{
		CheckIsValid();
		SetPadding(_this.Get(),ref InPadding);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
