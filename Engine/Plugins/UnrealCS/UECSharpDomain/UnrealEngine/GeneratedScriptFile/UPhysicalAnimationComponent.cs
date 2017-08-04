//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicalAnimationComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform GetBodyTargetTransform(IntPtr _this,string BodyName);
	public  FTransform GetBodyTargetTransform(string BodyName)
	{
		CheckIsValid();
		FTransform ___ret = GetBodyTargetTransform(_this.Get(),BodyName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyPhysicalAnimationProfileBelow(IntPtr _this,string BodyName,string ProfileName,int bIncludeSelf,int bClearNotFound);
	public  void ApplyPhysicalAnimationProfileBelow(string BodyName,string ProfileName,bool bIncludeSelf=true,bool bClearNotFound=false)
	{
		CheckIsValid();
		ApplyPhysicalAnimationProfileBelow(_this.Get(),BodyName,ProfileName,bIncludeSelf?1:0,bClearNotFound?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStrengthMultiplyer(IntPtr _this,float InStrengthMultiplyer);
	public  void SetStrengthMultiplyer(float InStrengthMultiplyer)
	{
		CheckIsValid();
		SetStrengthMultiplyer(_this.Get(),InStrengthMultiplyer);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyPhysicalAnimationSettingsBelow(IntPtr _this,string BodyName,ref FPhysicalAnimationData PhysicalAnimationData,int bIncludeSelf);
	public  void ApplyPhysicalAnimationSettingsBelow(string BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf=true)
	{
		CheckIsValid();
		ApplyPhysicalAnimationSettingsBelow(_this.Get(),BodyName,ref PhysicalAnimationData,bIncludeSelf?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyPhysicalAnimationSettings(IntPtr _this,string BodyName,ref FPhysicalAnimationData PhysicalAnimationData);
	public  void ApplyPhysicalAnimationSettings(string BodyName,FPhysicalAnimationData PhysicalAnimationData)
	{
		CheckIsValid();
		ApplyPhysicalAnimationSettings(_this.Get(),BodyName,ref PhysicalAnimationData);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSkeletalMeshComponent(IntPtr _this,IntPtr InSkeletalMeshComponent);
	public  void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
	{
		CheckIsValid();
		SetSkeletalMeshComponent(_this.Get(),InSkeletalMeshComponent);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
