//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTimelineComponent:UActorComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearColorCurve(IntPtr _this,IntPtr NewLinearColorCurve,string LinearColorTrackName);
	
	/// <summary>Update a certain linear color track's curve</summary>
	public  void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve,string LinearColorTrackName)
	{
		CheckIsValid();
		SetLinearColorCurve(_this.Get(),NewLinearColorCurve,LinearColorTrackName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVectorCurve(IntPtr _this,IntPtr NewVectorCurve,string VectorTrackName);
	
	/// <summary>Update a certain vector track's curve</summary>
	public  void SetVectorCurve(UCurveVector NewVectorCurve,string VectorTrackName)
	{
		CheckIsValid();
		SetVectorCurve(_this.Get(),NewVectorCurve,VectorTrackName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFloatCurve(IntPtr _this,IntPtr NewFloatCurve,string FloatTrackName);
	
	/// <summary>Update a certain float track's curve</summary>
	public  void SetFloatCurve(UCurveFloat NewFloatCurve,string FloatTrackName)
	{
		CheckIsValid();
		SetFloatCurve(_this.Get(),NewFloatCurve,FloatTrackName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetIgnoreTimeDilation(IntPtr _this);
	
	/// <summary>Get whether to ignore time dilation.</summary>
	public  bool GetIgnoreTimeDilation()
	{
		CheckIsValid();
		int ___ret = GetIgnoreTimeDilation(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIgnoreTimeDilation(IntPtr _this,int bNewIgnoreTimeDilation);
	
	/// <summary>Set whether to ignore time dilation.</summary>
	public  void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
	{
		CheckIsValid();
		SetIgnoreTimeDilation(_this.Get(),bNewIgnoreTimeDilation?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTimelineLengthMode(IntPtr _this,int NewLengthMode);
	
	/// <summary>Sets the length mode of the timeline</summary>
	public  void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode)
	{
		CheckIsValid();
		SetTimelineLengthMode(_this.Get(),(int)NewLengthMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTimelineLength(IntPtr _this,float NewLength);
	
	/// <summary>Set length of the timeline</summary>
	public  void SetTimelineLength(float NewLength)
	{
		CheckIsValid();
		SetTimelineLength(_this.Get(),NewLength);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTimelineLength(IntPtr _this);
	
	/// <summary>Get length of the timeline</summary>
	public  float GetTimelineLength()
	{
		CheckIsValid();
		float ___ret = GetTimelineLength(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNewTime(IntPtr _this,float NewTime);
	
	/// <summary>Set the new playback position time to use</summary>
	public  void SetNewTime(float NewTime)
	{
		CheckIsValid();
		SetNewTime(_this.Get(),NewTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlayRate(IntPtr _this);
	
	/// <summary>Get the current play rate for this timeline</summary>
	public  float GetPlayRate()
	{
		CheckIsValid();
		float ___ret = GetPlayRate(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlayRate(IntPtr _this,float NewRate);
	
	/// <summary>Sets the new play rate for this timeline</summary>
	public  void SetPlayRate(float NewRate)
	{
		CheckIsValid();
		SetPlayRate(_this.Get(),NewRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLooping(IntPtr _this);
	
	/// <summary>Get whether we are looping or not</summary>
	public  bool IsLooping()
	{
		CheckIsValid();
		int ___ret = IsLooping(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLooping(IntPtr _this,int bNewLooping);
	
	/// <summary>true means we would loop, false means we should not.</summary>
	public  void SetLooping(bool bNewLooping)
	{
		CheckIsValid();
		SetLooping(_this.Get(),bNewLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlaybackPosition(IntPtr _this);
	
	/// <summary>Get the current playback position of the Timeline</summary>
	public  float GetPlaybackPosition()
	{
		CheckIsValid();
		float ___ret = GetPlaybackPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaybackPosition(IntPtr _this,float NewPosition,int bFireEvents,int bFireUpdate);
	
	/// <summary>
	/// Jump to a position in the timeline.
	/// @param bFireEvents If true, event functions that are between current position and new playback position will fire.
	/// @param bFireUpdate If true, the update output exec will fire after setting the new playback position.
	/// </summary>
	public  void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate=true)
	{
		CheckIsValid();
		SetPlaybackPosition(_this.Get(),NewPosition,bFireEvents?1:0,bFireUpdate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsReversing(IntPtr _this);
	
	/// <summary>Get whether we are reversing or not</summary>
	public  bool IsReversing()
	{
		CheckIsValid();
		int ___ret = IsReversing(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlaying(IntPtr _this);
	
	/// <summary>Get whether this timeline is playing or not.</summary>
	public  bool IsPlaying()
	{
		CheckIsValid();
		int ___ret = IsPlaying(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Stop(IntPtr _this);
	
	/// <summary>Stop playback of timeline</summary>
	public  void Stop()
	{
		CheckIsValid();
		Stop(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ReverseFromEnd(IntPtr _this);
	
	/// <summary>Start playback of timeline in reverse from the end</summary>
	public  void ReverseFromEnd()
	{
		CheckIsValid();
		ReverseFromEnd(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Reverse(IntPtr _this);
	
	/// <summary>Start playback of timeline in reverse</summary>
	public  void Reverse()
	{
		CheckIsValid();
		Reverse(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayFromStart(IntPtr _this);
	
	/// <summary>Start playback of timeline from the start</summary>
	public  void PlayFromStart()
	{
		CheckIsValid();
		PlayFromStart(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Play(IntPtr _this);
	
	/// <summary>Start playback of timeline</summary>
	public  void Play()
	{
		CheckIsValid();
		Play(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
