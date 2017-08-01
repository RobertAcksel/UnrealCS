//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMenuAnchor:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasOpenSubMenus(IntPtr _this);
public  bool HasOpenSubMenus()
{
	CheckIsValid();
	int ___ret = HasOpenSubMenus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetMenuPosition(IntPtr _this);
public  FVector2D GetMenuPosition()
{
	CheckIsValid();
	FVector2D ___ret = GetMenuPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ShouldOpenDueToClick(IntPtr _this);
public  bool ShouldOpenDueToClick()
{
	CheckIsValid();
	int ___ret = ShouldOpenDueToClick(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOpen(IntPtr _this);
public  bool IsOpen()
{
	CheckIsValid();
	int ___ret = IsOpen(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Close(IntPtr _this);
public  void Close()
{
	CheckIsValid();
	Close(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Open(IntPtr _this,int bFocusMenu);
public  void Open(bool bFocusMenu)
{
	CheckIsValid();
	Open(_this.Get(),bFocusMenu?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleOpen(IntPtr _this,int bFocusOnOpen);
public  void ToggleOpen(bool bFocusOnOpen)
{
	CheckIsValid();
	ToggleOpen(_this.Get(),bFocusOnOpen?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
