//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AActor:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr[] GetComponentsByTag(IntPtr _this,IntPtr ComponentClass,string Tag);
	public  UActorComponent[] GetComponentsByTag(TSubclassOf<UActorComponent>  ComponentClass,string Tag)
	{
		CheckIsValid();
		IntPtr[] ___ret = GetComponentsByTag(_this.Get(),ComponentClass.NativeClass,Tag);
		return MarshalUtil.IntPtrArrayToObjectArray<UActorComponent>(___ret);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr[] GetComponentsByClass(IntPtr _this,IntPtr ComponentClass);
	public  UActorComponent[] GetComponentsByClass(TSubclassOf<UActorComponent>  ComponentClass)
	{
		CheckIsValid();
		IntPtr[] ___ret = GetComponentsByClass(_this.Get(),ComponentClass.NativeClass);
		return MarshalUtil.IntPtrArrayToObjectArray<UActorComponent>(___ret);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetComponentByClass(IntPtr _this,IntPtr ComponentClass);
	public  UActorComponent GetComponentByClass(TSubclassOf<UActorComponent>  ComponentClass)
	{
		CheckIsValid();
		IntPtr ___ret = GetComponentByClass(_this.Get(),ComponentClass.NativeClass);
		if(___ret==IntPtr.Zero) return null; UActorComponent ___ret2= new UActorComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetActorEyesViewPoint(IntPtr _this,out FVector OutLocation,out FRotator OutRotation);
	public  void GetActorEyesViewPoint(out FVector OutLocation,out FRotator OutRotation)
	{
		CheckIsValid();
		GetActorEyesViewPoint(_this.Get(),out OutLocation,out OutRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceNetUpdate(IntPtr _this);
	public  void ForceNetUpdate()
	{
		CheckIsValid();
		ForceNetUpdate(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int WasRecentlyRendered(IntPtr _this,float Tolerance);
	public  bool WasRecentlyRendered(float Tolerance=0.200000f)
	{
		CheckIsValid();
		int ___ret = WasRecentlyRendered(_this.Get(),Tolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTickGroup(IntPtr _this,int NewTickGroup);
	public  void SetTickGroup(ETickingGroup NewTickGroup)
	{
		CheckIsValid();
		SetTickGroup(_this.Get(),(int)NewTickGroup);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAttachedActors(IntPtr _this,out IntPtr[] OutActors);
	public  void GetAttachedActors(out AActor[] OutActors)
	{
		CheckIsValid();
		IntPtr[] OutActors_temp;
		GetAttachedActors(_this.Get(),out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetAttachParentSocketName(IntPtr _this);
	public  string GetAttachParentSocketName()
	{
		CheckIsValid();
		string ___ret = GetAttachParentSocketName(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetAttachParentActor(IntPtr _this);
	public  AActor GetAttachParentActor()
	{
		CheckIsValid();
		IntPtr ___ret = GetAttachParentActor(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_TeleportTo(IntPtr _this,ref FVector DestLocation,ref FRotator DestRotation);
	public  bool K2_TeleportTo(FVector DestLocation,FRotator DestRotation)
	{
		CheckIsValid();
		int ___ret = K2_TeleportTo(_this.Get(),ref DestLocation,ref DestRotation);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetParentActor(IntPtr _this);
	public  AActor GetParentActor()
	{
		CheckIsValid();
		IntPtr ___ret = GetParentActor(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetParentComponent(IntPtr _this);
	public  UChildActorComponent GetParentComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetParentComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UChildActorComponent ___ret2= new UChildActorComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAllChildActors(IntPtr _this,out IntPtr[] ChildActors,int bIncludeDescendants);
	public  void GetAllChildActors(out AActor[] ChildActors,bool bIncludeDescendants=true)
	{
		CheckIsValid();
		IntPtr[] ChildActors_temp;
		GetAllChildActors(_this.Get(),out ChildActors_temp,bIncludeDescendants?1:0);
		ChildActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(ChildActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsChildActor(IntPtr _this);
	public  bool IsChildActor()
	{
		CheckIsValid();
		int ___ret = IsChildActor(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FlushNetDormancy(IntPtr _this);
	public  void FlushNetDormancy()
	{
		CheckIsValid();
		FlushNetDormancy(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsOverlappingActor(IntPtr _this,IntPtr Other);
	public  bool IsOverlappingActor(AActor Other)
	{
		CheckIsValid();
		int ___ret = IsOverlappingActor(_this.Get(),Other);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwner(IntPtr _this);
	public  AActor GetOwner()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwner(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOwner(IntPtr _this,IntPtr NewOwner);
	public  void SetOwner(AActor NewOwner)
	{
		CheckIsValid();
		SetOwner(_this.Get(),NewOwner);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_ReplicatedMovement(IntPtr _this);
	public  void OnRep_ReplicatedMovement()
	{
		CheckIsValid();
		OnRep_ReplicatedMovement(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetActorTickInterval(IntPtr _this);
	public  float GetActorTickInterval()
	{
		CheckIsValid();
		float ___ret = GetActorTickInterval(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorTickInterval(IntPtr _this,float TickInterval);
	public  void SetActorTickInterval(float TickInterval)
	{
		CheckIsValid();
		SetActorTickInterval(_this.Get(),TickInterval);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsActorTickEnabled(IntPtr _this);
	public  bool IsActorTickEnabled()
	{
		CheckIsValid();
		int ___ret = IsActorTickEnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorTickEnabled(IntPtr _this,int bEnabled);
	public  void SetActorTickEnabled(bool bEnabled)
	{
		CheckIsValid();
		SetActorTickEnabled(_this.Get(),bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetLifeSpan(IntPtr _this);
	public  float GetLifeSpan()
	{
		CheckIsValid();
		float ___ret = GetLifeSpan(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLifeSpan(IntPtr _this,float InLifespan);
	public  void SetLifeSpan(float InLifespan)
	{
		CheckIsValid();
		SetLifeSpan(_this.Get(),InLifespan);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetOverlappingComponents(IntPtr _this,out IntPtr[] OverlappingComponents);
	public  void GetOverlappingComponents(out UPrimitiveComponent[] OverlappingComponents)
	{
		CheckIsValid();
		IntPtr[] OverlappingComponents_temp;
		GetOverlappingComponents(_this.Get(),out OverlappingComponents_temp);
		OverlappingComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OverlappingComponents_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetOverlappingActors(IntPtr _this,out IntPtr[] OverlappingActors,IntPtr ClassFilter);
	public  void GetOverlappingActors(out AActor[] OverlappingActors,TSubclassOf<AActor>  ClassFilter)
	{
		CheckIsValid();
		IntPtr[] OverlappingActors_temp;
		GetOverlappingActors(_this.Get(),out OverlappingActors_temp,ClassFilter.NativeClass);
		OverlappingActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OverlappingActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsActorBeingDestroyed(IntPtr _this);
	public  bool IsActorBeingDestroyed()
	{
		CheckIsValid();
		int ___ret = IsActorBeingDestroyed(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MakeNoise(IntPtr _this,float Loudness,IntPtr NoiseInstigator,ref FVector NoiseLocation,float MaxRange,string Tag);
	public  void MakeNoise(float Loudness=1.000000f,APawn NoiseInstigator=default(APawn),FVector NoiseLocation=default(FVector),float MaxRange=0.000000f,string Tag="None")
	{
		CheckIsValid();
		MakeNoise(_this.Get(),Loudness,NoiseInstigator,ref NoiseLocation,MaxRange,Tag);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetGameTimeSinceCreation(IntPtr _this);
	public  float GetGameTimeSinceCreation()
	{
		CheckIsValid();
		float ___ret = GetGameTimeSinceCreation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTickableWhenPaused(IntPtr _this,int bTickableWhenPaused);
	public  void SetTickableWhenPaused(bool bTickableWhenPaused)
	{
		CheckIsValid();
		SetTickableWhenPaused(_this.Get(),bTickableWhenPaused?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetTickableWhenPaused(IntPtr _this);
	public  bool GetTickableWhenPaused()
	{
		CheckIsValid();
		int ___ret = GetTickableWhenPaused(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
	public  void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckIsValid();
		RemoveTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
	public  void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckIsValid();
		RemoveTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
	public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckIsValid();
		AddTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
	public  void AddTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckIsValid();
		AddTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetActorTimeDilation(IntPtr _this);
	public  float GetActorTimeDilation()
	{
		CheckIsValid();
		float ___ret = GetActorTimeDilation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ActorHasTag(IntPtr _this,string Tag);
	public  bool ActorHasTag(string Tag)
	{
		CheckIsValid();
		int ___ret = ActorHasTag(_this.Get(),Tag);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DetachRootComponentFromParent(IntPtr _this,int bMaintainWorldPosition);
	public  void DetachRootComponentFromParent(bool bMaintainWorldPosition=true)
	{
		CheckIsValid();
		DetachRootComponentFromParent(_this.Get(),bMaintainWorldPosition?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AttachRootComponentToActor(IntPtr _this,IntPtr InParentActor,string InSocketName,int AttachLocationType,int bWeldSimulatedBodies);
	public  void K2_AttachRootComponentToActor(AActor InParentActor,string InSocketName="None",EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
	{
		CheckIsValid();
		K2_AttachRootComponentToActor(_this.Get(),InParentActor,InSocketName,(int)AttachLocationType,bWeldSimulatedBodies?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AttachRootComponentTo(IntPtr _this,IntPtr InParent,string InSocketName,int AttachLocationType,int bWeldSimulatedBodies);
	public  void K2_AttachRootComponentTo(USceneComponent InParent,string InSocketName="None",EAttachLocation AttachLocationType=EAttachLocation.KeepRelativeOffset,bool bWeldSimulatedBodies=true)
	{
		CheckIsValid();
		K2_AttachRootComponentTo(_this.Get(),InParent,InSocketName,(int)AttachLocationType,bWeldSimulatedBodies?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr AddComponent(IntPtr _this,string TemplateName,int bManualAttachment,ref FTransform RelativeTransform,IntPtr ComponentTemplateContext);
	public  UActorComponent AddComponent(string TemplateName,bool bManualAttachment,FTransform RelativeTransform,UObject ComponentTemplateContext)
	{
		CheckIsValid();
		IntPtr ___ret = AddComponent(_this.Get(),TemplateName,bManualAttachment?1:0,ref RelativeTransform,ComponentTemplateContext);
		if(___ret==IntPtr.Zero) return null; UActorComponent ___ret2= new UActorComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasAuthority(IntPtr _this);
	public  bool HasAuthority()
	{
		CheckIsValid();
		int ___ret = HasAuthority(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_DestroyActor(IntPtr _this);
	public  void K2_DestroyActor()
	{
		CheckIsValid();
		K2_DestroyActor(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetActorEnableCollision(IntPtr _this);
	public  bool GetActorEnableCollision()
	{
		CheckIsValid();
		int ___ret = GetActorEnableCollision(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorEnableCollision(IntPtr _this,int bNewActorEnableCollision);
	public  void SetActorEnableCollision(bool bNewActorEnableCollision)
	{
		CheckIsValid();
		SetActorEnableCollision(_this.Get(),bNewActorEnableCollision?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorHiddenInGame(IntPtr _this,int bNewHidden);
	public  void SetActorHiddenInGame(bool bNewHidden)
	{
		CheckIsValid();
		SetActorHiddenInGame(_this.Get(),bNewHidden?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorRelativeScale3D(IntPtr _this);
	public  FVector GetActorRelativeScale3D()
	{
		CheckIsValid();
		FVector ___ret = GetActorRelativeScale3D(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorRelativeScale3D(IntPtr _this,ref FVector NewRelativeScale);
	public  void SetActorRelativeScale3D(FVector NewRelativeScale)
	{
		CheckIsValid();
		SetActorRelativeScale3D(_this.Get(),ref NewRelativeScale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_SetActorRelativeTransform(IntPtr _this,ref FTransform NewRelativeTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_SetActorRelativeTransform(FTransform NewRelativeTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_SetActorRelativeTransform(_this.Get(),ref NewRelativeTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_SetActorRelativeRotation(IntPtr _this,ref FRotator NewRelativeRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_SetActorRelativeRotation(FRotator NewRelativeRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_SetActorRelativeRotation(_this.Get(),ref NewRelativeRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_SetActorRelativeLocation(IntPtr _this,ref FVector NewRelativeLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_SetActorRelativeLocation(FVector NewRelativeLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_SetActorRelativeLocation(_this.Get(),ref NewRelativeLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorLocalTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorLocalTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorLocalTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorLocalRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorLocalRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorLocalRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorLocalOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorLocalOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorLocalOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_SetActorTransform(IntPtr _this,ref FTransform NewTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  bool K2_SetActorTransform(FTransform NewTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		int ___ret = K2_SetActorTransform(_this.Get(),ref NewTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorWorldTransform(IntPtr _this,ref FTransform DeltaTransform,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorWorldTransform(FTransform DeltaTransform,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorWorldTransform(_this.Get(),ref DeltaTransform,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorWorldRotation(IntPtr _this,ref FRotator DeltaRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorWorldRotation(FRotator DeltaRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorWorldRotation(_this.Get(),ref DeltaRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_AddActorWorldOffset(IntPtr _this,ref FVector DeltaLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  void K2_AddActorWorldOffset(FVector DeltaLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		K2_AddActorWorldOffset(_this.Get(),ref DeltaLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetHorizontalDotProductTo(IntPtr _this,IntPtr OtherActor);
	public  float GetHorizontalDotProductTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetHorizontalDotProductTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetDotProductTo(IntPtr _this,IntPtr OtherActor);
	public  float GetDotProductTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetDotProductTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetVerticalDistanceTo(IntPtr _this,IntPtr OtherActor);
	public  float GetVerticalDistanceTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetVerticalDistanceTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetHorizontalDistanceTo(IntPtr _this,IntPtr OtherActor);
	public  float GetHorizontalDistanceTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetHorizontalDistanceTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetSquaredDistanceTo(IntPtr _this,IntPtr OtherActor);
	public  float GetSquaredDistanceTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetSquaredDistanceTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetDistanceTo(IntPtr _this,IntPtr OtherActor);
	public  float GetDistanceTo(AActor OtherActor)
	{
		CheckIsValid();
		float ___ret = GetDistanceTo(_this.Get(),OtherActor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorScale3D(IntPtr _this);
	public  FVector GetActorScale3D()
	{
		CheckIsValid();
		FVector ___ret = GetActorScale3D(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActorScale3D(IntPtr _this,ref FVector NewScale3D);
	public  void SetActorScale3D(FVector NewScale3D)
	{
		CheckIsValid();
		SetActorScale3D(_this.Get(),ref NewScale3D);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_SetActorLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  bool K2_SetActorLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		int ___ret = K2_SetActorLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_SetActorRotation(IntPtr _this,ref FRotator NewRotation,int bTeleportPhysics);
	public  bool K2_SetActorRotation(FRotator NewRotation,bool bTeleportPhysics)
	{
		CheckIsValid();
		int ___ret = K2_SetActorRotation(_this.Get(),ref NewRotation,bTeleportPhysics?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetVelocity(IntPtr _this);
	public  FVector GetVelocity()
	{
		CheckIsValid();
		FVector ___ret = GetVelocity(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr K2_GetRootComponent(IntPtr _this);
	public  USceneComponent K2_GetRootComponent()
	{
		CheckIsValid();
		IntPtr ___ret = K2_GetRootComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; USceneComponent ___ret2= new USceneComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetActorBounds(IntPtr _this,int bOnlyCollidingComponents,out FVector Origin,out FVector BoxExtent);
	public  void GetActorBounds(bool bOnlyCollidingComponents,out FVector Origin,out FVector BoxExtent)
	{
		CheckIsValid();
		GetActorBounds(_this.Get(),bOnlyCollidingComponents?1:0,out Origin,out BoxExtent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorRightVector(IntPtr _this);
	public  FVector GetActorRightVector()
	{
		CheckIsValid();
		FVector ___ret = GetActorRightVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorUpVector(IntPtr _this);
	public  FVector GetActorUpVector()
	{
		CheckIsValid();
		FVector ___ret = GetActorUpVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorForwardVector(IntPtr _this);
	public  FVector GetActorForwardVector()
	{
		CheckIsValid();
		FVector ___ret = GetActorForwardVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator K2_GetActorRotation(IntPtr _this);
	public  FRotator K2_GetActorRotation()
	{
		CheckIsValid();
		FRotator ___ret = K2_GetActorRotation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_SetActorLocation(IntPtr _this,ref FVector NewLocation,int bSweep,out FHitResult SweepHitResult,int bTeleport);
	public  bool K2_SetActorLocation(FVector NewLocation,bool bSweep,out FHitResult SweepHitResult,bool bTeleport)
	{
		CheckIsValid();
		int ___ret = K2_SetActorLocation(_this.Get(),ref NewLocation,bSweep?1:0,out SweepHitResult,bTeleport?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector K2_GetActorLocation(IntPtr _this);
	public  FVector K2_GetActorLocation()
	{
		CheckIsValid();
		FVector ___ret = K2_GetActorLocation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform GetTransform(IntPtr _this);
	public  FTransform GetTransform()
	{
		CheckIsValid();
		FTransform ___ret = GetTransform(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetInstigatorController(IntPtr _this);
	public  AController GetInstigatorController()
	{
		CheckIsValid();
		IntPtr ___ret = GetInstigatorController(_this.Get());
		if(___ret==IntPtr.Zero) return null; AController ___ret2= new AController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetInstigator(IntPtr _this);
	public  APawn GetInstigator()
	{
		CheckIsValid();
		IntPtr ___ret = GetInstigator(_this.Get());
		if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetInputVectorAxisValue(IntPtr _this,ref FKey InputAxisKey);
	public  FVector GetInputVectorAxisValue(FKey InputAxisKey)
	{
		CheckIsValid();
		FVector ___ret = GetInputVectorAxisValue(_this.Get(),ref InputAxisKey);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInputAxisKeyValue(IntPtr _this,ref FKey InputAxisKey);
	public  float GetInputAxisKeyValue(FKey InputAxisKey)
	{
		CheckIsValid();
		float ___ret = GetInputAxisKeyValue(_this.Get(),ref InputAxisKey);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInputAxisValue(IntPtr _this,string InputAxisName);
	public  float GetInputAxisValue(string InputAxisName)
	{
		CheckIsValid();
		float ___ret = GetInputAxisValue(_this.Get(),InputAxisName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DisableInput(IntPtr _this,IntPtr PlayerController);
	public  void DisableInput(APlayerController PlayerController)
	{
		CheckIsValid();
		DisableInput(_this.Get(),PlayerController);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EnableInput(IntPtr _this,IntPtr PlayerController);
	public  void EnableInput(APlayerController PlayerController)
	{
		CheckIsValid();
		EnableInput(_this.Get(),PlayerController);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_Instigator(IntPtr _this);
	public  void OnRep_Instigator()
	{
		CheckIsValid();
		OnRep_Instigator(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_AttachmentReplication(IntPtr _this);
	public  void OnRep_AttachmentReplication()
	{
		CheckIsValid();
		OnRep_AttachmentReplication(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetRemoteRole(IntPtr _this);
	public  ENetRole GetRemoteRole()
	{
		CheckIsValid();
		int ___ret = GetRemoteRole(_this.Get());
		return (ENetRole)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetReplicateMovement(IntPtr _this,int bInReplicateMovement);
	public  void SetReplicateMovement(bool bInReplicateMovement)
	{
		CheckIsValid();
		SetReplicateMovement(_this.Get(),bInReplicateMovement?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetReplicates(IntPtr _this,int bInReplicates);
	public  void SetReplicates(bool bInReplicates)
	{
		CheckIsValid();
		SetReplicates(_this.Get(),bInReplicates?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void TearOff(IntPtr _this);
	public  void TearOff()
	{
		CheckIsValid();
		TearOff(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_ReplicateMovement(IntPtr _this);
	public  void OnRep_ReplicateMovement()
	{
		CheckIsValid();
		OnRep_ReplicateMovement(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
