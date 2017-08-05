//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkeletalMeshComponent:USkinnedMeshComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetCurrentJointAngles(IntPtr _this,string InBoneName,out float Swing1Angle,out float TwistAngle,out float Swing2Angle);
	
	/// <summary>
	/// Gets the current Angular state for a named bone constraint
	/// @param InBoneName  Name of bone to get constraint ranges for
	/// @param Swing1Angle current angular state of the constraint
	/// @param TwistAngle  current angular state of the constraint
	/// @param Swing2Angle current angular state of the constraint
	/// </summary>
	public  void GetCurrentJointAngles(string InBoneName,out float Swing1Angle,out float TwistAngle,out float Swing2Angle)
	{
		CheckIsValid();
		GetCurrentJointAngles(_this.Get(),InBoneName,out Swing1Angle,out TwistAngle,out Swing2Angle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularLimits(IntPtr _this,string InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle);
	
	/// <summary>
	/// Sets the Angular Motion Ranges for a named bone
	/// @param InBoneName  Name of bone to adjust constraint ranges for
	/// @param Swing1LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
	/// @param TwistLimitAngle        Size of limit in degrees, 0 means locked, 180 means free
	/// @param Swing2LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
	/// </summary>
	public  void SetAngularLimits(string InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle)
	{
		CheckIsValid();
		SetAngularLimits(_this.Get(),InBoneName,Swing1LimitAngle,TwistLimitAngle,Swing2LimitAngle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakConstraint(IntPtr _this,ref FVector Impulse,ref FVector HitLocation,string InBoneName);
	
	/// <summary>
	/// Break a constraint off a Gore mesh.
	/// @param       Impulse vector of impulse
	/// @param       HitLocation     location of the hit
	/// @param       InBoneName      Name of bone to break constraint for
	/// </summary>
	public  void BreakConstraint(FVector Impulse,FVector HitLocation,string InBoneName)
	{
		CheckIsValid();
		BreakConstraint(_this.Get(),ref Impulse,ref HitLocation,InBoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string FindConstraintBoneName(IntPtr _this,int ConstraintIndex);
	
	/// <summary>
	/// Find Constraint Name from index
	/// @param       ConstraintIndex Index of constraint to look for
	/// @return      Constraint Joint Name
	/// </summary>
	public  string FindConstraintBoneName(int ConstraintIndex)
	{
		CheckIsValid();
		string ___ret = FindConstraintBoneName(_this.Get(),ConstraintIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetConstraintProfileForAll(IntPtr _this,string ProfileName,int bDefaultIfNotFound);
	
	/// <summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset for all constraints. If profile name is not found the joint is set to use the default constraint profile.</summary>
	public  void SetConstraintProfileForAll(string ProfileName,bool bDefaultIfNotFound=false)
	{
		CheckIsValid();
		SetConstraintProfileForAll(_this.Get(),ProfileName,bDefaultIfNotFound?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetConstraintProfile(IntPtr _this,string JointName,string ProfileName,int bDefaultIfNotFound);
	
	/// <summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset. If profile name is not found the joint is set to use the default constraint profile.</summary>
	public  void SetConstraintProfile(string JointName,string ProfileName,bool bDefaultIfNotFound=false)
	{
		CheckIsValid();
		SetConstraintProfile(_this.Get(),JointName,ProfileName,bDefaultIfNotFound?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularDriveParams(IntPtr _this,float InSpring,float InDamping,float InForceLimit,int bSkipCustomPhysicsType);
	
	/// <summary>Set Angular Drive motors params for all constraint instances</summary>
	public  void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularDriveParams(_this.Get(),InSpring,InDamping,InForceLimit,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularVelocityDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive,int bSkipCustomPhysicsType);
	
	/// <summary>Enable or Disable AngularVelocityDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
	public  void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularVelocityDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllMotorsAngularPositionDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive,int bSkipCustomPhysicsType);
	
	/// <summary>Enable or Disable AngularPositionDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
	public  void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		SetAllMotorsAngularPositionDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AccumulateAllBodiesBelowPhysicsBlendWeight(IntPtr _this,string InBoneName,float AddPhysicsBlendWeight,int bSkipCustomPhysicsType);
	
	/// <summary>Accumulate AddPhysicsBlendWeight to physics blendweight for all of the bones below passed in bone to be simulated</summary>
	public  void AccumulateAllBodiesBelowPhysicsBlendWeight(string InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType=false)
	{
		CheckIsValid();
		AccumulateAllBodiesBelowPhysicsBlendWeight(_this.Get(),InBoneName,AddPhysicsBlendWeight,bSkipCustomPhysicsType?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesBelowPhysicsBlendWeight(IntPtr _this,string InBoneName,float PhysicsBlendWeight,int bSkipCustomPhysicsType,int bIncludeSelf);
	
	/// <summary>Set all of the bones below passed in bone to be simulated</summary>
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
	
	/// <summary>Allows you to reset bodies Simulate state based on where bUsePhysics is set to true in the BodySetup.</summary>
	public  void ResetAllBodiesSimulatePhysics()
	{
		CheckIsValid();
		ResetAllBodiesSimulatePhysics(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesBelowSimulatePhysics(IntPtr _this,string InBoneName,int bNewSimulate,int bIncludeSelf);
	
	/// <summary>Set all of the bones below passed in bone to be simulated</summary>
	public  void SetAllBodiesBelowSimulatePhysics(string InBoneName,bool bNewSimulate,bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetAllBodiesBelowSimulatePhysics(_this.Get(),InBoneName,bNewSimulate?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnablePhysicsBlending(IntPtr _this,int bNewBlendPhysics);
	
	/// <summary>Disable physics blending of bones *</summary>
	public  void SetEnablePhysicsBlending(bool bNewBlendPhysics)
	{
		CheckIsValid();
		SetEnablePhysicsBlending(_this.Get(),bNewBlendPhysics?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPhysicsBlendWeight(IntPtr _this,float PhysicsBlendWeight);
	
	/// <summary>
	/// This is global set up for setting physics blend weight
	/// This does multiple things automatically
	/// If PhysicsBlendWeight == 1.f, it will enable Simulation, and if PhysicsBlendWeight == 0.f, it will disable Simulation.
	/// Also it will respect each body's setup, so if the body is fixed, it won't simulate. Vice versa
	/// So if you'd like all bodies to change manually, do not use this function, but SetAllBodiesPhysicsBlendWeight
	/// </summary>
	public  void SetPhysicsBlendWeight(float PhysicsBlendWeight)
	{
		CheckIsValid();
		SetPhysicsBlendWeight(_this.Get(),PhysicsBlendWeight);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllBodiesSimulatePhysics(IntPtr _this,int bNewSimulate);
	
	/// <summary>Set bSimulatePhysics to true for all bone bodies. Does not change the component bSimulatePhysics flag.</summary>
	public  void SetAllBodiesSimulatePhysics(bool bNewSimulate)
	{
		CheckIsValid();
		SetAllBodiesSimulatePhysics(_this.Get(),bNewSimulate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddImpulseToAllBodiesBelow(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange,int bIncludeSelf);
	
	/// <summary>
	/// Add impulse to all single rigid bodies below. Good for one time instant burst.
	/// @param  Impulse         Magnitude and direction of impulse to apply.
	/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
	/// @param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
	/// @param bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
	/// </summary>
	public  void AddImpulseToAllBodiesBelow(FVector Impulse,string BoneName="None",bool bVelChange=false,bool bIncludeSelf=true)
	{
		CheckIsValid();
		AddImpulseToAllBodiesBelow(_this.Get(),ref Impulse,BoneName,bVelChange?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddForceToAllBodiesBelow(IntPtr _this,ref FVector Force,string BoneName,int bAccelChange,int bIncludeSelf);
	
	/// <summary>
	/// Add a force to all rigid bodies below.
	/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
	/// @param  Force            Force vector to apply. Magnitude indicates strength of force.
	/// @param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
	/// @param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
	/// @param  bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
	/// </summary>
	public  void AddForceToAllBodiesBelow(FVector Force,string BoneName="None",bool bAccelChange=false,bool bIncludeSelf=true)
	{
		CheckIsValid();
		AddForceToAllBodiesBelow(_this.Get(),ref Force,BoneName,bAccelChange?1:0,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSkeletalCenterOfMass(IntPtr _this);
	
	/// <summary>Returns the center of mass of the skeletal mesh, instead of the root body's location</summary>
	public  FVector GetSkeletalCenterOfMass()
	{
		CheckIsValid();
		FVector ___ret = GetSkeletalCenterOfMass(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetBoneMass(IntPtr _this,string BoneName,int bScaleMass);
	
	/// <summary>
	/// Returns the mass (in kg) of the given bone
	/// @param BoneName         Name of the body to return. 'None' indicates root body.
	/// @param bScaleMass       If true, the mass is scaled by the bone's MassScale.
	/// </summary>
	public  float GetBoneMass(string BoneName="None",bool bScaleMass=true)
	{
		CheckIsValid();
		float ___ret = GetBoneMass(_this.Get(),BoneName,bScaleMass?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_GetClosestPointOnPhysicsAsset(IntPtr _this,ref FVector WorldPosition,out FVector ClosestWorldPosition,out FVector Normal,out string BoneName,out float Distance);
	
	/// <summary>
	/// Given a world position, find the closest point on the physics asset. Note that this is independent of collision and welding. This is based purely on animation position
	/// @param      WorldPosition                           The point we want the closest point to (i.e. for all bodies in the physics asset, find the one that has a point closest to WorldPosition)
	/// @param      ClosestPointOnPhysicsAsset      The data associated with the closest point (position, normal, etc...)
	/// @return     true if we found a closest point
	/// </summary>
	public  bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,out FVector ClosestWorldPosition,out FVector Normal,out string BoneName,out float Distance)
	{
		CheckIsValid();
		int ___ret = K2_GetClosestPointOnPhysicsAsset(_this.Get(),ref WorldPosition,out ClosestWorldPosition,out Normal,out BoneName,out Distance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableGravityOnAllBodiesBelow(IntPtr _this,int bEnableGravity,string BoneName,int bIncludeSelf);
	
	/// <summary>
	/// Enables or disables gravity to all bodies below the given bone.
	/// NAME_None indicates all bodies will be edited.
	/// In that case, consider using UPrimitiveComponent::EnableGravity.
	/// @param bEnableGravity   Whether gravity should be enabled or disabled.
	/// @param BoneName                 The name of the top most bone.
	/// @param bIncludeSelf             Whether the bone specified should be edited.
	/// </summary>
	public  void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,string BoneName,bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetEnableGravityOnAllBodiesBelow(_this.Get(),bEnableGravity?1:0,BoneName,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsBodyGravityEnabled(IntPtr _this,string BoneName);
	
	/// <summary>
	/// Checks whether or not gravity is enabled on the given bone.
	/// NAME_None indicates the root body should be queried.
	/// If the bone name given is otherwise invalid, false is returned.
	/// @param BoneName The name of the bone to check.
	/// @return True if gravity is enabled on the bone.
	/// </summary>
	public  bool IsBodyGravityEnabled(string BoneName)
	{
		CheckIsValid();
		int ___ret = IsBodyGravityEnabled(_this.Get(),BoneName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEnableBodyGravity(IntPtr _this,int bEnableGravity,string BoneName);
	
	/// <summary>
	/// Enables or disables gravity for the given bone.
	/// NAME_None indicates the root body will be edited.
	/// If the bone name given is otherwise invalid, nothing happens.
	/// @param bEnableGravity   Whether gravity should be enabled or disabled.
	/// @param BoneName                 The name of the bone to modify.
	/// </summary>
	public  void SetEnableBodyGravity(bool bEnableGravity,string BoneName)
	{
		CheckIsValid();
		SetEnableBodyGravity(_this.Get(),bEnableGravity?1:0,BoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNotifyRigidBodyCollisionBelow(IntPtr _this,int bNewNotifyRigidBodyCollision,string BoneName,int bIncludeSelf);
	
	/// <summary>
	/// Changes the value of bNotifyRigidBodyCollision on all bodies below a given bone
	/// @param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
	/// @param BoneName                                               Name of the body to turn hit notifies on (and below)
	/// @param bIncludeSelf                                   Whether to modify the given body (useful for roots with multiple children)
	/// </summary>
	public  void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,string BoneName="None",bool bIncludeSelf=true)
	{
		CheckIsValid();
		SetNotifyRigidBodyCollisionBelow(_this.Get(),bNewNotifyRigidBodyCollision?1:0,BoneName,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBodyNotifyRigidBodyCollision(IntPtr _this,int bNewNotifyRigidBodyCollision,string BoneName);
	
	/// <summary>
	/// Changes the value of bNotifyRigidBodyCollision for a given body
	/// @param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
	/// @param BoneName                                               Name of the body to turn hit notifies on/off. None implies root body
	/// </summary>
	public  void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,string BoneName="None")
	{
		CheckIsValid();
		SetBodyNotifyRigidBodyCollision(_this.Get(),bNewNotifyRigidBodyCollision?1:0,BoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUpdateAnimationInEditor(IntPtr _this,int NewUpdateState);
	
	/// <summary>
	/// Sets whether or not to force tick component in order to update animation and refresh transform for this component
	/// This is supported only in the editor
	/// </summary>
	public  void SetUpdateAnimationInEditor(bool NewUpdateState)
	{
		CheckIsValid();
		SetUpdateAnimationInEditor(_this.Get(),NewUpdateState?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UnbindClothFromMasterPoseComponent(IntPtr _this,int bRestoreSimulationSpace);
	
	/// <summary>
	/// If this component has a valid MasterPoseComponent and has previously had its cloth bound to the
	/// MCP, this function will unbind the cloth and resume simulation.
	/// @param bRestoreSimulationSpace if true and the master pose cloth was originally simulating in world
	/// space, we will restore this setting. This will cause the master component to reset which may be
	/// undesirable.
	/// </summary>
	public  void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace=true)
	{
		CheckIsValid();
		UnbindClothFromMasterPoseComponent(_this.Get(),bRestoreSimulationSpace?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BindClothToMasterPoseComponent(IntPtr _this);
	
	/// <summary>
	/// If this component has a valid MasterPoseComponent then this function makes cloth items on the slave component
	/// take the transforms of the cloth items on the master component instead of simulating separately.
	/// @Note This will FORCE any cloth actor on the master component to simulate in local space. Also
	/// The meshes used in the components must be identical for the cloth to bind correctly
	/// </summary>
	public  void BindClothToMasterPoseComponent()
	{
		CheckIsValid();
		BindClothToMasterPoseComponent(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetClothTeleportMode(IntPtr _this);
	
	/// <summary>Reset the teleport mode of a next update to 'Continuous'</summary>
	public  void ResetClothTeleportMode()
	{
		CheckIsValid();
		ResetClothTeleportMode(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsClothingSimulationSuspended(IntPtr _this);
	
	/// <summary>Gets whether or not the clothing simulation is currently suspended</summary>
	public  bool IsClothingSimulationSuspended()
	{
		CheckIsValid();
		int ___ret = IsClothingSimulationSuspended(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResumeClothingSimulation(IntPtr _this);
	
	/// <summary>Resumes a previously suspended clothing simulation, teleporting the clothing on the next tick</summary>
	public  void ResumeClothingSimulation()
	{
		CheckIsValid();
		ResumeClothingSimulation(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SuspendClothingSimulation(IntPtr _this);
	
	/// <summary>Stops simulating clothing, but does not show clothing ref pose. Keeps the last known simulation state</summary>
	public  void SuspendClothingSimulation()
	{
		CheckIsValid();
		SuspendClothingSimulation(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceClothNextUpdateTeleportAndReset(IntPtr _this);
	
	/// <summary>
	/// Used to indicate we should force 'teleport and reset' during the next call to UpdateClothState.
	/// This can be used to reset it from a bad state or by a teleport where the old state is not important anymore.
	/// </summary>
	public  void ForceClothNextUpdateTeleportAndReset()
	{
		CheckIsValid();
		ForceClothNextUpdateTeleportAndReset(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceClothNextUpdateTeleport(IntPtr _this);
	
	/// <summary>
	/// Used to indicate we should force 'teleport' during the next call to UpdateClothState,
	/// This will transform positions and velocities and thus keep the simulation state, just translate it to a new pose.
	/// </summary>
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
	
	/// <summary>Get/Set the max distance scale of clothing mesh vertices</summary>
	public  float GetClothMaxDistanceScale()
	{
		CheckIsValid();
		float ___ret = GetClothMaxDistanceScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SnapshotPose(IntPtr _this,out FPoseSnapshot Snapshot);
	
	/// <summary>
	/// Takes a snapshot of this skeletal mesh component's pose and saves it to the specified snapshot.
	/// The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1
	/// and then used it at LOD0 any bones not in LOD1 will use the reference pose
	/// </summary>
	public  void SnapshotPose(out FPoseSnapshot Snapshot)
	{
		CheckIsValid();
		SnapshotPose(_this.Get(),out Snapshot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMorphTarget(IntPtr _this,string MorphTargetName);
	
	/// <summary>Get Morph target with given name</summary>
	public  float GetMorphTarget(string MorphTargetName)
	{
		CheckIsValid();
		float ___ret = GetMorphTarget(_this.Get(),MorphTargetName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMorphTargets(IntPtr _this);
	
	/// <summary>Clear all Morph Target that are set to this mesh</summary>
	public  void ClearMorphTargets()
	{
		CheckIsValid();
		ClearMorphTargets(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMorphTarget(IntPtr _this,string MorphTargetName,float Value,int bRemoveZeroWeight);
	
	/// <summary>
	/// Set Morph Target with Name and Value(0-1)
	/// @param bRemoveZeroWeight : Used by editor code when it should stay in the active list with zero weight
	/// </summary>
	public  void SetMorphTarget(string MorphTargetName,float Value,bool bRemoveZeroWeight=true)
	{
		CheckIsValid();
		SetMorphTarget(_this.Get(),MorphTargetName,Value,bRemoveZeroWeight?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OverrideAnimationData(IntPtr _this,IntPtr InAnimToPlay,int bIsLooping,int bIsPlaying,float Position,float PlayRate);
	
	/// <summary>
	/// This overrides current AnimationData parameter in the SkeletalMeshComponent. This will serialize when the component serialize
	/// so it can be used during construction script. However note that this will override current existing data
	/// This can be useful if you'd like to make a blueprint with custom default animation per component
	/// This sets single player mode, which means you can't use AnimBlueprint with it
	/// </summary>
	public  void OverrideAnimationData(UAnimationAsset InAnimToPlay,bool bIsLooping=true,bool bIsPlaying=true,float Position=0.000000f,float PlayRate=1.000000f)
	{
		CheckIsValid();
		OverrideAnimationData(_this.Get(),InAnimToPlay,bIsLooping?1:0,bIsPlaying?1:0,Position,PlayRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlayRate(IntPtr _this);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  float GetPlayRate()
	{
		CheckIsValid();
		float ___ret = GetPlayRate(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlayRate(IntPtr _this,float Rate);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  void SetPlayRate(float Rate)
	{
		CheckIsValid();
		SetPlayRate(_this.Get(),Rate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPosition(IntPtr _this);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  float GetPosition()
	{
		CheckIsValid();
		float ___ret = GetPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPosition(IntPtr _this,float InPos,int bFireNotifies);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  void SetPosition(float InPos,bool bFireNotifies=true)
	{
		CheckIsValid();
		SetPosition(_this.Get(),InPos,bFireNotifies?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlaying(IntPtr _this);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  bool IsPlaying()
	{
		CheckIsValid();
		int ___ret = IsPlaying(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Stop(IntPtr _this);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  void Stop()
	{
		CheckIsValid();
		Stop(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Play(IntPtr _this,int bLooping);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  void Play(bool bLooping)
	{
		CheckIsValid();
		Play(_this.Get(),bLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnimation(IntPtr _this,IntPtr NewAnimToPlay);
	
	/// <summary>
	/// Animation play functions
	///       *
	///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///       * Becuase of that reason, it is not safe to be used during construction script
	///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
	public  void SetAnimation(UAnimationAsset NewAnimToPlay)
	{
		CheckIsValid();
		SetAnimation(_this.Get(),NewAnimToPlay);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayAnimation(IntPtr _this,IntPtr NewAnimToPlay,int bLooping);
	
	/// <summary>
	/// Animation play functions
	///        *
	///        * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
	///        * Becuase of that reason, it is not safe to be used during construction script
	///        * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
	/// </summary>
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
	
	/// <summary>Below are the interface to control animation when animation mode, not blueprint mode *</summary>
	public  void SetAnimationMode(EAnimationMode InAnimationMode)
	{
		CheckIsValid();
		SetAnimationMode(_this.Get(),(int)InAnimationMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPostProcessInstance(IntPtr _this);
	
	/// <summary>
	/// Returns the active post process instance is one is available. This is set on the mesh that this
	/// component is using, and is evaluated immediately after the main instance.
	/// </summary>
	public  UAnimInstance GetPostProcessInstance()
	{
		CheckIsValid();
		IntPtr ___ret = GetPostProcessInstance(_this.Get());
		if(___ret==IntPtr.Zero) return null; UAnimInstance ___ret2= new UAnimInstance(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetAnimInstance(IntPtr _this);
	
	/// <summary>
	/// Returns the animation instance that is driving the class (if available). This is typically an instance of
	/// the class set as AnimBlueprintGeneratedClass (generated by an animation blueprint)
	/// Since this instance is transient, it is not safe to be used during construction script
	/// </summary>
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
