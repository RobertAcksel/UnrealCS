//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ACharacter:APawn 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnimRootMotionTranslationScale(IntPtr _this);
public  float GetAnimRootMotionTranslationScale()
{
	CheckIsValid();
	float ___ret = GetAnimRootMotionTranslationScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingNetworkedRootMotionMontage(IntPtr _this);
public  bool IsPlayingNetworkedRootMotionMontage()
{
	CheckIsValid();
	int ___ret = IsPlayingNetworkedRootMotionMontage(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayingRootMotion(IntPtr _this);
public  bool IsPlayingRootMotion()
{
	CheckIsValid();
	int ___ret = IsPlayingRootMotion(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_RootMotion(IntPtr _this);
public  void OnRep_RootMotion()
{
	CheckIsValid();
	OnRep_RootMotion(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatGhost(IntPtr _this);
public  void ClientCheatGhost()
{
	CheckIsValid();
	ClientCheatGhost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatFly(IntPtr _this);
public  void ClientCheatFly()
{
	CheckIsValid();
	ClientCheatFly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientCheatWalk(IntPtr _this);
public  void ClientCheatWalk()
{
	CheckIsValid();
	ClientCheatWalk(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnCrouch(IntPtr _this,int bClientSimulation);
public  void UnCrouch(bool bClientSimulation=false)
{
	CheckIsValid();
	UnCrouch(_this.Get(),bClientSimulation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Crouch(IntPtr _this,int bClientSimulation);
public  void Crouch(bool bClientSimulation=false)
{
	CheckIsValid();
	Crouch(_this.Get(),bClientSimulation?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LaunchCharacter(IntPtr _this,ref FVector LaunchVelocity,int bXYOverride,int bZOverride);
public  void LaunchCharacter(FVector LaunchVelocity,bool bXYOverride,bool bZOverride)
{
	CheckIsValid();
	LaunchCharacter(_this.Get(),ref LaunchVelocity,bXYOverride?1:0,bZOverride?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetCurrentMontage(IntPtr _this);
public  UAnimMontage GetCurrentMontage()
{
	CheckIsValid();
	IntPtr ___ret = GetCurrentMontage(_this.Get());
	if(___ret==IntPtr.Zero) return null; UAnimMontage ___ret2= new UAnimMontage(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopAnimMontage(IntPtr _this,IntPtr AnimMontage);
public  void StopAnimMontage(UAnimMontage AnimMontage)
{
	CheckIsValid();
	StopAnimMontage(_this.Get(),AnimMontage);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float PlayAnimMontage(IntPtr _this,IntPtr AnimMontage,float InPlayRate,string StartSectionName);
public  float PlayAnimMontage(UAnimMontage AnimMontage,float InPlayRate=1.000000f,string StartSectionName="None")
{
	CheckIsValid();
	float ___ret = PlayAnimMontage(_this.Get(),AnimMontage,InPlayRate,StartSectionName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsJumpProvidingForce(IntPtr _this);
public  bool IsJumpProvidingForce()
{
	CheckIsValid();
	int ___ret = IsJumpProvidingForce(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CanJump(IntPtr _this);
public  bool CanJump()
{
	CheckIsValid();
	int ___ret = CanJump(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopJumping(IntPtr _this);
public  void StopJumping()
{
	CheckIsValid();
	StopJumping(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Jump(IntPtr _this);
public  void Jump()
{
	CheckIsValid();
	Jump(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_IsCrouched(IntPtr _this);
public  void OnRep_IsCrouched()
{
	CheckIsValid();
	OnRep_IsCrouched(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetBaseRotationOffsetRotator(IntPtr _this);
public  FRotator GetBaseRotationOffsetRotator()
{
	CheckIsValid();
	FRotator ___ret = GetBaseRotationOffsetRotator(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetBaseTranslationOffset(IntPtr _this);
public  FVector GetBaseTranslationOffset()
{
	CheckIsValid();
	FVector ___ret = GetBaseTranslationOffset(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetReplicateMovement(IntPtr _this,int bInReplicateMovement);
public  void SetReplicateMovement(bool bInReplicateMovement)
{
	CheckIsValid();
	SetReplicateMovement(_this.Get(),bInReplicateMovement?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_ReplicatedBasedMovement(IntPtr _this);
public  void OnRep_ReplicatedBasedMovement()
{
	CheckIsValid();
	OnRep_ReplicatedBasedMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CacheInitialMeshOffset(IntPtr _this,ref FVector MeshRelativeLocation,ref FRotator MeshRelativeRotation);
public  void CacheInitialMeshOffset(FVector MeshRelativeLocation,FRotator MeshRelativeRotation)
{
	CheckIsValid();
	CacheInitialMeshOffset(_this.Get(),ref MeshRelativeLocation,ref MeshRelativeRotation);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
