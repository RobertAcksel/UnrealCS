//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UButton:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPressed(IntPtr _this);
	public  bool IsPressed()
	{
		CheckIsValid();
		int ___ret = IsPressed(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBackgroundColor(IntPtr _this,ref FLinearColor InBackgroundColor);
	public  void SetBackgroundColor(FLinearColor InBackgroundColor)
	{
		CheckIsValid();
		SetBackgroundColor(_this.Get(),ref InBackgroundColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetColorAndOpacity(IntPtr _this,ref FLinearColor InColorAndOpacity);
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckIsValid();
		SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStyle(IntPtr _this,ref FButtonStyle InStyle);
	public  void SetStyle(FButtonStyle InStyle)
	{
		CheckIsValid();
		SetStyle(_this.Get(),ref InStyle);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
