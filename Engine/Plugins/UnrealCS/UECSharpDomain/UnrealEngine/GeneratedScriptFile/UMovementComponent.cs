//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMovementComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SnapUpdatedComponentToPlane(IntPtr _this);
	public  void SnapUpdatedComponentToPlane()
	{
		CheckIsValid();
		SnapUpdatedComponentToPlane(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ConstrainNormalToPlane(IntPtr _this,ref FVector Normal);
	public  FVector ConstrainNormalToPlane(FVector Normal)
	{
		CheckIsValid();
		FVector ___ret = ConstrainNormalToPlane(_this.Get(),ref Normal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ConstrainLocationToPlane(IntPtr _this,ref FVector Location);
	public  FVector ConstrainLocationToPlane(FVector Location)
	{
		CheckIsValid();
		FVector ___ret = ConstrainLocationToPlane(_this.Get(),ref Location);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ConstrainDirectionToPlane(IntPtr _this,ref FVector Direction);
	public  FVector ConstrainDirectionToPlane(FVector Direction)
	{
		CheckIsValid();
		FVector ___ret = ConstrainDirectionToPlane(_this.Get(),ref Direction);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetPlaneConstraintOrigin(IntPtr _this);
	public  FVector GetPlaneConstraintOrigin()
	{
		CheckIsValid();
		FVector ___ret = GetPlaneConstraintOrigin(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetPlaneConstraintNormal(IntPtr _this);
	public  FVector GetPlaneConstraintNormal()
	{
		CheckIsValid();
		FVector ___ret = GetPlaneConstraintNormal(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaneConstraintEnabled(IntPtr _this,int bEnabled);
	public  void SetPlaneConstraintEnabled(bool bEnabled)
	{
		CheckIsValid();
		SetPlaneConstraintEnabled(_this.Get(),bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaneConstraintOrigin(IntPtr _this,ref FVector PlaneOrigin);
	public  void SetPlaneConstraintOrigin(FVector PlaneOrigin)
	{
		CheckIsValid();
		SetPlaneConstraintOrigin(_this.Get(),ref PlaneOrigin);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaneConstraintFromVectors(IntPtr _this,ref FVector Forward,ref FVector Up);
	public  void SetPlaneConstraintFromVectors(FVector Forward,FVector Up)
	{
		CheckIsValid();
		SetPlaneConstraintFromVectors(_this.Get(),ref Forward,ref Up);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaneConstraintNormal(IntPtr _this,ref FVector PlaneNormal);
	public  void SetPlaneConstraintNormal(FVector PlaneNormal)
	{
		CheckIsValid();
		SetPlaneConstraintNormal(_this.Get(),ref PlaneNormal);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_MoveUpdatedComponent(IntPtr _this,ref FVector Delta,ref FRotator NewRotation,out FHitResult OutHit,int bSweep,int bTeleport);
	public  bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,out FHitResult OutHit,bool bSweep=true,bool bTeleport=false)
	{
		CheckIsValid();
		int ___ret = K2_MoveUpdatedComponent(_this.Get(),ref Delta,ref NewRotation,out OutHit,bSweep?1:0,bTeleport?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUpdatedComponent(IntPtr _this,IntPtr NewUpdatedComponent);
	public  void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
	{
		CheckIsValid();
		SetUpdatedComponent(_this.Get(),NewUpdatedComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PhysicsVolumeChanged(IntPtr _this,IntPtr NewVolume);
	public  void PhysicsVolumeChanged(APhysicsVolume NewVolume)
	{
		CheckIsValid();
		PhysicsVolumeChanged(_this.Get(),NewVolume);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPhysicsVolume(IntPtr _this);
	public  APhysicsVolume GetPhysicsVolume()
	{
		CheckIsValid();
		IntPtr ___ret = GetPhysicsVolume(_this.Get());
		if(___ret==IntPtr.Zero) return null; APhysicsVolume ___ret2= new APhysicsVolume(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StopMovementImmediately(IntPtr _this);
	public  void StopMovementImmediately()
	{
		CheckIsValid();
		StopMovementImmediately(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsExceedingMaxSpeed(IntPtr _this,float MaxSpeed);
	public  bool IsExceedingMaxSpeed(float MaxSpeed)
	{
		CheckIsValid();
		int ___ret = IsExceedingMaxSpeed(_this.Get(),MaxSpeed);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetModifiedMaxSpeed(IntPtr _this);
	public  float K2_GetModifiedMaxSpeed()
	{
		CheckIsValid();
		float ___ret = K2_GetModifiedMaxSpeed(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxSpeed(IntPtr _this);
	public  float GetMaxSpeed()
	{
		CheckIsValid();
		float ___ret = GetMaxSpeed(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetGravityZ(IntPtr _this);
	public  float GetGravityZ()
	{
		CheckIsValid();
		float ___ret = GetGravityZ(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
