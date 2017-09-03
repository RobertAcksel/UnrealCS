//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetSystemLibrary:UBlueprintFunctionLibrary 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetCommandLine(IntPtr _this);
	
	/// <summary>Returns the command line that the process was launched with.</summary>
	public static string GetCommandLine()
	{
		string ___ret = GetCommandLine(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUserActivity(IntPtr _this,ref FUserActivity UserActivity);
	
	/// <summary>Tells the engine what the user is doing for debug, analytics, etc.</summary>
	public static void SetUserActivity(FUserActivity UserActivity)
	{
		SetUserActivity(IntPtr.Zero,ref UserActivity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RegisterForRemoteNotifications(IntPtr _this);
	
	/// <summary>
	/// Requests permission to send remote notifications to the user's device.
	/// (iOS only)
	/// </summary>
	public static void RegisterForRemoteNotifications()
	{
		RegisterForRemoteNotifications(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetLocalCurrencySymbol(IntPtr _this);
	
	/// <summary>
	/// Returns the currency symbol associated with the device's locale
	/// @return the currency symbol associated with the device's locale
	/// </summary>
	public static string GetLocalCurrencySymbol()
	{
		string ___ret = GetLocalCurrencySymbol(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetLocalCurrencyCode(IntPtr _this);
	
	/// <summary>
	/// Returns the currency code associated with the device's locale
	/// @return the currency code associated with the device's locale
	/// </summary>
	public static string GetLocalCurrencyCode()
	{
		string ___ret = GetLocalCurrencyCode(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetDefaultLocale(IntPtr _this);
	
	/// <summary>
	/// Returns the user's preferred language and region
	/// @return A language ID indicating the user's language and region
	/// </summary>
	public static string GetDefaultLocale()
	{
		string ___ret = GetDefaultLocale(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FString[] GetPreferredLanguages(IntPtr _this);
	
	/// <summary>
	/// Returns an array of the user's preferred languages in order of preference
	/// @return An array of language IDs ordered from most preferred to least
	/// </summary>
	public static FString[] GetPreferredLanguages()
	{
		FString[] ___ret = GetPreferredLanguages(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSuppressViewportTransitionMessage(IntPtr _this,IntPtr WorldContextObject,int bState);
	
	/// <summary>
	/// Sets the state of the transition message rendered by the viewport. (The blue text displayed when the game is paused and so forth.)
	/// @param WorldContextObject    World context
	/// @param State                                 set true to suppress transition message
	/// </summary>
	public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState)
	{
		SetSuppressViewportTransitionMessage(IntPtr.Zero,WorldContextObject,bState?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsControllerAssignedToGamepad(IntPtr _this,int ControllerId);
	
	/// <summary>Returns true if controller id assigned to a gamepad (Android only)</summary>
	public static bool IsControllerAssignedToGamepad(int ControllerId)
	{
		int ___ret = IsControllerAssignedToGamepad(IntPtr.Zero,ControllerId);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetGamepadAssignmentToController(IntPtr _this,int ControllerId);
	
	/// <summary>* Resets the gamepad assignment to player controller id (Android only)</summary>
	public static void ResetGamepadAssignmentToController(int ControllerId)
	{
		ResetGamepadAssignmentToController(IntPtr.Zero,ControllerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetGamepadAssignments(IntPtr _this);
	
	/// <summary>Resets the gamepad to player controller id assignments (Android only)</summary>
	public static void ResetGamepadAssignments()
	{
		ResetGamepadAssignments(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetVolumeButtonsHandledBySystem(IntPtr _this);
	
	/// <summary>Returns true if system default handling of volume up and volume down buttons enabled (Android only)</summary>
	public static bool GetVolumeButtonsHandledBySystem()
	{
		int ___ret = GetVolumeButtonsHandledBySystem(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVolumeButtonsHandledBySystem(IntPtr _this,int bEnabled);
	
	/// <summary>
	/// Allows or inhibits system default handling of volume up and volume down buttons (Android only)
	/// @param       bEnabled                                If true, allow Android to handle volume up and down events
	/// </summary>
	public static void SetVolumeButtonsHandledBySystem(bool bEnabled)
	{
		SetVolumeButtonsHandledBySystem(IntPtr.Zero,bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ControlScreensaver(IntPtr _this,int bAllowScreenSaver);
	
	/// <summary>
	/// Allows or inhibits screensaver
	/// @param       bAllowScreenSaver               If false, don't allow screensaver if possible, otherwise allow default behavior
	/// </summary>
	public static void ControlScreensaver(bool bAllowScreenSaver)
	{
		ControlScreensaver(IntPtr.Zero,bAllowScreenSaver?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLoggedIn(IntPtr _this,IntPtr SpecificPlayer);
	
	/// <summary>
	/// Returns whether the player is logged in to the currently active online subsystem.
	/// @param Player Specific player's login status to get. May not be supported on all platforms. If null, defaults to the player with ControllerId 0.
	/// </summary>
	public static bool IsLoggedIn(APlayerController SpecificPlayer)
	{
		int ___ret = IsLoggedIn(IntPtr.Zero,SpecificPlayer);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowPlatformSpecificAchievementsScreen(IntPtr _this,IntPtr SpecificPlayer);
	
	/// <summary>
	/// Displays the built-in achievements GUI (iOS and Android only; this function may be renamed or moved in a future release)
	/// @param SpecificPlayer Specific player's achievements to show. May not be supported on all platforms. If null, defaults to the player with ControllerId 0
	/// </summary>
	public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer)
	{
		ShowPlatformSpecificAchievementsScreen(IntPtr.Zero,SpecificPlayer);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowPlatformSpecificLeaderboardScreen(IntPtr _this,string CategoryName);
	
	/// <summary>Displays the built-in leaderboard GUI (iOS and Android only; this function may be renamed or moved in a future release)</summary>
	public static void ShowPlatformSpecificLeaderboardScreen(string CategoryName)
	{
		ShowPlatformSpecificLeaderboardScreen(IntPtr.Zero,CategoryName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowInterstitialAd(IntPtr _this);
	
	/// <summary>
	/// Shows the loaded interstitial ad (loaded with LoadInterstitialAd)
	/// (Android only)
	/// </summary>
	public static void ShowInterstitialAd()
	{
		ShowInterstitialAd(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInterstitialAdRequested(IntPtr _this);
	
	/// <summary>
	/// Returns true if the requested interstitial ad has been successfully requested (false if load request fails)
	/// (Android only)
	/// </summary>
	public static bool IsInterstitialAdRequested()
	{
		int ___ret = IsInterstitialAdRequested(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInterstitialAdAvailable(IntPtr _this);
	
	/// <summary>
	/// Returns true if the requested interstitial ad is loaded and ready
	/// (Android only)
	/// </summary>
	public static bool IsInterstitialAdAvailable()
	{
		int ___ret = IsInterstitialAdAvailable(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void LoadInterstitialAd(IntPtr _this,int AdIdIndex);
	
	/// <summary>
	/// Will load a fullscreen interstitial AdMob ad. Call this before using ShowInterstitialAd
	/// (Android only)
	/// @param AdIdIndex The index of the ID to select for the ad to show
	/// </summary>
	public static void LoadInterstitialAd(int AdIdIndex)
	{
		LoadInterstitialAd(IntPtr.Zero,AdIdIndex);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceCloseAdBanner(IntPtr _this);
	
	/// <summary>
	/// Forces closed any displayed ad. Can lead to loss of revenue
	/// (iOS and Android only)
	/// </summary>
	public static void ForceCloseAdBanner()
	{
		ForceCloseAdBanner(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void HideAdBanner(IntPtr _this);
	
	/// <summary>
	/// Hides the ad banner (iAd on iOS, or AdMob on Android). Will force close the ad if it's open
	/// (iOS and Android only)
	/// </summary>
	public static void HideAdBanner()
	{
		HideAdBanner(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetAdIDCount(IntPtr _this);
	
	/// <summary>Retrieves the total number of Ad IDs that can be selected between</summary>
	public static int GetAdIDCount()
	{
		int ___ret = GetAdIDCount(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowAdBanner(IntPtr _this,int AdIdIndex,int bShowOnBottomOfScreen);
	
	/// <summary>
	/// Will show an ad banner (iAd on iOS, or AdMob on Android) on the top or bottom of screen, on top of the GL view (doesn't resize the view)
	/// (iOS and Android only)
	/// @param AdIdIndex The index of the ID to select for the ad to show
	/// @param bShowOnBottomOfScreen If true, the iAd will be shown at the bottom of the screen, top otherwise
	/// </summary>
	public static void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen)
	{
		ShowAdBanner(IntPtr.Zero,AdIdIndex,bShowOnBottomOfScreen?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CollectGarbage(IntPtr _this);
	
	/// <summary>
	/// Deletes all unreferenced objects, keeping only referenced objects (this command will be queued and happen at the end of the frame)
	/// Note: This can be a slow operation, and should only be performed where a hitch would be acceptable
	/// </summary>
	public static void CollectGarbage()
	{
		CollectGarbage(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CanLaunchURL(IntPtr _this,string URL);
	
	public static bool CanLaunchURL(string URL)
	{
		int ___ret = CanLaunchURL(IntPtr.Zero,URL);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void LaunchURL(IntPtr _this,string URL);
	
	/// <summary>Opens the specified URL in the platform's web browser of choice</summary>
	public static void LaunchURL(string URL)
	{
		LaunchURL(IntPtr.Zero,URL);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMinYResolutionFor3DView(IntPtr _this);
	
	/// <summary>
	/// Gets the smallest Y resolution we want to support in the 3D view, clamped within reasons
	/// @return value in pixels
	/// </summary>
	public static int GetMinYResolutionFor3DView()
	{
		int ___ret = GetMinYResolutionFor3DView(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMinYResolutionForUI(IntPtr _this);
	
	/// <summary>
	/// Gets the smallest Y resolution we want to support in the UI, clamped within reasons
	/// @return value in pixels
	/// </summary>
	public static int GetMinYResolutionForUI()
	{
		int ___ret = GetMinYResolutionForUI(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetConvenientWindowedResolutions(IntPtr _this,out FIntPoint[] Resolutions);
	
	/// <summary>
	/// Gets the list of windowed resolutions which are convenient for the current primary display size.
	/// @return true if successfully queried the device for available resolutions.
	/// </summary>
	public static bool GetConvenientWindowedResolutions(out FIntPoint[] Resolutions)
	{
		int ___ret = GetConvenientWindowedResolutions(IntPtr.Zero,out Resolutions);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetSupportedFullscreenResolutions(IntPtr _this,out FIntPoint[] Resolutions);
	
	/// <summary>
	/// Gets the list of support fullscreen resolutions.
	/// @return true if successfully queried the device for available resolutions.
	/// </summary>
	public static bool GetSupportedFullscreenResolutions(out FIntPoint[] Resolutions)
	{
		int ___ret = GetSupportedFullscreenResolutions(IntPtr.Zero,out Resolutions);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetRenderingMaterialQualityLevel(IntPtr _this);
	
	/// <summary>
	/// Get the clamped state of r.MaterialQualityLevel, see console variable help (allows for scalability, cannot be used in construction scripts)
	/// 0: low
	/// 1: high
	/// 2: medium
	/// </summary>
	public static int GetRenderingMaterialQualityLevel()
	{
		int ___ret = GetRenderingMaterialQualityLevel(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetRenderingDetailMode(IntPtr _this);
	
	/// <summary>
	/// Get the clamped state of r.DetailMode, see console variable help (allows for scalability, cannot be used in construction scripts)
	/// 0: low, show only object with DetailMode low or higher
	/// 1: medium, show all object with DetailMode medium or higher
	/// 2: high, show all objects
	/// </summary>
	public static int GetRenderingDetailMode()
	{
		int ___ret = GetRenderingDetailMode(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetComponentBounds(IntPtr _this,IntPtr Component,out FVector Origin,out FVector BoxExtent,out float SphereRadius);
	
	/// <summary>Get bounds</summary>
	public static void GetComponentBounds(USceneComponent Component,out FVector Origin,out FVector BoxExtent,out float SphereRadius)
	{
		GetComponentBounds(IntPtr.Zero,Component,out Origin,out BoxExtent,out SphereRadius);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CreateCopyForUndoBuffer(IntPtr _this,IntPtr ObjectToModify);
	
	/// <summary>Mark as modified.</summary>
	public static void CreateCopyForUndoBuffer(UObject ObjectToModify)
	{
		CreateCopyForUndoBuffer(IntPtr.Zero,ObjectToModify);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDebugFloatHistory AddFloatHistorySample(IntPtr _this,float Value,ref FDebugFloatHistory FloatHistory);
	
	public static FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory)
	{
		FDebugFloatHistory ___ret = AddFloatHistorySample(IntPtr.Zero,Value,ref FloatHistory);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugFloatHistoryLocation(IntPtr _this,IntPtr WorldContextObject,ref FDebugFloatHistory FloatHistory,ref FVector DrawLocation,ref FVector2D DrawSize,ref FLinearColor DrawColor,float Duration);
	
	/// <summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawLocation for the location in the world, rotation will face camera of first player.</summary>
	public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f)
	{
		DrawDebugFloatHistoryLocation(IntPtr.Zero,WorldContextObject,ref FloatHistory,ref DrawLocation,ref DrawSize,ref DrawColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugFloatHistoryTransform(IntPtr _this,IntPtr WorldContextObject,ref FDebugFloatHistory FloatHistory,ref FTransform DrawTransform,ref FVector2D DrawSize,ref FLinearColor DrawColor,float Duration);
	
	/// <summary>Draws a 2D Histogram of size 'DrawSize' based FDebugFloatHistory struct, using DrawTransform for the position in the world.</summary>
	public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor=default(FLinearColor),float Duration=0.000000f)
	{
		DrawDebugFloatHistoryTransform(IntPtr.Zero,WorldContextObject,ref FloatHistory,ref DrawTransform,ref DrawSize,ref DrawColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugCamera(IntPtr _this,IntPtr CameraActor,ref FLinearColor CameraColor,float Duration);
	
	/// <summary>Draw a debug camera shape.</summary>
	public static void DrawDebugCamera(ACameraActor CameraActor,FLinearColor CameraColor=default(FLinearColor),float Duration=0.000000f)
	{
		DrawDebugCamera(IntPtr.Zero,CameraActor,ref CameraColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugFrustum(IntPtr _this,IntPtr WorldContextObject,ref FTransform FrustumTransform,ref FLinearColor FrustumColor,float Duration,float Thickness);
	
	/// <summary>Draws a debug frustum.</summary>
	public static void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugFrustum(IntPtr.Zero,WorldContextObject,ref FrustumTransform,ref FrustumColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FlushPersistentDebugLines(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>
	/// Flush all persistent debug lines and shapes.
	/// @param WorldContext  World context
	/// </summary>
	public static void FlushPersistentDebugLines(UObject WorldContextObject)
	{
		FlushPersistentDebugLines(IntPtr.Zero,WorldContextObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugPlane(IntPtr _this,IntPtr WorldContextObject,ref FPlane PlaneCoordinates,ref FVector Location,float Size,ref FLinearColor PlaneColor,float Duration);
	
	/// <summary>Draws a debug plane.</summary>
	public static void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor=default(FLinearColor),float Duration=0.000000f)
	{
		DrawDebugPlane(IntPtr.Zero,WorldContextObject,ref PlaneCoordinates,ref Location,Size,ref PlaneColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FlushDebugStrings(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>
	/// Removes all debug strings.
	/// @param WorldContext  World context
	/// </summary>
	public static void FlushDebugStrings(UObject WorldContextObject)
	{
		FlushDebugStrings(IntPtr.Zero,WorldContextObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugString(IntPtr _this,IntPtr WorldContextObject,ref FVector TextLocation,string Text,IntPtr TestBaseActor,ref FLinearColor TextColor,float Duration);
	
	/// <summary>Draw a debug string at a 3d world location.</summary>
	public static void DrawDebugString(UObject WorldContextObject,FVector TextLocation,string Text,AActor TestBaseActor,FLinearColor TextColor=default(FLinearColor),float Duration=0.000000f)
	{
		DrawDebugString(IntPtr.Zero,WorldContextObject,ref TextLocation,Text,TestBaseActor,ref TextColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugCapsule(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float HalfHeight,float Radius,ref FRotator Rotation,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>Draw a debug capsule</summary>
	public static void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugCapsule(IntPtr.Zero,WorldContextObject,ref Center,HalfHeight,Radius,ref Rotation,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugConeInDegrees(IntPtr _this,IntPtr WorldContextObject,ref FVector Origin,ref FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>
	/// Draw a debug cone
	/// Angles are specified in degrees
	/// </summary>
	public static void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length=100.000000f,float AngleWidth=45.000000f,float AngleHeight=45.000000f,int NumSides=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugConeInDegrees(IntPtr.Zero,WorldContextObject,ref Origin,ref Direction,Length,AngleWidth,AngleHeight,NumSides,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugCylinder(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int Segments,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>Draw a debug cylinder</summary>
	public static void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugCylinder(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,Segments,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugSphere(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float Radius,int Segments,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>Draw a debug sphere</summary>
	public static void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius=100.000000f,int Segments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugSphere(IntPtr.Zero,WorldContextObject,ref Center,Radius,Segments,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugCoordinateSystem(IntPtr _this,IntPtr WorldContextObject,ref FVector AxisLoc,ref FRotator AxisRot,float Scale,float Duration,float Thickness);
	
	/// <summary>Draw a debug coordinate system.</summary>
	public static void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale=1.000000f,float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugCoordinateSystem(IntPtr.Zero,WorldContextObject,ref AxisLoc,ref AxisRot,Scale,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugBox(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,ref FVector Extent,ref FLinearColor LineColor,ref FRotator Rotation,float Duration,float Thickness);
	
	/// <summary>Draw a debug box</summary>
	public static void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation,float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugBox(IntPtr.Zero,WorldContextObject,ref Center,ref Extent,ref LineColor,ref Rotation,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugArrow(IntPtr _this,IntPtr WorldContextObject,ref FVector LineStart,ref FVector LineEnd,float ArrowSize,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>Draw directional arrow, pointing from LineStart to LineEnd.</summary>
	public static void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugArrow(IntPtr.Zero,WorldContextObject,ref LineStart,ref LineEnd,ArrowSize,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugPoint(IntPtr _this,IntPtr WorldContextObject,ref FVector Position,float Size,ref FLinearColor PointColor,float Duration);
	
	/// <summary>Draw a debug point</summary>
	public static void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration=0.000000f)
	{
		DrawDebugPoint(IntPtr.Zero,WorldContextObject,ref Position,Size,ref PointColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugCircle(IntPtr _this,IntPtr WorldContextObject,ref FVector Center,float Radius,int NumSegments,ref FLinearColor LineColor,float Duration,float Thickness,ref FVector YAxis,ref FVector ZAxis,int bDrawAxis);
	
	/// <summary>Draw a debug circle!</summary>
	public static void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments=12,FLinearColor LineColor=default(FLinearColor),float Duration=0.000000f,float Thickness=0.000000f,FVector YAxis=default(FVector),FVector ZAxis=default(FVector),bool bDrawAxis=false)
	{
		DrawDebugCircle(IntPtr.Zero,WorldContextObject,ref Center,Radius,NumSegments,ref LineColor,Duration,Thickness,ref YAxis,ref ZAxis,bDrawAxis?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DrawDebugLine(IntPtr _this,IntPtr WorldContextObject,ref FVector LineStart,ref FVector LineEnd,ref FLinearColor LineColor,float Duration,float Thickness);
	
	/// <summary>Draw a debug line</summary>
	public static void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration=0.000000f,float Thickness=0.000000f)
	{
		DrawDebugLine(IntPtr.Zero,WorldContextObject,ref LineStart,ref LineEnd,ref LineColor,Duration,Thickness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetActorListFromComponentList(IntPtr _this,IntPtr[] ComponentList,IntPtr ActorClassFilter,out IntPtr[] OutActorList);
	
	/// <summary>
	/// Returns an array of unique actors represented by the given list of components.
	/// @param ComponentList         List of components.
	/// @param ClassFilter           If set, will only return results of this class or subclasses of it.
	/// @param OutActorList          Start of line segment.
	/// </summary>
	public static void GetActorListFromComponentList(UPrimitiveComponent[] ComponentList,UClass ActorClassFilter,out AActor[] OutActorList)
	{
		IntPtr[] OutActorList_temp;
		GetActorListFromComponentList(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(ComponentList),ActorClassFilter,out OutActorList_temp);
		OutActorList = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActorList_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a capsule against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
	/// Results are sorted, so a blocking hit (if found) will be the last element of the array
	/// Only the single closest blocking result will be generated, no tests will be done after that
	/// @param WorldContext   World context
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Radius                 Radius of the capsule to sweep
	/// @param HalfHeight             Distance from center of capsule to tip of hemisphere endcap.
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                               True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a capsule against the world and return the first blocking hit using a specific profile
	/// @param WorldContext   World context
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Radius                 Radius of the capsule to sweep
	/// @param HalfHeight             Distance from center of capsule to tip of hemisphere endcap.
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a box against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
	/// Results are sorted, so a blocking hit (if found) will be the last element of the array
	/// Only the single closest blocking result will be generated, no tests will be done after that
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param HalfSize           Distance from the center of box along each axis
	/// @param Orientation    Orientation of the box
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHits                A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
	/// @return                               True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a box against the world and return the first blocking hit using a specific profile
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param HalfSize           Distance from the center of box along each axis
	/// @param Orientation    Orientation of the box
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a sphere against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit
	/// Results are sorted, so a blocking hit (if found) will be the last element of the array
	/// Only the single closest blocking result will be generated, no tests will be done after that
	/// @param WorldContext   World context
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Radius         Radius of the sphere to sweep
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                               True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweep a sphere against the world and return the first blocking hit using a specific profile
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Radius                 Radius of the sphere to sweep
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceMultiByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Trace a ray against the world using a specific profile and return overlapping hits and then first blocking hit
	/// Results are sorted, so a blocking hit (if found) will be the last element of the array
	/// Only the single closest blocking result will be generated, no tests will be done after that
	/// @param WorldContext   World context
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit         Properties of the trace hit.
	/// @return                               True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceMultiByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceSingleByProfile(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,string ProfileName,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Trace a ray against the world using a specific profile and return the first blocking hit
	/// @param WorldContext   World context
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param ProfileName    The 'profile' used to determine which components to hit
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceSingleByProfile(IntPtr.Zero,WorldContextObject,ref Start,ref End,ProfileName,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a capsule along the given line and returns all hits encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the capsule to sweep
	/// @param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a capsule along the given line and returns the first hit encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the capsule to sweep
	/// @param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a box along the given line and returns all hits encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Orientation
	/// @param HalfSize               Radius of the sphere to sweep
	/// @param ObjectTypes    Array of Object Types to trace
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHits                A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a box along the given line and returns the first hit encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param Orientation
	/// @param HalfSize               Radius of the sphere to sweep
	/// @param ObjectTypes    Array of Object Types to trace
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a sphere along the given line and returns all hits encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the sphere to sweep
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a sphere along the given line and returns the first hit encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the sphere to sweep
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceMultiForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Does a collision trace along the given line and returns all hits encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceMultiForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceSingleForObjects(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Does a collision trace along the given line and returns the first hit encountered.
	/// This only finds objects that are of a type specified by ObjectTypes.
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param ObjectTypes   Array of Object Types to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceSingleForObjects(IntPtr.Zero,WorldContextObject,ref Start,ref End,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a capsule along the given line and returns all hits encountered up to and including the first blocking hit.
	/// This trace finds the objects that RESPOND to the given TraceChannel
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the capsule to sweep
	/// @param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
	/// @param TraceChannel
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                              True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,float HalfHeight,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a capsule along the given line and returns the first blocking hit encountered.
	/// This trace finds the objects that RESPOND to the given TraceChannel
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the capsule to sweep
	/// @param HalfHeight    Distance from center of capsule to tip of hemisphere endcap.
	/// @param TraceChannel
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = CapsuleTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,HalfHeight,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a box along the given line and returns all hits encountered.
	/// This trace finds the objects that RESPONDS to the given TraceChannel
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param HalfSize           Distance from the center of box along each axis
	/// @param Orientation    Orientation of the box
	/// @param TraceChannel
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHits                A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
	/// @return                               True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,ref FVector HalfSize,ref FRotator Orientation,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a box along the given line and returns the first blocking hit encountered.
	/// This trace finds the objects that RESPONDS to the given TraceChannel
	/// @param Start                  Start of line segment.
	/// @param End                    End of line segment.
	/// @param HalfSize           Distance from the center of box along each axis
	/// @param Orientation    Orientation of the box
	/// @param TraceChannel
	/// @param bTraceComplex  True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                 Properties of the trace hit.
	/// @return                               True if there was a hit, false otherwise.
	/// </summary>
	public static bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = BoxTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,ref HalfSize,ref Orientation,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a sphere along the given line and returns all hits encountered up to and including the first blocking hit.
	/// This trace finds the objects that RESPOND to the given TraceChannel
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the sphere to sweep
	/// @param TraceChannel
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHits               A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
	/// @return                              True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,float Radius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Sweeps a sphere along the given line and returns the first blocking hit encountered.
	/// This trace finds the objects that RESPONDS to the given TraceChannel
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param Radius                Radius of the sphere to sweep
	/// @param TraceChannel
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = SphereTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,Radius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceMulti(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult[] OutHits,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Does a collision trace along the given line and returns all hits encountered up to and including the first blocking hit.
	/// This trace finds the objects that RESPOND to the given TraceChannel
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param TraceChannel  The channel to trace
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a blocking hit, false otherwise.
	/// </summary>
	public static bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult[] OutHits,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceMulti(IntPtr.Zero,WorldContextObject,ref Start,ref End,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHits,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LineTraceSingle(IntPtr _this,IntPtr WorldContextObject,ref FVector Start,ref FVector End,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,out FHitResult OutHit,int bIgnoreSelf,ref FLinearColor TraceColor,ref FLinearColor TraceHitColor,float DrawTime);
	
	/// <summary>
	/// Does a collision trace along the given line and returns the first blocking hit encountered.
	/// This trace finds the objects that RESPONDS to the given TraceChannel
	/// @param WorldContext  World context
	/// @param Start                 Start of line segment.
	/// @param End                   End of line segment.
	/// @param TraceChannel
	/// @param bTraceComplex True to test against complex collision, false to test against simplified collision.
	/// @param OutHit                Properties of the trace hit.
	/// @return                              True if there was a hit, false otherwise.
	/// </summary>
	public static bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,out FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor=default(FLinearColor),FLinearColor TraceHitColor=default(FLinearColor),float DrawTime=5.000000f)
	{
		int ___ret = LineTraceSingle(IntPtr.Zero,WorldContextObject,ref Start,ref End,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,out OutHit,bIgnoreSelf?1:0,ref TraceColor,ref TraceHitColor,DrawTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ComponentOverlapComponents(IntPtr _this,IntPtr Component,ref FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
	
	/// <summary>
	/// Returns an array of components that overlap the given component.
	/// @param Component                             Component to test with.
	/// @param ComponentTransform    Defines where to place the component for overlap testing.
	/// @param Filter                                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter                   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors                             Returned array of actors. Unsorted.
	/// @return                                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool ComponentOverlapComponents(UPrimitiveComponent Component,FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
	{
		IntPtr[] OutComponents_temp;
		int ___ret = ComponentOverlapComponents(IntPtr.Zero,Component,ref ComponentTransform,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
		OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ComponentOverlapActors(IntPtr _this,IntPtr Component,ref FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
	
	/// <summary>
	/// Returns an array of actors that overlap the given component.
	/// @param Component                             Component to test with.
	/// @param ComponentTransform    Defines where to place the component for overlap testing.
	/// @param Filter                                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter                   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors                             Returned array of actors. Unsorted.
	/// @return                                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool ComponentOverlapActors(UPrimitiveComponent Component,FTransform ComponentTransform,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		int ___ret = ComponentOverlapActors(IntPtr.Zero,Component,ref ComponentTransform,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
	
	/// <summary>
	/// Returns an array of components that overlap the given capsule.
	/// @param WorldContext  World context
	/// @param CapsulePos    Center of the capsule.
	/// @param Radius                Radius of capsule hemispheres and radius of center cylinder portion.
	/// @param HalfHeight    Half-height of the capsule (from center of capsule to tip of hemisphere.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
	{
		IntPtr[] OutComponents_temp;
		int ___ret = CapsuleOverlapComponents(IntPtr.Zero,WorldContextObject,ref CapsulePos,Radius,HalfHeight,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
		OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int CapsuleOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
	
	/// <summary>
	/// Returns an array of actors that overlap the given capsule.
	/// @param WorldContext  World context
	/// @param CapsulePos    Center of the capsule.
	/// @param Radius                Radius of capsule hemispheres and radius of center cylinder portion.
	/// @param HalfHeight    Half-height of the capsule (from center of capsule to tip of hemisphere.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		int ___ret = CapsuleOverlapActors(IntPtr.Zero,WorldContextObject,ref CapsulePos,Radius,HalfHeight,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector BoxPos,ref FVector Extent,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
	
	/// <summary>
	/// Returns an array of components that overlap the given axis-aligned box.
	/// @param WorldContext  World context
	/// @param BoxPos                Center of box.
	/// @param BoxExtent             Extents of box.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
	{
		IntPtr[] OutComponents_temp;
		int ___ret = BoxOverlapComponents(IntPtr.Zero,WorldContextObject,ref BoxPos,ref Extent,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
		OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BoxOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector BoxPos,ref FVector BoxExtent,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
	
	/// <summary>
	/// Returns an array of actors that overlap the given axis-aligned box.
	/// @param WorldContext  World context
	/// @param BoxPos                Center of box.
	/// @param BoxExtent             Extents of box.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		int ___ret = BoxOverlapActors(IntPtr.Zero,WorldContextObject,ref BoxPos,ref BoxExtent,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereOverlapComponents(IntPtr _this,IntPtr WorldContextObject,ref FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,IntPtr ComponentClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutComponents);
	
	/// <summary>
	/// Returns an array of components that overlap the given sphere.
	/// @param WorldContext  World context
	/// @param SpherePos             Center of sphere.
	/// @param SphereRadius  Size of sphere.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,UClass ComponentClassFilter,AActor[] ActorsToIgnore,out UPrimitiveComponent[] OutComponents)
	{
		IntPtr[] OutComponents_temp;
		int ___ret = SphereOverlapComponents(IntPtr.Zero,WorldContextObject,ref SpherePos,SphereRadius,ObjectTypes,ComponentClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutComponents_temp);
		OutComponents = MarshalUtil.IntPtrArrayToObjectArray<UPrimitiveComponent>(OutComponents_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SphereOverlapActors(IntPtr _this,IntPtr WorldContextObject,ref FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,IntPtr ActorClassFilter,IntPtr[] ActorsToIgnore,out IntPtr[] OutActors);
	
	/// <summary>
	/// Returns an array of actors that overlap the given sphere.
	/// @param WorldContext  World context
	/// @param SpherePos             Center of sphere.
	/// @param SphereRadius  Size of sphere.
	/// @param Filter                Option to restrict results to only static or only dynamic.  For efficiency.
	/// @param ClassFilter   If set, will only return results of this class or subclasses of it.
	/// @param ActorsToIgnore                Ignore these actors in the list
	/// @param OutActors             Returned array of actors. Unsorted.
	/// @return                              true if there was an overlap that passed the filters, false otherwise.
	/// </summary>
	public static bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,EObjectTypeQuery[] ObjectTypes,UClass ActorClassFilter,AActor[] ActorsToIgnore,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		int ___ret = SphereOverlapActors(IntPtr.Zero,WorldContextObject,ref SpherePos,SphereRadius,ObjectTypes,ActorClassFilter,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStructurePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FGenericStruct Value);
	
	/// <summary>Set a custom structure property by name</summary>
	public static void SetStructurePropertyByName(UObject Object,string PropertyName,FGenericStruct Value)
	{
		SetStructurePropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCollisionProfileNameProperty(IntPtr _this,IntPtr Object,string PropertyName,ref FCollisionProfileName Value);
	
	/// <summary>Set a CollisionProfileName property by name</summary>
	public static void SetCollisionProfileNameProperty(UObject Object,string PropertyName,FCollisionProfileName Value)
	{
		SetCollisionProfileNameProperty(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTransformPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FTransform Value);
	
	/// <summary>Set a TRANSFORM property by name</summary>
	public static void SetTransformPropertyByName(UObject Object,string PropertyName,FTransform Value)
	{
		SetTransformPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearColorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FLinearColor Value);
	
	/// <summary>Set a LINEAR COLOR property by name</summary>
	public static void SetLinearColorPropertyByName(UObject Object,string PropertyName,FLinearColor Value)
	{
		SetLinearColorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRotatorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FRotator Value);
	
	/// <summary>Set a ROTATOR property by name</summary>
	public static void SetRotatorPropertyByName(UObject Object,string PropertyName,FRotator Value)
	{
		SetRotatorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVectorPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,ref FVector Value);
	
	/// <summary>Set a VECTOR property by name</summary>
	public static void SetVectorPropertyByName(UObject Object,string PropertyName,FVector Value)
	{
		SetVectorPropertyByName(IntPtr.Zero,Object,PropertyName,ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTextPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
	
	/// <summary>Set a TEXT property by name</summary>
	public static void SetTextPropertyByName(UObject Object,string PropertyName,string Value)
	{
		SetTextPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetStringPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
	
	/// <summary>Set a STRING property by name</summary>
	public static void SetStringPropertyByName(UObject Object,string PropertyName,string Value)
	{
		SetStringPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNamePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,string Value);
	
	/// <summary>Set a NAME property by name</summary>
	public static void SetNamePropertyByName(UObject Object,string PropertyName,string Value)
	{
		SetNamePropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetClassPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,IntPtr Value);
	
	/// <summary>Set a CLASS property by name</summary>
	public static void SetClassPropertyByName(UObject Object,string PropertyName,TSubclassOf<UObject>  Value)
	{
		SetClassPropertyByName(IntPtr.Zero,Object,PropertyName,Value.NativeClass);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetObjectPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,IntPtr Value);
	
	/// <summary>Set an OBJECT property by name</summary>
	public static void SetObjectPropertyByName(UObject Object,string PropertyName,UObject Value)
	{
		SetObjectPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBoolPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
	
	/// <summary>Set a bool property by name</summary>
	public static void SetBoolPropertyByName(UObject Object,string PropertyName,bool Value)
	{
		SetBoolPropertyByName(IntPtr.Zero,Object,PropertyName,Value?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFloatPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,float Value);
	
	/// <summary>Set a float property by name</summary>
	public static void SetFloatPropertyByName(UObject Object,string PropertyName,float Value)
	{
		SetFloatPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBytePropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
	
	/// <summary>Set an uint8 or enum property by name</summary>
	public static void SetBytePropertyByName(UObject Object,string PropertyName,byte Value)
	{
		SetBytePropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIntPropertyByName(IntPtr _this,IntPtr Object,string PropertyName,int Value);
	
	/// <summary>Set an int32 property by name</summary>
	public static void SetIntPropertyByName(UObject Object,string PropertyName,int Value)
	{
		SetIntPropertyByName(IntPtr.Zero,Object,PropertyName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetTimerRemainingTime(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Returns time until the timer will next execute its delegate.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// @return                              How long is remaining in the current iteration of the timer.
	/// </summary>
	public static float GetTimerRemainingTime(UObject Object,string FunctionName)
	{
		float ___ret = K2_GetTimerRemainingTime(IntPtr.Zero,Object,FunctionName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetTimerElapsedTime(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Returns elapsed time for the given delegate (time since current countdown iteration began).
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// @return                              How long has elapsed since the current iteration of the timer began.
	/// </summary>
	public static float GetTimerElapsedTime(UObject Object,string FunctionName)
	{
		float ___ret = K2_GetTimerElapsedTime(IntPtr.Zero,Object,FunctionName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_TimerExists(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Returns true is a timer for the given delegate exists, false otherwise.
	/// @param Object         Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
	/// @return                               True if the timer exists.
	/// </summary>
	public static bool TimerExists(UObject Object,string FunctionName)
	{
		int ___ret = K2_TimerExists(IntPtr.Zero,Object,FunctionName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_IsTimerPaused(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Returns true if a timer exists and is paused for the given delegate, false otherwise.
	/// @param Object         Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName   Delegate function name. Can be a K2 function or a Custom Event.
	/// @return                               True if the timer exists and is paused.
	/// </summary>
	public static bool IsTimerPaused(UObject Object,string FunctionName)
	{
		int ___ret = K2_IsTimerPaused(IntPtr.Zero,Object,FunctionName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_IsTimerActive(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Returns true if a timer exists and is active for the given delegate, false otherwise.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// @return                              True if the timer exists and is active.
	/// </summary>
	public static bool IsTimerActive(UObject Object,string FunctionName)
	{
		int ___ret = K2_IsTimerActive(IntPtr.Zero,Object,FunctionName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_UnPauseTimer(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Resumes a paused timer from its current elapsed time.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// </summary>
	public static void UnPauseTimer(UObject Object,string FunctionName)
	{
		K2_UnPauseTimer(IntPtr.Zero,Object,FunctionName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_PauseTimer(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Pauses a set timer at its current elapsed time.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// </summary>
	public static void PauseTimer(UObject Object,string FunctionName)
	{
		K2_PauseTimer(IntPtr.Zero,Object,FunctionName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_ClearTimer(IntPtr _this,IntPtr Object,string FunctionName);
	
	/// <summary>
	/// Clears a set timer.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// </summary>
	public static void ClearTimer(UObject Object,string FunctionName)
	{
		K2_ClearTimer(IntPtr.Zero,Object,FunctionName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimerHandle K2_SetTimer(IntPtr _this,IntPtr Object,string FunctionName,float Time,int bLooping);
	
	/// <summary>
	/// Set a timer to execute delegate. Setting an existing timer will reset that timer with updated parameters.
	/// @param Object                Object that implements the delegate function. Defaults to self (this blueprint)
	/// @param FunctionName  Delegate function name. Can be a K2 function or a Custom Event.
	/// @param Time                  How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
	/// @param bLooping              true to keep executing the delegate every Time seconds, false to execute delegate only once.
	/// @return                              The timer handle to pass to other timer functions to manipulate this timer.
	/// </summary>
	public static FTimerHandle SetTimer(UObject Object,string FunctionName,float Time,bool bLooping)
	{
		FTimerHandle ___ret = K2_SetTimer(IntPtr.Zero,Object,FunctionName,Time,bLooping?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetTimerRemainingTimeHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns time until the timer will next execute its handle.
	/// @param Handle                The handle of the timer to time remaining of.
	/// @return                              How long is remaining in the current iteration of the timer.
	/// </summary>
	public static float GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		float ___ret = K2_GetTimerRemainingTimeHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float K2_GetTimerElapsedTimeHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns elapsed time for the given handle (time since current countdown iteration began).
	/// @param Handle                The handle of the timer to get the elapsed time of.
	/// @return                              How long has elapsed since the current iteration of the timer began.
	/// </summary>
	public static float GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		float ___ret = K2_GetTimerElapsedTimeHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_TimerExistsHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns true is a timer for the given handle exists, false otherwise.
	/// @param Handle                The handle to check whether it exists.
	/// @return                              True if the timer exists.
	/// </summary>
	public static bool TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		int ___ret = K2_TimerExistsHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_IsTimerPausedHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns true if a timer exists and is paused for the given handle, false otherwise.
	/// @param Handle                The handle of the timer to check whether it is paused.
	/// @return                              True if the timer exists and is paused.
	/// </summary>
	public static bool IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		int ___ret = K2_IsTimerPausedHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_IsTimerActiveHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns true if a timer exists and is active for the given handle, false otherwise.
	/// @param Handle                The handle of the timer to check whether it is active.
	/// @return                              True if the timer exists and is active.
	/// </summary>
	public static bool IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		int ___ret = K2_IsTimerActiveHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_UnPauseTimerHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Resumes a paused timer from its current elapsed time.
	/// @param Handle                The handle of the timer to unpause.
	/// </summary>
	public static void UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		K2_UnPauseTimerHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_PauseTimerHandle(IntPtr _this,IntPtr WorldContextObject,ref FTimerHandle Handle);
	
	/// <summary>
	/// Pauses a set timer at its current elapsed time.
	/// @param Handle                The handle of the timer to pause.
	/// </summary>
	public static void PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle)
	{
		K2_PauseTimerHandle(IntPtr.Zero,WorldContextObject,ref Handle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_ClearAndInvalidateTimerHandle(IntPtr _this,IntPtr WorldContextObject,out FTimerHandle Handle);
	
	/// <summary>
	/// Clears a set timer.
	/// @param Handle                The handle of the timer to clear.
	/// </summary>
	public static void ClearAndInvalidateTimerHandle(UObject WorldContextObject,out FTimerHandle Handle)
	{
		K2_ClearAndInvalidateTimerHandle(IntPtr.Zero,WorldContextObject,out Handle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimerHandle K2_InvalidateTimerHandle(IntPtr _this,out FTimerHandle Handle);
	
	/// <summary>
	/// Returns whether the timer handle is valid. This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.
	/// @param Handle                The handle of the timer to check validity of.
	/// @return                              Return the invalidated timer handle for convenience.
	/// </summary>
	public static FTimerHandle InvalidateTimerHandle(out FTimerHandle Handle)
	{
		FTimerHandle ___ret = K2_InvalidateTimerHandle(IntPtr.Zero,out Handle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_IsValidTimerHandle(IntPtr _this,ref FTimerHandle Handle);
	
	/// <summary>
	/// Returns whether the timer handle is valid. This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.
	/// @param Handle                The handle of the timer to check validity of.
	/// @return                              Whether the timer handle is valid.
	/// </summary>
	public static bool IsValidTimerHandle(FTimerHandle Handle)
	{
		int ___ret = K2_IsValidTimerHandle(IntPtr.Zero,ref Handle);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MoveComponentTo(IntPtr _this,IntPtr Component,ref FVector TargetRelativeLocation,ref FRotator TargetRelativeRotation,int bEaseOut,int bEaseIn,float OverTime,int bForceShortestRotationPath,int MoveAction,ref FLatentActionInfo LatentInfo);
	
	/// <summary>
	/// * Interpolate a component to the specified relative location and rotation over the course of OverTime seconds.
	/// * @param Component                                             Component to interpolate
	/// * @param TargetRelativeLocation                Relative target location
	/// * @param TargetRelativeRotation                Relative target rotation
	/// * @param bEaseOut                                              if true we will ease out (ie end slowly) during interpolation
	/// * @param bEaseIn                                               if true we will ease in (ie start slowly) during interpolation
	/// * @param OverTime                                              duration of interpolation
	/// * @param bForceShortestRotationPath    if true we will always use the shortest path for rotation
	/// * @param MoveAction                                    required movement behavior @see EMoveComponentAction
	/// * @param LatentInfo                                    The latent action
	/// </summary>
	public static void MoveComponentTo(USceneComponent Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,EMoveComponentAction MoveAction,FLatentActionInfo LatentInfo)
	{
		MoveComponentTo(IntPtr.Zero,Component,ref TargetRelativeLocation,ref TargetRelativeRotation,bEaseOut?1:0,bEaseIn?1:0,OverTime,bForceShortestRotationPath?1:0,(int)MoveAction,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RetriggerableDelay(IntPtr _this,IntPtr WorldContextObject,float Duration,ref FLatentActionInfo LatentInfo);
	
	/// <summary>
	/// Perform a latent action with a retriggerable delay (specified in seconds).  Calling again while it is counting down will reset the countdown to Duration.
	/// @param WorldContext  World context.
	/// @param Duration              length of delay (in seconds).
	/// @param LatentInfo    The latent action.
	/// </summary>
	public static void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo)
	{
		RetriggerableDelay(IntPtr.Zero,WorldContextObject,Duration,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Delay(IntPtr _this,IntPtr WorldContextObject,float Duration,ref FLatentActionInfo LatentInfo);
	
	/// <summary>
	/// Perform a latent action with a delay (specified in seconds).  Calling again while it is counting down will be ignored.
	/// @param WorldContext  World context.
	/// @param Duration              length of delay (in seconds).
	/// @param LatentInfo    The latent action.
	/// </summary>
	public static void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo)
	{
		Delay(IntPtr.Zero,WorldContextObject,Duration,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void QuitGame(IntPtr _this,IntPtr WorldContextObject,IntPtr SpecificPlayer,int QuitPreference);
	
	/// <summary>
	/// Exit the current game
	/// @param       SpecificPlayer  The specific player to quit the game. If not specified, player 0 will quit.
	/// </summary>
	public static void QuitGame(UObject WorldContextObject,APlayerController SpecificPlayer,EQuitPreference QuitPreference)
	{
		QuitGame(IntPtr.Zero,WorldContextObject,SpecificPlayer,(int)QuitPreference);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ExecuteConsoleCommand(IntPtr _this,IntPtr WorldContextObject,string Command,IntPtr SpecificPlayer);
	
	/// <summary>
	/// Executes a console command, optionally on a specific controller
	/// @param       Command                 Command to send to the console
	/// @param       SpecificPlayer  If specified, the console command will be routed through the specified player
	/// </summary>
	public static void ExecuteConsoleCommand(UObject WorldContextObject,string Command,APlayerController SpecificPlayer)
	{
		ExecuteConsoleCommand(IntPtr.Zero,WorldContextObject,Command,SpecificPlayer);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWindowTitle(IntPtr _this,string Title);
	
	/// <summary>Sets the game window title</summary>
	public static void SetWindowTitle(string Title)
	{
		SetWindowTitle(IntPtr.Zero,Title);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PrintWarning(IntPtr _this,string InString);
	
	/// <summary>
	/// Prints a warning string to the log and the screen. Meant to be used as a way to inform the user that they misused the node.
	/// WARNING!! Don't change the signature of this function without fixing up all nodes using it in the compiler
	/// @param       InString                The string to log out
	/// </summary>
	public static void PrintWarning(string InString)
	{
		PrintWarning(IntPtr.Zero,InString);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PrintText(IntPtr _this,IntPtr WorldContextObject,string InText,int bPrintToScreen,int bPrintToLog,ref FLinearColor TextColor,float Duration);
	
	/// <summary>
	/// Prints text to the log, and optionally, to the screen
	/// If Print To Log is true, it will be visible in the Output Log window.  Otherwise it will be logged only as 'Verbose', so it generally won't show up.
	/// @param       InText                  The text to log out
	/// @param       bPrintToScreen  Whether or not to print the output to the screen
	/// @param       bPrintToLog             Whether or not to print the output to the log
	/// @param       bPrintToConsole Whether or not to print the output to the console
	/// @param       TextColor               Whether or not to print the output to the console
	/// @param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
	/// </summary>
	public static void PrintText(UObject WorldContextObject,string InText="Hello",bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f)
	{
		PrintText(IntPtr.Zero,WorldContextObject,InText,bPrintToScreen?1:0,bPrintToLog?1:0,ref TextColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PrintString(IntPtr _this,IntPtr WorldContextObject,string InString,int bPrintToScreen,int bPrintToLog,ref FLinearColor TextColor,float Duration);
	
	/// <summary>
	/// Prints a string to the log, and optionally, to the screen
	/// If Print To Log is true, it will be visible in the Output Log window.  Otherwise it will be logged only as 'Verbose', so it generally won't show up.
	/// @param       InString                The string to log out
	/// @param       bPrintToScreen  Whether or not to print the output to the screen
	/// @param       bPrintToLog             Whether or not to print the output to the log
	/// @param       bPrintToConsole Whether or not to print the output to the console
	/// @param       TextColor               Whether or not to print the output to the console
	/// @param       Duration                The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
	/// </summary>
	public static void PrintString(UObject WorldContextObject,string InString="Hello",bool bPrintToScreen=true,bool bPrintToLog=true,FLinearColor TextColor=default(FLinearColor),float Duration=2.000000f)
	{
		PrintString(IntPtr.Zero,WorldContextObject,InString,bPrintToScreen?1:0,bPrintToLog?1:0,ref TextColor,Duration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string MakeLiteralText(IntPtr _this,string Value);
	
	/// <summary>
	/// Creates a literal FText
	/// @param       Value   value to set the FText to
	/// @return      The literal FText
	/// </summary>
	public static string MakeLiteralText(string Value)
	{
		string ___ret = MakeLiteralText(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string MakeLiteralString(IntPtr _this,string Value);
	
	/// <summary>
	/// Creates a literal string
	/// @param       Value   value to set the string to
	/// @return      The literal string
	/// </summary>
	public static string MakeLiteralString(string Value)
	{
		string ___ret = MakeLiteralString(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int MakeLiteralByte(IntPtr _this,int Value);
	
	/// <summary>
	/// Creates a literal byte
	/// @param       Value   value to set the byte to
	/// @return      The literal byte
	/// </summary>
	public static byte MakeLiteralByte(byte Value)
	{
		int ___ret = MakeLiteralByte(IntPtr.Zero,Value);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string MakeLiteralName(IntPtr _this,string Value);
	
	/// <summary>
	/// Creates a literal name
	/// @param       Value   value to set the name to
	/// @return      The literal name
	/// </summary>
	public static string MakeLiteralName(string Value)
	{
		string ___ret = MakeLiteralName(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int MakeLiteralBool(IntPtr _this,int Value);
	
	/// <summary>
	/// Creates a literal bool
	/// @param       Value   value to set the bool to
	/// @return      The literal bool
	/// </summary>
	public static bool MakeLiteralBool(bool Value)
	{
		int ___ret = MakeLiteralBool(IntPtr.Zero,Value?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MakeLiteralFloat(IntPtr _this,float Value);
	
	/// <summary>
	/// Creates a literal float
	/// @param       Value   value to set the float to
	/// @return      The literal float
	/// </summary>
	public static float MakeLiteralFloat(float Value)
	{
		float ___ret = MakeLiteralFloat(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int MakeLiteralInt(IntPtr _this,int Value);
	
	/// <summary>
	/// Creates a literal integer
	/// @param       Value   value to set the integer to
	/// @return      The literal integer
	/// </summary>
	public static int MakeLiteralInt(int Value)
	{
		int ___ret = MakeLiteralInt(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetDeviceId(IntPtr _this);
	
	/// <summary>Returns the platform specific unique device id</summary>
	public static string GetDeviceId()
	{
		string ___ret = GetDeviceId(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPackagedForDistribution(IntPtr _this);
	
	/// <summary>Returns whether this is a build that is packaged for distribution</summary>
	public static bool IsPackagedForDistribution()
	{
		int ___ret = IsPackagedForDistribution(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsStandalone(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns whether this game instance is stand alone (no networking).</summary>
	public static bool IsStandalone(UObject WorldContextObject)
	{
		int ___ret = IsStandalone(IntPtr.Zero,WorldContextObject);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsDedicatedServer(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns whether this is running on a dedicated server</summary>
	public static bool IsDedicatedServer(UObject WorldContextObject)
	{
		int ___ret = IsDedicatedServer(IntPtr.Zero,WorldContextObject);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsServer(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns whether the world this object is in is the host or not</summary>
	public static bool IsServer(UObject WorldContextObject)
	{
		int ___ret = IsServer(IntPtr.Zero,WorldContextObject);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetGameTimeInSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>
	/// Get the current game time, in seconds. This stops when the game is paused and is affected by slomo.
	/// @param WorldContextObject    World context
	/// </summary>
	public static float GetGameTimeInSeconds(UObject WorldContextObject)
	{
		float ___ret = GetGameTimeInSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DoesImplementInterface(IntPtr _this,IntPtr TestObject,IntPtr Interface);
	
	public static bool DoesImplementInterface(UObject TestObject,TSubclassOf<UInterface>  Interface)
	{
		int ___ret = DoesImplementInterface(IntPtr.Zero,TestObject,Interface.NativeClass);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetPlatformUserName(IntPtr _this);
	
	/// <summary>Get the current user name from the OS</summary>
	public static string GetPlatformUserName()
	{
		string ___ret = GetPlatformUserName(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetGameBundleId(IntPtr _this);
	
	/// <summary>
	/// Retrieves the game's platform-specific bundle identifier or package name of the game
	/// @return The game's bundle identifier or package name.
	/// </summary>
	public static string GetGameBundleId()
	{
		string ___ret = GetGameBundleId(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetGameName(IntPtr _this);
	
	/// <summary>Get the name of the current game</summary>
	public static string GetGameName()
	{
		string ___ret = GetGameName(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetEngineVersion(IntPtr _this);
	
	/// <summary>Engine build number, for displaying to end users.</summary>
	public static string GetEngineVersion()
	{
		string ___ret = GetEngineVersion(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetClassDisplayName(IntPtr _this,IntPtr Class);
	
	/// <summary>Returns the display name of a class</summary>
	public static string GetClassDisplayName(UClass Class)
	{
		string ___ret = GetClassDisplayName(IntPtr.Zero,Class);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetDisplayName(IntPtr _this,IntPtr Object);
	
	/// <summary>
	/// Returns the display name (or actor label), for displaying as a debugging aid.
	/// Note: In editor builds, this is the actor label.  In non-editor builds, this is the actual object name.  This function should not be used to uniquely identify actors!
	/// It is not localized and should not be used for display to an end user of a game.
	/// </summary>
	public static string GetDisplayName(UObject Object)
	{
		string ___ret = GetDisplayName(IntPtr.Zero,Object);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetPathName(IntPtr _this,IntPtr Object);
	
	/// <summary>Returns the full path to the specified object.</summary>
	public static string GetPathName(UObject Object)
	{
		string ___ret = GetPathName(IntPtr.Zero,Object);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetObjectName(IntPtr _this,IntPtr Object);
	
	/// <summary>Returns the actual object name.</summary>
	public static string GetObjectName(UObject Object)
	{
		string ___ret = GetObjectName(IntPtr.Zero,Object);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsValidClass(IntPtr _this,IntPtr Class);
	
	/// <summary>Return true if the class is usable : non-null and not pending kill</summary>
	public static bool IsValidClass(UClass Class)
	{
		int ___ret = IsValidClass(IntPtr.Zero,Class);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsValid(IntPtr _this,IntPtr Object);
	
	/// <summary>Return true if the object is usable : non-null and not pending kill</summary>
	public static bool IsValid(UObject Object)
	{
		int ___ret = IsValid(IntPtr.Zero,Object);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
