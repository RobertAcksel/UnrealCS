//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UContentWidget:UPanelWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetContent(IntPtr _this);
	
	public  UWidget GetContent()
	{
		CheckIsValid();
		IntPtr ___ret = GetContent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UWidget ___ret2= new UWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SetContent(IntPtr _this,IntPtr Content);
	
	public  UPanelSlot SetContent(UWidget Content)
	{
		CheckIsValid();
		IntPtr ___ret = SetContent(_this.Get(),Content);
		if(___ret==IntPtr.Zero) return null; UPanelSlot ___ret2= new UPanelSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetContentSlot(IntPtr _this);
	
	public  UPanelSlot GetContentSlot()
	{
		CheckIsValid();
		IntPtr ___ret = GetContentSlot(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPanelSlot ___ret2= new UPanelSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
