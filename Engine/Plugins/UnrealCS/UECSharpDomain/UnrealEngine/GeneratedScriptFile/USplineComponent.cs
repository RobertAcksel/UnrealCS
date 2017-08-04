//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USplineComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform FindTransformClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace,int bUseScale);
	public  FTransform FindTransformClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
	{
		CheckIsValid();
		FTransform ___ret = FindTransformClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace,bUseScale?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindScaleClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation);
	public  FVector FindScaleClosestToWorldLocation(FVector WorldLocation)
	{
		CheckIsValid();
		FVector ___ret = FindScaleClosestToWorldLocation(_this.Get(),ref WorldLocation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FindRollClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  float FindRollClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		float ___ret = FindRollClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindRightVectorClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = FindRightVectorClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindUpVectorClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = FindUpVectorClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator FindRotationClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FRotator FindRotationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FRotator ___ret = FindRotationClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindTangentClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FVector FindTangentClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = FindTangentClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindDirectionClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FVector FindDirectionClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = FindDirectionClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindLocationClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation,int CoordinateSpace);
	public  FVector FindLocationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = FindLocationClosestToWorldLocation(_this.Get(),ref WorldLocation,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FindInputKeyClosestToWorldLocation(IntPtr _this,ref FVector WorldLocation);
	public  float FindInputKeyClosestToWorldLocation(FVector WorldLocation)
	{
		CheckIsValid();
		float ___ret = FindInputKeyClosestToWorldLocation(_this.Get(),ref WorldLocation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetScaleAtTime(IntPtr _this,float Time,int bUseConstantVelocity);
	public  FVector GetScaleAtTime(float Time,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetScaleAtTime(_this.Get(),Time,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRollAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  float GetRollAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		float ___ret = GetRollAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform GetTransformAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity,int bUseScale);
	public  FTransform GetTransformAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false,bool bUseScale=false)
	{
		CheckIsValid();
		FTransform ___ret = GetTransformAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0,bUseScale?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetRightVectorAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FVector GetRightVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetRightVectorAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetUpVectorAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FVector GetUpVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetUpVectorAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator GetRotationAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FRotator GetRotationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FRotator ___ret = GetRotationAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetTangentAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FVector GetTangentAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetTangentAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetDirectionAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FVector GetDirectionAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetDirectionAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetLocationAtTime(IntPtr _this,float Time,int CoordinateSpace,int bUseConstantVelocity);
	public  FVector GetLocationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity=false)
	{
		CheckIsValid();
		FVector ___ret = GetLocationAtTime(_this.Get(),Time,(int)CoordinateSpace,bUseConstantVelocity?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform GetTransformAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace,int bUseScale);
	public  FTransform GetTransformAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
	{
		CheckIsValid();
		FTransform ___ret = GetTransformAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace,bUseScale?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetScaleAtDistanceAlongSpline(IntPtr _this,float Distance);
	public  FVector GetScaleAtDistanceAlongSpline(float Distance)
	{
		CheckIsValid();
		FVector ___ret = GetScaleAtDistanceAlongSpline(_this.Get(),Distance);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRollAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  float GetRollAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		float ___ret = GetRollAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetRightVectorAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FVector GetRightVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetRightVectorAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetUpVectorAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FVector GetUpVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetUpVectorAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator GetRotationAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FRotator GetRotationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FRotator ___ret = GetRotationAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetTangentAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FVector GetTangentAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetTangentAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetDirectionAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FVector GetDirectionAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetDirectionAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetLocationAtDistanceAlongSpline(IntPtr _this,float Distance,int CoordinateSpace);
	public  FVector GetLocationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetLocationAtDistanceAlongSpline(_this.Get(),Distance,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInputKeyAtDistanceAlongSpline(IntPtr _this,float Distance);
	public  float GetInputKeyAtDistanceAlongSpline(float Distance)
	{
		CheckIsValid();
		float ___ret = GetInputKeyAtDistanceAlongSpline(_this.Get(),Distance);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetDefaultUpVector(IntPtr _this,int CoordinateSpace);
	public  FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetDefaultUpVector(_this.Get(),(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDefaultUpVector(IntPtr _this,ref FVector UpVector,int CoordinateSpace);
	public  void SetDefaultUpVector(FVector UpVector,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		SetDefaultUpVector(_this.Get(),ref UpVector,(int)CoordinateSpace);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetSplineLength(IntPtr _this);
	public  float GetSplineLength()
	{
		CheckIsValid();
		float ___ret = GetSplineLength(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetDistanceAlongSplineAtSplinePoint(IntPtr _this,int PointIndex);
	public  float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
	{
		CheckIsValid();
		float ___ret = GetDistanceAlongSplineAtSplinePoint(_this.Get(),PointIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetLocationAndTangentAtSplinePoint(IntPtr _this,int PointIndex,out FVector Location,out FVector Tangent,int CoordinateSpace);
	public  void GetLocationAndTangentAtSplinePoint(int PointIndex,out FVector Location,out FVector Tangent,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		GetLocationAndTangentAtSplinePoint(_this.Get(),PointIndex,out Location,out Tangent,(int)CoordinateSpace);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform GetTransformAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace,int bUseScale);
	public  FTransform GetTransformAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace,bool bUseScale=false)
	{
		CheckIsValid();
		FTransform ___ret = GetTransformAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace,bUseScale?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetScaleAtSplinePoint(IntPtr _this,int PointIndex);
	public  FVector GetScaleAtSplinePoint(int PointIndex)
	{
		CheckIsValid();
		FVector ___ret = GetScaleAtSplinePoint(_this.Get(),PointIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRollAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  float GetRollAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		float ___ret = GetRollAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetRightVectorAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetRightVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetRightVectorAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetUpVectorAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetUpVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetUpVectorAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator GetRotationAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FRotator GetRotationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FRotator ___ret = GetRotationAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetLeaveTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetLeaveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetLeaveTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetArriveTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetArriveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetArriveTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetTangentAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetTangentAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetDirectionAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetDirectionAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetDirectionAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetLocationAtSplinePoint(IntPtr _this,int PointIndex,int CoordinateSpace);
	public  FVector GetLocationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace)
	{
		CheckIsValid();
		FVector ___ret = GetLocationAtSplinePoint(_this.Get(),PointIndex,(int)CoordinateSpace);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumberOfSplinePoints(IntPtr _this);
	public  int GetNumberOfSplinePoints()
	{
		CheckIsValid();
		int ___ret = GetNumberOfSplinePoints(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSplinePointType(IntPtr _this,int PointIndex,int Type,int bUpdateSpline);
	public  void SetSplinePointType(int PointIndex,ESplinePointType Type,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetSplinePointType(_this.Get(),PointIndex,(int)Type,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetSplinePointType(IntPtr _this,int PointIndex);
	public  ESplinePointType GetSplinePointType(int PointIndex)
	{
		CheckIsValid();
		int ___ret = GetSplinePointType(_this.Get(),PointIndex);
		return (ESplinePointType)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUpVectorAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InUpVector,int CoordinateSpace,int bUpdateSpline);
	public  void SetUpVectorAtSplinePoint(int PointIndex,FVector InUpVector,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetUpVectorAtSplinePoint(_this.Get(),PointIndex,ref InUpVector,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTangentsAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InArriveTangent,ref FVector InLeaveTangent,int CoordinateSpace,int bUpdateSpline);
	public  void SetTangentsAtSplinePoint(int PointIndex,FVector InArriveTangent,FVector InLeaveTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetTangentsAtSplinePoint(_this.Get(),PointIndex,ref InArriveTangent,ref InLeaveTangent,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTangentAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InTangent,int CoordinateSpace,int bUpdateSpline);
	public  void SetTangentAtSplinePoint(int PointIndex,FVector InTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetTangentAtSplinePoint(_this.Get(),PointIndex,ref InTangent,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLocationAtSplinePoint(IntPtr _this,int PointIndex,ref FVector InLocation,int CoordinateSpace,int bUpdateSpline);
	public  void SetLocationAtSplinePoint(int PointIndex,FVector InLocation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetLocationAtSplinePoint(_this.Get(),PointIndex,ref InLocation,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSplinePoints(IntPtr _this,FVector[] Points,int CoordinateSpace,int bUpdateSpline);
	public  void SetSplinePoints(FVector[] Points,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetSplinePoints(_this.Get(),Points,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveSplinePoint(IntPtr _this,int Index,int bUpdateSpline);
	public  void RemoveSplinePoint(int Index,bool bUpdateSpline=true)
	{
		CheckIsValid();
		RemoveSplinePoint(_this.Get(),Index,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddSplinePointAtIndex(IntPtr _this,ref FVector Position,int Index,int CoordinateSpace,int bUpdateSpline);
	public  void AddSplinePointAtIndex(FVector Position,int Index,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		AddSplinePointAtIndex(_this.Get(),ref Position,Index,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddSplinePoint(IntPtr _this,ref FVector Position,int CoordinateSpace,int bUpdateSpline);
	public  void AddSplinePoint(FVector Position,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline=true)
	{
		CheckIsValid();
		AddSplinePoint(_this.Get(),ref Position,(int)CoordinateSpace,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddPoints(IntPtr _this,FSplinePoint[] Points,int bUpdateSpline);
	public  void AddPoints(FSplinePoint[] Points,bool bUpdateSpline=true)
	{
		CheckIsValid();
		AddPoints(_this.Get(),Points,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddPoint(IntPtr _this,ref FSplinePoint Point,int bUpdateSpline);
	public  void AddPoint(FSplinePoint Point,bool bUpdateSpline=true)
	{
		CheckIsValid();
		AddPoint(_this.Get(),ref Point,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSplinePoints(IntPtr _this,int bUpdateSpline);
	public  void ClearSplinePoints(bool bUpdateSpline=true)
	{
		CheckIsValid();
		ClearSplinePoints(_this.Get(),bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsClosedLoop(IntPtr _this);
	public  bool IsClosedLoop()
	{
		CheckIsValid();
		int ___ret = IsClosedLoop(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetClosedLoopAtPosition(IntPtr _this,int bInClosedLoop,float Key,int bUpdateSpline);
	public  void SetClosedLoopAtPosition(bool bInClosedLoop,float Key,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetClosedLoopAtPosition(_this.Get(),bInClosedLoop?1:0,Key,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetClosedLoop(IntPtr _this,int bInClosedLoop,int bUpdateSpline);
	public  void SetClosedLoop(bool bInClosedLoop,bool bUpdateSpline=true)
	{
		CheckIsValid();
		SetClosedLoop(_this.Get(),bInClosedLoop?1:0,bUpdateSpline?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDrawDebug(IntPtr _this,int bShow);
	public  void SetDrawDebug(bool bShow)
	{
		CheckIsValid();
		SetDrawDebug(_this.Get(),bShow?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSelectedSplineSegmentColor(IntPtr _this,ref FLinearColor SegmentColor);
	public  void SetSelectedSplineSegmentColor(FLinearColor SegmentColor)
	{
		CheckIsValid();
		SetSelectedSplineSegmentColor(_this.Get(),ref SegmentColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUnselectedSplineSegmentColor(IntPtr _this,ref FLinearColor SegmentColor);
	public  void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor)
	{
		CheckIsValid();
		SetUnselectedSplineSegmentColor(_this.Get(),ref SegmentColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UpdateSpline(IntPtr _this);
	public  void UpdateSpline()
	{
		CheckIsValid();
		UpdateSpline(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
