//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkinnedMeshComponent:UMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsBoneHiddenByName(IntPtr _this,string BoneName);
	public  bool IsBoneHiddenByName(string BoneName)
	{
		CheckIsValid();
		int ___ret = IsBoneHiddenByName(_this.Get(),BoneName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UnHideBoneByName(IntPtr _this,string BoneName);
	public  void UnHideBoneByName(string BoneName)
	{
		CheckIsValid();
		UnHideBoneByName(_this.Get(),BoneName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void HideBoneByName(IntPtr _this,string BoneName,int PhysBodyOption);
	public  void HideBoneByName(string BoneName,EPhysBodyOp PhysBodyOption)
	{
		CheckIsValid();
		HideBoneByName(_this.Get(),BoneName,(int)PhysBodyOption);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string FindClosestBone_K2(IntPtr _this,ref FVector TestLocation,out FVector BoneLocation,float IgnoreScale,int bRequirePhysicsAsset);
	public  string FindClosestBone_K2(FVector TestLocation,out FVector BoneLocation,float IgnoreScale=0.000000f,bool bRequirePhysicsAsset=false)
	{
		CheckIsValid();
		string ___ret = FindClosestBone_K2(_this.Get(),ref TestLocation,out BoneLocation,IgnoreScale,bRequirePhysicsAsset?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void TransformFromBoneSpace(IntPtr _this,string BoneName,ref FVector InPosition,ref FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
	public  void TransformFromBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation)
	{
		CheckIsValid();
		TransformFromBoneSpace(_this.Get(),BoneName,ref InPosition,ref InRotation,out OutPosition,out OutRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void TransformToBoneSpace(IntPtr _this,string BoneName,ref FVector InPosition,ref FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
	public  void TransformToBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation)
	{
		CheckIsValid();
		TransformToBoneSpace(_this.Get(),BoneName,ref InPosition,ref InRotation,out OutPosition,out OutRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoneIsChildOf(IntPtr _this,string BoneName,string ParentBoneName);
	public  bool BoneIsChildOf(string BoneName,string ParentBoneName)
	{
		CheckIsValid();
		int ___ret = BoneIsChildOf(_this.Get(),BoneName,ParentBoneName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMasterPoseComponent(IntPtr _this,IntPtr NewMasterBoneComponent);
	public  void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent)
	{
		CheckIsValid();
		SetMasterPoseComponent(_this.Get(),NewMasterBoneComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSkinWeightOverride(IntPtr _this,int LODIndex);
	public  void ClearSkinWeightOverride(int LODIndex)
	{
		CheckIsValid();
		ClearSkinWeightOverride(_this.Get(),LODIndex);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearVertexColorOverride(IntPtr _this,int LODIndex);
	public  void ClearVertexColorOverride(int LODIndex)
	{
		CheckIsValid();
		ClearVertexColorOverride(_this.Get(),LODIndex);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVertexColorOverride_LinearColor(IntPtr _this,int LODIndex,FLinearColor[] VertexColors);
	public  void SetVertexColorOverride_LinearColor(int LODIndex,FLinearColor[] VertexColors)
	{
		CheckIsValid();
		SetVertexColorOverride_LinearColor(_this.Get(),LODIndex,VertexColors);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetParentBone(IntPtr _this,string BoneName);
	public  string GetParentBone(string BoneName)
	{
		CheckIsValid();
		string ___ret = GetParentBone(_this.Get(),BoneName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSkeletalMesh(IntPtr _this,IntPtr NewMesh,int bReinitPose);
	public  void SetSkeletalMesh(USkeletalMesh NewMesh,bool bReinitPose=true)
	{
		CheckIsValid();
		SetSkeletalMesh(_this.Get(),NewMesh,bReinitPose?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetSocketBoneName(IntPtr _this,string InSocketName);
	public  string GetSocketBoneName(string InSocketName)
	{
		CheckIsValid();
		string ___ret = GetSocketBoneName(_this.Get(),InSocketName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetBoneName(IntPtr _this,int BoneIndex);
	public  string GetBoneName(int BoneIndex)
	{
		CheckIsValid();
		string ___ret = GetBoneName(_this.Get(),BoneIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetBoneIndex(IntPtr _this,string BoneName);
	public  int GetBoneIndex(string BoneName)
	{
		CheckIsValid();
		int ___ret = GetBoneIndex(_this.Get(),BoneName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumBones(IntPtr _this);
	public  int GetNumBones()
	{
		CheckIsValid();
		int ___ret = GetNumBones(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCapsuleIndirectShadowMinVisibility(IntPtr _this,float NewValue);
	public  void SetCapsuleIndirectShadowMinVisibility(float NewValue)
	{
		CheckIsValid();
		SetCapsuleIndirectShadowMinVisibility(_this.Get(),NewValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCastCapsuleIndirectShadow(IntPtr _this,int bNewValue);
	public  void SetCastCapsuleIndirectShadow(bool bNewValue)
	{
		CheckIsValid();
		SetCastCapsuleIndirectShadow(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCastCapsuleDirectShadow(IntPtr _this,int bNewValue);
	public  void SetCastCapsuleDirectShadow(bool bNewValue)
	{
		CheckIsValid();
		SetCastCapsuleDirectShadow(_this.Get(),bNewValue?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetForcedLOD(IntPtr _this,int InNewForcedLOD);
	public  void SetForcedLOD(int InNewForcedLOD)
	{
		CheckIsValid();
		SetForcedLOD(_this.Get(),InNewForcedLOD);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinLOD(IntPtr _this,int InNewMinLOD);
	public  void SetMinLOD(int InNewMinLOD)
	{
		CheckIsValid();
		SetMinLOD(_this.Get(),InNewMinLOD);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPhysicsAsset(IntPtr _this,IntPtr NewPhysicsAsset,int bForceReInit);
	public  void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset,bool bForceReInit=false)
	{
		CheckIsValid();
		SetPhysicsAsset(_this.Get(),NewPhysicsAsset,bForceReInit?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
