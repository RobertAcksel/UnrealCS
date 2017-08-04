//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTimelineComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearColorCurve(IntPtr _this,IntPtr NewLinearColorCurve,string LinearColorTrackName);
public  void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve,string LinearColorTrackName)
{
	CheckIsValid();
	SetLinearColorCurve(_this.Get(),NewLinearColorCurve,LinearColorTrackName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorCurve(IntPtr _this,IntPtr NewVectorCurve,string VectorTrackName);
public  void SetVectorCurve(UCurveVector NewVectorCurve,string VectorTrackName)
{
	CheckIsValid();
	SetVectorCurve(_this.Get(),NewVectorCurve,VectorTrackName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFloatCurve(IntPtr _this,IntPtr NewFloatCurve,string FloatTrackName);
public  void SetFloatCurve(UCurveFloat NewFloatCurve,string FloatTrackName)
{
	CheckIsValid();
	SetFloatCurve(_this.Get(),NewFloatCurve,FloatTrackName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetIgnoreTimeDilation(IntPtr _this);
public  bool GetIgnoreTimeDilation()
{
	CheckIsValid();
	int ___ret = GetIgnoreTimeDilation(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreTimeDilation(IntPtr _this,int bNewIgnoreTimeDilation);
public  void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
{
	CheckIsValid();
	SetIgnoreTimeDilation(_this.Get(),bNewIgnoreTimeDilation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTimelineLengthMode(IntPtr _this,int NewLengthMode);
public  void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode)
{
	CheckIsValid();
	SetTimelineLengthMode(_this.Get(),(int)NewLengthMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTimelineLength(IntPtr _this,float NewLength);
public  void SetTimelineLength(float NewLength)
{
	CheckIsValid();
	SetTimelineLength(_this.Get(),NewLength);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTimelineLength(IntPtr _this);
public  float GetTimelineLength()
{
	CheckIsValid();
	float ___ret = GetTimelineLength(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNewTime(IntPtr _this,float NewTime);
public  void SetNewTime(float NewTime)
{
	CheckIsValid();
	SetNewTime(_this.Get(),NewTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlayRate(IntPtr _this);
public  float GetPlayRate()
{
	CheckIsValid();
	float ___ret = GetPlayRate(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlayRate(IntPtr _this,float NewRate);
public  void SetPlayRate(float NewRate)
{
	CheckIsValid();
	SetPlayRate(_this.Get(),NewRate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLooping(IntPtr _this);
public  bool IsLooping()
{
	CheckIsValid();
	int ___ret = IsLooping(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLooping(IntPtr _this,int bNewLooping);
public  void SetLooping(bool bNewLooping)
{
	CheckIsValid();
	SetLooping(_this.Get(),bNewLooping?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlaybackPosition(IntPtr _this);
public  float GetPlaybackPosition()
{
	CheckIsValid();
	float ___ret = GetPlaybackPosition(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlaybackPosition(IntPtr _this,float NewPosition,int bFireEvents,int bFireUpdate);
public  void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate=true)
{
	CheckIsValid();
	SetPlaybackPosition(_this.Get(),NewPosition,bFireEvents?1:0,bFireUpdate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsReversing(IntPtr _this);
public  bool IsReversing()
{
	CheckIsValid();
	int ___ret = IsReversing(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlaying(IntPtr _this);
public  bool IsPlaying()
{
	CheckIsValid();
	int ___ret = IsPlaying(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ReverseFromEnd(IntPtr _this);
public  void ReverseFromEnd()
{
	CheckIsValid();
	ReverseFromEnd(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Reverse(IntPtr _this);
public  void Reverse()
{
	CheckIsValid();
	Reverse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayFromStart(IntPtr _this);
public  void PlayFromStart()
{
	CheckIsValid();
	PlayFromStart(_this.Get());
	
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
