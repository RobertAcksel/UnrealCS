//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAbsolute(IntPtr _this,int bNewAbsoluteLocation,int bNewAbsoluteRotation,int bNewAbsoluteScale);
public  void SetAbsolute(bool bNewAbsoluteLocation=false,bool bNewAbsoluteRotation=false,bool bNewAbsoluteScale=false)
{
	CheckIsValid();
	SetAbsolute(_this.Get(),bNewAbsoluteLocation?1:0,bNewAbsoluteRotation?1:0,bNewAbsoluteScale?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPhysicsVolume(IntPtr _this);
public  APhysicsVolume GetPhysicsVolume()
{
	CheckIsValid();
	IntPtr ___ret = GetPhysicsVolume(_this.Get());
	if(___ret==IntPtr.Zero) return null; APhysicsVolume ___ret2= new APhysicsVolume(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHiddenInGame(IntPtr _this,int NewHidden,int bPropagateToChildren);
public  void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren=false)
{
	CheckIsValid();
	SetHiddenInGame(_this.Get(),NewHidden?1:0,bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleVisibility(IntPtr _this,int bPropagateToChildren);
public  void ToggleVisibility(bool bPropagateToChildren=false)
{
	CheckIsValid();
	ToggleVisibility(_this.Get(),bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVisibility(IntPtr _this,int bNewVisibility,int bPropagateToChildren);
public  void SetVisibility(bool bNewVisibility,bool bPropagateToChildren=false)
{
	CheckIsValid();
	SetVisibility(_this.Get(),bNewVisibility?1:0,bPropagateToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVisible(IntPtr _this);
public  bool IsVisible()
{
	CheckIsValid();
	int ___ret = IsVisible(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetComponentVelocity(IntPtr _this);
public  FVector GetComponentVelocity()
{
	CheckIsValid();
	FVector ___ret = GetComponentVelocity(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DoesSocketExist(IntPtr _this,string InSocketName);
public  bool DoesSocketExist(string InSocketName)
{
	CheckIsValid();
	int ___ret = DoesSocketExist(_this.Get(),InSocketName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetSocketRotation(IntPtr _this,string InSocketName);
public  FRotator GetSocketRotation(string InSocketName)
{
	CheckIsValid();
	FRotator ___ret = GetSocketRotation(_this.Get(),InSocketName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetSocketLocation(IntPtr _this,string InSocketName);
public  FVector GetSocketLocation(string InSocketName)
{
	CheckIsValid();
	FVector ___ret = GetSocketLocation(_this.Get(),InSocketName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetSocketTransform(IntPtr _this,string InSocketName,int TransformSpace);
public  FTransform GetSocketTransform(string InSocketName,ERelativeTransformSpace TransformSpace=ERelativeTransformSpace.RTS_World)
{
	CheckIsValid();
	FTransform ___ret = GetSocketTransform(_this.Get(),InSocketName,(int)TransformSpace);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FName[] GetAllSocketNames(IntPtr _this);
public  FName[] GetAllSocketNames()
{
	CheckIsValid();
	FName[] ___ret = GetAllSocketNames(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_AttachTo(IntPtr _this,IntPtr InParent,string InSocketName,int AttachType,int bWeldSimulatedBodies);
public  bool K2_AttachTo(USceneComponent InParent,string InSocketName="None",EAttachLocation AttachType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
{
	CheckIsValid();
	int ___ret = K2_AttachTo(_this.Get(),InParent,InSocketName,(int)AttachType,bWeldSimulatedBodies?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetChildrenComponents(IntPtr _this,int bIncludeAllDescendants,out IntPtr[] Children);
public  void GetChildrenComponents(bool bIncludeAllDescendants,out USceneComponent[] Children)
{
	CheckIsValid();
	IntPtr[] Children_temp;
	GetChildrenComponents(_this.Get(),bIncludeAllDescendants?1:0,out Children_temp);
	Children = MarshalUtil.IntPtrArrayToObjectArray<USceneComponent>(Children_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetChildComponent(IntPtr _this,int ChildIndex);
public  USceneComponent GetChildComponent(int ChildIndex)
{
	CheckIsValid();
	IntPtr ___ret = GetChildComponent(_this.Get(),ChildIndex);
	if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumChildrenComponents(IntPtr _this);
public  int GetNumChildrenComponents()
{
	CheckIsValid();
	int ___ret = GetNumChildrenComponents(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetParentComponents(IntPtr _this,out IntPtr[] Parents);
public  void GetParentComponents(out USceneComponent[] Parents)
{
	CheckIsValid();
	IntPtr[] Parents_temp;
	GetParentComponents(_this.Get(),out Parents_temp);
	Parents = MarshalUtil.IntPtrArrayToObjectArray<USceneComponent>(Parents_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetAttachSocketName(IntPtr _this);
public  string GetAttachSocketName()
{
	CheckIsValid();
	string ___ret = GetAttachSocketName(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetAttachParent(IntPtr _this);
public  USceneComponent GetAttachParent()
{
	CheckIsValid();
	IntPtr ___ret = GetAttachParent(_this.Get());
	if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnySimulatingPhysics(IntPtr _this);
public  bool IsAnySimulatingPhysics()
{
	CheckIsValid();
	int ___ret = IsAnySimulatingPhysics(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsSimulatingPhysics(IntPtr _this,string BoneName);
public  bool IsSimulatingPhysics(string BoneName="None")
{
	CheckIsValid();
	int ___ret = IsSimulatingPhysics(_this.Get(),BoneName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetRightVector(IntPtr _this);
public  FVector GetRightVector()
{
	CheckIsValid();
	FVector ___ret = GetRightVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetUpVector(IntPtr _this);
public  FVector GetUpVector()
{
	CheckIsValid();
	FVector ___ret = GetUpVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetForwardVector(IntPtr _this);
public  FVector GetForwardVector()
{
	CheckIsValid();
	FVector ___ret = GetForwardVector(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform K2_GetComponentToWorld(IntPtr _this);
public  FTransform K2_GetComponentToWorld()
{
	CheckIsValid();
	FTransform ___ret = K2_GetComponentToWorld(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_GetComponentScale(IntPtr _this);
public  FVector K2_GetComponentScale()
{
	CheckIsValid();
	FVector ___ret = K2_GetComponentScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator K2_GetComponentRotation(IntPtr _this);
public  FRotator K2_GetComponentRotation()
{
	CheckIsValid();
	FRotator ___ret = K2_GetComponentRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_GetComponentLocation(IntPtr _this);
public  FVector K2_GetComponentLocation()
{
	CheckIsValid();
	FVector ___ret = K2_GetComponentLocation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddWorldOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddWorldOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldScale3D(IntPtr _this,ref FVector NewScale);
public  void SetWorldScale3D(FVector NewScale)
{
	CheckIsValid();
	SetWorldScale3D(_this.Get(),ref NewScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldRotation(IntPtr _this,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldRotation(_this.Get(),ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetWorldLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetWorldLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetWorldLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddLocalOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddLocalOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddRelativeRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddRelativeRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_AddRelativeLocation(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_AddRelativeLocation(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRelativeScale3D(IntPtr _this,ref FVector NewScale3D);
public  void SetRelativeScale3D(FVector NewScale3D)
{
	CheckIsValid();
	SetRelativeScale3D(_this.Get(),ref NewScale3D);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetRelativeTransform(IntPtr _this);
public  void ResetRelativeTransform()
{
	CheckIsValid();
	ResetRelativeTransform(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTransform GetRelativeTransform(IntPtr _this);
public  FTransform GetRelativeTransform()
{
	CheckIsValid();
	FTransform ___ret = GetRelativeTransform(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeRotation(IntPtr _this,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeRotation(_this.Get(),ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetRelativeLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
public  void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
{
	CheckIsValid();
	K2_SetRelativeLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
