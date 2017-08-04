//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetSwitcher:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetWidgetAtIndex(IntPtr _this,int Index);
	public  UWidget GetWidgetAtIndex(int Index)
	{
		CheckIsValid();
		IntPtr ___ret = GetWidgetAtIndex(_this.Get(),Index);
		if(___ret==IntPtr.Zero) return null; UWidget ___ret2= new UWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActiveWidget(IntPtr _this,IntPtr Widget);
	public  void SetActiveWidget(UWidget Widget)
	{
		CheckIsValid();
		SetActiveWidget(_this.Get(),Widget);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActiveWidgetIndex(IntPtr _this,int Index);
	public  void SetActiveWidgetIndex(int Index)
	{
		CheckIsValid();
		SetActiveWidgetIndex(_this.Get(),Index);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetActiveWidgetIndex(IntPtr _this);
	public  int GetActiveWidgetIndex()
	{
		CheckIsValid();
		int ___ret = GetActiveWidgetIndex(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumWidgets(IntPtr _this);
	public  int GetNumWidgets()
	{
		CheckIsValid();
		int ___ret = GetNumWidgets(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
