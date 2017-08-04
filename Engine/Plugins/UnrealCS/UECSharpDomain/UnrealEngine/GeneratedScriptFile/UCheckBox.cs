//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheckBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsChecked(IntPtr _this,int InIsChecked);
public  void SetIsChecked(bool InIsChecked)
{
	CheckIsValid();
	SetIsChecked(_this.Get(),InIsChecked?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsChecked(IntPtr _this);
public  bool IsChecked()
{
	CheckIsValid();
	int ___ret = IsChecked(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPressed(IntPtr _this);
public  bool IsPressed()
{
	CheckIsValid();
	int ___ret = IsPressed(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
