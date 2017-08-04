//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ALevelScriptActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCinematicMode(IntPtr _this,int bCinematicMode,int bHidePlayer,int bAffectsHUD,int bAffectsMovement,int bAffectsTurning);
	public  void SetCinematicMode(bool bCinematicMode,bool bHidePlayer=true,bool bAffectsHUD=true,bool bAffectsMovement=false,bool bAffectsTurning=false)
	{
		CheckIsValid();
		SetCinematicMode(_this.Get(),bCinematicMode?1:0,bHidePlayer?1:0,bAffectsHUD?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RemoteEvent(IntPtr _this,string EventName);
	public  bool RemoteEvent(string EventName)
	{
		CheckIsValid();
		int ___ret = RemoteEvent(_this.Get(),EventName);
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
