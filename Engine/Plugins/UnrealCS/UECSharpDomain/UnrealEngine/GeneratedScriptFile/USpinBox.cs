//GENERATED: CS Code
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
	
	/// <summary>Clear the maximum value that can be specified using the slider.</summary>
	public  void ClearMaxSliderValue()
	{
		CheckIsValid();
		ClearMaxSliderValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMaxSliderValue(IntPtr _this,float NewValue);
	
	/// <summary>Set the maximum value that can be specified using the slider.</summary>
	public  void SetMaxSliderValue(float NewValue)
	{
		CheckIsValid();
		SetMaxSliderValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxSliderValue(IntPtr _this);
	
	/// <summary>Get the current maximum value that can be specified using the slider.</summary>
	public  float GetMaxSliderValue()
	{
		CheckIsValid();
		float ___ret = GetMaxSliderValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMinSliderValue(IntPtr _this);
	
	/// <summary>Clear the minimum value that can be specified using the slider.</summary>
	public  void ClearMinSliderValue()
	{
		CheckIsValid();
		ClearMinSliderValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinSliderValue(IntPtr _this,float NewValue);
	
	/// <summary>Set the minimum value that can be specified using the slider.</summary>
	public  void SetMinSliderValue(float NewValue)
	{
		CheckIsValid();
		SetMinSliderValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMinSliderValue(IntPtr _this);
	
	/// <summary>Get the current minimum value that can be specified using the slider.</summary>
	public  float GetMinSliderValue()
	{
		CheckIsValid();
		float ___ret = GetMinSliderValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMaxValue(IntPtr _this);
	
	/// <summary>Clear the maximum value that can be manually set in the spin box.</summary>
	public  void ClearMaxValue()
	{
		CheckIsValid();
		ClearMaxValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMaxValue(IntPtr _this,float NewValue);
	
	/// <summary>Set the maximum value that can be manually set in the spin box.</summary>
	public  void SetMaxValue(float NewValue)
	{
		CheckIsValid();
		SetMaxValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxValue(IntPtr _this);
	
	/// <summary>Get the current maximum value that can be manually set in the spin box.</summary>
	public  float GetMaxValue()
	{
		CheckIsValid();
		float ___ret = GetMaxValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMinValue(IntPtr _this);
	
	/// <summary>Clear the minimum value that can be manually set in the spin box.</summary>
	public  void ClearMinValue()
	{
		CheckIsValid();
		ClearMinValue(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinValue(IntPtr _this,float NewValue);
	
	/// <summary>Set the minimum value that can be manually set in the spin box.</summary>
	public  void SetMinValue(float NewValue)
	{
		CheckIsValid();
		SetMinValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMinValue(IntPtr _this);
	
	/// <summary>Get the current minimum value that can be manually set in the spin box.</summary>
	public  float GetMinValue()
	{
		CheckIsValid();
		float ___ret = GetMinValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetValue(IntPtr _this,float NewValue);
	
	/// <summary>Set the value of the spin box.</summary>
	public  void SetValue(float NewValue)
	{
		CheckIsValid();
		SetValue(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetValue(IntPtr _this);
	
	/// <summary>Get the current value of the spin box.</summary>
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
