//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USplineMeshComponent:UStaticMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBoundaryMax(IntPtr _this,float InBoundaryMax,int bUpdateMesh);
	public  void SetBoundaryMax(float InBoundaryMax,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetBoundaryMax(_this.Get(),InBoundaryMax,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetBoundaryMax(IntPtr _this);
	public  float GetBoundaryMax()
	{
		CheckIsValid();
		float ___ret = GetBoundaryMax(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBoundaryMin(IntPtr _this,float InBoundaryMin,int bUpdateMesh);
	public  void SetBoundaryMin(float InBoundaryMin,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetBoundaryMin(_this.Get(),InBoundaryMin,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetBoundaryMin(IntPtr _this);
	public  float GetBoundaryMin()
	{
		CheckIsValid();
		float ___ret = GetBoundaryMin(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSplineUpDir(IntPtr _this,ref FVector InSplineUpDir,int bUpdateMesh);
	public  void SetSplineUpDir(FVector InSplineUpDir,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetSplineUpDir(_this.Get(),ref InSplineUpDir,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetSplineUpDir(IntPtr _this);
	public  FVector GetSplineUpDir()
	{
		CheckIsValid();
		FVector ___ret = GetSplineUpDir(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetForwardAxis(IntPtr _this,int InForwardAxis,int bUpdateMesh);
	public  void SetForwardAxis(ESplineMeshAxis InForwardAxis,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetForwardAxis(_this.Get(),(int)InForwardAxis,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetForwardAxis(IntPtr _this);
	public  ESplineMeshAxis GetForwardAxis()
	{
		CheckIsValid();
		int ___ret = GetForwardAxis(_this.Get());
		return (ESplineMeshAxis)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEndOffset(IntPtr _this,ref FVector2D EndOffset,int bUpdateMesh);
	public  void SetEndOffset(FVector2D EndOffset,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetEndOffset(_this.Get(),ref EndOffset,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetEndOffset(IntPtr _this);
	public  FVector2D GetEndOffset()
	{
		CheckIsValid();
		FVector2D ___ret = GetEndOffset(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEndRoll(IntPtr _this,float EndRoll,int bUpdateMesh);
	public  void SetEndRoll(float EndRoll,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetEndRoll(_this.Get(),EndRoll,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetEndRoll(IntPtr _this);
	public  float GetEndRoll()
	{
		CheckIsValid();
		float ___ret = GetEndRoll(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEndScale(IntPtr _this,ref FVector2D EndScale,int bUpdateMesh);
	public  void SetEndScale(FVector2D EndScale=default(FVector2D),bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetEndScale(_this.Get(),ref EndScale,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetEndScale(IntPtr _this);
	public  FVector2D GetEndScale()
	{
		CheckIsValid();
		FVector2D ___ret = GetEndScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartOffset(IntPtr _this,ref FVector2D StartOffset,int bUpdateMesh);
	public  void SetStartOffset(FVector2D StartOffset,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartOffset(_this.Get(),ref StartOffset,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetStartOffset(IntPtr _this);
	public  FVector2D GetStartOffset()
	{
		CheckIsValid();
		FVector2D ___ret = GetStartOffset(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartRoll(IntPtr _this,float StartRoll,int bUpdateMesh);
	public  void SetStartRoll(float StartRoll,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartRoll(_this.Get(),StartRoll,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetStartRoll(IntPtr _this);
	public  float GetStartRoll()
	{
		CheckIsValid();
		float ___ret = GetStartRoll(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartScale(IntPtr _this,ref FVector2D StartScale,int bUpdateMesh);
	public  void SetStartScale(FVector2D StartScale=default(FVector2D),bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartScale(_this.Get(),ref StartScale,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetStartScale(IntPtr _this);
	public  FVector2D GetStartScale()
	{
		CheckIsValid();
		FVector2D ___ret = GetStartScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartAndEnd(IntPtr _this,ref FVector StartPos,ref FVector StartTangent,ref FVector EndPos,ref FVector EndTangent,int bUpdateMesh);
	public  void SetStartAndEnd(FVector StartPos,FVector StartTangent,FVector EndPos,FVector EndTangent,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartAndEnd(_this.Get(),ref StartPos,ref StartTangent,ref EndPos,ref EndTangent,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEndTangent(IntPtr _this,ref FVector EndTangent,int bUpdateMesh);
	public  void SetEndTangent(FVector EndTangent,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetEndTangent(_this.Get(),ref EndTangent,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetEndTangent(IntPtr _this);
	public  FVector GetEndTangent()
	{
		CheckIsValid();
		FVector ___ret = GetEndTangent(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEndPosition(IntPtr _this,ref FVector EndPos,int bUpdateMesh);
	public  void SetEndPosition(FVector EndPos,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetEndPosition(_this.Get(),ref EndPos,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetEndPosition(IntPtr _this);
	public  FVector GetEndPosition()
	{
		CheckIsValid();
		FVector ___ret = GetEndPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartTangent(IntPtr _this,ref FVector StartTangent,int bUpdateMesh);
	public  void SetStartTangent(FVector StartTangent,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartTangent(_this.Get(),ref StartTangent,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetStartTangent(IntPtr _this);
	public  FVector GetStartTangent()
	{
		CheckIsValid();
		FVector ___ret = GetStartTangent(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStartPosition(IntPtr _this,ref FVector StartPos,int bUpdateMesh);
	public  void SetStartPosition(FVector StartPos,bool bUpdateMesh=true)
	{
		CheckIsValid();
		SetStartPosition(_this.Get(),ref StartPos,bUpdateMesh?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetStartPosition(IntPtr _this);
	public  FVector GetStartPosition()
	{
		CheckIsValid();
		FVector ___ret = GetStartPosition(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UpdateMesh(IntPtr _this);
	public  void UpdateMesh()
	{
		CheckIsValid();
		UpdateMesh(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}