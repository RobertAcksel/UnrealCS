//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameplayStatics:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasLaunchOption(IntPtr _this,string OptionToCheck);
public static bool HasLaunchOption(string OptionToCheck)
{
	int ___ret = HasLaunchOption(IntPtr.Zero,OptionToCheck);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetIntOption(IntPtr _this,string Options,string Key,int DefaultValue);
public static int GetIntOption(string Options,string Key,int DefaultValue)
{
	int ___ret = GetIntOption(IntPtr.Zero,Options,Key,DefaultValue);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasOption(IntPtr _this,string Options,string InKey);
public static bool HasOption(string Options,string InKey)
{
	int ___ret = HasOption(IntPtr.Zero,Options,InKey);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string ParseOption(IntPtr _this,string Options,string Key);
public static string ParseOption(string Options,string Key)
{
	string ___ret = ParseOption(IntPtr.Zero,Options,Key);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetKeyValue(IntPtr _this,string Pair,out string Key,out string Value);
public static void GetKeyValue(string Pair,out string Key,out string Value)
{
	GetKeyValue(IntPtr.Zero,Pair,out Key,out Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ProjectWorldToScreen(IntPtr _this,IntPtr Player,ref FVector WorldPosition,out FVector2D ScreenPosition,int bPlayerViewportRelative);
public static bool ProjectWorldToScreen(APlayerController Player,FVector WorldPosition,out FVector2D ScreenPosition,bool bPlayerViewportRelative=false)
{
	int ___ret = ProjectWorldToScreen(IntPtr.Zero,Player,ref WorldPosition,out ScreenPosition,bPlayerViewportRelative?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DeprojectScreenToWorld(IntPtr _this,IntPtr Player,ref FVector2D ScreenPosition,out FVector WorldPosition,out FVector WorldDirection);
public static bool DeprojectScreenToWorld(APlayerController Player,FVector2D ScreenPosition,out FVector WorldPosition,out FVector WorldDirection)
{
	int ___ret = DeprojectScreenToWorld(IntPtr.Zero,Player,ref ScreenPosition,out WorldPosition,out WorldDirection);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GrassOverlappingSphereCount(IntPtr _this,IntPtr WorldContextObject,IntPtr StaticMesh,ref FVector CenterPosition,float Radius);
public static int GrassOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius)
{
	int ___ret = GrassOverlappingSphereCount(IntPtr.Zero,WorldContextObject,StaticMesh,ref CenterPosition,Radius);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RebaseZeroOriginOntoLocal(IntPtr _this,IntPtr WorldContextObject,ref FVector WorldLocation);
public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation)
{
	FVector ___ret = RebaseZeroOriginOntoLocal(IntPtr.Zero,WorldContextObject,ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector RebaseLocalOriginOntoZero(IntPtr _this,IntPtr WorldContextObject,ref FVector WorldLocation);
public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation)
{
	FVector ___ret = RebaseLocalOriginOntoZero(IntPtr.Zero,WorldContextObject,ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldOriginLocation(IntPtr _this,IntPtr WorldContextObject,ref FIntVector NewLocation);
public static void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation)
{
	SetWorldOriginLocation(IntPtr.Zero,WorldContextObject,ref NewLocation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntVector GetWorldOriginLocation(IntPtr _this,IntPtr WorldContextObject);
public static FIntVector GetWorldOriginLocation(UObject WorldContextObject)
{
	FIntVector ___ret = GetWorldOriginLocation(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SuggestProjectileVelocity_CustomArc(IntPtr _this,IntPtr WorldContextObject,out FVector OutLaunchVelocity,ref FVector StartPos,ref FVector EndPos,float OverrideGravityZ,float ArcParam);
public static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,out FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ=0.000000f,float ArcParam=0.500000f)
{
	int ___ret = SuggestProjectileVelocity_CustomArc(IntPtr.Zero,WorldContextObject,out OutLaunchVelocity,ref StartPos,ref EndPos,OverrideGravityZ,ArcParam);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Blueprint_PredictProjectilePath_Advanced(IntPtr _this,IntPtr WorldContextObject,ref FPredictProjectilePathParams PredictParams,out FPredictProjectilePathResult PredictResult);
public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,out FPredictProjectilePathResult PredictResult)
{
	int ___ret = Blueprint_PredictProjectilePath_Advanced(IntPtr.Zero,WorldContextObject,ref PredictParams,out PredictResult);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Blueprint_PredictProjectilePath_ByTraceChannel(IntPtr _this,IntPtr WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,ref FVector StartPos,ref FVector LaunchVelocity,int bTracePath,float ProjectileRadius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ);
public static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,ECollisionChannel TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.000000f,float MaxSimTime=2.000000f,float OverrideGravityZ=0.000000f)
{
	int ___ret = Blueprint_PredictProjectilePath_ByTraceChannel(IntPtr.Zero,WorldContextObject,out OutHit,out OutPathPositions,out OutLastTraceDestination,ref StartPos,ref LaunchVelocity,bTracePath?1:0,ProjectileRadius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Blueprint_PredictProjectilePath_ByObjectType(IntPtr _this,IntPtr WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,ref FVector StartPos,ref FVector LaunchVelocity,int bTracePath,float ProjectileRadius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ);
public static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.000000f,float MaxSimTime=2.000000f,float OverrideGravityZ=0.000000f)
{
	int ___ret = Blueprint_PredictProjectilePath_ByObjectType(IntPtr.Zero,WorldContextObject,out OutHit,out OutPathPositions,out OutLastTraceDestination,ref StartPos,ref LaunchVelocity,bTracePath?1:0,ProjectileRadius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BlueprintSuggestProjectileVelocity(IntPtr _this,IntPtr WorldContextObject,out FVector TossVelocity,ref FVector StartLocation,ref FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,int TraceOption,float CollisionRadius,int bFavorHighArc,int bDrawDebug);
public static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,out FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug)
{
	int ___ret = BlueprintSuggestProjectileVelocity(IntPtr.Zero,WorldContextObject,out TossVelocity,ref StartLocation,ref EndLocation,LaunchSpeed,OverrideGravityZ,(int)TraceOption,CollisionRadius,bFavorHighArc?1:0,bDrawDebug?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetPlatformName(IntPtr _this);
public static string GetPlatformName()
{
	string ___ret = GetPlatformName(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableLiveStreaming(IntPtr _this,int Enable);
public static void EnableLiveStreaming(bool Enable)
{
	EnableLiveStreaming(IntPtr.Zero,Enable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAccurateRealTime(IntPtr _this,IntPtr WorldContextObject,out int Seconds,out float PartialSeconds);
public static void GetAccurateRealTime(UObject WorldContextObject,out int Seconds,out float PartialSeconds)
{
	GetAccurateRealTime(IntPtr.Zero,WorldContextObject,out Seconds,out PartialSeconds);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetAudioTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetAudioTimeSeconds(UObject WorldContextObject)
{
	float ___ret = GetAudioTimeSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRealTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetRealTimeSeconds(UObject WorldContextObject)
{
	float ___ret = GetRealTimeSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetUnpausedTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetUnpausedTimeSeconds(UObject WorldContextObject)
{
	float ___ret = GetUnpausedTimeSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetTimeSeconds(UObject WorldContextObject)
{
	float ___ret = GetTimeSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetWorldDeltaSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetWorldDeltaSeconds(UObject WorldContextObject)
{
	float ___ret = GetWorldDeltaSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DeleteGameInSlot(IntPtr _this,string SlotName,int UserIndex);
public static bool DeleteGameInSlot(string SlotName,int UserIndex)
{
	int ___ret = DeleteGameInSlot(IntPtr.Zero,SlotName,UserIndex);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr LoadGameFromSlot(IntPtr _this,string SlotName,int UserIndex);
public static USaveGame LoadGameFromSlot(string SlotName,int UserIndex)
{
	IntPtr ___ret = LoadGameFromSlot(IntPtr.Zero,SlotName,UserIndex);
	if(___ret==IntPtr.Zero) return null; USaveGame ___ret2= new USaveGame(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DoesSaveGameExist(IntPtr _this,string SlotName,int UserIndex);
public static bool DoesSaveGameExist(string SlotName,int UserIndex)
{
	int ___ret = DoesSaveGameExist(IntPtr.Zero,SlotName,UserIndex);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SaveGameToSlot(IntPtr _this,IntPtr SaveGameObject,string SlotName,int UserIndex);
public static bool SaveGameToSlot(USaveGame SaveGameObject,string SlotName,int UserIndex)
{
	int ___ret = SaveGameToSlot(IntPtr.Zero,SaveGameObject,SlotName,UserIndex);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateSaveGameObject(IntPtr _this,IntPtr SaveGameClass);
public static USaveGame CreateSaveGameObject(TSubclassOf<USaveGame>  SaveGameClass)
{
	IntPtr ___ret = CreateSaveGameObject(IntPtr.Zero,SaveGameClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; USaveGame ___ret2= new USaveGame(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FindCollisionUV(IntPtr _this,ref FHitResult Hit,int UVChannel,out FVector2D UV);
public static bool FindCollisionUV(FHitResult Hit,int UVChannel,out FVector2D UV)
{
	int ___ret = FindCollisionUV(IntPtr.Zero,ref Hit,UVChannel,out UV);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetSurfaceType(IntPtr _this,ref FHitResult Hit);
public static EPhysicalSurface GetSurfaceType(FHitResult Hit)
{
	int ___ret = GetSurfaceType(IntPtr.Zero,ref Hit);
	return (EPhysicalSurface)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FHitResult MakeHitResult(IntPtr _this,int bBlockingHit,int bInitialOverlap,float Time,ref FVector Location,ref FVector ImpactPoint,ref FVector Normal,ref FVector ImpactNormal,IntPtr PhysMat,IntPtr HitActor,IntPtr HitComponent,string HitBoneName,int HitItem,int FaceIndex,ref FVector TraceStart,ref FVector TraceEnd);
public static FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,int HitItem,int FaceIndex,FVector TraceStart,FVector TraceEnd)
{
	FHitResult ___ret = MakeHitResult(IntPtr.Zero,bBlockingHit?1:0,bInitialOverlap?1:0,Time,ref Location,ref ImpactPoint,ref Normal,ref ImpactNormal,PhysMat,HitActor,HitComponent,HitBoneName,HitItem,FaceIndex,ref TraceStart,ref TraceEnd);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakHitResult(IntPtr _this,ref FHitResult Hit,out int bBlockingHit,out int bInitialOverlap,out float Time,out FVector Location,out FVector ImpactPoint,out FVector Normal,out FVector ImpactNormal,out IntPtr PhysMat,out IntPtr HitActor,out IntPtr HitComponent,out string HitBoneName,out int HitItem,out int FaceIndex,out FVector TraceStart,out FVector TraceEnd);
public static void BreakHitResult(FHitResult Hit,out bool bBlockingHit,out bool bInitialOverlap,out float Time,out FVector Location,out FVector ImpactPoint,out FVector Normal,out FVector ImpactNormal,out UPhysicalMaterial PhysMat,out AActor HitActor,out UPrimitiveComponent HitComponent,out string HitBoneName,out int HitItem,out int FaceIndex,out FVector TraceStart,out FVector TraceEnd)
{
	int bBlockingHit_temp;
	int bInitialOverlap_temp;
	IntPtr PhysMat_temp;
	IntPtr HitActor_temp;
	IntPtr HitComponent_temp;
	BreakHitResult(IntPtr.Zero,ref Hit,out bBlockingHit_temp,out bInitialOverlap_temp,out Time,out Location,out ImpactPoint,out Normal,out ImpactNormal,out PhysMat_temp,out HitActor_temp,out HitComponent_temp,out HitBoneName,out HitItem,out FaceIndex,out TraceStart,out TraceEnd);
	bBlockingHit=bBlockingHit_temp!=0;
	bInitialOverlap=bInitialOverlap_temp!=0;
	PhysMat=new UPhysicalMaterial(){ _this=PhysMat_temp};
	HitActor=new AActor(){ _this=HitActor_temp};
	HitComponent=new UPrimitiveComponent(){ _this=HitComponent_temp};
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnDecalAttached(IntPtr _this,IntPtr DecalMaterial,ref FVector DecalSize,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,float LifeSpan);
public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial,FVector DecalSize,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,float LifeSpan=0.000000f)
{
	IntPtr ___ret = SpawnDecalAttached(IntPtr.Zero,DecalMaterial,ref DecalSize,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,LifeSpan);
	if(___ret==IntPtr.Zero) return null; UDecalComponent ___ret2= new UDecalComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnDecalAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr DecalMaterial,ref FVector DecalSize,ref FVector Location,ref FRotator Rotation,float LifeSpan);
public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject,UMaterialInterface DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation=default(FRotator),float LifeSpan=0.000000f)
{
	IntPtr ___ret = SpawnDecalAtLocation(IntPtr.Zero,WorldContextObject,DecalMaterial,ref DecalSize,ref Location,ref Rotation,LifeSpan);
	if(___ret==IntPtr.Zero) return null; UDecalComponent ___ret2= new UDecalComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetCurrentReverbEffect(IntPtr _this,IntPtr WorldContextObject);
public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject)
{
	IntPtr ___ret = GetCurrentReverbEffect(IntPtr.Zero,WorldContextObject);
	if(___ret==IntPtr.Zero) return null; UReverbEffect ___ret2= new UReverbEffect(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DeactivateReverbEffect(IntPtr _this,IntPtr WorldContextObject,string TagName);
public static void DeactivateReverbEffect(UObject WorldContextObject,string TagName)
{
	DeactivateReverbEffect(IntPtr.Zero,WorldContextObject,TagName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ActivateReverbEffect(IntPtr _this,IntPtr WorldContextObject,IntPtr ReverbEffect,string TagName,float Priority,float Volume,float FadeTime);
public static void ActivateReverbEffect(UObject WorldContextObject,UReverbEffect ReverbEffect,string TagName,float Priority=0.000000f,float Volume=0.500000f,float FadeTime=2.000000f)
{
	ActivateReverbEffect(IntPtr.Zero,WorldContextObject,ReverbEffect,TagName,Priority,Volume,FadeTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearSoundMixModifiers(IntPtr _this,IntPtr WorldContextObject);
public static void ClearSoundMixModifiers(UObject WorldContextObject)
{
	ClearSoundMixModifiers(IntPtr.Zero,WorldContextObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PopSoundMixModifier(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier);
public static void PopSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier)
{
	PopSoundMixModifier(IntPtr.Zero,WorldContextObject,InSoundMixModifier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PushSoundMixModifier(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier);
public static void PushSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier)
{
	PushSoundMixModifier(IntPtr.Zero,WorldContextObject,InSoundMixModifier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearSoundMixClassOverride(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier,IntPtr InSoundClass,float FadeOutTime);
public static void ClearSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float FadeOutTime=1.000000f)
{
	ClearSoundMixClassOverride(IntPtr.Zero,WorldContextObject,InSoundMixModifier,InSoundClass,FadeOutTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSoundMixClassOverride(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier,IntPtr InSoundClass,float Volume,float Pitch,float FadeInTime,int bApplyToChildren);
public static void SetSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float Volume=1.000000f,float Pitch=1.000000f,float FadeInTime=1.000000f,bool bApplyToChildren=true)
{
	SetSoundMixClassOverride(IntPtr.Zero,WorldContextObject,InSoundMixModifier,InSoundClass,Volume,Pitch,FadeInTime,bApplyToChildren?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBaseSoundMix(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMix);
public static void SetBaseSoundMix(UObject WorldContextObject,USoundMix InSoundMix)
{
	SetBaseSoundMix(IntPtr.Zero,WorldContextObject,InSoundMix);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int AreSubtitlesEnabled(IntPtr _this);
public static bool AreSubtitlesEnabled()
{
	int ___ret = AreSubtitlesEnabled(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSubtitlesEnabled(IntPtr _this,int bEnabled);
public static void SetSubtitlesEnabled(bool bEnabled)
{
	SetSubtitlesEnabled(IntPtr.Zero,bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnForceFeedbackAttached(IntPtr _this,IntPtr ForceFeedbackEffect,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,int bLooping,float IntensityMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnForceFeedbackAttached(IntPtr.Zero,ForceFeedbackEffect,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,bLooping?1:0,IntensityMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UForceFeedbackComponent ___ret2= new UForceFeedbackComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnForceFeedbackAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr ForceFeedbackEffect,ref FVector Location,ref FRotator Rotation,int bLooping,float IntensityMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject,UForceFeedbackEffect ForceFeedbackEffect,FVector Location,FRotator Rotation,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnForceFeedbackAtLocation(IntPtr.Zero,WorldContextObject,ForceFeedbackEffect,ref Location,ref Rotation,bLooping?1:0,IntensityMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UForceFeedbackComponent ___ret2= new UForceFeedbackComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnDialogueAttached(IntPtr _this,IntPtr Dialogue,ref FDialogueContext Context,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue,FDialogueContext Context,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnDialogueAttached(IntPtr.Zero,Dialogue,ref Context,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnDialogueAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnDialogueAtLocation(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayDialogueAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings);
public static void PlayDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation))
{
	PlayDialogueAtLocation(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnDialogue2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,float VolumeMultiplier,float PitchMultiplier,float StartTime,int bAutoDestroy);
public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnDialogue2D(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,VolumeMultiplier,PitchMultiplier,StartTime,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayDialogue2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,float VolumeMultiplier,float PitchMultiplier,float StartTime);
public static void PlayDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f)
{
	PlayDialogue2D(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,VolumeMultiplier,PitchMultiplier,StartTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnSoundAttached(IntPtr _this,IntPtr Sound,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings,int bAutoDestroy);
public static UAudioComponent SpawnSoundAttached(USoundBase Sound,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnSoundAttached(IntPtr.Zero,Sound,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnSoundAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings,int bAutoDestroy);
public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnSoundAtLocation(IntPtr.Zero,WorldContextObject,Sound,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlaySoundAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings);
public static void PlaySoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency))
{
	PlaySoundAtLocation(IntPtr.Zero,WorldContextObject,Sound,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateSound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings,int bPersistAcrossLevelTransition,int bAutoDestroy);
public static UAudioComponent CreateSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true)
{
	IntPtr ___ret = CreateSound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition?1:0,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnSound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings,int bPersistAcrossLevelTransition,int bAutoDestroy);
public static UAudioComponent SpawnSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnSound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition?1:0,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlaySound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings);
public static void PlaySound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency))
{
	PlaySound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGlobalListenerFocusParameters(IntPtr _this,IntPtr WorldContextObject,float FocusAzimuthScale,float NonFocusAzimuthScale,float FocusDistanceScale,float NonFocusDistanceScale,float FocusVolumeScale,float NonFocusVolumeScale,float FocusPriorityScale,float NonFocusPriorityScale);
public static void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale=1.000000f,float NonFocusAzimuthScale=1.000000f,float FocusDistanceScale=1.000000f,float NonFocusDistanceScale=1.000000f,float FocusVolumeScale=1.000000f,float NonFocusVolumeScale=1.000000f,float FocusPriorityScale=1.000000f,float NonFocusPriorityScale=1.000000f)
{
	SetGlobalListenerFocusParameters(IntPtr.Zero,WorldContextObject,FocusAzimuthScale,NonFocusAzimuthScale,FocusDistanceScale,NonFocusDistanceScale,FocusVolumeScale,NonFocusVolumeScale,FocusPriorityScale,NonFocusPriorityScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGlobalPitchModulation(IntPtr _this,IntPtr WorldContextObject,float PitchModulation,float TimeSec);
public static void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec)
{
	SetGlobalPitchModulation(IntPtr.Zero,WorldContextObject,PitchModulation,TimeSec);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int AreAnyListenersWithinRange(IntPtr _this,IntPtr WorldContextObject,ref FVector Location,float MaximumRange);
public static bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange)
{
	int ___ret = AreAnyListenersWithinRange(IntPtr.Zero,WorldContextObject,ref Location,MaximumRange);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnEmitterAttached(IntPtr _this,IntPtr EmitterTemplate,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bAutoDestroy);
public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnEmitterAttached(IntPtr.Zero,EmitterTemplate,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UParticleSystemComponent ___ret2= new UParticleSystemComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnEmitterAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr EmitterTemplate,ref FVector Location,ref FRotator Rotation,int bAutoDestroy);
public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject,UParticleSystem EmitterTemplate,FVector Location,FRotator Rotation,bool bAutoDestroy=true)
{
	IntPtr ___ret = SpawnEmitterAtLocation(IntPtr.Zero,WorldContextObject,EmitterTemplate,ref Location,ref Rotation,bAutoDestroy?1:0);
	if(___ret==IntPtr.Zero) return null; UParticleSystemComponent ___ret2= new UParticleSystemComponent(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayWorldCameraShake(IntPtr _this,IntPtr WorldContextObject,IntPtr Shake,ref FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff,int bOrientShakeTowardsEpicenter);
public static void PlayWorldCameraShake(UObject WorldContextObject,TSubclassOf<UCameraShake>  Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff=1.000000f,bool bOrientShakeTowardsEpicenter=false)
{
	PlayWorldCameraShake(IntPtr.Zero,WorldContextObject,Shake.NativeClass,ref Epicenter,InnerRadius,OuterRadius,Falloff,bOrientShakeTowardsEpicenter?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float ApplyDamage(IntPtr _this,IntPtr DamagedActor,float BaseDamage,IntPtr EventInstigator,IntPtr DamageCauser,IntPtr DamageTypeClass);
public static float ApplyDamage(AActor DamagedActor,float BaseDamage,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
{
	float ___ret = ApplyDamage(IntPtr.Zero,DamagedActor,BaseDamage,EventInstigator,DamageCauser,DamageTypeClass.NativeClass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float ApplyPointDamage(IntPtr _this,IntPtr DamagedActor,float BaseDamage,ref FVector HitFromDirection,ref FHitResult HitInfo,IntPtr EventInstigator,IntPtr DamageCauser,IntPtr DamageTypeClass);
public static float ApplyPointDamage(AActor DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
{
	float ___ret = ApplyPointDamage(IntPtr.Zero,DamagedActor,BaseDamage,ref HitFromDirection,ref HitInfo,EventInstigator,DamageCauser,DamageTypeClass.NativeClass);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ApplyRadialDamageWithFalloff(IntPtr _this,IntPtr WorldContextObject,float BaseDamage,float MinimumDamage,ref FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,IntPtr DamageTypeClass,IntPtr[] IgnoreActors,IntPtr DamageCauser,IntPtr InstigatedByController,int DamagePreventionChannel);
public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,TSubclassOf<UDamageType>  DamageTypeClass,AActor[] IgnoreActors,AActor DamageCauser,AController InstigatedByController,ECollisionChannel DamagePreventionChannel=ECollisionChannel.ECC_Visibility)
{
	int ___ret = ApplyRadialDamageWithFalloff(IntPtr.Zero,WorldContextObject,BaseDamage,MinimumDamage,ref Origin,DamageInnerRadius,DamageOuterRadius,DamageFalloff,DamageTypeClass.NativeClass,MarshalUtil.ObjectArrayToIntPtrArray(IgnoreActors),DamageCauser,InstigatedByController,(int)DamagePreventionChannel);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ApplyRadialDamage(IntPtr _this,IntPtr WorldContextObject,float BaseDamage,ref FVector Origin,float DamageRadius,IntPtr DamageTypeClass,IntPtr[] IgnoreActors,IntPtr DamageCauser,IntPtr InstigatedByController,int bDoFullDamage,int DamagePreventionChannel);
public static bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,TSubclassOf<UDamageType>  DamageTypeClass,AActor[] IgnoreActors,AActor DamageCauser,AController InstigatedByController,bool bDoFullDamage=false,ECollisionChannel DamagePreventionChannel=ECollisionChannel.ECC_Visibility)
{
	int ___ret = ApplyRadialDamage(IntPtr.Zero,WorldContextObject,BaseDamage,ref Origin,DamageRadius,DamageTypeClass.NativeClass,MarshalUtil.ObjectArrayToIntPtrArray(IgnoreActors),DamageCauser,InstigatedByController,bDoFullDamage?1:0,(int)DamagePreventionChannel);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsGamePaused(IntPtr _this,IntPtr WorldContextObject);
public static bool IsGamePaused(UObject WorldContextObject)
{
	int ___ret = IsGamePaused(IntPtr.Zero,WorldContextObject);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SetGamePaused(IntPtr _this,IntPtr WorldContextObject,int bPaused);
public static bool SetGamePaused(UObject WorldContextObject,bool bPaused)
{
	int ___ret = SetGamePaused(IntPtr.Zero,WorldContextObject,bPaused?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGlobalTimeDilation(IntPtr _this,IntPtr WorldContextObject,float TimeDilation);
public static void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation)
{
	SetGlobalTimeDilation(IntPtr.Zero,WorldContextObject,TimeDilation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetGlobalTimeDilation(IntPtr _this,IntPtr WorldContextObject);
public static float GetGlobalTimeDilation(UObject WorldContextObject)
{
	float ___ret = GetGlobalTimeDilation(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetObjectClass(IntPtr _this,IntPtr Object);
public static UClass GetObjectClass(UObject Object)
{
	IntPtr ___ret = GetObjectClass(IntPtr.Zero,Object);
	if(___ret==IntPtr.Zero) return null; UClass ___ret2= new UClass(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetGameState(IntPtr _this,IntPtr WorldContextObject);
public static AGameStateBase GetGameState(UObject WorldContextObject)
{
	IntPtr ___ret = GetGameState(IntPtr.Zero,WorldContextObject);
	if(___ret==IntPtr.Zero) return null; AGameStateBase ___ret2= new AGameStateBase(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetGameMode(IntPtr _this,IntPtr WorldContextObject);
public static AGameModeBase GetGameMode(UObject WorldContextObject)
{
	IntPtr ___ret = GetGameMode(IntPtr.Zero,WorldContextObject);
	if(___ret==IntPtr.Zero) return null; AGameModeBase ___ret2= new AGameModeBase(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetCurrentLevelName(IntPtr _this,IntPtr WorldContextObject,int bRemovePrefixString);
public static string GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString=true)
{
	string ___ret = GetCurrentLevelName(IntPtr.Zero,WorldContextObject,bRemovePrefixString?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OpenLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,int bAbsolute,string Options);
public static void OpenLevel(UObject WorldContextObject,string LevelName,bool bAbsolute=true,string Options=default(string))
{
	OpenLevel(IntPtr.Zero,WorldContextObject,LevelName,bAbsolute?1:0,Options);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CancelAsyncLoading(IntPtr _this);
public static void CancelAsyncLoading()
{
	CancelAsyncLoading(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushLevelStreaming(IntPtr _this,IntPtr WorldContextObject);
public static void FlushLevelStreaming(UObject WorldContextObject)
{
	FlushLevelStreaming(IntPtr.Zero,WorldContextObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetStreamingLevel(IntPtr _this,IntPtr WorldContextObject,string PackageName);
public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject,string PackageName)
{
	IntPtr ___ret = GetStreamingLevel(IntPtr.Zero,WorldContextObject,PackageName);
	if(___ret==IntPtr.Zero) return null; ULevelStreaming ___ret2= new ULevelStreaming(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnloadStreamLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,ref FLatentActionInfo LatentInfo);
public static void UnloadStreamLevel(UObject WorldContextObject,string LevelName,FLatentActionInfo LatentInfo)
{
	UnloadStreamLevel(IntPtr.Zero,WorldContextObject,LevelName,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LoadStreamLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,int bMakeVisibleAfterLoad,int bShouldBlockOnLoad,ref FLatentActionInfo LatentInfo);
public static void LoadStreamLevel(UObject WorldContextObject,string LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo)
{
	LoadStreamLevel(IntPtr.Zero,WorldContextObject,LevelName,bMakeVisibleAfterLoad?1:0,bShouldBlockOnLoad?1:0,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPlayerControllerID(IntPtr _this,IntPtr Player,int ControllerId);
public static void SetPlayerControllerID(APlayerController Player,int ControllerId)
{
	SetPlayerControllerID(IntPtr.Zero,Player,ControllerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetPlayerControllerID(IntPtr _this,IntPtr Player);
public static int GetPlayerControllerID(APlayerController Player)
{
	int ___ret = GetPlayerControllerID(IntPtr.Zero,Player);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemovePlayer(IntPtr _this,IntPtr Player,int bDestroyPawn);
public static void RemovePlayer(APlayerController Player,bool bDestroyPawn)
{
	RemovePlayer(IntPtr.Zero,Player,bDestroyPawn?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreatePlayer(IntPtr _this,IntPtr WorldContextObject,int ControllerId,int bSpawnPawn);
public static APlayerController CreatePlayer(UObject WorldContextObject,int ControllerId=-1,bool bSpawnPawn=true)
{
	IntPtr ___ret = CreatePlayer(IntPtr.Zero,WorldContextObject,ControllerId,bSpawnPawn?1:0);
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPlayerCameraManager(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex)
{
	IntPtr ___ret = GetPlayerCameraManager(IntPtr.Zero,WorldContextObject,PlayerIndex);
	if(___ret==IntPtr.Zero) return null; APlayerCameraManager ___ret2= new APlayerCameraManager(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPlayerCharacter(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
public static ACharacter GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex)
{
	IntPtr ___ret = GetPlayerCharacter(IntPtr.Zero,WorldContextObject,PlayerIndex);
	if(___ret==IntPtr.Zero) return null; ACharacter ___ret2= new ACharacter(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPlayerPawn(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
public static APawn GetPlayerPawn(UObject WorldContextObject,int PlayerIndex)
{
	IntPtr ___ret = GetPlayerPawn(IntPtr.Zero,WorldContextObject,PlayerIndex);
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPlayerController(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
public static APlayerController GetPlayerController(UObject WorldContextObject,int PlayerIndex)
{
	IntPtr ___ret = GetPlayerController(IntPtr.Zero,WorldContextObject,PlayerIndex);
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetGameInstance(IntPtr _this,IntPtr WorldContextObject);
public static UGameInstance GetGameInstance(UObject WorldContextObject)
{
	IntPtr ___ret = GetGameInstance(IntPtr.Zero,WorldContextObject);
	if(___ret==IntPtr.Zero) return null; UGameInstance ___ret2= new UGameInstance(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllActorsWithTag(IntPtr _this,IntPtr WorldContextObject,string Tag,out IntPtr[] OutActors);
public static void GetAllActorsWithTag(UObject WorldContextObject,string Tag,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	GetAllActorsWithTag(IntPtr.Zero,WorldContextObject,Tag,out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllActorsWithInterface(IntPtr _this,IntPtr WorldContextObject,IntPtr Interface,out IntPtr[] OutActors);
public static void GetAllActorsWithInterface(UObject WorldContextObject,TSubclassOf<UInterface>  Interface,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	GetAllActorsWithInterface(IntPtr.Zero,WorldContextObject,Interface.NativeClass,out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllActorsOfClass(IntPtr _this,IntPtr WorldContextObject,IntPtr ActorClass,out IntPtr[] OutActors);
public static void GetAllActorsOfClass(UObject WorldContextObject,TSubclassOf<AActor>  ActorClass,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	GetAllActorsOfClass(IntPtr.Zero,WorldContextObject,ActorClass.NativeClass,out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorArrayBounds(IntPtr _this,IntPtr[] Actors,int bOnlyCollidingComponents,out FVector Center,out FVector BoxExtent);
public static void GetActorArrayBounds(AActor[] Actors,bool bOnlyCollidingComponents,out FVector Center,out FVector BoxExtent)
{
	GetActorArrayBounds(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(Actors),bOnlyCollidingComponents?1:0,out Center,out BoxExtent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetActorArrayAverageLocation(IntPtr _this,IntPtr[] Actors);
public static FVector GetActorArrayAverageLocation(AActor[] Actors)
{
	FVector ___ret = GetActorArrayAverageLocation(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(Actors));
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr FinishSpawningActor(IntPtr _this,IntPtr Actor,ref FTransform SpawnTransform);
public static AActor FinishSpawningActor(AActor Actor,FTransform SpawnTransform)
{
	IntPtr ___ret = FinishSpawningActor(IntPtr.Zero,Actor,ref SpawnTransform);
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr SpawnObject(IntPtr _this,IntPtr ObjectClass,IntPtr Outer);
public static UObject SpawnObject(TSubclassOf<UObject>  ObjectClass,UObject Outer)
{
	IntPtr ___ret = SpawnObject(IntPtr.Zero,ObjectClass.NativeClass,Outer);
	if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
