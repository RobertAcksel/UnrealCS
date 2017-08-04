//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameViewportClient:UScriptViewportClient 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConsoleTarget(IntPtr _this,int PlayerIndex);
public  void SetConsoleTarget(int PlayerIndex)
{
	CheckIsValid();
	SetConsoleTarget(_this.Get(),PlayerIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowTitleSafeArea(IntPtr _this);
public  void ShowTitleSafeArea()
{
	CheckIsValid();
	ShowTitleSafeArea(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SSSwapControllers(IntPtr _this);
public  void SSSwapControllers()
{
	CheckIsValid();
	SSSwapControllers(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
