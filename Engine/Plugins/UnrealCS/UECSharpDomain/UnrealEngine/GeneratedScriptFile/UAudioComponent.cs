//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAudioComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BP_GetAttenuationSettingsToApply(IntPtr _this,out FSoundAttenuationSettings OutAttenuationSettings);
public  bool BP_GetAttenuationSettingsToApply(out FSoundAttenuationSettings OutAttenuationSettings)
{
	CheckIsValid();
	int ___ret = BP_GetAttenuationSettingsToApply(_this.Get(),out OutAttenuationSettings);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSubmixSend(IntPtr _this,IntPtr Submix,float SendLevel);
public  void SetSubmixSend(USoundSubmix Submix,float SendLevel)
{
	CheckIsValid();
	SetSubmixSend(_this.Get(),Submix,SendLevel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AdjustAttenuation(IntPtr _this,ref FSoundAttenuationSettings InAttenuationSettings);
public  void AdjustAttenuation(FSoundAttenuationSettings InAttenuationSettings)
{
	CheckIsValid();
	AdjustAttenuation(_this.Get(),ref InAttenuationSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUISound(IntPtr _this,int bInUISound);
public  void SetUISound(bool bInUISound)
{
	CheckIsValid();
	SetUISound(_this.Get(),bInUISound?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPitchMultiplier(IntPtr _this,float NewPitchMultiplier);
public  void SetPitchMultiplier(float NewPitchMultiplier)
{
	CheckIsValid();
	SetPitchMultiplier(_this.Get(),NewPitchMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumeMultiplier(IntPtr _this,float NewVolumeMultiplier);
public  void SetVolumeMultiplier(float NewVolumeMultiplier)
{
	CheckIsValid();
	SetVolumeMultiplier(_this.Get(),NewVolumeMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntParameter(IntPtr _this,string InName,int InInt);
public  void SetIntParameter(string InName,int InInt)
{
	CheckIsValid();
	SetIntParameter(_this.Get(),InName,InInt);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoolParameter(IntPtr _this,string InName,int InBool);
public  void SetBoolParameter(string InName,bool InBool)
{
	CheckIsValid();
	SetBoolParameter(_this.Get(),InName,InBool?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWaveParameter(IntPtr _this,string InName,IntPtr InWave);
public  void SetWaveParameter(string InName,USoundWave InWave)
{
	CheckIsValid();
	SetWaveParameter(_this.Get(),InName,InWave);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFloatParameter(IntPtr _this,string InName,float InFloat);
public  void SetFloatParameter(string InName,float InFloat)
{
	CheckIsValid();
	SetFloatParameter(_this.Get(),InName,InFloat);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AdjustVolume(IntPtr _this,float AdjustVolumeDuration,float AdjustVolumeLevel);
public  void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel)
{
	CheckIsValid();
	AdjustVolume(_this.Get(),AdjustVolumeDuration,AdjustVolumeLevel);
	
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
extern static void SetPaused(IntPtr _this,int bPause);
public  void SetPaused(bool bPause)
{
	CheckIsValid();
	SetPaused(_this.Get(),bPause?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Play(IntPtr _this,float StartTime);
public  void Play(float StartTime=0.000000f)
{
	CheckIsValid();
	Play(_this.Get(),StartTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FadeOut(IntPtr _this,float FadeOutDuration,float FadeVolumeLevel);
public  void FadeOut(float FadeOutDuration,float FadeVolumeLevel)
{
	CheckIsValid();
	FadeOut(_this.Get(),FadeOutDuration,FadeVolumeLevel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FadeIn(IntPtr _this,float FadeInDuration,float FadeVolumeLevel,float StartTime);
public  void FadeIn(float FadeInDuration,float FadeVolumeLevel=1.000000f,float StartTime=0.000000f)
{
	CheckIsValid();
	FadeIn(_this.Get(),FadeInDuration,FadeVolumeLevel,StartTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSound(IntPtr _this,IntPtr NewSound);
public  void SetSound(USoundBase NewSound)
{
	CheckIsValid();
	SetSound(_this.Get(),NewSound);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
