//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AMatineeActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLoopingState(IntPtr _this,int bNewLooping);
	public  void SetLoopingState(bool bNewLooping)
	{
		CheckIsValid();
		SetLoopingState(_this.Get(),bNewLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ChangePlaybackDirection(IntPtr _this);
	public  void ChangePlaybackDirection()
	{
		CheckIsValid();
		ChangePlaybackDirection(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPosition(IntPtr _this,float NewPosition,int bJump);
	public  void SetPosition(float NewPosition,bool bJump=false)
	{
		CheckIsValid();
		SetPosition(_this.Get(),NewPosition,bJump?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Pause(IntPtr _this);
	public  void Pause()
	{
		CheckIsValid();
		Pause(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Reverse(IntPtr _this);
	public  void Reverse()
	{
		CheckIsValid();
		Reverse(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Stop(IntPtr _this);
	public  void Stop()
	{
		CheckIsValid();
		Stop(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Play(IntPtr _this);
	public  void Play()
	{
		CheckIsValid();
		Play(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
