//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ADebugCameraController:APlayerController 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPawnMovementSpeedScale(IntPtr _this,float NewSpeedScale);
	
	/// <summary>Sets the pawn movement speed scale.</summary>
	public  void SetPawnMovementSpeedScale(float NewSpeedScale)
	{
		CheckIsValid();
		SetPawnMovementSpeedScale(_this.Get(),NewSpeedScale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetSelectedActor(IntPtr _this);
	
	public  AActor GetSelectedActor()
	{
		CheckIsValid();
		IntPtr ___ret = GetSelectedActor(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ToggleDisplay(IntPtr _this);
	
	/// <summary>Toggles the display of debug info and input commands for the Debug Camera.</summary>
	public  void ToggleDisplay()
	{
		CheckIsValid();
		ToggleDisplay(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowDebugSelectedInfo(IntPtr _this);
	
	/// <summary>@todo document</summary>
	public  void ShowDebugSelectedInfo()
	{
		CheckIsValid();
		ShowDebugSelectedInfo(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
