//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UUniformGridPanel:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr AddChildToUniformGrid(IntPtr _this,IntPtr Content);
	public  UUniformGridSlot AddChildToUniformGrid(UWidget Content)
	{
		CheckIsValid();
		IntPtr ___ret = AddChildToUniformGrid(_this.Get(),Content);
		if(___ret==IntPtr.Zero) return null; UUniformGridSlot ___ret2= new UUniformGridSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinDesiredSlotHeight(IntPtr _this,float InMinDesiredSlotHeight);
	public  void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)
	{
		CheckIsValid();
		SetMinDesiredSlotHeight(_this.Get(),InMinDesiredSlotHeight);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinDesiredSlotWidth(IntPtr _this,float InMinDesiredSlotWidth);
	public  void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)
	{
		CheckIsValid();
		SetMinDesiredSlotWidth(_this.Get(),InMinDesiredSlotWidth);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSlotPadding(IntPtr _this,ref FMargin InSlotPadding);
	public  void SetSlotPadding(FMargin InSlotPadding)
	{
		CheckIsValid();
		SetSlotPadding(_this.Get(),ref InSlotPadding);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
