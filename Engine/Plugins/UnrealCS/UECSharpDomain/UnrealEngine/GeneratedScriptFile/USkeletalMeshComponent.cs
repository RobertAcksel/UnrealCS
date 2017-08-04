//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkeletalMeshComponent:USkinnedMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetCurrentJointAngles(IntPtr _this,string InBoneName,out float Swing1Angle,out float TwistAngle,out float Swing2Angle);
	public  void GetCurrentJointAngles(string InBoneName,out float Swing1Angle,out float TwistAngle,out float Swing2Angle)
	{
		CheckIsValid();
		GetCurrentJointAngles(_this.Get(),InBoneName,out Swing1Angle,out TwistAngle,out Swing2Angle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularLimits(IntPtr _this,string InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle);
	public  void SetAngularLimits(string InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle)
	{
		CheckIsValid();
		SetAngularLimits(_this.Get(),InBoneName,Swing1LimitAngle,TwistLimitAngle,Swing2LimitAngle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakConstraint(IntPtr _this,ref FVector Impulse,ref FVector HitLocation,string InBoneName);
	public  void BreakConstraint(FVector Impulse,FVector HitLocation,string InBoneName)
	{
		CheckIsValid();
		BreakConstraint(_this.Get(),ref Impulse,ref HitLocation,InBoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string FindConstraintBoneName(IntPtr _this,int ConstraintIndex);
	public  string FindConstraintBoneName(int ConstraintIndex)
	{
		CheckIsValid();
		string ___ret = FindConstraintBoneName(_this.Get(),ConstraintIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetConstraintProfileForAll(IntPtr _this,string ProfileName,int bDefaultIfNotFound);
	public  void SetConstraintProfileForAll(string ProfileName,bool bDefaultIfNotFound=false)
	{
		CheckIsValid();
		SetConstraintProfileForAll(_this.Get(),ProfileName,bDefaultIfNotFound?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetConstraintProfile(IntPtr _this,string JointName,string ProfileName,int bDefaultIfNotFound);
	public  void SetConstraintProfile(string JointName,string ProfileName,bool bDefaultIfNotFound=false)
	{
		CheckIsValid();
		SetConstraintProfile(_this.Get(),JointName,ProfileName,bDefaultIfNotFound?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularDriveParams(IntPtr _this,float InSpring,float InDamping,float InForceLimit,int bSkipCustomPhysicsType);
	public  void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularDriveParams(_this.Get(),InSpring,InDamping,InForceLimit,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularVelocityDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive,int bSkipCustomPhysicsType);
	public  void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularVelocityDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularPositionDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive,int bSkipCustomPhysicsType);
	public  void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularPositionDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AccumulateAllBodiesBelowPhysicsBlendWeight(IntPtr _this,string InBoneName,float AddPhysicsBlendWeight,int bSkipCustomPhysicsType);
	public  void AccumulateAllBodiesBelowPhysicsBlendWeight(string InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		AccumulateAllBodiesBelowPhysicsBlendWeight(_this.Get(),InBoneName,AddPhysicsBlendWeight,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesBelowPhysicsBlendWeight(IntPtr _this,string InBoneName,float PhysicsBlendWeight,int bSkipCustomPhysicsType,int bIncludeSelf);
	public  void SetAllBodiesBelowPhysicsBlendWeight(string InBoneName,float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false,bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetAllBodiesBelowPhysicsBlendWeight(_this.Get(),InBoneName,PhysicsBlendWeight,bSkipCustomPhysicsType?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesPhysicsBlendWeight(IntPtr _this,float PhysicsBlendWeight,int bSkipCustomPhysicsType);
	public  void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllBodiesPhysicsBlendWeight(_this.Get(),PhysicsBlendWeight,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetAllBodiesSimulatePhysics(IntPtr _this);
	public  void ResetAllBodiesSimulatePhysics()
	{
		CheckIsValid();
		ResetAllBodiesSimulatePhysics(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesBelowSimulatePhysics(IntPtr _this,string InBoneName,int bNewSimulate,int bIncludeSelf);
	public  void SetAllBodiesBelowSimulatePhysics(string InBoneName,bool bNewSimulate,bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetAllBodiesBelowSimulatePhysics(_this.Get(),InBoneName,bNewSimulate?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnablePhysicsBlending(IntPtr _this,int bNewBlendPhysics);
	public  void SetEnablePhysicsBlending(bool bNewBlendPhysics)
	{
		CheckIsValid();
		SetEnablePhysicsBlending(_this.Get(),bNewBlendPhysics?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPhysicsBlendWeight(IntPtr _this,float PhysicsBlendWeight);
	public  void SetPhysicsBlendWeight(float PhysicsBlendWeight)
	{
		CheckIsValid();
		SetPhysicsBlendWeight(_this.Get(),PhysicsBlendWeight);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesSimulatePhysics(IntPtr _this,int bNewSimulate);
	public  void SetAllBodiesSimulatePhysics(bool bNewSimulate)
	{
		CheckIsValid();
		SetAllBodiesSimulatePhysics(_this.Get(),bNewSimulate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddImpulseToAllBodiesBelow(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange,int bIncludeSelf);
	public  void AddImpulseToAllBodiesBelow(FVector Impulse,string BoneName="None",bool bVelChange=false,bool bIncludeSelf=true)
	{
		CheckIsValid();
		AddImpulseToAllBodiesBelow(_this.Get(),ref Impulse,BoneName,bVelChange?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddForceToAllBodiesBelow(IntPtr _this,ref FVector Force,string BoneName,int bAccelChange,int bIncludeSelf);
	public  void AddForceToAllBodiesBelow(FVector Force,string BoneName="None",bool bAccelChange=false,bool bIncludeSelf=true)
	{
		CheckIsValid();
		AddForceToAllBodiesBelow(_this.Get(),ref Force,BoneName,bAccelChange?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSkeletalCenterOfMass(IntPtr _this);
	public  FVector GetSkeletalCenterOfMass()
	{
		CheckIsValid();
		FVector ___ret = GetSkeletalCenterOfMass(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetBoneMass(IntPtr _this,string BoneName,int bScaleMass);
	public  float GetBoneMass(string BoneName="None",bool bScaleMass=true)
	{
		CheckIsValid();
		float ___ret = GetBoneMass(_this.Get(),BoneName,bScaleMass?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_GetClosestPointOnPhysicsAsset(IntPtr _this,ref FVector WorldPosition,out FVector ClosestWorldPosition,out FVector Normal,out string BoneName,out float Distance);
	public  bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,out FVector ClosestWorldPosition,out FVector Normal,out string BoneName,out float Distance)
	{
		CheckIsValid();
		int ___ret = K2_GetClosestPointOnPhysicsAsset(_this.Get(),ref WorldPosition,out ClosestWorldPosition,out Normal,out BoneName,out Distance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableGravityOnAllBodiesBelow(IntPtr _this,int bEnableGravity,string BoneName,int bIncludeSelf);
	public  void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,string BoneName,bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetEnableGravityOnAllBodiesBelow(_this.Get(),bEnableGravity?1:0,BoneName,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsBodyGravityEnabled(IntPtr _this,string BoneName);
	public  bool IsBodyGravityEnabled(string BoneName)
	{
		CheckIsValid();
		int ___ret = IsBodyGravityEnabled(_this.Get(),BoneName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableBodyGravity(IntPtr _this,int bEnableGravity,string BoneName);
	public  void SetEnableBodyGravity(bool bEnableGravity,string BoneName)
	{
		CheckIsValid();
		SetEnableBodyGravity(_this.Get(),bEnableGravity?1:0,BoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNotifyRigidBodyCollisionBelow(IntPtr _this,int bNewNotifyRigidBodyCollision,string BoneName,int bIncludeSelf);
	public  void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,string BoneName="None",bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetNotifyRigidBodyCollisionBelow(_this.Get(),bNewNotifyRigidBodyCollision?1:0,BoneName,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBodyNotifyRigidBodyCollision(IntPtr _this,int bNewNotifyRigidBodyCollision,string BoneName);
	public  void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,string BoneName="None")
	{
		CheckIsValid();
		SetBodyNotifyRigidBodyCollision(_this.Get(),bNewNotifyRigidBodyCollision?1:0,BoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUpdateAnimationInEditor(IntPtr _this,int NewUpdateState);
	public  void SetUpdateAnimationInEditor(bool NewUpdateState)
	{
		CheckIsValid();
		SetUpdateAnimationInEditor(_this.Get(),NewUpdateState?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UnbindClothFromMasterPoseComponent(IntPtr _this,int bRestoreSimulationSpace);
	public  void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace=true)
	{
		CheckIsValid();
		UnbindClothFromMasterPoseComponent(_this.Get(),bRestoreSimulationSpace?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BindClothToMasterPoseComponent(IntPtr _this);
	public  void BindClothToMasterPoseComponent()
	{
		CheckIsValid();
		BindClothToMasterPoseComponent(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetClothTeleportMode(IntPtr _this);
	public  void ResetClothTeleportMode()
	{
		CheckIsValid();
		ResetClothTeleportMode(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsClothingSimulationSuspended(IntPtr _this);
	public  bool IsClothingSimulationSuspended()
	{
		CheckIsValid();
		int ___ret = IsClothingSimulationSuspended(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResumeClothingSimulation(IntPtr _this);
	public  void ResumeClothingSimulation()
	{
		CheckIsValid();
		ResumeClothingSimulation(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SuspendClothingSimulation(IntPtr _this);
	public  void SuspendClothingSimulation()
	{
		CheckIsValid();
		SuspendClothingSimulation(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceClothNextUpdateTeleportAndReset(IntPtr _this);
	public  void ForceClothNextUpdateTeleportAndReset()
	{
		CheckIsValid();
		ForceClothNextUpdateTeleportAndReset(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceClothNextUpdateTeleport(IntPtr _this);
	public  void ForceClothNextUpdateTeleport()
	{
		CheckIsValid();
		ForceClothNextUpdateTeleport(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetClothMaxDistanceScale(IntPtr _this,float Scale);
	public  void SetClothMaxDistanceScale(float Scale)
	{
		CheckIsValid();
		SetClothMaxDistanceScale(_this.Get(),Scale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetClothMaxDistanceScale(IntPtr _this);
	public  float GetClothMaxDistanceScale()
	{
		CheckIsValid();
		float ___ret = GetClothMaxDistanceScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SnapshotPose(IntPtr _this,out FPoseSnapshot Snapshot);
	public  void SnapshotPose(out FPoseSnapshot Snapshot)
	{
		CheckIsValid();
		SnapshotPose(_this.Get(),out Snapshot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMorphTarget(IntPtr _this,string MorphTargetName);
	public  float GetMorphTarget(string MorphTargetName)
	{
		CheckIsValid();
		float ___ret = GetMorphTarget(_this.Get(),MorphTargetName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMorphTargets(IntPtr _this);
	public  void ClearMorphTargets()
	{
		CheckIsValid();
		ClearMorphTargets(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMorphTarget(IntPtr _this,string MorphTargetName,float Value,int bRemoveZeroWeight);
	public  void SetMorphTarget(string MorphTargetName,float Value,bool bRemoveZeroWeight=true)
	{
		CheckIsValid();
		SetMorphTarget(_this.Get(),MorphTargetName,Value,bRemoveZeroWeight?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OverrideAnimationData(IntPtr _this,IntPtr InAnimToPlay,int bIsLooping,int bIsPlaying,float Position,float PlayRate);
	public  void OverrideAnimationData(UAnimationAsset InAnimToPlay,bool bIsLooping=true,bool bIsPlaying=true,float Position=0.000000f,float PlayRate=1.000000f)
	{
		CheckIsValid();
		OverrideAnimationData(_this.Get(),InAnimToPlay,bIsLooping?1:0,bIsPlaying?1:0,Position,PlayRate);
		
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
	static extern void SetPlayRate(IntPtr _this,float Rate);
	public  void SetPlayRate(float Rate)
	{
		CheckIsValid();
		SetPlayRate(_this.Get(),Rate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPosition(IntPtr _this);
	public  float GetPosition()
	{
		CheckIsValid();
		float ___ret = GetPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPosition(IntPtr _this,float InPos,int bFireNotifies);
	public  void SetPosition(float InPos,bool bFireNotifies=true)
	{
		CheckIsValid();
		SetPosition(_this.Get(),InPos,bFireNotifies?1:0);
		
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
	static extern void Stop(IntPtr _this);
	public  void Stop()
	{
		CheckIsValid();
		Stop(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Play(IntPtr _this,int bLooping);
	public  void Play(bool bLooping)
	{
		CheckIsValid();
		Play(_this.Get(),bLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnimation(IntPtr _this,IntPtr NewAnimToPlay);
	public  void SetAnimation(UAnimationAsset NewAnimToPlay)
	{
		CheckIsValid();
		SetAnimation(_this.Get(),NewAnimToPlay);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayAnimation(IntPtr _this,IntPtr NewAnimToPlay,int bLooping);
	public  void PlayAnimation(UAnimationAsset NewAnimToPlay,bool bLooping)
	{
		CheckIsValid();
		PlayAnimation(_this.Get(),NewAnimToPlay,bLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetAnimationMode(IntPtr _this);
	public  EAnimationMode GetAnimationMode()
	{
		CheckIsValid();
		int ___ret = GetAnimationMode(_this.Get());
		return (EAnimationMode)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnimationMode(IntPtr _this,int InAnimationMode);
	public  void SetAnimationMode(EAnimationMode InAnimationMode)
	{
		CheckIsValid();
		SetAnimationMode(_this.Get(),(int)InAnimationMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPostProcessInstance(IntPtr _this);
	public  UAnimInstance GetPostProcessInstance()
	{
		CheckIsValid();
		IntPtr ___ret = GetPostProcessInstance(_this.Get());
		if(___ret==IntPtr.Zero) return null; UAnimInstance ___ret2= new UAnimInstance(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetAnimInstance(IntPtr _this);
	public  UAnimInstance GetAnimInstance()
	{
		CheckIsValid();
		IntPtr ___ret = GetAnimInstance(_this.Get());
		if(___ret==IntPtr.Zero) return null; UAnimInstance ___ret2= new UAnimInstance(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnimInstanceClass(IntPtr _this,IntPtr NewClass);
	public  void SetAnimInstanceClass(UClass NewClass)
	{
		CheckIsValid();
		SetAnimInstanceClass(_this.Get(),NewClass);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
