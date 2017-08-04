//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ULevelStreaming:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetLevelScriptActor(IntPtr _this);
	public  ALevelScriptActor GetLevelScriptActor()
	{
		CheckIsValid();
		IntPtr ___ret = GetLevelScriptActor(_this.Get());
		if(___ret==IntPtr.Zero) return null; ALevelScriptActor ___ret2= new ALevelScriptActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsStreamingStatePending(IntPtr _this);
	public  bool IsStreamingStatePending()
	{
		CheckIsValid();
		int ___ret = IsStreamingStatePending(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLevelLoaded(IntPtr _this);
	public  bool IsLevelLoaded()
	{
		CheckIsValid();
		int ___ret = IsLevelLoaded(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLevelVisible(IntPtr _this);
	public  bool IsLevelVisible()
	{
		CheckIsValid();
		int ___ret = IsLevelVisible(_this.Get());
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
