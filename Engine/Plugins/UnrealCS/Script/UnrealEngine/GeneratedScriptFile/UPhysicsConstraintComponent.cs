//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsConstraintComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetConstraintForce(IntPtr _this,out FVector OutLinearForce,out FVector OutAngularForce);
public  void GetConstraintForce(out FVector OutLinearForce,out FVector OutAngularForce)
{
	CheckIsValid();
	GetConstraintForce(_this.Get(),out OutLinearForce,out OutAngularForce);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDisableCollision(IntPtr _this,int bDisableCollision);
public  void SetDisableCollision(bool bDisableCollision)
{
	CheckIsValid();
	SetDisableCollision(_this.Get(),bDisableCollision?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferenceOrientation(IntPtr _this,int Frame,ref FVector PriAxis,ref FVector SecAxis);
public  void SetConstraintReferenceOrientation(EConstraintFrame Frame,FVector PriAxis,FVector SecAxis)
{
	CheckIsValid();
	SetConstraintReferenceOrientation(_this.Get(),(int)Frame,ref PriAxis,ref SecAxis);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferencePosition(IntPtr _this,int Frame,ref FVector RefPosition);
public  void SetConstraintReferencePosition(EConstraintFrame Frame,FVector RefPosition)
{
	CheckIsValid();
	SetConstraintReferencePosition(_this.Get(),(int)Frame,ref RefPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferenceFrame(IntPtr _this,int Frame,ref FTransform RefFrame);
public  void SetConstraintReferenceFrame(EConstraintFrame Frame,FTransform RefFrame)
{
	CheckIsValid();
	SetConstraintReferenceFrame(_this.Get(),(int)Frame,ref RefFrame);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentSwing2(IntPtr _this);
public  float GetCurrentSwing2()
{
	CheckIsValid();
	float ___ret = GetCurrentSwing2(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentSwing1(IntPtr _this);
public  float GetCurrentSwing1()
{
	CheckIsValid();
	float ___ret = GetCurrentSwing1(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentTwist(IntPtr _this);
public  float GetCurrentTwist()
{
	CheckIsValid();
	float ___ret = GetCurrentTwist(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularTwistLimit(IntPtr _this,int ConstraintType,float TwistLimitAngle);
public  void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType,float TwistLimitAngle)
{
	CheckIsValid();
	SetAngularTwistLimit(_this.Get(),(int)ConstraintType,TwistLimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularSwing2Limit(IntPtr _this,int MotionType,float Swing2LimitAngle);
public  void SetAngularSwing2Limit(EAngularConstraintMotion MotionType,float Swing2LimitAngle)
{
	CheckIsValid();
	SetAngularSwing2Limit(_this.Get(),(int)MotionType,Swing2LimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularSwing1Limit(IntPtr _this,int MotionType,float Swing1LimitAngle);
public  void SetAngularSwing1Limit(EAngularConstraintMotion MotionType,float Swing1LimitAngle)
{
	CheckIsValid();
	SetAngularSwing1Limit(_this.Get(),(int)MotionType,Swing1LimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearZLimit(IntPtr _this,int ConstraintType,float LimitSize);
public  void SetLinearZLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearZLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearYLimit(IntPtr _this,int ConstraintType,float LimitSize);
public  void SetLinearYLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearYLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearXLimit(IntPtr _this,int ConstraintType,float LimitSize);
public  void SetLinearXLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearXLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDriveParams(IntPtr _this,float PositionStrength,float VelocityStrength,float InForceLimit);
public  void SetAngularDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit)
{
	CheckIsValid();
	SetAngularDriveParams(_this.Get(),PositionStrength,VelocityStrength,InForceLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularVelocityTarget(IntPtr _this,ref FVector InVelTarget);
public  void SetAngularVelocityTarget(FVector InVelTarget)
{
	CheckIsValid();
	SetAngularVelocityTarget(_this.Get(),ref InVelTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularOrientationTarget(IntPtr _this,ref FRotator InPosTarget);
public  void SetAngularOrientationTarget(FRotator InPosTarget)
{
	CheckIsValid();
	SetAngularOrientationTarget(_this.Get(),ref InPosTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearDriveParams(IntPtr _this,float PositionStrength,float VelocityStrength,float InForceLimit);
public  void SetLinearDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit)
{
	CheckIsValid();
	SetLinearDriveParams(_this.Get(),PositionStrength,VelocityStrength,InForceLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearVelocityTarget(IntPtr _this,ref FVector InVelTarget);
public  void SetLinearVelocityTarget(FVector InVelTarget)
{
	CheckIsValid();
	SetLinearVelocityTarget(_this.Get(),ref InVelTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearPositionTarget(IntPtr _this,ref FVector InPosTarget);
public  void SetLinearPositionTarget(FVector InPosTarget)
{
	CheckIsValid();
	SetLinearPositionTarget(_this.Get(),ref InPosTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDriveMode(IntPtr _this,int DriveMode);
public  void SetAngularDriveMode(EAngularDriveMode DriveMode)
{
	CheckIsValid();
	SetAngularDriveMode(_this.Get(),(int)DriveMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularVelocityDriveSLERP(IntPtr _this,int bEnableSLERP);
public  void SetAngularVelocityDriveSLERP(bool bEnableSLERP)
{
	CheckIsValid();
	SetAngularVelocityDriveSLERP(_this.Get(),bEnableSLERP?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularVelocityDriveTwistAndSwing(IntPtr _this,int bEnableTwistDrive,int bEnableSwingDrive);
public  void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive)
{
	CheckIsValid();
	SetAngularVelocityDriveTwistAndSwing(_this.Get(),bEnableTwistDrive?1:0,bEnableSwingDrive?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOrientationDriveSLERP(IntPtr _this,int bEnableSLERP);
public  void SetOrientationDriveSLERP(bool bEnableSLERP)
{
	CheckIsValid();
	SetOrientationDriveSLERP(_this.Get(),bEnableSLERP?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOrientationDriveTwistAndSwing(IntPtr _this,int bEnableTwistDrive,int bEnableSwingDrive);
public  void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive)
{
	CheckIsValid();
	SetOrientationDriveTwistAndSwing(_this.Get(),bEnableTwistDrive?1:0,bEnableSwingDrive?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearVelocityDrive(IntPtr _this,int bEnableDriveX,int bEnableDriveY,int bEnableDriveZ);
public  void SetLinearVelocityDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ)
{
	CheckIsValid();
	SetLinearVelocityDrive(_this.Get(),bEnableDriveX?1:0,bEnableDriveY?1:0,bEnableDriveZ?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearPositionDrive(IntPtr _this,int bEnableDriveX,int bEnableDriveY,int bEnableDriveZ);
public  void SetLinearPositionDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ)
{
	CheckIsValid();
	SetLinearPositionDrive(_this.Get(),bEnableDriveX?1:0,bEnableDriveY?1:0,bEnableDriveZ?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakConstraint(IntPtr _this);
public  void BreakConstraint()
{
	CheckIsValid();
	BreakConstraint(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstrainedComponents(IntPtr _this,IntPtr Component1,string BoneName1,IntPtr Component2,string BoneName2);
public  void SetConstrainedComponents(UPrimitiveComponent Component1,string BoneName1,UPrimitiveComponent Component2,string BoneName2)
{
	CheckIsValid();
	SetConstrainedComponents(_this.Get(),Component1,BoneName1,Component2,BoneName2);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
