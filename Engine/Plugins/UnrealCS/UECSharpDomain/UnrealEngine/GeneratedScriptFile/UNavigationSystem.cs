//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavigationSystem:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnNavigationBoundsUpdated(IntPtr _this,IntPtr NavVolume);
	public  void OnNavigationBoundsUpdated(ANavMeshBoundsVolume NavVolume)
	{
		CheckIsValid();
		OnNavigationBoundsUpdated(_this.Get(),NavVolume);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void UnregisterNavigationInvoker(IntPtr _this,IntPtr Invoker);
	public  void UnregisterNavigationInvoker(AActor Invoker)
	{
		CheckIsValid();
		UnregisterNavigationInvoker(_this.Get(),Invoker);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RegisterNavigationInvoker(IntPtr _this,IntPtr Invoker,float TileGenerationRadius,float TileRemovalRadius);
	public  void RegisterNavigationInvoker(AActor Invoker,float TileGenerationRadius=3000.000000f,float TileRemovalRadius=5000.000000f)
	{
		CheckIsValid();
		RegisterNavigationInvoker(_this.Get(),Invoker,TileGenerationRadius,TileRemovalRadius);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetMaxSimultaneousTileGenerationJobsCount(IntPtr _this);
	public  void ResetMaxSimultaneousTileGenerationJobsCount()
	{
		CheckIsValid();
		ResetMaxSimultaneousTileGenerationJobsCount(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMaxSimultaneousTileGenerationJobsCount(IntPtr _this,int MaxNumberOfJobs);
	public  void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs)
	{
		CheckIsValid();
		SetMaxSimultaneousTileGenerationJobsCount(_this.Get(),MaxNumberOfJobs);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NavigationRaycast(IntPtr _this,IntPtr WorldContext,ref FVector RayStart,ref FVector RayEnd,out FVector HitLocation,IntPtr FilterClass,IntPtr Querier);
	public static bool NavigationRaycast(UObject WorldContext,FVector RayStart,FVector RayEnd,out FVector HitLocation,TSubclassOf<UNavigationQueryFilter>  FilterClass,AController Querier)
	{
		int ___ret = NavigationRaycast(IntPtr.Zero,WorldContext,ref RayStart,ref RayEnd,out HitLocation,FilterClass.NativeClass,Querier);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr FindPathToActorSynchronously(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,IntPtr GoalActor,float TetherDistance,IntPtr PathfindingContext,IntPtr FilterClass);
	public static UNavigationPath FindPathToActorSynchronously(UObject WorldContext,FVector PathStart,AActor GoalActor,float TetherDistance=50.000000f,AActor PathfindingContext=default(AActor),TSubclassOf<UNavigationQueryFilter>  FilterClass=default(TSubclassOf<UNavigationQueryFilter> ))
	{
		IntPtr ___ret = FindPathToActorSynchronously(IntPtr.Zero,WorldContext,ref PathStart,GoalActor,TetherDistance,PathfindingContext,FilterClass.NativeClass);
		if(___ret==IntPtr.Zero) return null; UNavigationPath ___ret2= new UNavigationPath(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr FindPathToLocationSynchronously(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,IntPtr PathfindingContext,IntPtr FilterClass);
	public static UNavigationPath FindPathToLocationSynchronously(UObject WorldContext,FVector PathStart,FVector PathEnd,AActor PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
	{
		IntPtr ___ret = FindPathToLocationSynchronously(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,PathfindingContext,FilterClass.NativeClass);
		if(___ret==IntPtr.Zero) return null; UNavigationPath ___ret2= new UNavigationPath(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SimpleMoveToLocation(IntPtr _this,IntPtr Controller,ref FVector Goal);
	public static void SimpleMoveToLocation(AController Controller,FVector Goal)
	{
		SimpleMoveToLocation(IntPtr.Zero,Controller,ref Goal);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SimpleMoveToActor(IntPtr _this,IntPtr Controller,IntPtr Goal);
	public static void SimpleMoveToActor(AController Controller,AActor Goal)
	{
		SimpleMoveToActor(IntPtr.Zero,Controller,Goal);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsNavigationBeingBuiltOrLocked(IntPtr _this,IntPtr WorldContext);
	public static bool IsNavigationBeingBuiltOrLocked(UObject WorldContext)
	{
		int ___ret = IsNavigationBeingBuiltOrLocked(IntPtr.Zero,WorldContext);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsNavigationBeingBuilt(IntPtr _this,IntPtr WorldContext);
	public static bool IsNavigationBeingBuilt(UObject WorldContext)
	{
		int ___ret = IsNavigationBeingBuilt(IntPtr.Zero,WorldContext);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPathLength(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,out float PathLength,IntPtr NavData,IntPtr FilterClass);
	public static ENavigationQueryResult GetPathLength(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathLength,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
	{
		int ___ret = GetPathLength(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,out PathLength,NavData,FilterClass.NativeClass);
		return (ENavigationQueryResult)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPathCost(IntPtr _this,IntPtr WorldContext,ref FVector PathStart,ref FVector PathEnd,out float PathCost,IntPtr NavData,IntPtr FilterClass);
	public static ENavigationQueryResult GetPathCost(UObject WorldContext,FVector PathStart,FVector PathEnd,out float PathCost,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
	{
		int ___ret = GetPathCost(IntPtr.Zero,WorldContext,ref PathStart,ref PathEnd,out PathCost,NavData,FilterClass.NativeClass);
		return (ENavigationQueryResult)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_GetRandomPointInNavigableRadius(IntPtr _this,IntPtr WorldContext,ref FVector Origin,out FVector RandomLocation,float Radius,IntPtr NavData,IntPtr FilterClass);
	public static bool K2_GetRandomPointInNavigableRadius(UObject WorldContext,FVector Origin,out FVector RandomLocation,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
	{
		int ___ret = K2_GetRandomPointInNavigableRadius(IntPtr.Zero,WorldContext,ref Origin,out RandomLocation,Radius,NavData,FilterClass.NativeClass);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_GetRandomReachablePointInRadius(IntPtr _this,IntPtr WorldContext,ref FVector Origin,out FVector RandomLocation,float Radius,IntPtr NavData,IntPtr FilterClass);
	public static bool K2_GetRandomReachablePointInRadius(UObject WorldContext,FVector Origin,out FVector RandomLocation,float Radius,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
	{
		int ___ret = K2_GetRandomReachablePointInRadius(IntPtr.Zero,WorldContext,ref Origin,out RandomLocation,Radius,NavData,FilterClass.NativeClass);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int K2_ProjectPointToNavigation(IntPtr _this,IntPtr WorldContext,ref FVector Point,out FVector ProjectedLocation,IntPtr NavData,IntPtr FilterClass,ref FVector QueryExtent);
	public static bool K2_ProjectPointToNavigation(UObject WorldContext,FVector Point,out FVector ProjectedLocation,ANavigationData NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass,FVector QueryExtent)
	{
		int ___ret = K2_ProjectPointToNavigation(IntPtr.Zero,WorldContext,ref Point,out ProjectedLocation,NavData,FilterClass.NativeClass,ref QueryExtent);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetNavigationSystem(IntPtr _this,IntPtr WorldContext);
	public static UNavigationSystem GetNavigationSystem(UObject WorldContext)
	{
		IntPtr ___ret = GetNavigationSystem(IntPtr.Zero,WorldContext);
		if(___ret==IntPtr.Zero) return null; UNavigationSystem ___ret2= new UNavigationSystem(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
