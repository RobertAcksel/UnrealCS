//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameplayStatics:UBlueprintFunctionLibrary 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasLaunchOption(IntPtr _this,string OptionToCheck);
	
	/// <summary>
	/// Checks the commandline to see if the desired option was specified on the commandline (e.g. -demobuild)
	/// @return                               True if the launch option was specified on the commandline, false otherwise
	/// </summary>
	public static bool HasLaunchOption(string OptionToCheck)
	{
		int ___ret = HasLaunchOption(IntPtr.Zero,OptionToCheck);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetIntOption(IntPtr _this,string Options,string Key,int DefaultValue);
	
	/// <summary>
	/// Find an option in the options string and return it as an integer.
	/// @param Options               The string containing the options.
	/// @param Key                   The key to find the value of in Options.
	/// @return                              The value associated with Key as an integer if Key found in Options string, otherwise DefaultValue.
	/// </summary>
	public static int GetIntOption(string Options,string Key,int DefaultValue)
	{
		int ___ret = GetIntOption(IntPtr.Zero,Options,Key,DefaultValue);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasOption(IntPtr _this,string Options,string InKey);
	
	/// <summary>
	/// Returns whether a key exists in an options string.
	/// @param Options               The string containing the options.
	/// @param Key                   The key to determine if it exists in Options.
	/// @return                              Whether Key was found in Options.
	/// </summary>
	public static bool HasOption(string Options,string InKey)
	{
		int ___ret = HasOption(IntPtr.Zero,Options,InKey);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string ParseOption(IntPtr _this,string Options,string Key);
	
	/// <summary>
	/// Find an option in the options string and return it.
	/// @param Options               The string containing the options.
	/// @param Key                   The key to find the value of in Options.
	/// @return                              The value associated with Key if Key found in Options string.
	/// </summary>
	public static string ParseOption(string Options,string Key)
	{
		string ___ret = ParseOption(IntPtr.Zero,Options,Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetKeyValue(IntPtr _this,string Pair,out string Key,out string Value);
	
	/// <summary>
	/// Break up a key=value pair into its key and value.
	/// @param Pair                  The string containing a pair to split apart.
	/// @param Key                   (out) Key portion of Pair. If no = in string will be the same as Pair.
	/// @param Value                 (out) Value portion of Pair. If no = in string will be empty.
	/// </summary>
	public static void GetKeyValue(string Pair,out string Key,out string Value)
	{
		GetKeyValue(IntPtr.Zero,Pair,out Key,out Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ProjectWorldToScreen(IntPtr _this,IntPtr Player,ref FVector WorldPosition,out FVector2D ScreenPosition,int bPlayerViewportRelative);
	
	/// <summary>
	/// Transforms the given 3D world-space point into a its 2D screen space coordinate.
	/// @param Player                        Project using this player's view.
	/// @param WorldPosition         World position to project.
	/// @param ScreenPosition        (out) Corresponding 2D position in screen space
	/// @param bPlayerViewportRelative       Should this be relative to the player viewport subregion (useful when using player attached widgets in split screen)
	/// </summary>
	public static bool ProjectWorldToScreen(APlayerController Player,FVector WorldPosition,out FVector2D ScreenPosition,bool bPlayerViewportRelative=false)
	{
		int ___ret = ProjectWorldToScreen(IntPtr.Zero,Player,ref WorldPosition,out ScreenPosition,bPlayerViewportRelative?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DeprojectScreenToWorld(IntPtr _this,IntPtr Player,ref FVector2D ScreenPosition,out FVector WorldPosition,out FVector WorldDirection);
	
	/// <summary>
	/// Transforms the given 2D screen space coordinate into a 3D world-space point and direction.
	/// @param Player                        Deproject using this player's view.
	/// @param ScreenPosition        2D screen space to deproject.
	/// @param WorldPosition         (out) Corresponding 3D position in world space.
	/// @param WorldDirection        (out) World space direction vector away from the camera at the given 2d point.
	/// </summary>
	public static bool DeprojectScreenToWorld(APlayerController Player,FVector2D ScreenPosition,out FVector WorldPosition,out FVector WorldDirection)
	{
		int ___ret = DeprojectScreenToWorld(IntPtr.Zero,Player,ref ScreenPosition,out WorldPosition,out WorldDirection);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GrassOverlappingSphereCount(IntPtr _this,IntPtr WorldContextObject,IntPtr StaticMesh,ref FVector CenterPosition,float Radius);
	
	/// <summary>
	/// Counts how many grass foliage instances overlap a given sphere.
	/// @param        Mesh                    The static mesh we are interested in counting.
	/// @param        CenterPosition  The center position of the sphere.
	/// @param        Radius                  The radius of the sphere.
	/// @return Number of foliage instances with their mesh set to Mesh that overlap the sphere.
	/// </summary>
	public static int GrassOverlappingSphereCount(UObject WorldContextObject,UStaticMesh StaticMesh,FVector CenterPosition,float Radius)
	{
		int ___ret = GrassOverlappingSphereCount(IntPtr.Zero,WorldContextObject,StaticMesh,ref CenterPosition,Radius);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RebaseZeroOriginOntoLocal(IntPtr _this,IntPtr WorldContextObject,ref FVector WorldLocation);
	
	/// <summary>Returns local location for origin based position.</summary>
	public static FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation)
	{
		FVector ___ret = RebaseZeroOriginOntoLocal(IntPtr.Zero,WorldContextObject,ref WorldLocation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RebaseLocalOriginOntoZero(IntPtr _this,IntPtr WorldContextObject,ref FVector WorldLocation);
	
	/// <summary>Returns origin based position for local world location.</summary>
	public static FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation)
	{
		FVector ___ret = RebaseLocalOriginOntoZero(IntPtr.Zero,WorldContextObject,ref WorldLocation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWorldOriginLocation(IntPtr _this,IntPtr WorldContextObject,ref FIntVector NewLocation);
	
	/// <summary>Requests a new location for a world origin.</summary>
	public static void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation)
	{
		SetWorldOriginLocation(IntPtr.Zero,WorldContextObject,ref NewLocation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntVector GetWorldOriginLocation(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns world origin current location.</summary>
	public static FIntVector GetWorldOriginLocation(UObject WorldContextObject)
	{
		FIntVector ___ret = GetWorldOriginLocation(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SuggestProjectileVelocity_CustomArc(IntPtr _this,IntPtr WorldContextObject,out FVector OutLaunchVelocity,ref FVector StartPos,ref FVector EndPos,float OverrideGravityZ,float ArcParam);
	
	/// <summary>
	/// Returns the launch velocity needed for a projectile at rest at StartPos to land on EndPos.
	/// Assumes a medium arc (e.g. 45 deg on level ground). Projectile velocity is variable and unconstrained.
	/// Does no tracing.
	/// @param OutLaunchVelocity                      Returns the launch velocity required to reach the EndPos
	/// @param StartPos                                       Start position of the simulation
	/// @param EndPos                                         Desired end location for the simulation
	/// @param OverrideGravityZ                       Optional override of WorldGravityZ
	/// @param ArcParam                                       Change height of arc between 0.0-1.0 where 0.5 is the default medium arc
	/// </summary>
	public static bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,out FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ=0.000000f,float ArcParam=0.500000f)
	{
		int ___ret = SuggestProjectileVelocity_CustomArc(IntPtr.Zero,WorldContextObject,out OutLaunchVelocity,ref StartPos,ref EndPos,OverrideGravityZ,ArcParam);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Blueprint_PredictProjectilePath_Advanced(IntPtr _this,IntPtr WorldContextObject,ref FPredictProjectilePathParams PredictParams,out FPredictProjectilePathResult PredictResult);
	
	/// <summary>
	/// Predict the arc of a virtual projectile affected by gravity with collision checks along the arc.
	/// Returns true if it hit something.
	/// @param PredictParams                          Input params to the trace (start location, velocity, time to simulate, etc).
	/// @param PredictResult                          Output result of the trace (Hit result, array of location/velocity/times for each trace step, etc).
	/// @return                                                       True if hit something along the path (if tracing with collision).
	/// </summary>
	public static bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,out FPredictProjectilePathResult PredictResult)
	{
		int ___ret = Blueprint_PredictProjectilePath_Advanced(IntPtr.Zero,WorldContextObject,ref PredictParams,out PredictResult);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Blueprint_PredictProjectilePath_ByTraceChannel(IntPtr _this,IntPtr WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,ref FVector StartPos,ref FVector LaunchVelocity,int bTracePath,float ProjectileRadius,int TraceChannel,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ);
	
	/// <summary>
	/// Predict the arc of a virtual projectile affected by gravity with collision checks along the arc. Returns a list of positions of the simulated arc and the destination reached by the simulation.
	/// Returns true if it hit something (if tracing with collision).
	/// @param OutPathPositions                       Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
	/// @param OutHit                                         Predicted hit result, if the projectile will hit something
	/// @param OutLastTraceDestination        Goal position of the final trace it did. Will not be in the path if there is a hit.
	/// @param StartPos                                       First start trace location
	/// @param LaunchVelocity                         Velocity the "virtual projectile" is launched at
	/// @param bTracePath                                     Trace along the entire path to look for blocking hits
	/// @param ProjectileRadius                       Radius of the virtual projectile to sweep against the environment
	/// @param TraceChannel                           TraceChannel to trace against, if bTracePath is true.
	/// @param bTraceComplex                          Use TraceComplex (trace against triangles not primitives)
	/// @param ActorsToIgnore                         Actors to exclude from the traces
	/// @param DrawDebugType                          Debug type (one-frame, duration, persistent)
	/// @param DrawDebugTime                          Duration of debug lines (only relevant for DrawDebugType::Duration)
	/// @param SimFrequency                           Determines size of each sub-step in the simulation (chopping up MaxSimTime)
	/// @param MaxSimTime                                     Maximum simulation time for the virtual projectile.
	/// @param OverrideGravityZ                       Optional override of Gravity (if 0, uses WorldGravityZ)
	/// @return                                                       True if hit something along the path (if tracing with collision).
	/// </summary>
	public static bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,ECollisionChannel TraceChannel,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.000000f,float MaxSimTime=2.000000f,float OverrideGravityZ=0.000000f)
	{
		int ___ret = Blueprint_PredictProjectilePath_ByTraceChannel(IntPtr.Zero,WorldContextObject,out OutHit,out OutPathPositions,out OutLastTraceDestination,ref StartPos,ref LaunchVelocity,bTracePath?1:0,ProjectileRadius,(int)TraceChannel,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Blueprint_PredictProjectilePath_ByObjectType(IntPtr _this,IntPtr WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,ref FVector StartPos,ref FVector LaunchVelocity,int bTracePath,float ProjectileRadius,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,IntPtr[] ActorsToIgnore,int DrawDebugType,float DrawDebugTime,float SimFrequency,float MaxSimTime,float OverrideGravityZ);
	
	/// <summary>
	/// Predict the arc of a virtual projectile affected by gravity with collision checks along the arc. Returns a list of positions of the simulated arc and the destination reached by the simulation.
	/// Returns true if it hit something.
	/// @param OutPathPositions                       Predicted projectile path. Ordered series of positions from StartPos to the end. Includes location at point of impact if it hit something.
	/// @param OutHit                                         Predicted hit result, if the projectile will hit something
	/// @param OutLastTraceDestination        Goal position of the final trace it did. Will not be in the path if there is a hit.
	/// @param StartPos                                       First start trace location
	/// @param LaunchVelocity                         Velocity the "virtual projectile" is launched at
	/// @param bTracePath                                     Trace along the entire path to look for blocking hits
	/// @param ProjectileRadius                       Radius of the virtual projectile to sweep against the environment
	/// @param ObjectTypes                            ObjectTypes to trace against, if bTracePath is true.
	/// @param bTraceComplex                          Use TraceComplex (trace against triangles not primitives)
	/// @param ActorsToIgnore                         Actors to exclude from the traces
	/// @param DrawDebugType                          Debug type (one-frame, duration, persistent)
	/// @param DrawDebugTime                          Duration of debug lines (only relevant for DrawDebugType::Duration)
	/// @param SimFrequency                           Determines size of each sub-step in the simulation (chopping up MaxSimTime)
	/// @param MaxSimTime                                     Maximum simulation time for the virtual projectile.
	/// @param OverrideGravityZ                       Optional override of Gravity (if 0, uses WorldGravityZ)
	/// @return                                                       True if hit something along the path if tracing for collision.
	/// </summary>
	public static bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,out FHitResult OutHit,out FVector[] OutPathPositions,out FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,AActor[] ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.000000f,float MaxSimTime=2.000000f,float OverrideGravityZ=0.000000f)
	{
		int ___ret = Blueprint_PredictProjectilePath_ByObjectType(IntPtr.Zero,WorldContextObject,out OutHit,out OutPathPositions,out OutLastTraceDestination,ref StartPos,ref LaunchVelocity,bTracePath?1:0,ProjectileRadius,ObjectTypes,bTraceComplex?1:0,MarshalUtil.ObjectArrayToIntPtrArray(ActorsToIgnore),(int)DrawDebugType,DrawDebugTime,SimFrequency,MaxSimTime,OverrideGravityZ);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BlueprintSuggestProjectileVelocity(IntPtr _this,IntPtr WorldContextObject,out FVector TossVelocity,ref FVector StartLocation,ref FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,int TraceOption,float CollisionRadius,int bFavorHighArc,int bDrawDebug);
	
	/// <summary>
	/// Calculates an launch velocity for a projectile to hit a specified point.
	/// @param TossVelocity          (output) Result launch velocity.
	/// @param StartLocation         Intended launch location
	/// @param EndLocation           Desired landing location
	/// @param LaunchSpeed           Desired launch speed
	/// @param OverrideGravityZ      Optional gravity override.  0 means "do not override".
	/// @param TraceOption           Controls whether or not to validate a clear path by tracing along the calculated arc
	/// @param CollisionRadius       Radius of the projectile (assumed spherical), used when tracing
	/// @param bFavorHighArc         If true and there are 2 valid solutions, will return the higher arc.  If false, will favor the lower arc.
	/// @param bDrawDebug            When true, a debug arc is drawn (red for an invalid arc, green for a valid arc)
	/// @return                                      Returns false if there is no valid solution or the valid solutions are blocked.  Returns true otherwise.
	/// </summary>
	public static bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,out FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug)
	{
		int ___ret = BlueprintSuggestProjectileVelocity(IntPtr.Zero,WorldContextObject,out TossVelocity,ref StartLocation,ref EndLocation,LaunchSpeed,OverrideGravityZ,(int)TraceOption,CollisionRadius,bFavorHighArc?1:0,bDrawDebug?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetPlatformName(IntPtr _this);
	
	/// <summary>
	/// Returns the string name of the current platform, to perform different behavior based on platform.
	/// (Platform names include Windows, Mac, IOS, Android, PS4, XboxOne, HTML5, Linux)
	/// </summary>
	public static string GetPlatformName()
	{
		string ___ret = GetPlatformName(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EnableLiveStreaming(IntPtr _this,int Enable);
	
	/// <summary>
	/// Toggle live DVR streaming.
	/// @param Enable                        If true enable streaming, otherwise disable.
	/// </summary>
	public static void EnableLiveStreaming(bool Enable)
	{
		EnableLiveStreaming(IntPtr.Zero,Enable?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAccurateRealTime(IntPtr _this,IntPtr WorldContextObject,out int Seconds,out float PartialSeconds);
	
	public static void GetAccurateRealTime(UObject WorldContextObject,out int Seconds,out float PartialSeconds)
	{
		GetAccurateRealTime(IntPtr.Zero,WorldContextObject,out Seconds,out PartialSeconds);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetAudioTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped.</summary>
	public static float GetAudioTimeSeconds(UObject WorldContextObject)
	{
		float ___ret = GetAudioTimeSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRealTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped</summary>
	public static float GetRealTimeSeconds(UObject WorldContextObject)
	{
		float ___ret = GetRealTimeSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetUnpausedTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS NOT stopped when game pauses</summary>
	public static float GetUnpausedTimeSeconds(UObject WorldContextObject)
	{
		float ___ret = GetUnpausedTimeSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTimeSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns time in seconds since world was brought up for play, adjusted by time dilation and IS stopped when game pauses</summary>
	public static float GetTimeSeconds(UObject WorldContextObject)
	{
		float ___ret = GetTimeSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetWorldDeltaSeconds(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns the frame delta time in seconds, adjusted by time dilation.</summary>
	public static float GetWorldDeltaSeconds(UObject WorldContextObject)
	{
		float ___ret = GetWorldDeltaSeconds(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DeleteGameInSlot(IntPtr _this,string SlotName,int UserIndex);
	
	/// <summary>
	/// Delete a save game in a particular slot.
	///      @param SlotName                 Name of save game slot to delete.
	///  @param UserIndex            For some platforms, master user index to identify the user doing the deletion.
	///  @return True if a file was actually able to be deleted. use DoesSaveGameExist to distinguish between delete failures and failure due to file not existing.
	/// </summary>
	public static bool DeleteGameInSlot(string SlotName,int UserIndex)
	{
		int ___ret = DeleteGameInSlot(IntPtr.Zero,SlotName,UserIndex);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr LoadGameFromSlot(IntPtr _this,string SlotName,int UserIndex);
	
	/// <summary>
	/// Load the contents from a given slot.
	/// @param SlotName                 Name of the save game slot to load from.
	/// @param UserIndex            For some platforms, master user index to identify the user doing the loading.
	/// @return SaveGameObject  Object containing loaded game state (NULL if load fails)
	/// </summary>
	public static USaveGame LoadGameFromSlot(string SlotName,int UserIndex)
	{
		IntPtr ___ret = LoadGameFromSlot(IntPtr.Zero,SlotName,UserIndex);
		if(___ret==IntPtr.Zero) return null; USaveGame ___ret2= new USaveGame(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DoesSaveGameExist(IntPtr _this,string SlotName,int UserIndex);
	
	/// <summary>
	/// See if a save game exists with the specified name.
	/// @param SlotName                 Name of save game slot.
	/// @param UserIndex            For some platforms, master user index to identify the user doing the saving.
	/// </summary>
	public static bool DoesSaveGameExist(string SlotName,int UserIndex)
	{
		int ___ret = DoesSaveGameExist(IntPtr.Zero,SlotName,UserIndex);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SaveGameToSlot(IntPtr _this,IntPtr SaveGameObject,string SlotName,int UserIndex);
	
	/// <summary>
	/// Save the contents of the SaveGameObject to a slot.
	/// @param SaveGameObject   Object that contains data about the save game that we want to write out
	/// @param SlotName                 Name of save game slot to save to.
	/// @param UserIndex            For some platforms, master user index to identify the user doing the saving.
	/// @return                                 Whether we successfully saved this information
	/// </summary>
	public static bool SaveGameToSlot(USaveGame SaveGameObject,string SlotName,int UserIndex)
	{
		int ___ret = SaveGameToSlot(IntPtr.Zero,SaveGameObject,SlotName,UserIndex);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr CreateSaveGameObject(IntPtr _this,IntPtr SaveGameClass);
	
	/// <summary>
	/// Create a new, empty SaveGame object to set data on and then pass to SaveGameToSlot.
	/// @param  SaveGameClass   Class of SaveGame to create
	/// @return                                 New SaveGame object to write data to
	/// </summary>
	public static USaveGame CreateSaveGameObject(TSubclassOf<USaveGame>  SaveGameClass)
	{
		IntPtr ___ret = CreateSaveGameObject(IntPtr.Zero,SaveGameClass.NativeClass);
		if(___ret==IntPtr.Zero) return null; USaveGame ___ret2= new USaveGame(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FindCollisionUV(IntPtr _this,ref FHitResult Hit,int UVChannel,out FVector2D UV);
	
	/// <summary>Try and find the UV for a collision impact. Note this ONLY works if 'Support UV From Hit Results' is enabled in Physics Settings.</summary>
	public static bool FindCollisionUV(FHitResult Hit,int UVChannel,out FVector2D UV)
	{
		int ___ret = FindCollisionUV(IntPtr.Zero,ref Hit,UVChannel,out UV);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetSurfaceType(IntPtr _this,ref FHitResult Hit);
	
	/// <summary>
	/// Returns the EPhysicalSurface type of the given Hit.
	/// To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section
	/// </summary>
	public static EPhysicalSurface GetSurfaceType(FHitResult Hit)
	{
		int ___ret = GetSurfaceType(IntPtr.Zero,ref Hit);
		return (EPhysicalSurface)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FHitResult MakeHitResult(IntPtr _this,int bBlockingHit,int bInitialOverlap,float Time,ref FVector Location,ref FVector ImpactPoint,ref FVector Normal,ref FVector ImpactNormal,IntPtr PhysMat,IntPtr HitActor,IntPtr HitComponent,string HitBoneName,int HitItem,int FaceIndex,ref FVector TraceStart,ref FVector TraceEnd);
	
	/// <summary>
	/// Create a HitResult struct
	/// @param Hit                   The source HitResult.
	/// @param bBlockingHit  True if there was a blocking hit, false otherwise.
	/// @param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
	/// @param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
	/// @param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
	/// @param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
	/// @param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
	/// @param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
	/// @param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
	/// @param HitActor              Actor hit by the trace.
	/// @param HitComponent  PrimitiveComponent hit by the trace.
	/// @param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
	/// @param HitItem               Primitive-specific data recording which item in the primitive was hit
	/// @param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
	/// </summary>
	public static FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UPhysicalMaterial PhysMat,AActor HitActor,UPrimitiveComponent HitComponent,string HitBoneName,int HitItem,int FaceIndex,FVector TraceStart,FVector TraceEnd)
	{
		FHitResult ___ret = MakeHitResult(IntPtr.Zero,bBlockingHit?1:0,bInitialOverlap?1:0,Time,ref Location,ref ImpactPoint,ref Normal,ref ImpactNormal,PhysMat,HitActor,HitComponent,HitBoneName,HitItem,FaceIndex,ref TraceStart,ref TraceEnd);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakHitResult(IntPtr _this,ref FHitResult Hit,out int bBlockingHit,out int bInitialOverlap,out float Time,out FVector Location,out FVector ImpactPoint,out FVector Normal,out FVector ImpactNormal,out IntPtr PhysMat,out IntPtr HitActor,out IntPtr HitComponent,out string HitBoneName,out int HitItem,out int FaceIndex,out FVector TraceStart,out FVector TraceEnd);
	
	/// <summary>
	/// Extracts data from a HitResult.
	/// @param Hit                   The source HitResult.
	/// @param bBlockingHit  True if there was a blocking hit, false otherwise.
	/// @param bInitialOverlap True if the hit started in an initial overlap. In this case some other values should be interpreted differently. Time will be 0, ImpactPoint will equal Location, and normals will be equal and indicate a depenetration vector.
	/// @param Time                  'Time' of impact along trace direction ranging from [0.0 to 1.0) if there is a hit, indicating time between start and end. Equals 1.0 if there is no hit.
	/// @param Location              Location of the hit in world space. If this was a swept shape test, this is the location where we can place the shape in the world where it will not penetrate.
	/// @param Normal                Normal of the hit in world space, for the object that was swept (e.g. for a sphere trace this points towards the sphere's center). Equal to ImpactNormal for line tests.
	/// @param ImpactPoint   Location of the actual contact point of the trace shape with the surface of the hit object. Equal to Location in the case of an initial overlap.
	/// @param ImpactNormal  Normal of the hit in world space, for the object that was hit by the sweep.
	/// @param PhysMat               Physical material that was hit. Must set bReturnPhysicalMaterial to true in the query params for this to be returned.
	/// @param HitActor              Actor hit by the trace.
	/// @param HitComponent  PrimitiveComponent hit by the trace.
	/// @param HitBoneName   Name of the bone hit (valid only if we hit a skeletal mesh).
	/// @param HitItem               Primitive-specific data recording which item in the primitive was hit
	/// @param FaceIndex             If colliding with trimesh or landscape, index of face that was hit.
	/// </summary>
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
	static extern IntPtr SpawnDecalAttached(IntPtr _this,IntPtr DecalMaterial,ref FVector DecalSize,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,float LifeSpan);
	
	/// <summary>
	/// Spawns a decal attached to and following the specified component. Does not replicate.
	/// @param DecalMaterial - decal's material
	/// @param DecalSize - size of decal
	/// @param AttachComponent - Component to attach to.
	/// @param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
	/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
	/// @param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a realative offset
	/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
	/// @param LifeSpan - destroy decal component after time runs out (0 = infinite)
	/// </summary>
	public static UDecalComponent SpawnDecalAttached(UMaterialInterface DecalMaterial,FVector DecalSize,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,float LifeSpan=0.000000f)
	{
		IntPtr ___ret = SpawnDecalAttached(IntPtr.Zero,DecalMaterial,ref DecalSize,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,LifeSpan);
		if(___ret==IntPtr.Zero) return null; UDecalComponent ___ret2= new UDecalComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnDecalAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr DecalMaterial,ref FVector DecalSize,ref FVector Location,ref FRotator Rotation,float LifeSpan);
	
	/// <summary>
	/// Spawns a decal at the given location and rotation, fire and forget. Does not replicate.
	/// @param DecalMaterial - decal's material
	/// @param DecalSize - size of decal
	/// @param Location - location to place the decal in world space
	/// @param Rotation - rotation to place the decal in world space
	/// @param LifeSpan - destroy decal component after time runs out (0 = infinite)
	/// </summary>
	public static UDecalComponent SpawnDecalAtLocation(UObject WorldContextObject,UMaterialInterface DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation=default(FRotator),float LifeSpan=0.000000f)
	{
		IntPtr ___ret = SpawnDecalAtLocation(IntPtr.Zero,WorldContextObject,DecalMaterial,ref DecalSize,ref Location,ref Rotation,LifeSpan);
		if(___ret==IntPtr.Zero) return null; UDecalComponent ___ret2= new UDecalComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetCurrentReverbEffect(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns the highest priority reverb settings currently active from any source (volumes or manual setting).</summary>
	public static UReverbEffect GetCurrentReverbEffect(UObject WorldContextObject)
	{
		IntPtr ___ret = GetCurrentReverbEffect(IntPtr.Zero,WorldContextObject);
		if(___ret==IntPtr.Zero) return null; UReverbEffect ___ret2= new UReverbEffect(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DeactivateReverbEffect(IntPtr _this,IntPtr WorldContextObject,string TagName);
	
	/// <summary>
	/// Deactivates a Reverb Effect not applied by a volume
	/// @param TagName Tag associated with Reverb Effect to remove
	/// </summary>
	public static void DeactivateReverbEffect(UObject WorldContextObject,string TagName)
	{
		DeactivateReverbEffect(IntPtr.Zero,WorldContextObject,TagName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ActivateReverbEffect(IntPtr _this,IntPtr WorldContextObject,IntPtr ReverbEffect,string TagName,float Priority,float Volume,float FadeTime);
	
	/// <summary>
	/// Activates a Reverb Effect without the need for a volume
	/// @param ReverbEffect Reverb Effect to use
	/// @param TagName Tag to associate with Reverb Effect
	/// @param Priority Priority of the Reverb Effect
	/// @param Volume Volume level of Reverb Effect
	/// @param FadeTime Time before Reverb Effect is fully active
	/// </summary>
	public static void ActivateReverbEffect(UObject WorldContextObject,UReverbEffect ReverbEffect,string TagName,float Priority=0.000000f,float Volume=0.500000f,float FadeTime=2.000000f)
	{
		ActivateReverbEffect(IntPtr.Zero,WorldContextObject,ReverbEffect,TagName,Priority,Volume,FadeTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSoundMixModifiers(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Clear all sound mix modifiers from the audio system *</summary>
	public static void ClearSoundMixModifiers(UObject WorldContextObject)
	{
		ClearSoundMixModifiers(IntPtr.Zero,WorldContextObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PopSoundMixModifier(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier);
	
	/// <summary>Pop a sound mix modifier from the audio system *</summary>
	public static void PopSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier)
	{
		PopSoundMixModifier(IntPtr.Zero,WorldContextObject,InSoundMixModifier);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PushSoundMixModifier(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier);
	
	/// <summary>Push a sound mix modifier onto the audio system *</summary>
	public static void PushSoundMixModifier(UObject WorldContextObject,USoundMix InSoundMixModifier)
	{
		PushSoundMixModifier(IntPtr.Zero,WorldContextObject,InSoundMixModifier);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSoundMixClassOverride(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier,IntPtr InSoundClass,float FadeOutTime);
	
	/// <summary>
	/// Clears the override of the sound class adjuster in the given sound mix. If the override did not exist in the sound mix, this will do nothing.
	/// @param InSoundMixModifier The sound mix to modify.
	/// @param InSoundClass The sound class to override (or add) in the sound mix.
	/// @param FadeOutTime The interpolation time to use to go from the current sound class adjuster override values to the non-override values.
	/// </summary>
	public static void ClearSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float FadeOutTime=1.000000f)
	{
		ClearSoundMixClassOverride(IntPtr.Zero,WorldContextObject,InSoundMixModifier,InSoundClass,FadeOutTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSoundMixClassOverride(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMixModifier,IntPtr InSoundClass,float Volume,float Pitch,float FadeInTime,int bApplyToChildren);
	
	/// <summary>
	/// Overrides the sound class adjuster in the given sound mix. If the sound class does not exist in the input sound mix, the sound class adjustment will be added to the sound mix.
	/// @param InSoundMixModifier The sound mix to modify.
	/// @param InSoundClass The sound class to override (or add) in the sound mix.
	/// @param Volume The volume scale to set the sound class adjuster to.
	/// @param Pitch The pitch scale to set the sound class adjuster to.
	/// @param FadeInTime The interpolation time to use to go from the current sound class adjuster values to the new values.
	/// @param bApplyToChildren Whether or not to apply this override to the sound class' children or to just the specified sound class.
	/// </summary>
	public static void SetSoundMixClassOverride(UObject WorldContextObject,USoundMix InSoundMixModifier,USoundClass InSoundClass,float Volume=1.000000f,float Pitch=1.000000f,float FadeInTime=1.000000f,bool bApplyToChildren=true)
	{
		SetSoundMixClassOverride(IntPtr.Zero,WorldContextObject,InSoundMixModifier,InSoundClass,Volume,Pitch,FadeInTime,bApplyToChildren?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBaseSoundMix(IntPtr _this,IntPtr WorldContextObject,IntPtr InSoundMix);
	
	/// <summary>Set the sound mix of the audio system for special EQing *</summary>
	public static void SetBaseSoundMix(UObject WorldContextObject,USoundMix InSoundMix)
	{
		SetBaseSoundMix(IntPtr.Zero,WorldContextObject,InSoundMix);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int AreSubtitlesEnabled(IntPtr _this);
	
	/// <summary>
	/// Returns whether or not subtitles are currently enabled.
	/// @return true if subtitles are enabled.
	/// </summary>
	public static bool AreSubtitlesEnabled()
	{
		int ___ret = AreSubtitlesEnabled(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSubtitlesEnabled(IntPtr _this,int bEnabled);
	
	/// <summary>
	/// Will set subtitles to be enabled or disabled.
	/// @param bEnabled will enable subtitle drawing if true, disable if false.
	/// </summary>
	public static void SetSubtitlesEnabled(bool bEnabled)
	{
		SetSubtitlesEnabled(IntPtr.Zero,bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnForceFeedbackAttached(IntPtr _this,IntPtr ForceFeedbackEffect,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,int bLooping,float IntensityMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
	
	/// <summary>
	/// Plays a force feedback effect attached to and following the specified component. This is a fire and forget effect. Replication is also not handled at this point.
	/// @param ForceFeedbackEffect - effect to play
	/// @param AttachComponent - Component to attach to.
	/// @param AttachPointName - Optional named point within the AttachComponent to attach to
	/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
	/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
	/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
	/// @param bStopWhenAttachedToDestroyed - Specifies whether the feedback effect should stop playing when the owner of the attach to component is destroyed.
	/// @param IntensityMultiplier - Intensity multiplier
	/// @param StartTime - How far in to the feedback effect to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play effect with
	/// @param bAutoDestroy - Whether the returned force feedback component will be automatically cleaned up when the feedback patern finishes (by completing or stopping) or whether it can be reactivated
	/// @return Force Feedback Component to manipulate the playing feedback effect with
	/// </summary>
	public static UForceFeedbackComponent SpawnForceFeedbackAttached(UForceFeedbackEffect ForceFeedbackEffect,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnForceFeedbackAttached(IntPtr.Zero,ForceFeedbackEffect,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,bLooping?1:0,IntensityMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UForceFeedbackComponent ___ret2= new UForceFeedbackComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnForceFeedbackAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr ForceFeedbackEffect,ref FVector Location,ref FRotator Rotation,int bLooping,float IntensityMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
	
	/// <summary>
	/// Plays a force feedback effect at the given location. This is a fire and forget effect and does not travel with any actor. Replication is also not handled at this point.
	/// @param ForceFeedbackEffect - effect to play
	/// @param Location - World position to center the effect at
	/// @param Rotation - World rotation to center the effect at
	/// @param IntensityMultiplier - Intensity multiplier
	/// @param StartTime - How far in to the feedback effect to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play effect with
	/// @param bAutoDestroy - Whether the returned force feedback component will be automatically cleaned up when the feedback patern finishes (by completing or stopping) or whether it can be reactivated
	/// @return Force Feedback Component to manipulate the playing feedback effect with
	/// </summary>
	public static UForceFeedbackComponent SpawnForceFeedbackAtLocation(UObject WorldContextObject,UForceFeedbackEffect ForceFeedbackEffect,FVector Location,FRotator Rotation,bool bLooping=false,float IntensityMultiplier=1.000000f,float StartTime=0.000000f,UForceFeedbackAttenuation AttenuationSettings=default(UForceFeedbackAttenuation),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnForceFeedbackAtLocation(IntPtr.Zero,WorldContextObject,ForceFeedbackEffect,ref Location,ref Rotation,bLooping?1:0,IntensityMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UForceFeedbackComponent ___ret2= new UForceFeedbackComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnDialogueAttached(IntPtr _this,IntPtr Dialogue,ref FDialogueContext Context,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
	
	/// <summary>
	/// Spawns a dialogue attached to and following the specified component. This is a fire and forget sound. Replication is also not handled at this point.
	/// @param Dialogue - dialogue to play
	/// @param Context - context the dialogue is to play in
	/// @param AttachComponent - Component to attach to.
	/// @param AttachPointName - Optional named point within the AttachComponent to play the sound at
	/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
	/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
	/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
	/// @param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - PitchMultiplier
	/// @param StartTime - How far in to the dialogue to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return Audio Component to manipulate the playing dialogue with
	/// </summary>
	public static UAudioComponent SpawnDialogueAttached(UDialogueWave Dialogue,FDialogueContext Context,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnDialogueAttached(IntPtr.Zero,Dialogue,ref Context,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnDialogueAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,int bAutoDestroy);
	
	/// <summary>
	/// Plays a dialogue at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
	/// @param Dialogue - dialogue to play
	/// @param Context - context the dialogue is to play in
	/// @param Location - World position to play dialogue at
	/// @param Rotation - World rotation to play dialogue at
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - PitchMultiplier
	/// @param StartTime - How far in to the dialogue to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return Audio Component to manipulate the playing dialogue with
	/// </summary>
	public static UAudioComponent SpawnDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnDialogueAtLocation(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayDialogueAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings);
	
	/// <summary>
	/// Plays a dialogue at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
	/// @param Dialogue - dialogue to play
	/// @param Context - context the dialogue is to play in
	/// @param Location - World position to play dialogue at
	/// @param Rotation - World rotation to play dialogue at
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - Pitch multiplier
	/// @param StartTime - How far in to the dialogue to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// </summary>
	public static void PlayDialogueAtLocation(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation))
	{
		PlayDialogueAtLocation(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnDialogue2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,float VolumeMultiplier,float PitchMultiplier,float StartTime,int bAutoDestroy);
	
	/// <summary>
	/// Spawns a dialogue with no attenuation, perfect for UI.
	/// * Not Replicated.
	/// @param Dialogue - dialogue to play
	/// @param Context - context the dialogue is to play in
	/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
	/// @param PitchMultiplier - Multiplies the pitch.
	/// @param StartTime - How far in to the dialogue to begin playback at
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return An audio component to manipulate the spawned sound
	/// </summary>
	public static UAudioComponent SpawnDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnDialogue2D(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,VolumeMultiplier,PitchMultiplier,StartTime,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayDialogue2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Dialogue,ref FDialogueContext Context,float VolumeMultiplier,float PitchMultiplier,float StartTime);
	
	/// <summary>
	/// Plays a dialogue directly with no attenuation, perfect for UI.
	/// * Fire and Forget.
	/// * Not Replicated.
	/// @param Dialogue - dialogue to play
	/// @param Context - context the dialogue is to play in
	/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
	/// @param PitchMultiplier - Multiplies the pitch.
	/// @param StartTime - How far in to the dialogue to begin playback at
	/// </summary>
	public static void PlayDialogue2D(UObject WorldContextObject,UDialogueWave Dialogue,FDialogueContext Context,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f)
	{
		PlayDialogue2D(IntPtr.Zero,WorldContextObject,Dialogue,ref Context,VolumeMultiplier,PitchMultiplier,StartTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnSoundAttached(IntPtr _this,IntPtr Sound,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bStopWhenAttachedToDestroyed,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings,int bAutoDestroy);
	
	/// <summary>
	/// Plays a sound attached to and following the specified component. This is a fire and forget sound. Replication is also not handled at this point.
	/// @param Sound - sound to play
	/// @param AttachComponent - Component to attach to.
	/// @param AttachPointName - Optional named point within the AttachComponent to play the sound at
	/// @param Location - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world position that will be translated to a relative offset
	/// @param Rotation - Depending on the value of Location Type this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset
	/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
	/// @param bStopWhenAttachedToDestroyed - Specifies whether the sound should stop playing when the owner of the attach to component is destroyed.
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - PitchMultiplier
	/// @param StartTime - How far in to the sound to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return An audio component to manipulate the spawned sound
	/// </summary>
	public static UAudioComponent SpawnSoundAttached(USoundBase Sound,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnSoundAttached(IntPtr.Zero,Sound,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bStopWhenAttachedToDestroyed?1:0,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnSoundAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings,int bAutoDestroy);
	
	/// <summary>
	/// Spawns a sound at the given location. This does not travel with any actor. Replication is also not handled at this point.
	/// @param Sound - sound to play
	/// @param Location - World position to play sound at
	/// @param Rotation - World rotation to play sound at
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - PitchMultiplier
	/// @param StartTime - How far in to the sound to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return An audio component to manipulate the spawned sound
	/// </summary>
	public static UAudioComponent SpawnSoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnSoundAtLocation(IntPtr.Zero,WorldContextObject,Sound,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlaySoundAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,ref FVector Location,ref FRotator Rotation,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr AttenuationSettings,IntPtr ConcurrencySettings);
	
	/// <summary>
	/// Plays a sound at the given location. This is a fire and forget sound and does not travel with any actor. Replication is also not handled at this point.
	/// @param Sound - sound to play
	/// @param Location - World position to play sound at
	/// @param Rotation - World rotation to play sound at
	/// @param VolumeMultiplier - Volume multiplier
	/// @param PitchMultiplier - PitchMultiplier
	/// @param StartTime - How far in to the sound to begin playback at
	/// @param AttenuationSettings - Override attenuation settings package to play sound with
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// </summary>
	public static void PlaySoundAtLocation(UObject WorldContextObject,USoundBase Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundAttenuation AttenuationSettings=default(USoundAttenuation),USoundConcurrency ConcurrencySettings=default(USoundConcurrency))
	{
		PlaySoundAtLocation(IntPtr.Zero,WorldContextObject,Sound,ref Location,ref Rotation,VolumeMultiplier,PitchMultiplier,StartTime,AttenuationSettings,ConcurrencySettings);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr CreateSound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings,int bPersistAcrossLevelTransition,int bAutoDestroy);
	
	/// <summary>
	/// Creates a sound with no attenuation, perfect for UI sounds. This does NOT play the sound
	/// * Not Replicated.
	/// @param Sound - Sound to create.
	/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
	/// @param PitchMultiplier - Multiplies the pitch.
	/// @param StartTime - How far in to the sound to begin playback at
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// @param PersistAcrossLevelTransition - Whether the sound should continue to play when the map it was played in is unloaded
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return An audio component to manipulate the created sound
	/// </summary>
	public static UAudioComponent CreateSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true)
	{
		IntPtr ___ret = CreateSound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition?1:0,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnSound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings,int bPersistAcrossLevelTransition,int bAutoDestroy);
	
	/// <summary>
	/// Spawns a sound with no attenuation, perfect for UI sounds.
	/// * Not Replicated.
	/// @param Sound - Sound to play.
	/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
	/// @param PitchMultiplier - Multiplies the pitch.
	/// @param StartTime - How far in to the sound to begin playback at
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// @param PersistAcrossLevelTransition - Whether the sound should continue to play when the map it was played in is unloaded
	/// @param bAutoDestroy - Whether the returned audio component will be automatically cleaned up when the sound finishes (by completing or stopping) or whether it can be reactivated
	/// @return An audio component to manipulate the spawned sound
	/// </summary>
	public static UAudioComponent SpawnSound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency),bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnSound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings,bPersistAcrossLevelTransition?1:0,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UAudioComponent ___ret2= new UAudioComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlaySound2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier,float StartTime,IntPtr ConcurrencySettings);
	
	/// <summary>
	/// Plays a sound directly with no attenuation, perfect for UI sounds.
	/// * Fire and Forget.
	/// * Not Replicated.
	/// @param Sound - Sound to play.
	/// @param VolumeMultiplier - Multiplied with the volume to make the sound louder or softer.
	/// @param PitchMultiplier - Multiplies the pitch.
	/// @param ConcurrencySettings - Override concurrency settings package to play sound with
	/// @param StartTime - How far in to the sound to begin playback at
	/// </summary>
	public static void PlaySound2D(UObject WorldContextObject,USoundBase Sound,float VolumeMultiplier=1.000000f,float PitchMultiplier=1.000000f,float StartTime=0.000000f,USoundConcurrency ConcurrencySettings=default(USoundConcurrency))
	{
		PlaySound2D(IntPtr.Zero,WorldContextObject,Sound,VolumeMultiplier,PitchMultiplier,StartTime,ConcurrencySettings);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetGlobalListenerFocusParameters(IntPtr _this,IntPtr WorldContextObject,float FocusAzimuthScale,float NonFocusAzimuthScale,float FocusDistanceScale,float NonFocusDistanceScale,float FocusVolumeScale,float NonFocusVolumeScale,float FocusPriorityScale,float NonFocusPriorityScale);
	
	/// <summary>
	/// Sets the global listener focus parameters which will scale focus behavior of sounds based on their focus azimuth settings in their attenuation settings.
	/// * Fire and Forget.
	/// * Not Replicated.
	/// @param FocusAzimuthScale - An angle scale value used to scale the azimuth angle that defines where sounds are in-focus.
	/// @param NonFocusAzimuthScale- An angle scale value used to scale the azimuth angle that defines where sounds are out-of-focus.
	/// @param FocusDistanceScale - A distance scale value to use for sounds which are in-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
	/// @param NonFocusDistanceScale - A distance scale value to use for sounds which are out-of-focus. Values < 1.0 will reduce perceived distance to sounds, values > 1.0 will increase perceived distance to in-focus sounds.
	/// @param FocusVolumeScale- A volume attenuation value to use for sounds which are in-focus.
	/// @param NonFocusVolumeScale- A volume attenuation value to use for sounds which are out-of-focus.
	/// @param FocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are in-focus. Values < 1.0 will reduce the priority of in-focus sounds, values > 1.0 will increase the priority of in-focus sounds.
	/// @param NonFocusPriorityScale - A priority scale value (> 0.0) to use for sounds which are out-of-focus. Values < 1.0 will reduce the priority of sounds out-of-focus sounds, values > 1.0 will increase the priority of out-of-focus sounds.
	/// </summary>
	public static void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale=1.000000f,float NonFocusAzimuthScale=1.000000f,float FocusDistanceScale=1.000000f,float NonFocusDistanceScale=1.000000f,float FocusVolumeScale=1.000000f,float NonFocusVolumeScale=1.000000f,float FocusPriorityScale=1.000000f,float NonFocusPriorityScale=1.000000f)
	{
		SetGlobalListenerFocusParameters(IntPtr.Zero,WorldContextObject,FocusAzimuthScale,NonFocusAzimuthScale,FocusDistanceScale,NonFocusDistanceScale,FocusVolumeScale,NonFocusVolumeScale,FocusPriorityScale,NonFocusPriorityScale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetGlobalPitchModulation(IntPtr _this,IntPtr WorldContextObject,float PitchModulation,float TimeSec);
	
	/// <summary>
	/// Sets a global pitch modulation scalar that will apply to all non-UI sounds
	/// * Fire and Forget.
	/// * Not Replicated.
	/// @param PitchModulation - A pitch modulation value to globally set.
	/// @param TimeSec - A time value to linearly interpolate the global modulation pitch over from it's current value.
	/// </summary>
	public static void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec)
	{
		SetGlobalPitchModulation(IntPtr.Zero,WorldContextObject,PitchModulation,TimeSec);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int AreAnyListenersWithinRange(IntPtr _this,IntPtr WorldContextObject,ref FVector Location,float MaximumRange);
	
	/// <summary>
	/// Determines if any audio listeners are within range of the specified location
	/// @param Location              The location to potentially play a sound at
	/// @param MaximumRange  The maximum distance away from Location that a listener can be
	/// @note This will always return false if there is no audio device, or the audio device is disabled.
	/// </summary>
	public static bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange)
	{
		int ___ret = AreAnyListenersWithinRange(IntPtr.Zero,WorldContextObject,ref Location,MaximumRange);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnEmitterAttached(IntPtr _this,IntPtr EmitterTemplate,IntPtr AttachToComponent,string AttachPointName,ref FVector Location,ref FRotator Rotation,int LocationType,int bAutoDestroy);
	
	/// <summary>
	/// Plays the specified effect attached to and following the specified component. The system will go away when the effect is complete. Does not replicate.
	/// @param EmitterTemplate - particle system to create
	/// @param AttachComponent - Component to attach to.
	/// @param AttachPointName - Optional named point within the AttachComponent to spawn the emitter at
	/// @param Location - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world location that will be translated to a relative offset (if LocationType is KeepWorldPosition).
	/// @param Rotation - Depending on the value of LocationType this is either a relative offset from the attach component/point or an absolute world rotation that will be translated to a relative offset (if LocationType is KeepWorldPosition).
	/// @param LocationType - Specifies whether Location is a relative offset or an absolute world position
	/// @param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
	/// </summary>
	public static UParticleSystemComponent SpawnEmitterAttached(UParticleSystem EmitterTemplate,USceneComponent AttachToComponent,string AttachPointName="None",FVector Location=default(FVector),FRotator Rotation=default(FRotator),EAttachLocation LocationType=EAttachLocation.KeepRelativeOffset,bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnEmitterAttached(IntPtr.Zero,EmitterTemplate,AttachToComponent,AttachPointName,ref Location,ref Rotation,(int)LocationType,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UParticleSystemComponent ___ret2= new UParticleSystemComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnEmitterAtLocation(IntPtr _this,IntPtr WorldContextObject,IntPtr EmitterTemplate,ref FVector Location,ref FRotator Rotation,int bAutoDestroy);
	
	/// <summary>
	/// Plays the specified effect at the given location and rotation, fire and forget. The system will go away when the effect is complete. Does not replicate.
	/// @param WorldContextObject - Object that we can obtain a world context from
	/// @param EmitterTemplate - particle system to create
	/// @param Location - location to place the effect in world space
	/// @param Rotation - rotation to place the effect in world space
	/// @param bAutoDestroy - Whether the component will automatically be destroyed when the particle system completes playing or whether it can be reactivated
	/// </summary>
	public static UParticleSystemComponent SpawnEmitterAtLocation(UObject WorldContextObject,UParticleSystem EmitterTemplate,FVector Location,FRotator Rotation,bool bAutoDestroy=true)
	{
		IntPtr ___ret = SpawnEmitterAtLocation(IntPtr.Zero,WorldContextObject,EmitterTemplate,ref Location,ref Rotation,bAutoDestroy?1:0);
		if(___ret==IntPtr.Zero) return null; UParticleSystemComponent ___ret2= new UParticleSystemComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayWorldCameraShake(IntPtr _this,IntPtr WorldContextObject,IntPtr Shake,ref FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff,int bOrientShakeTowardsEpicenter);
	
	/// <summary>
	/// Plays an in-world camera shake that affects all nearby local players, with distance-based attenuation. Does not replicate.
	/// @param WorldContextObject - Object that we can obtain a world context from
	/// @param Shake - Camera shake asset to use
	/// @param Epicenter - location to place the effect in world space
	/// @param InnerRadius - Cameras inside this radius are ignored
	/// @param OuterRadius - Cameras outside of InnerRadius and inside this are effected
	/// @param Falloff - Affects falloff of effect as it nears OuterRadius
	/// @param bOrientShakeTowardsEpicenter - Changes the rotation of shake to point towards epicenter instead of forward
	/// </summary>
	public static void PlayWorldCameraShake(UObject WorldContextObject,TSubclassOf<UCameraShake>  Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff=1.000000f,bool bOrientShakeTowardsEpicenter=false)
	{
		PlayWorldCameraShake(IntPtr.Zero,WorldContextObject,Shake.NativeClass,ref Epicenter,InnerRadius,OuterRadius,Falloff,bOrientShakeTowardsEpicenter?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float ApplyDamage(IntPtr _this,IntPtr DamagedActor,float BaseDamage,IntPtr EventInstigator,IntPtr DamageCauser,IntPtr DamageTypeClass);
	
	/// <summary>
	/// Hurts the specified actor with generic damage.
	/// @param DamagedActor - Actor that will be damaged.
	/// @param BaseDamage - The base damage to apply.
	/// @param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
	/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
	/// @param DamageTypeClass - Class that describes the damage that was done.
	/// @return Actual damage the ended up being applied to the actor.
	/// </summary>
	public static float ApplyDamage(AActor DamagedActor,float BaseDamage,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
	{
		float ___ret = ApplyDamage(IntPtr.Zero,DamagedActor,BaseDamage,EventInstigator,DamageCauser,DamageTypeClass.NativeClass);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float ApplyPointDamage(IntPtr _this,IntPtr DamagedActor,float BaseDamage,ref FVector HitFromDirection,ref FHitResult HitInfo,IntPtr EventInstigator,IntPtr DamageCauser,IntPtr DamageTypeClass);
	
	/// <summary>
	/// Hurts the specified actor with the specified impact.
	/// @param DamagedActor - Actor that will be damaged.
	/// @param BaseDamage - The base damage to apply.
	/// @param HitFromDirection - Direction the hit came FROM
	/// @param HitInfo - Collision or trace result that describes the hit
	/// @param EventInstigator - Controller that was responsible for causing this damage (e.g. player who shot the weapon)
	/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
	/// @param DamageTypeClass - Class that describes the damage that was done.
	/// @return Actual damage the ended up being applied to the actor.
	/// </summary>
	public static float ApplyPointDamage(AActor DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,AController EventInstigator,AActor DamageCauser,TSubclassOf<UDamageType>  DamageTypeClass)
	{
		float ___ret = ApplyPointDamage(IntPtr.Zero,DamagedActor,BaseDamage,ref HitFromDirection,ref HitInfo,EventInstigator,DamageCauser,DamageTypeClass.NativeClass);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ApplyRadialDamageWithFalloff(IntPtr _this,IntPtr WorldContextObject,float BaseDamage,float MinimumDamage,ref FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,IntPtr DamageTypeClass,IntPtr[] IgnoreActors,IntPtr DamageCauser,IntPtr InstigatedByController,int DamagePreventionChannel);
	
	/// <summary>
	/// Hurt locally authoritative actors within the radius. Will only hit components that block the Visibility channel.
	/// @param BaseDamage - The base damage to apply, i.e. the damage at the origin.
	/// @param Origin - Epicenter of the damage area.
	/// @param DamageInnerRadius - Radius of the full damage area, from Origin
	/// @param DamageOuterRadius - Radius of the minimum damage area, from Origin
	/// @param DamageFalloff - Falloff exponent of damage from DamageInnerRadius to DamageOuterRadius
	/// @param DamageTypeClass - Class that describes the damage that was done.
	/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded)
	/// @param InstigatedByController - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
	/// @param bFullDamage - if true, damage not scaled based on distance from Origin
	/// @param DamagePreventionChannel - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
	/// @return true if damage was applied to at least one actor.
	/// </summary>
	public static bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,TSubclassOf<UDamageType>  DamageTypeClass,AActor[] IgnoreActors,AActor DamageCauser,AController InstigatedByController,ECollisionChannel DamagePreventionChannel=ECollisionChannel.ECC_Visibility)
	{
		int ___ret = ApplyRadialDamageWithFalloff(IntPtr.Zero,WorldContextObject,BaseDamage,MinimumDamage,ref Origin,DamageInnerRadius,DamageOuterRadius,DamageFalloff,DamageTypeClass.NativeClass,MarshalUtil.ObjectArrayToIntPtrArray(IgnoreActors),DamageCauser,InstigatedByController,(int)DamagePreventionChannel);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ApplyRadialDamage(IntPtr _this,IntPtr WorldContextObject,float BaseDamage,ref FVector Origin,float DamageRadius,IntPtr DamageTypeClass,IntPtr[] IgnoreActors,IntPtr DamageCauser,IntPtr InstigatedByController,int bDoFullDamage,int DamagePreventionChannel);
	
	/// <summary>
	/// Hurt locally authoritative actors within the radius. Will only hit components that block the Visibility channel.
	/// @param BaseDamage - The base damage to apply, i.e. the damage at the origin.
	/// @param Origin - Epicenter of the damage area.
	/// @param DamageRadius - Radius of the damage area, from Origin
	/// @param DamageTypeClass - Class that describes the damage that was done.
	/// @param DamageCauser - Actor that actually caused the damage (e.g. the grenade that exploded).  This actor will not be damaged and it will not block damage.
	/// @param InstigatedByController - Controller that was responsible for causing this damage (e.g. player who threw the grenade)
	/// @param bFullDamage - if true, damage not scaled based on distance from Origin
	/// @param DamagePreventionChannel - Damage will not be applied to victim if there is something between the origin and the victim which blocks traces on this channel
	/// @return true if damage was applied to at least one actor.
	/// </summary>
	public static bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,TSubclassOf<UDamageType>  DamageTypeClass,AActor[] IgnoreActors,AActor DamageCauser,AController InstigatedByController,bool bDoFullDamage=false,ECollisionChannel DamagePreventionChannel=ECollisionChannel.ECC_Visibility)
	{
		int ___ret = ApplyRadialDamage(IntPtr.Zero,WorldContextObject,BaseDamage,ref Origin,DamageRadius,DamageTypeClass.NativeClass,MarshalUtil.ObjectArrayToIntPtrArray(IgnoreActors),DamageCauser,InstigatedByController,bDoFullDamage?1:0,(int)DamagePreventionChannel);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsGamePaused(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>
	/// Returns the game's paused state
	/// @return      Whether the game is currently paused or not
	/// </summary>
	public static bool IsGamePaused(UObject WorldContextObject)
	{
		int ___ret = IsGamePaused(IntPtr.Zero,WorldContextObject);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SetGamePaused(IntPtr _this,IntPtr WorldContextObject,int bPaused);
	
	/// <summary>
	/// Sets the game's paused state
	/// @param       bPaused         Whether the game should be paused or not
	/// @return      Whether the game was successfully paused/unpaused
	/// </summary>
	public static bool SetGamePaused(UObject WorldContextObject,bool bPaused)
	{
		int ___ret = SetGamePaused(IntPtr.Zero,WorldContextObject,bPaused?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetGlobalTimeDilation(IntPtr _this,IntPtr WorldContextObject,float TimeDilation);
	
	/// <summary>
	/// Sets the global time dilation.
	/// @param       TimeDilation    value to set the global time dilation to
	/// </summary>
	public static void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation)
	{
		SetGlobalTimeDilation(IntPtr.Zero,WorldContextObject,TimeDilation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetGlobalTimeDilation(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>
	/// Gets the current global time dilation.
	/// @return Current time dilation.
	/// </summary>
	public static float GetGlobalTimeDilation(UObject WorldContextObject)
	{
		float ___ret = GetGlobalTimeDilation(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetObjectClass(IntPtr _this,IntPtr Object);
	
	/// <summary>Returns the class of a passed in Object, will always be valid if Object is not NULL</summary>
	public static UClass GetObjectClass(UObject Object)
	{
		IntPtr ___ret = GetObjectClass(IntPtr.Zero,Object);
		if(___ret==IntPtr.Zero) return null; UClass ___ret2= new UClass(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGameState(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns the current GameStateBase or Null if it can't be retrieved</summary>
	public static AGameStateBase GetGameState(UObject WorldContextObject)
	{
		IntPtr ___ret = GetGameState(IntPtr.Zero,WorldContextObject);
		if(___ret==IntPtr.Zero) return null; AGameStateBase ___ret2= new AGameStateBase(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGameMode(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns the current GameModeBase or Null if it can't be retrieved, such as on the client</summary>
	public static AGameModeBase GetGameMode(UObject WorldContextObject)
	{
		IntPtr ___ret = GetGameMode(IntPtr.Zero,WorldContextObject);
		if(___ret==IntPtr.Zero) return null; AGameModeBase ___ret2= new AGameModeBase(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetCurrentLevelName(IntPtr _this,IntPtr WorldContextObject,int bRemovePrefixString);
	
	/// <summary>
	/// Get the name of the currently-open level.
	/// @param bRemovePrefixString    remove any streaming- or editor- added prefixes from the level name.
	/// </summary>
	public static string GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString=true)
	{
		string ___ret = GetCurrentLevelName(IntPtr.Zero,WorldContextObject,bRemovePrefixString?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OpenLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,int bAbsolute,string Options);
	
	/// <summary>
	/// Travel to another level
	/// @param       LevelName                       the level to open
	/// @param       bAbsolute                       if true options are reset, if false options are carried over from current level
	/// @param       Options                         a string of options to use for the travel URL
	/// </summary>
	public static void OpenLevel(UObject WorldContextObject,string LevelName,bool bAbsolute=true,string Options=default(string))
	{
		OpenLevel(IntPtr.Zero,WorldContextObject,LevelName,bAbsolute?1:0,Options);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CancelAsyncLoading(IntPtr _this);
	
	/// <summary>Cancels all currently queued streaming packages</summary>
	public static void CancelAsyncLoading()
	{
		CancelAsyncLoading(IntPtr.Zero);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FlushLevelStreaming(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Flushes level streaming in blocking fashion and returns when all sub-levels are loaded / visible / hidden</summary>
	public static void FlushLevelStreaming(UObject WorldContextObject)
	{
		FlushLevelStreaming(IntPtr.Zero,WorldContextObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetStreamingLevel(IntPtr _this,IntPtr WorldContextObject,string PackageName);
	
	/// <summary>Returns level streaming object with specified level package name</summary>
	public static ULevelStreaming GetStreamingLevel(UObject WorldContextObject,string PackageName)
	{
		IntPtr ___ret = GetStreamingLevel(IntPtr.Zero,WorldContextObject,PackageName);
		if(___ret==IntPtr.Zero) return null; ULevelStreaming ___ret2= new ULevelStreaming(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UnloadStreamLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,ref FLatentActionInfo LatentInfo);
	
	/// <summary>Unload a streamed in level</summary>
	public static void UnloadStreamLevel(UObject WorldContextObject,string LevelName,FLatentActionInfo LatentInfo)
	{
		UnloadStreamLevel(IntPtr.Zero,WorldContextObject,LevelName,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void LoadStreamLevel(IntPtr _this,IntPtr WorldContextObject,string LevelName,int bMakeVisibleAfterLoad,int bShouldBlockOnLoad,ref FLatentActionInfo LatentInfo);
	
	/// <summary>Stream the level with the LevelName ; Calling again before it finishes has no effect</summary>
	public static void LoadStreamLevel(UObject WorldContextObject,string LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo)
	{
		LoadStreamLevel(IntPtr.Zero,WorldContextObject,LevelName,bMakeVisibleAfterLoad?1:0,bShouldBlockOnLoad?1:0,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlayerControllerID(IntPtr _this,IntPtr Player,int ControllerId);
	
	/// <summary>
	/// Sets what controller ID a Player should be using
	/// @param Player                        The player controller of the player to change the controller ID of
	/// @param ControllerId          The controller ID to assign to this player
	/// </summary>
	public static void SetPlayerControllerID(APlayerController Player,int ControllerId)
	{
		SetPlayerControllerID(IntPtr.Zero,Player,ControllerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPlayerControllerID(IntPtr _this,IntPtr Player);
	
	/// <summary>
	/// Gets what controller ID a Player is using
	/// @param Player         The player controller of the player to get the ID of
	/// @return                       The ID of the passed in player. -1 if there is no controller for the passed in player
	/// </summary>
	public static int GetPlayerControllerID(APlayerController Player)
	{
		int ___ret = GetPlayerControllerID(IntPtr.Zero,Player);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemovePlayer(IntPtr _this,IntPtr Player,int bDestroyPawn);
	
	/// <summary>
	/// Removes a player from this game.
	/// @param Player                       The player controller of the player to be removed
	/// @param bDestroyPawn         Whether the controlled pawn should be deleted as well
	/// </summary>
	public static void RemovePlayer(APlayerController Player,bool bDestroyPawn)
	{
		RemovePlayer(IntPtr.Zero,Player,bDestroyPawn?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr CreatePlayer(IntPtr _this,IntPtr WorldContextObject,int ControllerId,int bSpawnPawn);
	
	/// <summary>
	/// Create a new player for this game.
	/// @param ControllerId         The ID of the controller that the should control the newly created player.  A value of -1 specifies to use the next available ID
	/// @param bSpawnPawn           Whether a pawn should be spawned immediately. If false a pawn will not be created until transition to the next map.
	/// </summary>
	public static APlayerController CreatePlayer(UObject WorldContextObject,int ControllerId=-1,bool bSpawnPawn=true)
	{
		IntPtr ___ret = CreatePlayer(IntPtr.Zero,WorldContextObject,ControllerId,bSpawnPawn?1:0);
		if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPlayerCameraManager(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
	
	/// <summary>Returns the player's camera manager for the specified player index</summary>
	public static APlayerCameraManager GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex)
	{
		IntPtr ___ret = GetPlayerCameraManager(IntPtr.Zero,WorldContextObject,PlayerIndex);
		if(___ret==IntPtr.Zero) return null; APlayerCameraManager ___ret2= new APlayerCameraManager(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPlayerCharacter(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
	
	/// <summary>Returns the player character (NULL if the player pawn doesn't exist OR is not a character) at the specified player index</summary>
	public static ACharacter GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex)
	{
		IntPtr ___ret = GetPlayerCharacter(IntPtr.Zero,WorldContextObject,PlayerIndex);
		if(___ret==IntPtr.Zero) return null; ACharacter ___ret2= new ACharacter(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPlayerPawn(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
	
	/// <summary>Returns the player pawn at the specified player index</summary>
	public static APawn GetPlayerPawn(UObject WorldContextObject,int PlayerIndex)
	{
		IntPtr ___ret = GetPlayerPawn(IntPtr.Zero,WorldContextObject,PlayerIndex);
		if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPlayerController(IntPtr _this,IntPtr WorldContextObject,int PlayerIndex);
	
	/// <summary>Returns the player controller at the specified player index</summary>
	public static APlayerController GetPlayerController(UObject WorldContextObject,int PlayerIndex)
	{
		IntPtr ___ret = GetPlayerController(IntPtr.Zero,WorldContextObject,PlayerIndex);
		if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGameInstance(IntPtr _this,IntPtr WorldContextObject);
	
	/// <summary>Returns the game instance object</summary>
	public static UGameInstance GetGameInstance(UObject WorldContextObject)
	{
		IntPtr ___ret = GetGameInstance(IntPtr.Zero,WorldContextObject);
		if(___ret==IntPtr.Zero) return null; UGameInstance ___ret2= new UGameInstance(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAllActorsWithTag(IntPtr _this,IntPtr WorldContextObject,string Tag,out IntPtr[] OutActors);
	
	/// <summary>
	/// Find all Actors in the world with the specified tag.
	/// This is a slow operation, use with caution e.g. do not use every frame.
	/// @param  Tag                     Tag to find. Must be specified or result array will be empty.
	/// @param  OutActors       Output array of Actors of the specified tag.
	/// </summary>
	public static void GetAllActorsWithTag(UObject WorldContextObject,string Tag,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		GetAllActorsWithTag(IntPtr.Zero,WorldContextObject,Tag,out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAllActorsWithInterface(IntPtr _this,IntPtr WorldContextObject,IntPtr Interface,out IntPtr[] OutActors);
	
	/// <summary>
	/// Find all Actors in the world with the specified interface.
	/// This is a slow operation, use with caution e.g. do not use every frame.
	/// @param  Interface       Interface to find. Must be specified or result array will be empty.
	/// @param  OutActors       Output array of Actors of the specified interface.
	/// </summary>
	public static void GetAllActorsWithInterface(UObject WorldContextObject,TSubclassOf<UInterface>  Interface,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		GetAllActorsWithInterface(IntPtr.Zero,WorldContextObject,Interface.NativeClass,out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAllActorsOfClass(IntPtr _this,IntPtr WorldContextObject,IntPtr ActorClass,out IntPtr[] OutActors);
	
	/// <summary>
	/// Find all Actors in the world of the specified class.
	/// This is a slow operation, use with caution e.g. do not use every frame.
	/// @param  ActorClass      Class of Actor to find. Must be specified or result array will be empty.
	/// @param  OutActors       Output array of Actors of the specified class.
	/// </summary>
	public static void GetAllActorsOfClass(UObject WorldContextObject,TSubclassOf<AActor>  ActorClass,out AActor[] OutActors)
	{
		IntPtr[] OutActors_temp;
		GetAllActorsOfClass(IntPtr.Zero,WorldContextObject,ActorClass.NativeClass,out OutActors_temp);
		OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetActorArrayBounds(IntPtr _this,IntPtr[] Actors,int bOnlyCollidingComponents,out FVector Center,out FVector BoxExtent);
	
	/// <summary>Bind the bounds of an array of Actors</summary>
	public static void GetActorArrayBounds(AActor[] Actors,bool bOnlyCollidingComponents,out FVector Center,out FVector BoxExtent)
	{
		GetActorArrayBounds(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(Actors),bOnlyCollidingComponents?1:0,out Center,out BoxExtent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetActorArrayAverageLocation(IntPtr _this,IntPtr[] Actors);
	
	/// <summary>Find the average location (centroid) of an array of Actors</summary>
	public static FVector GetActorArrayAverageLocation(AActor[] Actors)
	{
		FVector ___ret = GetActorArrayAverageLocation(IntPtr.Zero,MarshalUtil.ObjectArrayToIntPtrArray(Actors));
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr FinishSpawningActor(IntPtr _this,IntPtr Actor,ref FTransform SpawnTransform);
	
	/// <summary>'Finish' spawning an actor.  This will run the construction script.</summary>
	public static AActor FinishSpawningActor(AActor Actor,FTransform SpawnTransform)
	{
		IntPtr ___ret = FinishSpawningActor(IntPtr.Zero,Actor,ref SpawnTransform);
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SpawnObject(IntPtr _this,IntPtr ObjectClass,IntPtr Outer);
	
	/// <summary>--- Create Object</summary>
	public static UObject SpawnObject(TSubclassOf<UObject>  ObjectClass,UObject Outer)
	{
		IntPtr ___ret = SpawnObject(IntPtr.Zero,ObjectClass.NativeClass,Outer);
		if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
