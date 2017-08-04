//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMovieSceneSequencePlayer:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlaybackEnd(IntPtr _this);
	public  float GetPlaybackEnd()
	{
		CheckIsValid();
		float ___ret = GetPlaybackEnd(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlaybackStart(IntPtr _this);
	public  float GetPlaybackStart()
	{
		CheckIsValid();
		float ___ret = GetPlaybackStart(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaybackRange(IntPtr _this,float NewStartTime,float NewEndTime);
	public  void SetPlaybackRange(float NewStartTime,float NewEndTime)
	{
		CheckIsValid();
		SetPlaybackRange(_this.Get(),NewStartTime,NewEndTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlayRate(IntPtr _this,float PlayRate);
	public  void SetPlayRate(float PlayRate)
	{
		CheckIsValid();
		SetPlayRate(_this.Get(),PlayRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlayRate(IntPtr _this);
	public  float GetPlayRate()
	{
		CheckIsValid();
		float ___ret = GetPlayRate(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetLength(IntPtr _this);
	public  float GetLength()
	{
		CheckIsValid();
		float ___ret = GetLength(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlaying(IntPtr _this);
	public  bool IsPlaying()
	{
		CheckIsValid();
		int ___ret = IsPlaying(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaybackPosition(IntPtr _this,float NewPlaybackPosition);
	public  void SetPlaybackPosition(float NewPlaybackPosition)
	{
		CheckIsValid();
		SetPlaybackPosition(_this.Get(),NewPlaybackPosition);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlaybackPosition(IntPtr _this);
	public  float GetPlaybackPosition()
	{
		CheckIsValid();
		float ___ret = GetPlaybackPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Stop(IntPtr _this);
	public  void Stop()
	{
		CheckIsValid();
		Stop(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Pause(IntPtr _this);
	public  void Pause()
	{
		CheckIsValid();
		Pause(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StartPlayingNextTick(IntPtr _this);
	public  void StartPlayingNextTick()
	{
		CheckIsValid();
		StartPlayingNextTick(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayLooping(IntPtr _this,int NumLoops);
	public  void PlayLooping(int NumLoops=-1)
	{
		CheckIsValid();
		PlayLooping(_this.Get(),NumLoops);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ChangePlaybackDirection(IntPtr _this);
	public  void ChangePlaybackDirection()
	{
		CheckIsValid();
		ChangePlaybackDirection(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayReverse(IntPtr _this);
	public  void PlayReverse()
	{
		CheckIsValid();
		PlayReverse(_this.Get());
		
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
