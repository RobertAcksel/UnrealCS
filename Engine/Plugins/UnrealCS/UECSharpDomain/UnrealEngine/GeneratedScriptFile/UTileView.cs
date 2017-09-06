//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTileView:UTableViewBase 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RequestListRefresh(IntPtr _this);
	
	/// <summary>Refreshes the list</summary>
	public  void RequestListRefresh()
	{
		CheckIsValid();
		RequestListRefresh(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetItemHeight(IntPtr _this,float Height);
	
	/// <summary>Set item height</summary>
	public  void SetItemHeight(float Height)
	{
		CheckIsValid();
		SetItemHeight(_this.Get(),Height);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetItemWidth(IntPtr _this,float Width);
	
	/// <summary>Set item width</summary>
	public  void SetItemWidth(float Width)
	{
		CheckIsValid();
		SetItemWidth(_this.Get(),Width);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
