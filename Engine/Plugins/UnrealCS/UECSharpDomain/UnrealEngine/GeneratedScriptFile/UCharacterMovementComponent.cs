//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCharacterMovementComponent:UPawnMovementComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientAdjustRootMotionSourcePosition(IntPtr _this,float TimeStamp,ref FRootMotionSourceGroup ServerRootMotion,int bHasAnimRootMotion,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
	
	/// <summary>Replicate root motion source correction to client when using root motion for movement.</summary>
	public  void ClientAdjustRootMotionSourcePosition(float TimeStamp,FRootMotionSourceGroup ServerRootMotion,bool bHasAnimRootMotion,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
	{
		CheckIsValid();
		ClientAdjustRootMotionSourcePosition(_this.Get(),TimeStamp,ref ServerRootMotion,bHasAnimRootMotion?1:0,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientAdjustRootMotionPosition(IntPtr _this,float TimeStamp,float ServerMontageTrackPosition,ref FVector ServerLoc,ref FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,IntPtr ServerBase,string ServerBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
	
	/// <summary>Replicate position correction to client when using root motion for movement. (animation root motion specific)</summary>
	public  void ClientAdjustRootMotionPosition(float TimeStamp,float ServerMontageTrackPosition,FVector ServerLoc,FVector_NetQuantizeNormal ServerRotation,float ServerVelZ,UPrimitiveComponent ServerBase,string ServerBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
	{
		CheckIsValid();
		ClientAdjustRootMotionPosition(_this.Get(),TimeStamp,ServerMontageTrackPosition,ref ServerLoc,ref ServerRotation,ServerVelZ,ServerBase,ServerBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientVeryShortAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
	
	/// <summary>Bandwidth saving version, when velocity is zeroed</summary>
	public  void ClientVeryShortAdjustPosition(float TimeStamp,FVector NewLoc,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
	{
		CheckIsValid();
		ClientVeryShortAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientAdjustPosition(IntPtr _this,float TimeStamp,ref FVector NewLoc,ref FVector NewVel,IntPtr NewBase,string NewBaseBoneName,int bHasBase,int bBaseRelativePosition,int ServerMovementMode);
	
	/// <summary>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment.</summary>
	public  void ClientAdjustPosition(float TimeStamp,FVector NewLoc,FVector NewVel,UPrimitiveComponent NewBase,string NewBaseBoneName,bool bHasBase,bool bBaseRelativePosition,byte ServerMovementMode)
	{
		CheckIsValid();
		ClientAdjustPosition(_this.Get(),TimeStamp,ref NewLoc,ref NewVel,NewBase,NewBaseBoneName,bHasBase?1:0,bBaseRelativePosition?1:0,ServerMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientAckGoodMove(IntPtr _this,float TimeStamp);
	
	/// <summary>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves</summary>
	public  void ClientAckGoodMove(float TimeStamp)
	{
		CheckIsValid();
		ClientAckGoodMove(_this.Get(),TimeStamp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerMoveOld(IntPtr _this,float OldTimeStamp,ref FVector_NetQuantize10 OldAccel,int OldMoveFlags);
	
	/// <summary>Resending an (important) old move. Process it if not already processed.</summary>
	public  void ServerMoveOld(float OldTimeStamp,FVector_NetQuantize10 OldAccel,byte OldMoveFlags)
	{
		CheckIsValid();
		ServerMoveOld(_this.Get(),OldTimeStamp,ref OldAccel,OldMoveFlags);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerMoveDualHybridRootMotion(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
	
	/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves. First move is non root motion, second is root motion.</summary>
	public  void ServerMoveDualHybridRootMotion(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
	{
		CheckIsValid();
		ServerMoveDualHybridRootMotion(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerMoveDual(IntPtr _this,float TimeStamp0,ref FVector_NetQuantize10 InAccel0,int PendingFlags,uint View0,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int NewFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
	
	/// <summary>Replicated function sent by client to server - contains client movement and view info for two moves.</summary>
	public  void ServerMoveDual(float TimeStamp0,FVector_NetQuantize10 InAccel0,byte PendingFlags,uint View0,float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte NewFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
	{
		CheckIsValid();
		ServerMoveDual(_this.Get(),TimeStamp0,ref InAccel0,PendingFlags,View0,TimeStamp,ref InAccel,ref ClientLoc,NewFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerMove(IntPtr _this,float TimeStamp,ref FVector_NetQuantize10 InAccel,ref FVector_NetQuantize100 ClientLoc,int CompressedMoveFlags,int ClientRoll,uint View,IntPtr ClientMovementBase,string ClientBaseBoneName,int ClientMovementMode);
	
	/// <summary>Replicated function sent by client to server - contains client movement and view info.</summary>
	public  void ServerMove(float TimeStamp,FVector_NetQuantize10 InAccel,FVector_NetQuantize100 ClientLoc,byte CompressedMoveFlags,byte ClientRoll,uint View,UPrimitiveComponent ClientMovementBase,string ClientBaseBoneName,byte ClientMovementMode)
	{
		CheckIsValid();
		ServerMove(_this.Get(),TimeStamp,ref InAccel,ref ClientLoc,CompressedMoveFlags,ClientRoll,View,ClientMovementBase,ClientBaseBoneName,ClientMovementMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_ComputeFloorDist(IntPtr _this,ref FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,out FFindFloorResult FloorResult);
	
	/// <summary>
	/// Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult.
	/// This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace.
	/// This function does not care if collision is disabled on the capsule (unlike FindFloor).
	/// @param CapsuleLocation                Location where the capsule sweep should originate
	/// @param LineDistance                   If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.
	/// @param SweepDistance                  If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.
	/// @param SweepRadius                    The radius to use for sweep tests. Should be <= capsule radius.
	/// @param FloorResult                    Result of the floor check
	/// </summary>
	public  void ComputeFloorDist(FVector CapsuleLocation,float LineDistance,float SweepDistance,float SweepRadius,out FFindFloorResult FloorResult)
	{
		CheckIsValid();
		K2_ComputeFloorDist(_this.Get(),ref CapsuleLocation,LineDistance,SweepDistance,SweepRadius,out FloorResult);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_FindFloor(IntPtr _this,ref FVector CapsuleLocation,out FFindFloorResult FloorResult);
	
	/// <summary>
	/// Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.
	/// No floor will be found if collision is disabled on the capsule!
	/// @param CapsuleLocation                Location where the capsule sweep should originate
	/// @param FloorResult                    Result of the floor check
	/// </summary>
	public  void FindFloor(FVector CapsuleLocation,out FFindFloorResult FloorResult)
	{
		CheckIsValid();
		K2_FindFloor(_this.Get(),ref CapsuleLocation,out FloorResult);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWalkableFloorZ(IntPtr _this,float InWalkableFloorZ);
	
	/// <summary>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.</summary>
	public  void SetWalkableFloorZ(float InWalkableFloorZ)
	{
		CheckIsValid();
		SetWalkableFloorZ(_this.Get(),InWalkableFloorZ);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetWalkableFloorZ(IntPtr _this);
	
	/// <summary>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.</summary>
	public  float GetWalkableFloorZ()
	{
		CheckIsValid();
		float ___ret = K2_GetWalkableFloorZ(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWalkableFloorAngle(IntPtr _this,float InWalkableFloorAngle);
	
	/// <summary>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.</summary>
	public  void SetWalkableFloorAngle(float InWalkableFloorAngle)
	{
		CheckIsValid();
		SetWalkableFloorAngle(_this.Get(),InWalkableFloorAngle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetWalkableFloorAngle(IntPtr _this);
	
	/// <summary>Get the max angle in degrees of a walkable surface for the character.</summary>
	public  float GetWalkableFloorAngle()
	{
		CheckIsValid();
		float ___ret = K2_GetWalkableFloorAngle(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsWalkable(IntPtr _this,ref FHitResult Hit);
	
	/// <summary>Return true if the hit result should be considered a walkable surface for the character.</summary>
	public  bool IsWalkable(FHitResult Hit)
	{
		CheckIsValid();
		int ___ret = IsWalkable(_this.Get(),ref Hit);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetValidPerchRadius(IntPtr _this);
	
	/// <summary>
	/// Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).
	/// Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold().
	/// </summary>
	public  float GetValidPerchRadius()
	{
		CheckIsValid();
		float ___ret = GetValidPerchRadius(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPerchRadiusThreshold(IntPtr _this);
	
	/// <summary>@return The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface.</summary>
	public  float GetPerchRadiusThreshold()
	{
		CheckIsValid();
		float ___ret = GetPerchRadiusThreshold(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddForce(IntPtr _this,ref FVector Force);
	
	/// <summary>
	/// Add force to character. Forces are accumulated each tick and applied together
	/// so multiple calls to this function will accumulate.
	/// Forces are scaled depending on timestep, so they can be applied each frame. If you want an
	/// instantaneous force, use AddImpulse.
	/// Adding a force always takes the actor's mass into account.
	/// Note that changing the momentum of characters like this can change the movement mode.
	/// @param       Force                   Force to apply.
	/// </summary>
	public  void AddForce(FVector Force)
	{
		CheckIsValid();
		AddForce(_this.Get(),ref Force);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddImpulse(IntPtr _this,ref FVector Impulse,int bVelocityChange);
	
	/// <summary>
	/// Add impulse to character. Impulses are accumulated each tick and applied together
	/// so multiple calls to this function will accumulate.
	/// An impulse is an instantaneous force, usually applied once. If you want to continually apply
	/// forces each frame, use AddForce().
	/// Note that changing the momentum of characters like this can change the movement mode.
	/// @param       Impulse                         Impulse to apply.
	/// @param       bVelocityChange         Whether or not the impulse is relative to mass.
	/// </summary>
	public  void AddImpulse(FVector Impulse,bool bVelocityChange=false)
	{
		CheckIsValid();
		AddImpulse(_this.Get(),ref Impulse,bVelocityChange?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearAccumulatedForces(IntPtr _this);
	
	/// <summary>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.</summary>
	public  void ClearAccumulatedForces()
	{
		CheckIsValid();
		ClearAccumulatedForces(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetAnalogInputModifier(IntPtr _this);
	
	/// <summary>@return Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.</summary>
	public  float GetAnalogInputModifier()
	{
		CheckIsValid();
		float ___ret = GetAnalogInputModifier(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetCurrentAcceleration(IntPtr _this);
	
	/// <summary>@return Current acceleration, computed from input vector each update.</summary>
	public  FVector GetCurrentAcceleration()
	{
		CheckIsValid();
		FVector ___ret = GetCurrentAcceleration(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxBrakingDeceleration(IntPtr _this);
	
	/// <summary>@return Maximum deceleration for the current state when braking (ie when there is no acceleration).</summary>
	public  float GetMaxBrakingDeceleration()
	{
		CheckIsValid();
		float ___ret = GetMaxBrakingDeceleration(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxAcceleration(IntPtr _this);
	
	/// <summary>@return Maximum acceleration for the current state.</summary>
	public  float GetMaxAcceleration()
	{
		CheckIsValid();
		float ___ret = GetMaxAcceleration(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxJumpHeightWithJumpTime(IntPtr _this);
	
	/// <summary>
	/// Compute the max jump height based on the JumpZVelocity velocity and gravity.
	/// This does take into account the CharacterOwner's MaxJumpHoldTime.
	/// </summary>
	public  float GetMaxJumpHeightWithJumpTime()
	{
		CheckIsValid();
		float ___ret = GetMaxJumpHeightWithJumpTime(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxJumpHeight(IntPtr _this);
	
	/// <summary>
	/// Compute the max jump height based on the JumpZVelocity velocity and gravity.
	/// This does not take into account the CharacterOwner's MaxJumpHoldTime.
	/// </summary>
	public  float GetMaxJumpHeight()
	{
		CheckIsValid();
		float ___ret = GetMaxJumpHeight(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CalcVelocity(IntPtr _this,float DeltaTime,float Friction,int bFluid,float BrakingDeceleration);
	
	/// <summary>
	/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
	/// This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes.
	/// @param       DeltaTime                                               time elapsed since last frame.
	/// @param       Friction                                                coefficient of friction when not accelerating, or in the direction opposite acceleration.
	/// @param       bFluid                                                  true if moving through a fluid, causing Friction to always be applied regardless of acceleration.
	/// @param       BrakingDeceleration                             deceleration applied when not accelerating, or when exceeding max velocity.
	/// </summary>
	public  void CalcVelocity(float DeltaTime,float Friction,bool bFluid,float BrakingDeceleration)
	{
		CheckIsValid();
		CalcVelocity(_this.Get(),DeltaTime,Friction,bFluid?1:0,BrakingDeceleration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetImpartedMovementBaseVelocity(IntPtr _this);
	
	/// <summary>
	/// If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.
	/// Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ.
	/// </summary>
	public  FVector GetImpartedMovementBaseVelocity()
	{
		CheckIsValid();
		FVector ___ret = GetImpartedMovementBaseVelocity(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetMovementBase(IntPtr _this);
	
	/// <summary>Return PrimitiveComponent we are based on (standing and walking on).</summary>
	public  UPrimitiveComponent GetMovementBase()
	{
		CheckIsValid();
		IntPtr ___ret = GetMovementBase(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPrimitiveComponent ___ret2= new UPrimitiveComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DisableMovement(IntPtr _this);
	
	/// <summary>Make movement impossible (sets movement mode to MOVE_None).</summary>
	public  void DisableMovement()
	{
		CheckIsValid();
		DisableMovement(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsWalking(IntPtr _this);
	
	/// <summary>@return true if the character is in the 'Walking' movement mode.</summary>
	public  bool IsWalking()
	{
		CheckIsValid();
		int ___ret = IsWalking(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMovementMode(IntPtr _this,int NewMovementMode,int NewCustomMode);
	
	/// <summary>
	/// Change movement mode.
	/// @param NewMovementMode       The new movement mode
	/// @param NewCustomMode         The new custom sub-mode, only applicable if NewMovementMode is Custom.
	/// </summary>
	public  void SetMovementMode(EMovementMode NewMovementMode,byte NewCustomMode=0)
	{
		CheckIsValid();
		SetMovementMode(_this.Get(),(int)NewMovementMode,NewCustomMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetCharacterOwner(IntPtr _this);
	
	/// <summary>Get the Character that owns UpdatedComponent.</summary>
	public  ACharacter GetCharacterOwner()
	{
		CheckIsValid();
		IntPtr ___ret = GetCharacterOwner(_this.Get());
		if(___ret==IntPtr.Zero) return null; ACharacter ___ret2= new ACharacter(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAvoidanceEnabled(IntPtr _this,int bEnable);
	
	/// <summary>Change avoidance state and registers in RVO manager if needed</summary>
	public  void SetAvoidanceEnabled(bool bEnable)
	{
		CheckIsValid();
		SetAvoidanceEnabled(_this.Get(),bEnable?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetGroupsToIgnoreMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
	
	public  void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask)
	{
		CheckIsValid();
		SetGroupsToIgnoreMask(_this.Get(),ref GroupMask);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetGroupsToAvoidMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
	
	public  void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask)
	{
		CheckIsValid();
		SetGroupsToAvoidMask(_this.Get(),ref GroupMask);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAvoidanceGroupMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
	
	public  void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask)
	{
		CheckIsValid();
		SetAvoidanceGroupMask(_this.Get(),ref GroupMask);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
