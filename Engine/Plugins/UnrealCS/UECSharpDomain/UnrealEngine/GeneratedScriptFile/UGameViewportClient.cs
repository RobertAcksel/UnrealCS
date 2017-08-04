//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameViewportClient:UScriptViewportClient 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetConsoleTarget(IntPtr _this,int PlayerIndex);
	public  void SetConsoleTarget(int PlayerIndex)
	{
		CheckIsValid();
		SetConsoleTarget(_this.Get(),PlayerIndex);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowTitleSafeArea(IntPtr _this);
	public  void ShowTitleSafeArea()
	{
		CheckIsValid();
		ShowTitleSafeArea(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SSSwapControllers(IntPtr _this);
	public  void SSSwapControllers()
	{
		CheckIsValid();
		SSSwapControllers(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
