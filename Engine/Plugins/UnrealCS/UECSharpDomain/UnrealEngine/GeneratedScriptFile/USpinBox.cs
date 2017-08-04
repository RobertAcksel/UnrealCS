//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USpinBox:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetForegroundColor(IntPtr _this,ref FSlateColor InForegroundColor);
	public  void SetForegroundColor(FSlateColor InForegroundColor)
	{
		CheckIsValid();
		SetForegroundColor(_this.Get(),ref InForegroundColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMaxSliderValue(IntPtr _this);
	public  void ClearMaxSliderValue()
	{
		CheckIsValid();
		ClearMaxSliderValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMaxSliderValue(IntPtr _this,float NewValue);
	public  void SetMaxSliderValue(float NewValue)
	{
		CheckIsValid();
		SetMaxSliderValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxSliderValue(IntPtr _this);
	public  float GetMaxSliderValue()
	{
		CheckIsValid();
		float ___ret = GetMaxSliderValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMinSliderValue(IntPtr _this);
	public  void ClearMinSliderValue()
	{
		CheckIsValid();
		ClearMinSliderValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinSliderValue(IntPtr _this,float NewValue);
	public  void SetMinSliderValue(float NewValue)
	{
		CheckIsValid();
		SetMinSliderValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMinSliderValue(IntPtr _this);
	public  float GetMinSliderValue()
	{
		CheckIsValid();
		float ___ret = GetMinSliderValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMaxValue(IntPtr _this);
	public  void ClearMaxValue()
	{
		CheckIsValid();
		ClearMaxValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMaxValue(IntPtr _this,float NewValue);
	public  void SetMaxValue(float NewValue)
	{
		CheckIsValid();
		SetMaxValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxValue(IntPtr _this);
	public  float GetMaxValue()
	{
		CheckIsValid();
		float ___ret = GetMaxValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMinValue(IntPtr _this);
	public  void ClearMinValue()
	{
		CheckIsValid();
		ClearMinValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinValue(IntPtr _this,float NewValue);
	public  void SetMinValue(float NewValue)
	{
		CheckIsValid();
		SetMinValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMinValue(IntPtr _this);
	public  float GetMinValue()
	{
		CheckIsValid();
		float ___ret = GetMinValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetValue(IntPtr _this,float NewValue);
	public  void SetValue(float NewValue)
	{
		CheckIsValid();
		SetValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetValue(IntPtr _this);
	public  float GetValue()
	{
		CheckIsValid();
		float ___ret = GetValue(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
