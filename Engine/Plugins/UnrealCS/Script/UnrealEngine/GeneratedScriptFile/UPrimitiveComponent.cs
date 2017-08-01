//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPrimitiveComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CanCharacterStepUp(IntPtr _this,IntPtr Pawn);
public  bool CanCharacterStepUp(APawn Pawn)
{
	CheckIsValid();
	int ___ret = CanCharacterStepUp(_this.Get(),Pawn);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCullDistance(IntPtr _this,float NewCullDistance);
public  void SetCullDistance(float NewCullDistance)
{
	CheckIsValid();
	SetCullDistance(_this.Get(),NewCullDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysMaterialOverride(IntPtr _this,IntPtr NewPhysMaterial);
public  void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
{
	CheckIsValid();
	SetPhysMaterialOverride(_this.Get(),NewPhysMaterial);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionResponseToAllChannels(IntPtr _this,int NewResponse);
public  void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
{
	CheckIsValid();
	SetCollisionResponseToAllChannels(_this.Get(),(int)NewResponse);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionResponseToChannel(IntPtr _this,int Channel,int NewResponse);
public  void SetCollisionResponseToChannel(ECollisionChannel Channel,ECollisionResponse NewResponse)
{
	CheckIsValid();
	SetCollisionResponseToChannel(_this.Get(),(int)Channel,(int)NewResponse);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsAnyRigidBodyAwake(IntPtr _this);
public  bool IsAnyRigidBodyAwake()
{
	CheckIsValid();
	int ___ret = IsAnyRigidBodyAwake(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector ScaleByMomentOfInertia(IntPtr _this,ref FVector InputVector,string BoneName);
public  FVector ScaleByMomentOfInertia(FVector InputVector,string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = ScaleByMomentOfInertia(_this.Get(),ref InputVector,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetInertiaTensor(IntPtr _this,string BoneName);
public  FVector GetInertiaTensor(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetInertiaTensor(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMass(IntPtr _this);
public  float GetMass()
{
	CheckIsValid();
	float ___ret = GetMass(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMassOverrideInKg(IntPtr _this,string BoneName,float MassInKg,int bOverrideMass);
public  void SetMassOverrideInKg(string BoneName="None",float MassInKg=1.000000f,bool bOverrideMass=true)
{
	CheckIsValid();
	SetMassOverrideInKg(_this.Get(),BoneName,MassInKg,bOverrideMass?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllMassScale(IntPtr _this,float InMassScale);
public  void SetAllMassScale(float InMassScale=1.000000f)
{
	CheckIsValid();
	SetAllMassScale(_this.Get(),InMassScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetMassScale(IntPtr _this,string BoneName);
public  float GetMassScale(string BoneName="None")
{
	CheckIsValid();
	float ___ret = GetMassScale(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMassScale(IntPtr _this,string BoneName,float InMassScale);
public  void SetMassScale(string BoneName="None",float InMassScale=1.000000f)
{
	CheckIsValid();
	SetMassScale(_this.Get(),BoneName,InMassScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAngularDamping(IntPtr _this);
public  float GetAngularDamping()
{
	CheckIsValid();
	float ___ret = GetAngularDamping(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDamping(IntPtr _this,float InDamping);
public  void SetAngularDamping(float InDamping)
{
	CheckIsValid();
	SetAngularDamping(_this.Get(),InDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetLinearDamping(IntPtr _this);
public  float GetLinearDamping()
{
	CheckIsValid();
	float ___ret = GetLinearDamping(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearDamping(IntPtr _this,float InDamping);
public  void SetLinearDamping(float InDamping)
{
	CheckIsValid();
	SetLinearDamping(_this.Get(),InDamping);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsGravityEnabled(IntPtr _this);
public  bool IsGravityEnabled()
{
	CheckIsValid();
	int ___ret = IsGravityEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetEnableGravity(IntPtr _this,int bGravityEnabled);
public  void SetEnableGravity(bool bGravityEnabled)
{
	CheckIsValid();
	SetEnableGravity(_this.Get(),bGravityEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void WakeAllRigidBodies(IntPtr _this);
public  void WakeAllRigidBodies()
{
	CheckIsValid();
	WakeAllRigidBodies(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllPhysicsAngularVelocity(IntPtr _this,ref FVector NewAngVel,int bAddToCurrent);
public  void SetAllPhysicsAngularVelocity(FVector NewAngVel,bool bAddToCurrent=false)
{
	CheckIsValid();
	SetAllPhysicsAngularVelocity(_this.Get(),ref NewAngVel,bAddToCurrent?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionObjectType(IntPtr _this);
public  ECollisionChannel GetCollisionObjectType()
{
	CheckIsValid();
	int ___ret = GetCollisionObjectType(_this.Get());
	return (ECollisionChannel)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionResponseToChannel(IntPtr _this,int Channel);
public  ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
{
	CheckIsValid();
	int ___ret = GetCollisionResponseToChannel(_this.Get(),(int)Channel);
	return (ECollisionResponse)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsPhysicsCollisionEnabled(IntPtr _this);
public  bool K2_IsPhysicsCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsPhysicsCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsQueryCollisionEnabled(IntPtr _this);
public  bool K2_IsQueryCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsQueryCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsCollisionEnabled(IntPtr _this);
public  bool K2_IsCollisionEnabled()
{
	CheckIsValid();
	int ___ret = K2_IsCollisionEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCollisionEnabled(IntPtr _this);
public  ECollisionEnabled GetCollisionEnabled()
{
	CheckIsValid();
	int ___ret = GetCollisionEnabled(_this.Get());
	return (ECollisionEnabled)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetClosestPointOnCollision(IntPtr _this,ref FVector Point,out FVector OutPointOnBody,string BoneName);
public  float GetClosestPointOnCollision(FVector Point,out FVector OutPointOnBody,string BoneName="None")
{
	CheckIsValid();
	float ___ret = GetClosestPointOnCollision(_this.Get(),ref Point,out OutPointOnBody,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumMaterials(IntPtr _this);
public  int GetNumMaterials()
{
	CheckIsValid();
	int ___ret = GetNumMaterials(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderInMono(IntPtr _this,int bValue);
public  void SetRenderInMono(bool bValue)
{
	CheckIsValid();
	SetRenderInMono(_this.Get(),bValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderInMainPass(IntPtr _this,int bValue);
public  void SetRenderInMainPass(bool bValue)
{
	CheckIsValid();
	SetRenderInMainPass(_this.Get(),bValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCustomDepthStencilValue(IntPtr _this,int Value);
public  void SetCustomDepthStencilValue(int Value)
{
	CheckIsValid();
	SetCustomDepthStencilValue(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderCustomDepth(IntPtr _this,int bValue);
public  void SetRenderCustomDepth(bool bValue)
{
	CheckIsValid();
	SetRenderCustomDepth(_this.Get(),bValue?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_LineTraceComponent(IntPtr _this,ref FVector TraceStart,ref FVector TraceEnd,int bTraceComplex,int bShowTrace,out FVector HitLocation,out FVector HitNormal,out string BoneName,out FHitResult OutHit);
public  bool K2_LineTraceComponent(FVector TraceStart,FVector TraceEnd,bool bTraceComplex,bool bShowTrace,out FVector HitLocation,out FVector HitNormal,out string BoneName,out FHitResult OutHit)
{
	CheckIsValid();
	int ___ret = K2_LineTraceComponent(_this.Get(),ref TraceStart,ref TraceEnd,bTraceComplex?1:0,bShowTrace?1:0,out HitLocation,out HitNormal,out BoneName,out OutHit);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionObjectType(IntPtr _this,int Channel);
public  void SetCollisionObjectType(ECollisionChannel Channel)
{
	CheckIsValid();
	SetCollisionObjectType(_this.Get(),(int)Channel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetCollisionProfileName(IntPtr _this);
public  string GetCollisionProfileName()
{
	CheckIsValid();
	string ___ret = GetCollisionProfileName(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionProfileName(IntPtr _this,string InCollisionProfileName);
public  void SetCollisionProfileName(string InCollisionProfileName)
{
	CheckIsValid();
	SetCollisionProfileName(_this.Get(),InCollisionProfileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionEnabled(IntPtr _this,int NewType);
public  void SetCollisionEnabled(ECollisionEnabled NewType)
{
	CheckIsValid();
	SetCollisionEnabled(_this.Get(),(int)NewType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTranslucentSortPriority(IntPtr _this,int NewTranslucentSortPriority);
public  void SetTranslucentSortPriority(int NewTranslucentSortPriority)
{
	CheckIsValid();
	SetTranslucentSortPriority(_this.Get(),NewTranslucentSortPriority);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCastShadow(IntPtr _this,int NewCastShadow);
public  void SetCastShadow(bool NewCastShadow)
{
	CheckIsValid();
	SetCastShadow(_this.Get(),NewCastShadow?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOnlyOwnerSee(IntPtr _this,int bNewOnlyOwnerSee);
public  void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
{
	CheckIsValid();
	SetOnlyOwnerSee(_this.Get(),bNewOnlyOwnerSee?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOwnerNoSee(IntPtr _this,int bNewOwnerNoSee);
public  void SetOwnerNoSee(bool bNewOwnerNoSee)
{
	CheckIsValid();
	SetOwnerNoSee(_this.Get(),bNewOwnerNoSee?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNotifyRigidBodyCollision(IntPtr _this,int bNewNotifyRigidBodyCollision);
public  void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
{
	CheckIsValid();
	SetNotifyRigidBodyCollision(_this.Get(),bNewNotifyRigidBodyCollision?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PutRigidBodyToSleep(IntPtr _this,string BoneName);
public  void PutRigidBodyToSleep(string BoneName="None")
{
	CheckIsValid();
	PutRigidBodyToSleep(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void WakeRigidBody(IntPtr _this,string BoneName);
public  void WakeRigidBody(string BoneName="None")
{
	CheckIsValid();
	WakeRigidBody(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCenterOfMass(IntPtr _this,ref FVector CenterOfMassOffset,string BoneName);
public  void SetCenterOfMass(FVector CenterOfMassOffset,string BoneName="None")
{
	CheckIsValid();
	SetCenterOfMass(_this.Get(),ref CenterOfMassOffset,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetCenterOfMass(IntPtr _this,string BoneName);
public  FVector GetCenterOfMass(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetCenterOfMass(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsAngularVelocity(IntPtr _this,string BoneName);
public  FVector GetPhysicsAngularVelocity(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsAngularVelocity(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsMaxAngularVelocity(IntPtr _this,float NewMaxAngVel,int bAddToCurrent,string BoneName);
public  void SetPhysicsMaxAngularVelocity(float NewMaxAngVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsMaxAngularVelocity(_this.Get(),NewMaxAngVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsAngularVelocity(IntPtr _this,ref FVector NewAngVel,int bAddToCurrent,string BoneName);
public  void SetPhysicsAngularVelocity(FVector NewAngVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsAngularVelocity(_this.Get(),ref NewAngVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAllPhysicsLinearVelocity(IntPtr _this,ref FVector NewVel,int bAddToCurrent);
public  void SetAllPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false)
{
	CheckIsValid();
	SetAllPhysicsLinearVelocity(_this.Get(),ref NewVel,bAddToCurrent?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsLinearVelocityAtPoint(IntPtr _this,ref FVector Point,string BoneName);
public  FVector GetPhysicsLinearVelocityAtPoint(FVector Point,string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsLinearVelocityAtPoint(_this.Get(),ref Point,BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetPhysicsLinearVelocity(IntPtr _this,string BoneName);
public  FVector GetPhysicsLinearVelocity(string BoneName="None")
{
	CheckIsValid();
	FVector ___ret = GetPhysicsLinearVelocity(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsLinearVelocity(IntPtr _this,ref FVector NewVel,int bAddToCurrent,string BoneName);
public  void SetPhysicsLinearVelocity(FVector NewVel,bool bAddToCurrent=false,string BoneName="None")
{
	CheckIsValid();
	SetPhysicsLinearVelocity(_this.Get(),ref NewVel,bAddToCurrent?1:0,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddTorque(IntPtr _this,ref FVector Torque,string BoneName,int bAccelChange);
public  void AddTorque(FVector Torque,string BoneName="None",bool bAccelChange=false)
{
	CheckIsValid();
	AddTorque(_this.Get(),ref Torque,BoneName,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddRadialForce(IntPtr _this,ref FVector Origin,float Radius,float Strength,int Falloff,int bAccelChange);
public  void AddRadialForce(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bAccelChange=false)
{
	CheckIsValid();
	AddRadialForce(_this.Get(),ref Origin,Radius,Strength,(int)Falloff,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForceAtLocationLocal(IntPtr _this,ref FVector Force,ref FVector Location,string BoneName);
public  void AddForceAtLocationLocal(FVector Force,FVector Location,string BoneName="None")
{
	CheckIsValid();
	AddForceAtLocationLocal(_this.Get(),ref Force,ref Location,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForceAtLocation(IntPtr _this,ref FVector Force,ref FVector Location,string BoneName);
public  void AddForceAtLocation(FVector Force,FVector Location,string BoneName="None")
{
	CheckIsValid();
	AddForceAtLocation(_this.Get(),ref Force,ref Location,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddForce(IntPtr _this,ref FVector Force,string BoneName,int bAccelChange);
public  void AddForce(FVector Force,string BoneName="None",bool bAccelChange=false)
{
	CheckIsValid();
	AddForce(_this.Get(),ref Force,BoneName,bAccelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddRadialImpulse(IntPtr _this,ref FVector Origin,float Radius,float Strength,int Falloff,int bVelChange);
public  void AddRadialImpulse(FVector Origin,float Radius,float Strength,ERadialImpulseFalloff Falloff,bool bVelChange=false)
{
	CheckIsValid();
	AddRadialImpulse(_this.Get(),ref Origin,Radius,Strength,(int)Falloff,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulseAtLocation(IntPtr _this,ref FVector Impulse,ref FVector Location,string BoneName);
public  void AddImpulseAtLocation(FVector Impulse,FVector Location,string BoneName="None")
{
	CheckIsValid();
	AddImpulseAtLocation(_this.Get(),ref Impulse,ref Location,BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddAngularImpulse(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange);
public  void AddAngularImpulse(FVector Impulse,string BoneName="None",bool bVelChange=false)
{
	CheckIsValid();
	AddAngularImpulse(_this.Get(),ref Impulse,BoneName,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddImpulse(IntPtr _this,ref FVector Impulse,string BoneName,int bVelChange);
public  void AddImpulse(FVector Impulse,string BoneName="None",bool bVelChange=false)
{
	CheckIsValid();
	AddImpulse(_this.Get(),ref Impulse,BoneName,bVelChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintMode(IntPtr _this,int ConstraintMode);
public  void SetConstraintMode(EDOFMode ConstraintMode)
{
	CheckIsValid();
	SetConstraintMode(_this.Get(),(int)ConstraintMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSimulatePhysics(IntPtr _this,int bSimulate);
public  void SetSimulatePhysics(bool bSimulate)
{
	CheckIsValid();
	SetSimulatePhysics(_this.Get(),bSimulate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWalkableSlopeOverride(IntPtr _this,ref FWalkableSlopeOverride NewOverride);
public  void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride)
{
	CheckIsValid();
	SetWalkableSlopeOverride(_this.Get(),ref NewOverride);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FWalkableSlopeOverride GetWalkableSlopeOverride(IntPtr _this);
public  FWalkableSlopeOverride GetWalkableSlopeOverride()
{
	CheckIsValid();
	FWalkableSlopeOverride ___ret = GetWalkableSlopeOverride(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMaterialFromCollisionFaceIndex(IntPtr _this,int FaceIndex);
public  UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex)
{
	CheckIsValid();
	IntPtr ___ret = GetMaterialFromCollisionFaceIndex(_this.Get(),FaceIndex);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDynamicMaterialInstance(IntPtr _this,int ElementIndex,IntPtr SourceMaterial);
public  UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex,UMaterialInterface SourceMaterial)
{
	CheckIsValid();
	IntPtr ___ret = CreateDynamicMaterialInstance(_this.Get(),ElementIndex,SourceMaterial);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterialByName(IntPtr _this,string MaterialSlotName,IntPtr Material);
public  void SetMaterialByName(string MaterialSlotName,UMaterialInterface Material)
{
	CheckIsValid();
	SetMaterialByName(_this.Get(),MaterialSlotName,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMaterial(IntPtr _this,int ElementIndex,IntPtr Material);
public  void SetMaterial(int ElementIndex,UMaterialInterface Material)
{
	CheckIsValid();
	SetMaterial(_this.Get(),ElementIndex,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetMaterial(IntPtr _this,int ElementIndex);
public  UMaterialInterface GetMaterial(int ElementIndex)
{
	CheckIsValid();
	IntPtr ___ret = GetMaterial(_this.Get(),ElementIndex);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoundsScale(IntPtr _this,float NewBoundsScale);
public  void SetBoundsScale(float NewBoundsScale=1.000000f)
{
	CheckIsValid();
	SetBoundsScale(_this.Get(),NewBoundsScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FOverlapInfo[] GetOverlapInfos(IntPtr _this);
public  FOverlapInfo[] GetOverlapInfos()
{
	CheckIsValid();
	FOverlapInfo[] ___ret = GetOverlapInfos(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingComponents(IntPtr _this,out IntPtr[] InOverlappingComponents);
public  void GetOverlappingComponents(out UPrimitiveComponent[] InOverlappingComponents)
{
	CheckIsValid();
	IntPtr[] InOverlappingComponents_temp;
	GetOverlappingComponents(_this.Get(),out InOverlappingComponents_temp);
	InOverlappingComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(InOverlappingComponents_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOverlappingActors(IntPtr _this,out IntPtr[] OverlappingActors,IntPtr ClassFilter);
public  void GetOverlappingActors(out AActor[] OverlappingActors,TSubclassOf<AActor>  ClassFilter)
{
	CheckIsValid();
	IntPtr[] OverlappingActors_temp;
	GetOverlappingActors(_this.Get(),out OverlappingActors_temp,ClassFilter.NativeClass);
	OverlappingActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OverlappingActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOverlappingActor(IntPtr _this,IntPtr Other);
public  bool IsOverlappingActor(AActor Other)
{
	CheckIsValid();
	int ___ret = IsOverlappingActor(_this.Get(),Other);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsOverlappingComponent(IntPtr _this,IntPtr OtherComp);
public  bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
{
	CheckIsValid();
	int ___ret = IsOverlappingComponent(_this.Get(),OtherComp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMoveIgnoreComponents(IntPtr _this);
public  void ClearMoveIgnoreComponents()
{
	CheckIsValid();
	ClearMoveIgnoreComponents(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] CopyArrayOfMoveIgnoreComponents(IntPtr _this);
public  UPrimitiveComponent[] CopyArrayOfMoveIgnoreComponents()
{
	CheckIsValid();
	IntPtr[] ___ret = CopyArrayOfMoveIgnoreComponents(_this.Get());
	return MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void IgnoreComponentWhenMoving(IntPtr _this,IntPtr Component,int bShouldIgnore);
public  void IgnoreComponentWhenMoving(UPrimitiveComponent Component,bool bShouldIgnore)
{
	CheckIsValid();
	IgnoreComponentWhenMoving(_this.Get(),Component,bShouldIgnore?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearMoveIgnoreActors(IntPtr _this);
public  void ClearMoveIgnoreActors()
{
	CheckIsValid();
	ClearMoveIgnoreActors(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr[] CopyArrayOfMoveIgnoreActors(IntPtr _this);
public  AActor[] CopyArrayOfMoveIgnoreActors()
{
	CheckIsValid();
	IntPtr[] ___ret = CopyArrayOfMoveIgnoreActors(_this.Get());
	return MarshalUtil.IntPtrArrayToObjectArray<AActor>(___ret);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void IgnoreActorWhenMoving(IntPtr _this,IntPtr Actor,int bShouldIgnore);
public  void IgnoreActorWhenMoving(AActor Actor,bool bShouldIgnore)
{
	CheckIsValid();
	IgnoreActorWhenMoving(_this.Get(),Actor,bShouldIgnore?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
