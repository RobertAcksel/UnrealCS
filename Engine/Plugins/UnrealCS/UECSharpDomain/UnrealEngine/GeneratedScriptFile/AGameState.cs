//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameState:AGameStateBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_ElapsedTime(IntPtr _this);
	public  void OnRep_ElapsedTime()
	{
		CheckIsValid();
		OnRep_ElapsedTime(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_MatchState(IntPtr _this);
	public  void OnRep_MatchState()
	{
		CheckIsValid();
		OnRep_MatchState(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
