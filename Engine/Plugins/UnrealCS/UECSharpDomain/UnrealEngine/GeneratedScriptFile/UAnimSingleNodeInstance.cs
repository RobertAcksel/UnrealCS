//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAnimSingleNodeInstance:UAnimInstance 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPreviewCurveOverride(IntPtr _this,string PoseName,float Value,int bRemoveIfZero);
	
	/// <summary>Set pose value</summary>
	public  void SetPreviewCurveOverride(string PoseName,float Value,bool bRemoveIfZero)
	{
		CheckIsValid();
		SetPreviewCurveOverride(_this.Get(),PoseName,Value,bRemoveIfZero?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnimationAsset(IntPtr _this,IntPtr NewAsset,int bIsLooping,float InPlayRate);
	
	/// <summary>Set New Asset - calls InitializeAnimation, for now we need MeshComponent *</summary>
	public  void SetAnimationAsset(UAnimationAsset NewAsset,bool bIsLooping=true,float InPlayRate=1.000000f)
	{
		CheckIsValid();
		SetAnimationAsset(_this.Get(),NewAsset,bIsLooping?1:0,InPlayRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StopAnim(IntPtr _this);
	
	public  void StopAnim()
	{
		CheckIsValid();
		StopAnim(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayAnim(IntPtr _this,int bIsLooping,float InPlayRate,float InStartPosition);
	
	/// <summary>For AnimSequence specific *</summary>
	public  void PlayAnim(bool bIsLooping=false,float InPlayRate=1.000000f,float InStartPosition=0.000000f)
	{
		CheckIsValid();
		PlayAnim(_this.Get(),bIsLooping?1:0,InPlayRate,InStartPosition);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetLength(IntPtr _this);
	
	public  float GetLength()
	{
		CheckIsValid();
		float ___ret = GetLength(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaying(IntPtr _this,int bIsPlaying);
	
	public  void SetPlaying(bool bIsPlaying)
	{
		CheckIsValid();
		SetPlaying(_this.Get(),bIsPlaying?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBlendSpaceInput(IntPtr _this,ref FVector InBlendInput);
	
	public  void SetBlendSpaceInput(FVector InBlendInput)
	{
		CheckIsValid();
		SetBlendSpaceInput(_this.Get(),ref InBlendInput);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPositionWithPreviousTime(IntPtr _this,float InPosition,float InPreviousTime,int bFireNotifies);
	
	public  void SetPositionWithPreviousTime(float InPosition,float InPreviousTime,bool bFireNotifies=true)
	{
		CheckIsValid();
		SetPositionWithPreviousTime(_this.Get(),InPosition,InPreviousTime,bFireNotifies?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPosition(IntPtr _this,float InPosition,int bFireNotifies);
	
	public  void SetPosition(float InPosition,bool bFireNotifies=true)
	{
		CheckIsValid();
		SetPosition(_this.Get(),InPosition,bFireNotifies?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetReverse(IntPtr _this,int bInReverse);
	
	public  void SetReverse(bool bInReverse)
	{
		CheckIsValid();
		SetReverse(_this.Get(),bInReverse?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlayRate(IntPtr _this,float InPlayRate);
	
	public  void SetPlayRate(float InPlayRate)
	{
		CheckIsValid();
		SetPlayRate(_this.Get(),InPlayRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLooping(IntPtr _this,int bIsLooping);
	
	public  void SetLooping(bool bIsLooping)
	{
		CheckIsValid();
		SetLooping(_this.Get(),bIsLooping?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
