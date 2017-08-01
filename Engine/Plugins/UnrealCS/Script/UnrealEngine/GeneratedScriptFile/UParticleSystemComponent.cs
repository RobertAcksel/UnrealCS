//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UParticleSystemComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GenerateParticleEvent(IntPtr _this,string InEventName,float InEmitterTime,ref FVector InLocation,ref FVector InDirection,ref FVector InVelocity);
public  void GenerateParticleEvent(string InEventName,float InEmitterTime,FVector InLocation,FVector InDirection,FVector InVelocity)
{
	CheckIsValid();
	GenerateParticleEvent(_this.Get(),InEventName,InEmitterTime,ref InLocation,ref InDirection,ref InVelocity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetNamedMaterial(IntPtr _this,string InName);
public  UMaterialInterface GetNamedMaterial(string InName)
{
	CheckIsValid();
	IntPtr ___ret = GetNamedMaterial(_this.Get(),InName);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateNamedDynamicMaterialInstance(IntPtr _this,string InName,IntPtr SourceMaterial);
public  UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(string InName,UMaterialInterface SourceMaterial)
{
	CheckIsValid();
	IntPtr ___ret = CreateNamedDynamicMaterialInstance(_this.Get(),InName,SourceMaterial);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTrailSourceData(IntPtr _this,string InFirstSocketName,string InSecondSocketName,int InWidthMode,float InWidth);
public  void SetTrailSourceData(string InFirstSocketName,string InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth)
{
	CheckIsValid();
	SetTrailSourceData(_this.Get(),InFirstSocketName,InSecondSocketName,(int)InWidthMode,InWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EndTrails(IntPtr _this);
public  void EndTrails()
{
	CheckIsValid();
	EndTrails(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BeginTrails(IntPtr _this,string InFirstSocketName,string InSecondSocketName,int InWidthMode,float InWidth);
public  void BeginTrails(string InFirstSocketName,string InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth)
{
	CheckIsValid();
	BeginTrails(_this.Get(),InFirstSocketName,InSecondSocketName,(int)InWidthMode,InWidth);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumActiveParticles(IntPtr _this);
public  int GetNumActiveParticles()
{
	CheckIsValid();
	int ___ret = GetNumActiveParticles(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTemplate(IntPtr _this,IntPtr NewTemplate);
public  void SetTemplate(UParticleSystem NewTemplate)
{
	CheckIsValid();
	SetTemplate(_this.Get(),NewTemplate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterialParameter(IntPtr _this,string ParameterName,IntPtr Param);
public  void SetMaterialParameter(string ParameterName,UMaterialInterface Param)
{
	CheckIsValid();
	SetMaterialParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetActorParameter(IntPtr _this,string ParameterName,IntPtr Param);
public  void SetActorParameter(string ParameterName,AActor Param)
{
	CheckIsValid();
	SetActorParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColorParameter(IntPtr _this,string ParameterName,ref FLinearColor Param);
public  void SetColorParameter(string ParameterName,FLinearColor Param)
{
	CheckIsValid();
	SetColorParameter(_this.Get(),ParameterName,ref Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorParameter(IntPtr _this,string ParameterName,ref FVector Param);
public  void SetVectorParameter(string ParameterName,FVector Param)
{
	CheckIsValid();
	SetVectorParameter(_this.Get(),ParameterName,ref Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFloatParameter(IntPtr _this,string ParameterName,float Param);
public  void SetFloatParameter(string ParameterName,float Param)
{
	CheckIsValid();
	SetFloatParameter(_this.Get(),ParameterName,Param);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEmitterEnable(IntPtr _this,string EmitterName,int bNewEnableState);
public  void SetEmitterEnable(string EmitterName,bool bNewEnableState)
{
	CheckIsValid();
	SetEmitterEnable(_this.Get(),EmitterName,bNewEnableState?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetStrength(IntPtr _this,int EmitterIndex,int TargetIndex,out float OutTargetStrength);
public  bool GetBeamTargetStrength(int EmitterIndex,int TargetIndex,out float OutTargetStrength)
{
	CheckIsValid();
	int ___ret = GetBeamTargetStrength(_this.Get(),EmitterIndex,TargetIndex,out OutTargetStrength);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetTangent(IntPtr _this,int EmitterIndex,int TargetIndex,out FVector OutTangentPoint);
public  bool GetBeamTargetTangent(int EmitterIndex,int TargetIndex,out FVector OutTangentPoint)
{
	CheckIsValid();
	int ___ret = GetBeamTargetTangent(_this.Get(),EmitterIndex,TargetIndex,out OutTangentPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamTargetPoint(IntPtr _this,int EmitterIndex,int TargetIndex,out FVector OutTargetPoint);
public  bool GetBeamTargetPoint(int EmitterIndex,int TargetIndex,out FVector OutTargetPoint)
{
	CheckIsValid();
	int ___ret = GetBeamTargetPoint(_this.Get(),EmitterIndex,TargetIndex,out OutTargetPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourceStrength(IntPtr _this,int EmitterIndex,int SourceIndex,out float OutSourceStrength);
public  bool GetBeamSourceStrength(int EmitterIndex,int SourceIndex,out float OutSourceStrength)
{
	CheckIsValid();
	int ___ret = GetBeamSourceStrength(_this.Get(),EmitterIndex,SourceIndex,out OutSourceStrength);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourceTangent(IntPtr _this,int EmitterIndex,int SourceIndex,out FVector OutTangentPoint);
public  bool GetBeamSourceTangent(int EmitterIndex,int SourceIndex,out FVector OutTangentPoint)
{
	CheckIsValid();
	int ___ret = GetBeamSourceTangent(_this.Get(),EmitterIndex,SourceIndex,out OutTangentPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamSourcePoint(IntPtr _this,int EmitterIndex,int SourceIndex,out FVector OutSourcePoint);
public  bool GetBeamSourcePoint(int EmitterIndex,int SourceIndex,out FVector OutSourcePoint)
{
	CheckIsValid();
	int ___ret = GetBeamSourcePoint(_this.Get(),EmitterIndex,SourceIndex,out OutSourcePoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBeamEndPoint(IntPtr _this,int EmitterIndex,out FVector OutEndPoint);
public  bool GetBeamEndPoint(int EmitterIndex,out FVector OutEndPoint)
{
	CheckIsValid();
	int ___ret = GetBeamEndPoint(_this.Get(),EmitterIndex,out OutEndPoint);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetStrength(IntPtr _this,int EmitterIndex,float NewTargetStrength,int TargetIndex);
public  void SetBeamTargetStrength(int EmitterIndex,float NewTargetStrength,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetStrength(_this.Get(),EmitterIndex,NewTargetStrength,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetTangent(IntPtr _this,int EmitterIndex,ref FVector NewTangentPoint,int TargetIndex);
public  void SetBeamTargetTangent(int EmitterIndex,FVector NewTangentPoint,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetTangent(_this.Get(),EmitterIndex,ref NewTangentPoint,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamTargetPoint(IntPtr _this,int EmitterIndex,ref FVector NewTargetPoint,int TargetIndex);
public  void SetBeamTargetPoint(int EmitterIndex,FVector NewTargetPoint,int TargetIndex)
{
	CheckIsValid();
	SetBeamTargetPoint(_this.Get(),EmitterIndex,ref NewTargetPoint,TargetIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourceStrength(IntPtr _this,int EmitterIndex,float NewSourceStrength,int SourceIndex);
public  void SetBeamSourceStrength(int EmitterIndex,float NewSourceStrength,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourceStrength(_this.Get(),EmitterIndex,NewSourceStrength,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourceTangent(IntPtr _this,int EmitterIndex,ref FVector NewTangentPoint,int SourceIndex);
public  void SetBeamSourceTangent(int EmitterIndex,FVector NewTangentPoint,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourceTangent(_this.Get(),EmitterIndex,ref NewTangentPoint,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamSourcePoint(IntPtr _this,int EmitterIndex,ref FVector NewSourcePoint,int SourceIndex);
public  void SetBeamSourcePoint(int EmitterIndex,FVector NewSourcePoint,int SourceIndex)
{
	CheckIsValid();
	SetBeamSourcePoint(_this.Get(),EmitterIndex,ref NewSourcePoint,SourceIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBeamEndPoint(IntPtr _this,int EmitterIndex,ref FVector NewEndPoint);
public  void SetBeamEndPoint(int EmitterIndex,FVector NewEndPoint)
{
	CheckIsValid();
	SetBeamEndPoint(_this.Get(),EmitterIndex,ref NewEndPoint);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
