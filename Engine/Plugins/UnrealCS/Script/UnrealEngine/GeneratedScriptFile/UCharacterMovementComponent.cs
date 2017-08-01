//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCharacterMovementComponent:UPawnMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustRootMotionSourcePosition(IntPtr _this,float TimeStamp,ref FRootMotionSourceGroup ServerRootMotion,int bHasAnimRootMotion,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
public  void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustRootMotionSourcePosition(_this.Get(),TimeStamp,ref ServerRootMotion,bHasAnimRootMotion?1:0,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustRootMotionPosition(IntPtr _this,float TimeStamp,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
public  void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustRootMotionPosition(_this.Get(),TimeStamp,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientVeryShortAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
public  void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientVeryShortAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,ref FVector NewVel,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
public  void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
{
	CheckIsValid();
	ClientAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,ref NewVel,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientAckGoodMove(IntPtr _this,float TimeStamp);
public  void ClientAckGoodMove(float TimeStamp)
{
	CheckIsValid();
	ClientAckGoodMove(_this.Get(),TimeStamp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveOld(IntPtr _this,float OldTimeStamp,ref FVector_NetQuantize10 OldAccel,int OldMoveFlags);
public  void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags)
{
	CheckIsValid();
	ServerMoveOld(_this.Get(),OldTimeStamp,ref OldAccel,OldMoveFlags);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveDualHybridRootMotion(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
public  void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMoveDualHybridRootMotion(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMoveDual(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
public  void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMoveDual(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerMove(IntPtr _this,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int CompressedMoveFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
public  void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
{
	CheckIsValid();
	ServerMove(_this.Get(),TimeStamp,ref InAccel,ref ClientLoc,CompressedMoveFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_ComputeFloorDist(IntPtr _this,ref FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,out FFindFloorResult FloorResult);
public  void K2_ComputeFloorDist(FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,out FFindFloorResult FloorResult)
{
	CheckIsValid();
	K2_ComputeFloorDist(_this.Get(),ref CapsuleLocation,LineDistance,SweepDistance,SweepRadius,out FloorResult);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_FindFloor(IntPtr _this,ref FVector CapsuleLocation,out FFindFloorResult FloorResult);
public  void K2_FindFloor(FVector CapsuleLocation,out FFindFloorResult FloorResult)
{
	CheckIsValid();
	K2_FindFloor(_this.Get(),ref CapsuleLocation,out FloorResult);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableFloorZ(IntPtr _this,float InWalkableFloorZ);
public  void SetWalkableFloorZ(float InWalkableFloorZ)
{
	CheckIsValid();
	SetWalkableFloorZ(_this.Get(),InWalkableFloorZ);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetWalkableFloorZ(IntPtr _this);
public  float K2_GetWalkableFloorZ()
{
	CheckIsValid();
	float ___ret = K2_GetWalkableFloorZ(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableFloorAngle(IntPtr _this,float InWalkableFloorAngle);
public  void SetWalkableFloorAngle(float InWalkableFloorAngle)
{
	CheckIsValid();
	SetWalkableFloorAngle(_this.Get(),InWalkableFloorAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetWalkableFloorAngle(IntPtr _this);
public  float K2_GetWalkableFloorAngle()
{
	CheckIsValid();
	float ___ret = K2_GetWalkableFloorAngle(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsWalkable(IntPtr _this,ref FHitResult Hit);
public  bool IsWalkable(FHitResult Hit)
{
	CheckIsValid();
	int ___ret = IsWalkable(_this.Get(),ref Hit);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetValidPerchRadius(IntPtr _this);
public  float GetValidPerchRadius()
{
	CheckIsValid();
	float ___ret = GetValidPerchRadius(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPerchRadiusThreshold(IntPtr _this);
public  float GetPerchRadiusThreshold()
{
	CheckIsValid();
	float ___ret = GetPerchRadiusThreshold(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForce(IntPtr _this,ref FVector Force);
public  void AddForce(FVector Force)
{
	CheckIsValid();
	AddForce(_this.Get(),ref Force);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulse(IntPtr _this,ref FVector Impulse,int bVelocityChange);
public  void AddImpulse(FVector Impulse,bool bVelocityChange=false)
{
	CheckIsValid();
	AddImpulse(_this.Get(),ref Impulse,bVelocityChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearAccumulatedForces(IntPtr _this);
public  void ClearAccumulatedForces()
{
	CheckIsValid();
	ClearAccumulatedForces(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAnalogInputModifier(IntPtr _this);
public  float GetAnalogInputModifier()
{
	CheckIsValid();
	float ___ret = GetAnalogInputModifier(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCurrentAcceleration(IntPtr _this);
public  FVector GetCurrentAcceleration()
{
	CheckIsValid();
	FVector ___ret = GetCurrentAcceleration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxBrakingDeceleration(IntPtr _this);
public  float GetMaxBrakingDeceleration()
{
	CheckIsValid();
	float ___ret = GetMaxBrakingDeceleration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxAcceleration(IntPtr _this);
public  float GetMaxAcceleration()
{
	CheckIsValid();
	float ___ret = GetMaxAcceleration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxJumpHeightWithJumpTime(IntPtr _this);
public  float GetMaxJumpHeightWithJumpTime()
{
	CheckIsValid();
	float ___ret = GetMaxJumpHeightWithJumpTime(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMaxJumpHeight(IntPtr _this);
public  float GetMaxJumpHeight()
{
	CheckIsValid();
	float ___ret = GetMaxJumpHeight(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CalcVelocity(IntPtr _this,float DeltaTime,float Friction,int bFluid,float BrakingDeceleration);
public  void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration)
{
	CheckIsValid();
	CalcVelocity(_this.Get(),DeltaTime,Friction,bFluid?1:0,BrakingDeceleration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetImpartedMovementBaseVelocity(IntPtr _this);
public  FVector GetImpartedMovementBaseVelocity()
{
	CheckIsValid();
	FVector ___ret = GetImpartedMovementBaseVelocity(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMovementBase(IntPtr _this);
public  UPrimitiveComponent GetMovementBase()
{
	CheckIsValid();
	IntPtr ___ret = GetMovementBase(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPrimitiveComponent ___ret2= new UPrimitiveComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableMovement(IntPtr _this);
public  void DisableMovement()
{
	CheckIsValid();
	DisableMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsWalking(IntPtr _this);
public  bool IsWalking()
{
	CheckIsValid();
	int ___ret = IsWalking(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMovementMode(IntPtr _this,int NewMovementMode,int NewCustomMode);
public  void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode=0)
{
	CheckIsValid();
	SetMovementMode(_this.Get(),(int)NewMovementMode,NewCustomMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetCharacterOwner(IntPtr _this);
public  ACharacter GetCharacterOwner()
{
	CheckIsValid();
	IntPtr ___ret = GetCharacterOwner(_this.Get());
	if(___ret==IntPtr.Zero) return null; ACharacter ___ret2= new ACharacter(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceEnabled(IntPtr _this,int bEnable);
public  void SetAvoidanceEnabled(bool bEnable)
{
	CheckIsValid();
	SetAvoidanceEnabled(_this.Get(),bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToIgnoreMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetGroupsToIgnoreMask(_this.Get(),ref GroupMask);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToAvoidMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetGroupsToAvoidMask(_this.Get(),ref GroupMask);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceGroupMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetAvoidanceGroupMask(_this.Get(),ref GroupMask);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
