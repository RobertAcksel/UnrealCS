//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheckBox:UContentWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsChecked(IntPtr _this,int InIsChecked);
	
	/// <summary>Sets the checked state.</summary>
	public  void SetIsChecked(bool InIsChecked)
	{
		CheckIsValid();
		SetIsChecked(_this.Get(),InIsChecked?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsChecked(IntPtr _this);
	
	/// <summary>Returns true if the checkbox is currently checked</summary>
	public  bool IsChecked()
	{
		CheckIsValid();
		int ___ret = IsChecked(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPressed(IntPtr _this);
	
	/// <summary>Returns true if this button is currently pressed</summary>
	public  bool IsPressed()
	{
		CheckIsValid();
		int ___ret = IsPressed(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
