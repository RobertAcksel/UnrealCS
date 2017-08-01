//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USlider:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSliderHandleColor(IntPtr _this,ref FLinearColor InValue);
public  void SetSliderHandleColor(FLinearColor InValue)
{
	CheckIsValid();
	SetSliderHandleColor(_this.Get(),ref InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSliderBarColor(IntPtr _this,ref FLinearColor InValue);
public  void SetSliderBarColor(FLinearColor InValue)
{
	CheckIsValid();
	SetSliderBarColor(_this.Get(),ref InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStepSize(IntPtr _this,float InValue);
public  void SetStepSize(float InValue)
{
	CheckIsValid();
	SetStepSize(_this.Get(),InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLocked(IntPtr _this,int InValue);
public  void SetLocked(bool InValue)
{
	CheckIsValid();
	SetLocked(_this.Get(),InValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIndentHandle(IntPtr _this,int InValue);
public  void SetIndentHandle(bool InValue)
{
	CheckIsValid();
	SetIndentHandle(_this.Get(),InValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetValue(IntPtr _this,float InValue);
public  void SetValue(float InValue)
{
	CheckIsValid();
	SetValue(_this.Get(),InValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetValue(IntPtr _this);
public  float GetValue()
{
	CheckIsValid();
	float ___ret = GetValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}