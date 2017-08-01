//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetSystemLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetCommandLine(IntPtr _this);
public static string GetCommandLine()
{
	string ___ret = GetCommandLine(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUserActivity(IntPtr _this,ref FUserActivity UserActivity);
public static void SetUserActivity(FUserActivity UserActivity)
{
	SetUserActivity(IntPtr.Zero,ref UserActivity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RegisterForRemoteNotifications(IntPtr _this);
public static void RegisterForRemoteNotifications()
{
	RegisterForRemoteNotifications(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetLocalCurrencySymbol(IntPtr _this);
public static string GetLocalCurrencySymbol()
{
	string ___ret = GetLocalCurrencySymbol(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetLocalCurrencyCode(IntPtr _this);
public static string GetLocalCurrencyCode()
{
	string ___ret = GetLocalCurrencyCode(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetDefaultLocale(IntPtr _this);
public static string GetDefaultLocale()
{
	string ___ret = GetDefaultLocale(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FString[] GetPreferredLanguages(IntPtr _this);
public static FString[] GetPreferredLanguages()
{
	FString[] ___ret = GetPreferredLanguages(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSuppressViewportTransitionMessage(IntPtr _this,IntPtr WorldContextObject,int bState);
public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState)
{
	SetSuppressViewportTransitionMessage(IntPtr.Zero,WorldContextObject,bState?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsControllerAssignedToGamepad(IntPtr _this,int ControllerId);
public static bool IsControllerAssignedToGamepad(int ControllerId)
{
	int ___ret = IsControllerAssignedToGamepad(IntPtr.Zero,ControllerId);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetGamepadAssignmentToController(IntPtr _this,int ControllerId);
public static void ResetGamepadAssignmentToController(int ControllerId)
{
	ResetGamepadAssignmentToController(IntPtr.Zero,ControllerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetGamepadAssignments(IntPtr _this);
public static void ResetGamepadAssignments()
{
	ResetGamepadAssignments(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetVolumeButtonsHandledBySystem(IntPtr _this);
public static bool GetVolumeButtonsHandledBySystem()
{
	int ___ret = GetVolumeButtonsHandledBySystem(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVolumeButtonsHandledBySystem(IntPtr _this,int bEnabled);
public static void SetVolumeButtonsHandledBySystem(bool bEnabled)
{
	SetVolumeButtonsHandledBySystem(IntPtr.Zero,bEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ControlScreensaver(IntPtr _this,int bAllowScreenSaver);
public static void ControlScreensaver(bool bAllowScreenSaver)
{
	ControlScreensaver(IntPtr.Zero,bAllowScreenSaver?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLoggedIn(IntPtr _this,IntPtr SpecificPlayer);
public static bool IsLoggedIn(APlayerController SpecificPlayer)
{
	int ___ret = IsLoggedIn(IntPtr.Zero,SpecificPlayer);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowPlatformSpecificAchievementsScreen(IntPtr _this,IntPtr SpecificPlayer);
public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer)
{
	ShowPlatformSpecificAchievementsScreen(IntPtr.Zero,SpecificPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowPlatformSpecificLeaderboardScreen(IntPtr _this,string CategoryName);
public static void ShowPlatformSpecificLeaderboardScreen(string CategoryName)
{
	ShowPlatformSpecificLeaderboardScreen(IntPtr.Zero,CategoryName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowInterstitialAd(IntPtr _this);
public static void ShowInterstitialAd()
{
	ShowInterstitialAd(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInterstitialAdRequested(IntPtr _this);
public static bool IsInterstitialAdRequested()
{
	int ___ret = IsInterstitialAdRequested(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsInterstitialAdAvailable(IntPtr _this);
public static bool IsInterstitialAdAvailable()
{
	int ___ret = IsInterstitialAdAvailable(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LoadInterstitialAd(IntPtr _this,int AdIdIndex);
public static void LoadInterstitialAd(int AdIdIndex)
{
	LoadInterstitialAd(IntPtr.Zero,AdIdIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceCloseAdBanner(IntPtr _this);
public static void ForceCloseAdBanner()
{
	ForceCloseAdBanner(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideAdBanner(IntPtr _this);
public static void HideAdBanner()
{
	HideAdBanner(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAdIDCount(IntPtr _this);
public static int GetAdIDCount()
{
	int ___ret = GetAdIDCount(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowAdBanner(IntPtr _this,int AdIdIndex,int bShowOnBottomOfScreen);
public static void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen)
{
	ShowAdBanner(IntPtr.Zero,AdIdIndex,bShowOnBottomOfScreen?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CollectGarbage(IntPtr _this);
public static void CollectGarbage()
{
	CollectGarbage(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CanLaunchURL(IntPtr _this,string URL);
public static bool CanLaunchURL(string URL)
{
	int ___ret = CanLaunchURL(IntPtr.Zero,URL);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LaunchURL(IntPtr _this,string URL);
public static void LaunchURL(string URL)
{
	LaunchURL(IntPtr.Zero,URL);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMinYResolutionFor3DView(IntPtr _this);
public static int GetMinYResolutionFor3DView()
{
	int ___ret = GetMinYResolutionFor3DView(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetMinYResolutionForUI(IntPtr _this);
public static int GetMinYResolutionForUI()
{
	int ___ret = GetMinYResolutionForUI(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetConvenientWindowedResolutions(IntPtr _this,out FIntPoint[] Resolutions);
public static bool GetConvenientWindowedResolutions(out FIntPoint[] Resolutions)
{
	int ___ret = GetConvenientWindowedResolutions(IntPtr.Zero,out Resolutions);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetSupportedFullscreenResolutions(IntPtr _this,out FIntPoint[] Resolutions);
public static bool GetSupportedFullscreenResolutions(out FIntPoint[] Resolutions)
{
	int ___ret = GetSupportedFullscreenResolutions(IntPtr.Zero,out Resolutions);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetRenderingMaterialQualityLevel(IntPtr _this);
public static int GetRenderingMaterialQualityLevel()
{
	int ___ret = GetRenderingMaterialQualityLevel(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetRenderingDetailMode(IntPtr _this);
public static int GetRenderingDetailMode()
{
	int ___ret = GetRenderingDetailMode(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetComponentBounds(IntPtr _this,IntPtr Component,out FVector Origin,out FVector BoxExtent,out float SphereRadius);
public static void GetComponentBounds(USceneComponent Component,out FVector Origin,out FVector BoxExtent,out float SphereRadius)
{
	GetComponentBounds(IntPtr.Zero,Component,out Origin,out BoxExtent,out SphereRadius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CreateCopyForUndoBuffer(IntPtr _this,IntPtr ObjectToModify);
public static void CreateCopyForUndoBuffer(UObject ObjectToModify)
{
	CreateCopyForUndoBuffer(IntPtr.Zero,ObjectToModify);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FDebugFloatHistory AddFloatHistorySample(IntPtr _this,float Value,ref FDebugFloatHistory FloatHistory);
public static FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory)
{
	FDebugFloatHistory ___ret = AddFloatHistorySample(IntPtr.Zero,Value,ref FloatHistory);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugFloatHistoryLocation(IntPtr _this,IntPtr WorldContextObject,ref FDebugFloatHistory FloatHistory,ref FVector DrawLocation,ref FVector2D DrawSize,ref FLinearColor DrawColor,float Duration);
public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f)
{
	DrawDebugFloatHistoryLocation(IntPtr.Zero,WorldContextObject,ref FloatHistory,ref DrawLocation,ref DrawSize,ref DrawColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugFloatHistoryTransform(IntPtr _this,IntPtr WorldContextObject,ref FDebugFloatHistory FloatHistory,ref FTransform DrawTransform,ref FVector2D DrawSize,ref FLinearColor DrawColor,float Duration);
public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f)
{
	DrawDebugFloatHistoryTransform(IntPtr.Zero,WorldContextObject,ref FloatHistory,ref DrawTransform,ref DrawSize,ref DrawColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugCamera(IntPtr _this,IntPtr CameraActor,ref FLinearColor CameraColor,float Duration);
public static void DrawDebugCamera(ACameraActor CameraActor,FLinearColor CameraColor=default(FLinearColor),float Duration=0.000000f)
{
	DrawDebugCamera(IntPtr.Zero,CameraActor,ref CameraColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugFrustum(IntPtr _this,IntPtr WorldContextObject,ref FTransform FrustumTransform,ref FLinearColor FrustumColor,float Duration,float Thickness);
public static void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugFrustum(IntPtr.Zero,WorldContextObject,ref FrustumTransform,ref FrustumColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushPersistentDebugLines(IntPtr _this,IntPtr WorldContextObject);
public static void FlushPersistentDebugLines(UObject WorldContextObject)
{
	FlushPersistentDebugLines(IntPtr.Zero,WorldContextObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugPlane(IntPtr _this,IntPtr WorldContextObject,ref FPlane PlaneCoordinates,ref FVector Location,float Size,ref FLinearColor PlaneColor,float Duration);
public static void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor=default(FLinearColor),float Duration=0.000000f)
{
	DrawDebugPlane(IntPtr.Zero,WorldContextObject,ref PlaneCoordinates,ref Location,Size,ref PlaneColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushDebugStrings(IntPtr _this,IntPtr WorldContextObject);
public static void FlushDebugStrings(UObject WorldContextObject)
{
	FlushDebugStrings(IntPtr.Zero,WorldContextObject);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugString(IntPtr _this,IntPtr WorldContextObject,ref FVector TextLocation,string Text,IntPtr TestBaseActor,ref FLinearColor TextColor,float Duration);
public static void DrawDebugString(UObject WorldContextObject,FVector TextLocation,string Text,AActor TestBaseActor,FLinearColor TextColor=default(FLinearColor),float Duration=0.000000f)
{
	DrawDebugString(IntPtr.Zero,WorldContextObject,ref TextLocation,Text,TestBaseActor,ref TextColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugCapsule(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float HalfHeight,float Radius,ref FRotator Rotation,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugCapsule(IntPtr.Zero,WorldContextObject,ref Center,HalfHeight,Radius,ref Rotation,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugConeInDegrees(IntPtr _this,IntPtr WorldContextObject,ref FVector Origin,ref FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length=100.000000f,float AngleWidth=45.000000f,float AngleHeight=45.000000f,int NumSides=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugConeInDegrees(IntPtr.Zero,WorldContextObject,ref Origin,ref Direction,Length,AngleWidth,AngleHeight,NumSides,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugCylinder(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int Segments,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugCylinder(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,Segments,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugSphere(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float Radius,int Segments,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugSphere(IntPtr.Zero,WorldContextObject,ref Center,Radius,Segments,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugCoordinateSystem(IntPtr _this,IntPtr WorldContextObject,ref FVector AxisLoc,ref FRotator AxisRot,float Scale,float Duration,float Thickness);
public static void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale=1.000000f,float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugCoordinateSystem(IntPtr.Zero,WorldContextObject,ref AxisLoc,ref AxisRot,Scale,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugBox(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,ref FVector Extent,ref FLinearColor LineColor,ref FRotator Rotation,float Duration,float Thickness);
public static void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation,float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugBox(IntPtr.Zero,WorldContextObject,ref Center,ref Extent,ref LineColor,ref Rotation,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugArrow(IntPtr _this,IntPtr WorldContextObject,ref FVector LineStart,ref FVector LineEnd,float ArrowSize,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugArrow(IntPtr.Zero,WorldContextObject,ref LineStart,ref LineEnd,ArrowSize,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugPoint(IntPtr _this,IntPtr WorldContextObject,ref FVector Position,float Size,ref FLinearColor PointColor,float Duration);
public static void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration=0.000000f)
{
	DrawDebugPoint(IntPtr.Zero,WorldContextObject,ref Position,Size,ref PointColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugCircle(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float Radius,int NumSegments,ref FLinearColor LineColor,float Duration,float Thickness,ref FVector YAxis,ref FVector ZAxis,int bDrawAxis);
public static void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f,FVector YAxis=default(FVector),FVector ZAxis=default(FVector),bool bDrawAxis=false)
{
	DrawDebugCircle(IntPtr.Zero,WorldContextObject,ref Center,Radius,NumSegments,ref LineColor,Duration,Thickness,ref YAxis,ref ZAxis,bDrawAxis?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawDebugLine(IntPtr _this,IntPtr WorldContextObject,ref FVector LineStart,ref FVector LineEnd,ref FLinearColor LineColor,float Duration,float Thickness);
public static void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f)
{
	DrawDebugLine(IntPtr.Zero,WorldContextObject,ref LineStart,ref LineEnd,ref LineColor,Duration,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorListFromComponentList(IntPtr _this,IntPtr[] ComponentList,IntPtr ActorClassFilter,out IntPtr[] OutActorList);
public static void GetActorListFromComponentList(UPrimitiveComponent[] ComponentList,UClass ActorClassFilter,out AActor[] OutActorList)
{
	IntPtr[] OutActorList_temp;
	GetActorListFromComponentList(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(ComponentList),ActorClassFilter,out OutActorList_temp);
	OutActorList = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActorList_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = CapsuleTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = BoxTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = SphereTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
public static bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
{
	int ___ret = LineTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ComponentOverlapComponents(IntPtr _this,IntPtr Component,ref FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
public static bool ComponentOverlapComponents(UPrimitiveComponent Component,FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
{
	IntPtr[] OutComponents_temp;
	int ___ret = ComponentOverlapComponents(IntPtr.Zero,Component,ref ComponentTransform,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
	OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ComponentOverlapActors(IntPtr _this,IntPtr Component,ref FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
public static bool ComponentOverlapActors(UPrimitiveComponent Component,FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	int ___ret = ComponentOverlapActors(IntPtr.Zero,Component,ref ComponentTransform,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
public static bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
{
	IntPtr[] OutComponents_temp;
	int ___ret = CapsuleOverlapComponents(IntPtr.Zero,WorldContextObject,ref CapsulePos,Radius,HalfHeight,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
	OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CapsuleOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
public static bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	int ___ret = CapsuleOverlapActors(IntPtr.Zero,WorldContextObject,ref CapsulePos,Radius,HalfHeight,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector BoxPos,ref FVector Extent,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
public static bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
{
	IntPtr[] OutComponents_temp;
	int ___ret = BoxOverlapComponents(IntPtr.Zero,WorldContextObject,ref BoxPos,ref Extent,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
	OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoxOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector BoxPos,ref FVector BoxExtent,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
public static bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	int ___ret = BoxOverlapActors(IntPtr.Zero,WorldContextObject,ref BoxPos,ref BoxExtent,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
public static bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
{
	IntPtr[] OutComponents_temp;
	int ___ret = SphereOverlapComponents(IntPtr.Zero,WorldContextObject,ref SpherePos,SphereRadius,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
	OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SphereOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
public static bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
{
	IntPtr[] OutActors_temp;
	int ___ret = SphereOverlapActors(IntPtr.Zero,WorldContextObject,ref SpherePos,SphereRadius,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStructurePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FGenericStruct Value);
public static void SetStructurePropertyByName(UObject Object,string PropertyName,FGenericStruct Value)
{
	SetStructurePropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCollisionProfileNameProperty(IntPtr _this,IntPtr Object,string PropertyName,ref FCollisionProfileName Value);
public static void SetCollisionProfileNameProperty(UObject Object,string PropertyName,FCollisionProfileName Value)
{
	SetCollisionProfileNameProperty(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTransformPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FTransform Value);
public static void SetTransformPropertyByName(UObject Object,string PropertyName,FTransform Value)
{
	SetTransformPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearColorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FLinearColor Value);
public static void SetLinearColorPropertyByName(UObject Object,string PropertyName,FLinearColor Value)
{
	SetLinearColorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRotatorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FRotator Value);
public static void SetRotatorPropertyByName(UObject Object,string PropertyName,FRotator Value)
{
	SetRotatorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVectorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FVector Value);
public static void SetVectorPropertyByName(UObject Object,string PropertyName,FVector Value)
{
	SetVectorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTextPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
public static void SetTextPropertyByName(UObject Object,string PropertyName,string Value)
{
	SetTextPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStringPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
public static void SetStringPropertyByName(UObject Object,string PropertyName,string Value)
{
	SetStringPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNamePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
public static void SetNamePropertyByName(UObject Object,string PropertyName,string Value)
{
	SetNamePropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetClassPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,IntPtr Value);
public static void SetClassPropertyByName(UObject Object,string PropertyName,TSubclassOf<UObject>  Value)
{
	SetClassPropertyByName(IntPtr.Zero,Object,PropertyName,Value.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetObjectPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,IntPtr Value);
public static void SetObjectPropertyByName(UObject Object,string PropertyName,UObject Value)
{
	SetObjectPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBoolPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
public static void SetBoolPropertyByName(UObject Object,string PropertyName,bool Value)
{
	SetBoolPropertyByName(IntPtr.Zero,Object,PropertyName,Value?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFloatPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,float Value);
public static void SetFloatPropertyByName(UObject Object,string PropertyName,float Value)
{
	SetFloatPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBytePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
public static void SetBytePropertyByName(UObject Object,string PropertyName,byte Value)
{
	SetBytePropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
public static void SetIntPropertyByName(UObject Object,string PropertyName,int Value)
{
	SetIntPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetTimerRemainingTime(IntPtr _this,IntPtr Object,string FunctionName);
public static float K2_GetTimerRemainingTime(UObject Object,string FunctionName)
{
	float ___ret = K2_GetTimerRemainingTime(IntPtr.Zero,Object,FunctionName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetTimerElapsedTime(IntPtr _this,IntPtr Object,string FunctionName);
public static float K2_GetTimerElapsedTime(UObject Object,string FunctionName)
{
	float ___ret = K2_GetTimerElapsedTime(IntPtr.Zero,Object,FunctionName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_TimerExists(IntPtr _this,IntPtr Object,string FunctionName);
public static bool K2_TimerExists(UObject Object,string FunctionName)
{
	int ___ret = K2_TimerExists(IntPtr.Zero,Object,FunctionName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsTimerPaused(IntPtr _this,IntPtr Object,string FunctionName);
public static bool K2_IsTimerPaused(UObject Object,string FunctionName)
{
	int ___ret = K2_IsTimerPaused(IntPtr.Zero,Object,FunctionName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsTimerActive(IntPtr _this,IntPtr Object,string FunctionName);
public static bool K2_IsTimerActive(UObject Object,string FunctionName)
{
	int ___ret = K2_IsTimerActive(IntPtr.Zero,Object,FunctionName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_UnPauseTimer(IntPtr _this,IntPtr Object,string FunctionName);
public static void K2_UnPauseTimer(UObject Object,string FunctionName)
{
	K2_UnPauseTimer(IntPtr.Zero,Object,FunctionName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_PauseTimer(IntPtr _this,IntPtr Object,string FunctionName);
public static void K2_PauseTimer(UObject Object,string FunctionName)
{
	K2_PauseTimer(IntPtr.Zero,Object,FunctionName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_ClearTimer(IntPtr _this,IntPtr Object,string FunctionName);
public static void K2_ClearTimer(UObject Object,string FunctionName)
{
	K2_ClearTimer(IntPtr.Zero,Object,FunctionName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimerHandle K2_SetTimer(IntPtr _this,IntPtr Object,string FunctionName,float Time,int bLooping);
public static FTimerHandle K2_SetTimer(UObject Object,string FunctionName,float Time,bool bLooping)
{
	FTimerHandle ___ret = K2_SetTimer(IntPtr.Zero,Object,FunctionName,Time,bLooping?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetTimerRemainingTimeHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	float ___ret = K2_GetTimerRemainingTimeHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float K2_GetTimerElapsedTimeHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	float ___ret = K2_GetTimerElapsedTimeHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_TimerExistsHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	int ___ret = K2_TimerExistsHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsTimerPausedHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	int ___ret = K2_IsTimerPausedHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsTimerActiveHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	int ___ret = K2_IsTimerActiveHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_UnPauseTimerHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	K2_UnPauseTimerHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_PauseTimerHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
public static void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle)
{
	K2_PauseTimerHandle(IntPtr.Zero,WorldContextObject,ref Handle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_ClearAndInvalidateTimerHandle(IntPtr _this,IntPtr WorldContextObject,out FTimerHandle Handle);
public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,out FTimerHandle Handle)
{
	K2_ClearAndInvalidateTimerHandle(IntPtr.Zero,WorldContextObject,out Handle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FTimerHandle K2_InvalidateTimerHandle(IntPtr _this,out FTimerHandle Handle);
public static FTimerHandle K2_InvalidateTimerHandle(out FTimerHandle Handle)
{
	FTimerHandle ___ret = K2_InvalidateTimerHandle(IntPtr.Zero,out Handle);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int K2_IsValidTimerHandle(IntPtr _this,ref FTimerHandle Handle);
public static bool K2_IsValidTimerHandle(FTimerHandle Handle)
{
	int ___ret = K2_IsValidTimerHandle(IntPtr.Zero,ref Handle);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveComponentTo(IntPtr _this,IntPtr Component,ref FVector TargetRelativeLocation,ref FRotator TargetRelativeRotation,int bEaseOut,int bEaseIn,float OverTime,int bForceShortestRotationPath,int MoveAction,ref FLatentActionInfo LatentInfo);
public static void MoveComponentTo(USceneComponent Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,EMoveComponentAction MoveAction,FLatentActionInfo LatentInfo)
{
	MoveComponentTo(IntPtr.Zero,Component,ref TargetRelativeLocation,ref TargetRelativeRotation,bEaseOut?1:0,bEaseIn?1:0,OverTime,bForceShortestRotationPath?1:0,(int)MoveAction,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RetriggerableDelay(IntPtr _this,IntPtr WorldContextObject,float Duration,ref FLatentActionInfo LatentInfo);
public static void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo)
{
	RetriggerableDelay(IntPtr.Zero,WorldContextObject,Duration,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Delay(IntPtr _this,IntPtr WorldContextObject,float Duration,ref FLatentActionInfo LatentInfo);
public static void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo)
{
	Delay(IntPtr.Zero,WorldContextObject,Duration,ref LatentInfo);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void QuitGame(IntPtr _this,IntPtr WorldContextObject,IntPtr SpecificPlayer,int QuitPreference);
public static void QuitGame(UObject WorldContextObject,APlayerController SpecificPlayer,EQuitPreference QuitPreference)
{
	QuitGame(IntPtr.Zero,WorldContextObject,SpecificPlayer,(int)QuitPreference);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ExecuteConsoleCommand(IntPtr _this,IntPtr WorldContextObject,string Command,IntPtr SpecificPlayer);
public static void ExecuteConsoleCommand(UObject WorldContextObject,string Command,APlayerController SpecificPlayer)
{
	ExecuteConsoleCommand(IntPtr.Zero,WorldContextObject,Command,SpecificPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWindowTitle(IntPtr _this,string Title);
public static void SetWindowTitle(string Title)
{
	SetWindowTitle(IntPtr.Zero,Title);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PrintWarning(IntPtr _this,string InString);
public static void PrintWarning(string InString)
{
	PrintWarning(IntPtr.Zero,InString);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PrintText(IntPtr _this,IntPtr WorldContextObject,string InText,int bPrintToScreen,int bPrintToLog,ref FLinearColor TextColor,float Duration);
public static void PrintText(UObject WorldContextObject,string InText="Hello",bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f)
{
	PrintText(IntPtr.Zero,WorldContextObject,InText,bPrintToScreen?1:0,bPrintToLog?1:0,ref TextColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PrintString(IntPtr _this,IntPtr WorldContextObject,string InString,int bPrintToScreen,int bPrintToLog,ref FLinearColor TextColor,float Duration);
public static void PrintString(UObject WorldContextObject,string InString="Hello",bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f)
{
	PrintString(IntPtr.Zero,WorldContextObject,InString,bPrintToScreen?1:0,bPrintToLog?1:0,ref TextColor,Duration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string MakeLiteralText(IntPtr _this,string Value);
public static string MakeLiteralText(string Value)
{
	string ___ret = MakeLiteralText(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string MakeLiteralString(IntPtr _this,string Value);
public static string MakeLiteralString(string Value)
{
	string ___ret = MakeLiteralString(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int MakeLiteralByte(IntPtr _this,int Value);
public static byte MakeLiteralByte(byte Value)
{
	int ___ret = MakeLiteralByte(IntPtr.Zero,Value);
	return (byte)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string MakeLiteralName(IntPtr _this,string Value);
public static string MakeLiteralName(string Value)
{
	string ___ret = MakeLiteralName(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int MakeLiteralBool(IntPtr _this,int Value);
public static bool MakeLiteralBool(bool Value)
{
	int ___ret = MakeLiteralBool(IntPtr.Zero,Value?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float MakeLiteralFloat(IntPtr _this,float Value);
public static float MakeLiteralFloat(float Value)
{
	float ___ret = MakeLiteralFloat(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int MakeLiteralInt(IntPtr _this,int Value);
public static int MakeLiteralInt(int Value)
{
	int ___ret = MakeLiteralInt(IntPtr.Zero,Value);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetDeviceId(IntPtr _this);
public static string GetDeviceId()
{
	string ___ret = GetDeviceId(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPackagedForDistribution(IntPtr _this);
public static bool IsPackagedForDistribution()
{
	int ___ret = IsPackagedForDistribution(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsStandalone(IntPtr _this,IntPtr WorldContextObject);
public static bool IsStandalone(UObject WorldContextObject)
{
	int ___ret = IsStandalone(IntPtr.Zero,WorldContextObject);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsDedicatedServer(IntPtr _this,IntPtr WorldContextObject);
public static bool IsDedicatedServer(UObject WorldContextObject)
{
	int ___ret = IsDedicatedServer(IntPtr.Zero,WorldContextObject);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsServer(IntPtr _this,IntPtr WorldContextObject);
public static bool IsServer(UObject WorldContextObject)
{
	int ___ret = IsServer(IntPtr.Zero,WorldContextObject);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetGameTimeInSeconds(IntPtr _this,IntPtr WorldContextObject);
public static float GetGameTimeInSeconds(UObject WorldContextObject)
{
	float ___ret = GetGameTimeInSeconds(IntPtr.Zero,WorldContextObject);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int DoesImplementInterface(IntPtr _this,IntPtr TestObject,IntPtr Interface);
public static bool DoesImplementInterface(UObject TestObject,TSubclassOf<UInterface>  Interface)
{
	int ___ret = DoesImplementInterface(IntPtr.Zero,TestObject,Interface.NativeClass);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetPlatformUserName(IntPtr _this);
public static string GetPlatformUserName()
{
	string ___ret = GetPlatformUserName(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetGameBundleId(IntPtr _this);
public static string GetGameBundleId()
{
	string ___ret = GetGameBundleId(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetGameName(IntPtr _this);
public static string GetGameName()
{
	string ___ret = GetGameName(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetEngineVersion(IntPtr _this);
public static string GetEngineVersion()
{
	string ___ret = GetEngineVersion(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetClassDisplayName(IntPtr _this,IntPtr Class);
public static string GetClassDisplayName(UClass Class)
{
	string ___ret = GetClassDisplayName(IntPtr.Zero,Class);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetDisplayName(IntPtr _this,IntPtr Object);
public static string GetDisplayName(UObject Object)
{
	string ___ret = GetDisplayName(IntPtr.Zero,Object);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetPathName(IntPtr _this,IntPtr Object);
public static string GetPathName(UObject Object)
{
	string ___ret = GetPathName(IntPtr.Zero,Object);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetObjectName(IntPtr _this,IntPtr Object);
public static string GetObjectName(UObject Object)
{
	string ___ret = GetObjectName(IntPtr.Zero,Object);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsValidClass(IntPtr _this,IntPtr Class);
public static bool IsValidClass(UClass Class)
{
	int ___ret = IsValidClass(IntPtr.Zero,Class);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsValid(IntPtr _this,IntPtr Object);
public static bool IsValid(UObject Object)
{
	int ___ret = IsValid(IntPtr.Zero,Object);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
