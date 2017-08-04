//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetInteractionComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCustomHitResult(IntPtr _this,ref FHitResult HitResult);
	public  void SetCustomHitResult(FHitResult HitResult)
	{
		CheckIsValid();
		SetCustomHitResult(_this.Get(),ref HitResult);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Get2DHitLocation(IntPtr _this);
	public  FVector2D Get2DHitLocation()
	{
		CheckIsValid();
		FVector2D ___ret = Get2DHitLocation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FHitResult GetLastHitResult(IntPtr _this);
	public  FHitResult GetLastHitResult()
	{
		CheckIsValid();
		FHitResult ___ret = GetLastHitResult(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsOverHitTestVisibleWidget(IntPtr _this);
	public  bool IsOverHitTestVisibleWidget()
	{
		CheckIsValid();
		int ___ret = IsOverHitTestVisibleWidget(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsOverFocusableWidget(IntPtr _this);
	public  bool IsOverFocusableWidget()
	{
		CheckIsValid();
		int ___ret = IsOverFocusableWidget(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsOverInteractableWidget(IntPtr _this);
	public  bool IsOverInteractableWidget()
	{
		CheckIsValid();
		int ___ret = IsOverInteractableWidget(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetHoveredWidgetComponent(IntPtr _this);
	public  UWidgetComponent GetHoveredWidgetComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetHoveredWidgetComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UWidgetComponent ___ret2= new UWidgetComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScrollWheel(IntPtr _this,float ScrollDelta);
	public  void ScrollWheel(float ScrollDelta)
	{
		CheckIsValid();
		ScrollWheel(_this.Get(),ScrollDelta);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SendKeyChar(IntPtr _this,string Characters,int bRepeat);
	public  bool SendKeyChar(string Characters,bool bRepeat=false)
	{
		CheckIsValid();
		int ___ret = SendKeyChar(_this.Get(),Characters,bRepeat?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PressAndReleaseKey(IntPtr _this,ref FKey Key);
	public  bool PressAndReleaseKey(FKey Key)
	{
		CheckIsValid();
		int ___ret = PressAndReleaseKey(_this.Get(),ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ReleaseKey(IntPtr _this,ref FKey Key);
	public  bool ReleaseKey(FKey Key)
	{
		CheckIsValid();
		int ___ret = ReleaseKey(_this.Get(),ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PressKey(IntPtr _this,ref FKey Key,int bRepeat);
	public  bool PressKey(FKey Key,bool bRepeat=false)
	{
		CheckIsValid();
		int ___ret = PressKey(_this.Get(),ref Key,bRepeat?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ReleasePointerKey(IntPtr _this,ref FKey Key);
	public  void ReleasePointerKey(FKey Key)
	{
		CheckIsValid();
		ReleasePointerKey(_this.Get(),ref Key);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PressPointerKey(IntPtr _this,ref FKey Key);
	public  void PressPointerKey(FKey Key)
	{
		CheckIsValid();
		PressPointerKey(_this.Get(),ref Key);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
