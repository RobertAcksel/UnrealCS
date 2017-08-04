//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UForceFeedbackComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BP_GetAttenuationSettingsToApply(IntPtr _this,out FForceFeedbackAttenuationSettings OutAttenuationSettings);
public  bool BP_GetAttenuationSettingsToApply(out FForceFeedbackAttenuationSettings OutAttenuationSettings)
{
	CheckIsValid();
	int ___ret = BP_GetAttenuationSettingsToApply(_this.Get(),out OutAttenuationSettings);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AdjustAttenuation(IntPtr _this,ref FForceFeedbackAttenuationSettings InAttenuationSettings);
public  void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings)
{
	CheckIsValid();
	AdjustAttenuation(_this.Get(),ref InAttenuationSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensityMultiplier(IntPtr _this,float NewIntensityMultiplier);
public  void SetIntensityMultiplier(float NewIntensityMultiplier)
{
	CheckIsValid();
	SetIntensityMultiplier(_this.Get(),NewIntensityMultiplier);
	
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
extern static void SetForceFeedbackEffect(IntPtr _this,IntPtr NewForceFeedbackEffect);
public  void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
{
	CheckIsValid();
	SetForceFeedbackEffect(_this.Get(),NewForceFeedbackEffect);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
