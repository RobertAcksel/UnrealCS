//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APlayerCameraManager:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllCameraAnims(IntPtr _this,int bImmediate);
public  void StopAllCameraAnims(bool bImmediate=false)
{
	CheckIsValid();
	StopAllCameraAnims(_this.Get(),bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraAnimInst(IntPtr _this,IntPtr AnimInst,int bImmediate);
public  void StopCameraAnimInst(UCameraAnimInst AnimInst,bool bImmediate=false)
{
	CheckIsValid();
	StopCameraAnimInst(_this.Get(),AnimInst,bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllInstancesOfCameraAnim(IntPtr _this,IntPtr Anim,int bImmediate);
public  void StopAllInstancesOfCameraAnim(UCameraAnim Anim,bool bImmediate=false)
{
	CheckIsValid();
	StopAllInstancesOfCameraAnim(_this.Get(),Anim,bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr PlayCameraAnim(IntPtr _this,IntPtr Anim,float Rate,float Scale,float BlendInTime,float BlendOutTime,int bLoop,int bRandomStartTime,float Duration,int PlaySpace,ref FRotator UserPlaySpaceRot);
public  UCameraAnimInst PlayCameraAnim(UCameraAnim Anim,float Rate=1.000000f,float Scale=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,float Duration=0.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
{
	CheckIsValid();
	IntPtr ___ret = PlayCameraAnim(_this.Get(),Anim,Rate,Scale,BlendInTime,BlendOutTime,bLoop?1:0,bRandomStartTime?1:0,Duration,(int)PlaySpace,ref UserPlaySpaceRot);
	if(___ret==IntPtr.Zero) return null; UCameraAnimInst ___ret2= new UCameraAnimInst(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetManualCameraFade(IntPtr _this,float InFadeAmount,ref FLinearColor Color,int bInFadeAudio);
public  void SetManualCameraFade(float InFadeAmount,FLinearColor Color,bool bInFadeAudio)
{
	CheckIsValid();
	SetManualCameraFade(_this.Get(),InFadeAmount,ref Color,bInFadeAudio?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraFade(IntPtr _this);
public  void StopCameraFade()
{
	CheckIsValid();
	StopCameraFade(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartCameraFade(IntPtr _this,float FromAlpha,float ToAlpha,float Duration,ref FLinearColor Color,int bShouldFadeAudio,int bHoldWhenFinished);
public  void StartCameraFade(float FromAlpha,float ToAlpha,float Duration,FLinearColor Color,bool bShouldFadeAudio=false,bool bHoldWhenFinished=false)
{
	CheckIsValid();
	StartCameraFade(_this.Get(),FromAlpha,ToAlpha,Duration,ref Color,bShouldFadeAudio?1:0,bHoldWhenFinished?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllCameraShakes(IntPtr _this,int bImmediately);
public  void StopAllCameraShakes(bool bImmediately=true)
{
	CheckIsValid();
	StopAllCameraShakes(_this.Get(),bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAllInstancesOfCameraShake(IntPtr _this,IntPtr Shake,int bImmediately);
public  void StopAllInstancesOfCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true)
{
	CheckIsValid();
	StopAllInstancesOfCameraShake(_this.Get(),Shake.NativeClass,bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopCameraShake(IntPtr _this,IntPtr ShakeInstance,int bImmediately);
public  void StopCameraShake(UCameraShake ShakeInstance,bool bImmediately=true)
{
	CheckIsValid();
	StopCameraShake(_this.Get(),ShakeInstance,bImmediately?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr PlayCameraShake(IntPtr _this,IntPtr ShakeClass,float Scale,int PlaySpace,ref FRotator UserPlaySpaceRot);
public  UCameraShake PlayCameraShake(TSubclassOf<UCameraShake>  ShakeClass,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
{
	CheckIsValid();
	IntPtr ___ret = PlayCameraShake(_this.Get(),ShakeClass.NativeClass,Scale,(int)PlaySpace,ref UserPlaySpaceRot);
	if(___ret==IntPtr.Zero) return null; UCameraShake ___ret2= new UCameraShake(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearCameraLensEffects(IntPtr _this);
public  void ClearCameraLensEffects()
{
	CheckIsValid();
	ClearCameraLensEffects(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveCameraLensEffect(IntPtr _this,IntPtr Emitter);
public  void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter)
{
	CheckIsValid();
	RemoveCameraLensEffect(_this.Get(),Emitter);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddCameraLensEffect(IntPtr _this,IntPtr LensEffectEmitterClass);
public  AEmitterCameraLensEffectBase AddCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
{
	CheckIsValid();
	IntPtr ___ret = AddCameraLensEffect(_this.Get(),LensEffectEmitterClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; AEmitterCameraLensEffectBase ___ret2= new AEmitterCameraLensEffectBase(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCameraLocation(IntPtr _this);
public  FVector GetCameraLocation()
{
	CheckIsValid();
	FVector ___ret = GetCameraLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetCameraRotation(IntPtr _this);
public  FRotator GetCameraRotation()
{
	CheckIsValid();
	FRotator ___ret = GetCameraRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFOVAngle(IntPtr _this);
public  float GetFOVAngle()
{
	CheckIsValid();
	float ___ret = GetFOVAngle(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int RemoveCameraModifier(IntPtr _this,IntPtr ModifierToRemove);
public  bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
{
	CheckIsValid();
	int ___ret = RemoveCameraModifier(_this.Get(),ModifierToRemove);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FindCameraModifierByClass(IntPtr _this,IntPtr ModifierClass);
public  UCameraModifier FindCameraModifierByClass(TSubclassOf<UCameraModifier>  ModifierClass)
{
	CheckIsValid();
	IntPtr ___ret = FindCameraModifierByClass(_this.Get(),ModifierClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UCameraModifier ___ret2= new UCameraModifier(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr AddNewCameraModifier(IntPtr _this,IntPtr ModifierClass);
public  UCameraModifier AddNewCameraModifier(TSubclassOf<UCameraModifier>  ModifierClass)
{
	CheckIsValid();
	IntPtr ___ret = AddNewCameraModifier(_this.Get(),ModifierClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UCameraModifier ___ret2= new UCameraModifier(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningPlayerController(IntPtr _this);
public  APlayerController GetOwningPlayerController()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningPlayerController(_this.Get());
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
