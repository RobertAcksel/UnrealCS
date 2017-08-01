//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AMatineeActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLoopingState(IntPtr _this,int bNewLooping);
public  void SetLoopingState(bool bNewLooping)
{
	CheckIsValid();
	SetLoopingState(_this.Get(),bNewLooping?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangePlaybackDirection(IntPtr _this);
public  void ChangePlaybackDirection()
{
	CheckIsValid();
	ChangePlaybackDirection(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPosition(IntPtr _this,float NewPosition,int bJump);
public  void SetPosition(float NewPosition,bool bJump=false)
{
	CheckIsValid();
	SetPosition(_this.Get(),NewPosition,bJump?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Pause(IntPtr _this);
public  void Pause()
{
	CheckIsValid();
	Pause(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Reverse(IntPtr _this);
public  void Reverse()
{
	CheckIsValid();
	Reverse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Play(IntPtr _this);
public  void Play()
{
	CheckIsValid();
	Play(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
