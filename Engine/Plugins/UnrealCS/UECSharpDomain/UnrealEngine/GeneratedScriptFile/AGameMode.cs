//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameMode:AGameModeBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBandwidthLimit(IntPtr _this,float AsyncIOBandwidthLimit);
	public  void SetBandwidthLimit(float AsyncIOBandwidthLimit)
	{
		CheckIsValid();
		SetBandwidthLimit(_this.Get(),AsyncIOBandwidthLimit);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Say(IntPtr _this,string Msg);
	public  void Say(string Msg)
	{
		CheckIsValid();
		Say(_this.Get(),Msg);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AbortMatch(IntPtr _this);
	public  void AbortMatch()
	{
		CheckIsValid();
		AbortMatch(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RestartGame(IntPtr _this);
	public  void RestartGame()
	{
		CheckIsValid();
		RestartGame(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EndMatch(IntPtr _this);
	public  void EndMatch()
	{
		CheckIsValid();
		EndMatch(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StartMatch(IntPtr _this);
	public  void StartMatch()
	{
		CheckIsValid();
		StartMatch(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasMatchEnded(IntPtr _this);
	public  bool HasMatchEnded()
	{
		CheckIsValid();
		int ___ret = HasMatchEnded(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsMatchInProgress(IntPtr _this);
	public  bool IsMatchInProgress()
	{
		CheckIsValid();
		int ___ret = IsMatchInProgress(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetMatchState(IntPtr _this);
	public  string GetMatchState()
	{
		CheckIsValid();
		string ___ret = GetMatchState(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
