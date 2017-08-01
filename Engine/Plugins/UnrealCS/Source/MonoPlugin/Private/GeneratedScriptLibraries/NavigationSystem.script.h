#pragma once

namespace UnrealEngine
{
	class _UNavigationSystem
	{
		static void OnNavigationBoundsUpdated(UNavigationSystem* _this,ANavMeshBoundsVolume* NavVolume)
		{
			_this->OnNavigationBoundsUpdated(NavVolume);
			
		}
		static void UnregisterNavigationInvoker(UNavigationSystem* _this,AActor* Invoker)
		{
			_this->UnregisterNavigationInvoker(Invoker);
			
		}
		static void RegisterNavigationInvoker(UNavigationSystem* _this,AActor* Invoker,float TileGenerationRadius,float TileRemovalRadius)
		{
			_this->RegisterNavigationInvoker(Invoker,TileGenerationRadius,TileRemovalRadius);
			
		}
		static void ResetMaxSimultaneousTileGenerationJobsCount(UNavigationSystem* _this)
		{
			_this->ResetMaxSimultaneousTileGenerationJobsCount();
			
		}
		static void SetMaxSimultaneousTileGenerationJobsCount(UNavigationSystem* _this,int32 MaxNumberOfJobs)
		{
			_this->SetMaxSimultaneousTileGenerationJobsCount(MaxNumberOfJobs);
			
		}
		static int32 NavigationRaycast(UNavigationSystem* _this,UObject* WorldContext,FVector* RayStart,FVector* RayEnd,FVector* HitLocation,TSubclassOf<UNavigationQueryFilter>  FilterClass,AController* Querier)
		{
			bool ___ret = _this->NavigationRaycast(WorldContext,*RayStart,*RayEnd,*HitLocation,FilterClass,Querier);
			return ___ret?1:0;
			
		}
		static UNavigationPath* FindPathToActorSynchronously(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,AActor* GoalActor,float TetherDistance,AActor* PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			UNavigationPath* ___ret = _this->FindPathToActorSynchronously(WorldContext,*PathStart,GoalActor,TetherDistance,PathfindingContext,FilterClass);
			return ___ret;
			
		}
		static UNavigationPath* FindPathToLocationSynchronously(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,AActor* PathfindingContext,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			UNavigationPath* ___ret = _this->FindPathToLocationSynchronously(WorldContext,*PathStart,*PathEnd,PathfindingContext,FilterClass);
			return ___ret;
			
		}
		static void SimpleMoveToLocation(UNavigationSystem* _this,AController* Controller,FVector* Goal)
		{
			_this->SimpleMoveToLocation(Controller,*Goal);
			
		}
		static void SimpleMoveToActor(UNavigationSystem* _this,AController* Controller,AActor* Goal)
		{
			_this->SimpleMoveToActor(Controller,Goal);
			
		}
		static int32 IsNavigationBeingBuiltOrLocked(UNavigationSystem* _this,UObject* WorldContext)
		{
			bool ___ret = _this->IsNavigationBeingBuiltOrLocked(WorldContext);
			return ___ret?1:0;
			
		}
		static int32 IsNavigationBeingBuilt(UNavigationSystem* _this,UObject* WorldContext)
		{
			bool ___ret = _this->IsNavigationBeingBuilt(WorldContext);
			return ___ret?1:0;
			
		}
		static int32 GetPathLength(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,float* PathLength,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			TEnumAsByte<ENavigationQueryResult::Type> ___ret = _this->GetPathLength(WorldContext,*PathStart,*PathEnd,*PathLength,NavData,FilterClass);
			return (int32)___ret.GetValue();
			
		}
		static int32 GetPathCost(UNavigationSystem* _this,UObject* WorldContext,FVector* PathStart,FVector* PathEnd,float* PathCost,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			TEnumAsByte<ENavigationQueryResult::Type> ___ret = _this->GetPathCost(WorldContext,*PathStart,*PathEnd,*PathCost,NavData,FilterClass);
			return (int32)___ret.GetValue();
			
		}
		static int32 K2_GetRandomPointInNavigableRadius(UNavigationSystem* _this,UObject* WorldContext,FVector* Origin,FVector* RandomLocation,float Radius,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			bool ___ret = _this->K2_GetRandomPointInNavigableRadius(WorldContext,*Origin,*RandomLocation,Radius,NavData,FilterClass);
			return ___ret?1:0;
			
		}
		static int32 K2_GetRandomReachablePointInRadius(UNavigationSystem* _this,UObject* WorldContext,FVector* Origin,FVector* RandomLocation,float Radius,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass)
		{
			bool ___ret = _this->K2_GetRandomReachablePointInRadius(WorldContext,*Origin,*RandomLocation,Radius,NavData,FilterClass);
			return ___ret?1:0;
			
		}
		static int32 K2_ProjectPointToNavigation(UNavigationSystem* _this,UObject* WorldContext,FVector* Point,FVector* ProjectedLocation,ANavigationData* NavData,TSubclassOf<UNavigationQueryFilter>  FilterClass,FVector* QueryExtent)
		{
			bool ___ret = _this->K2_ProjectPointToNavigation(WorldContext,*Point,*ProjectedLocation,NavData,FilterClass,*QueryExtent);
			return ___ret?1:0;
			
		}
		static UNavigationSystem* GetNavigationSystem(UNavigationSystem* _this,UObject* WorldContext)
		{
			UNavigationSystem* ___ret = _this->GetNavigationSystem(WorldContext);
			return ___ret;
			
		}
		static UClass* StaticClass(){return UNavigationSystem::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavigationSystem::OnNavigationBoundsUpdated",(const void*)OnNavigationBoundsUpdated);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::UnregisterNavigationInvoker",(const void*)UnregisterNavigationInvoker);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::RegisterNavigationInvoker",(const void*)RegisterNavigationInvoker);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::ResetMaxSimultaneousTileGenerationJobsCount",(const void*)ResetMaxSimultaneousTileGenerationJobsCount);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SetMaxSimultaneousTileGenerationJobsCount",(const void*)SetMaxSimultaneousTileGenerationJobsCount);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::NavigationRaycast",(const void*)NavigationRaycast);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::FindPathToActorSynchronously",(const void*)FindPathToActorSynchronously);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::FindPathToLocationSynchronously",(const void*)FindPathToLocationSynchronously);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SimpleMoveToLocation",(const void*)SimpleMoveToLocation);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::SimpleMoveToActor",(const void*)SimpleMoveToActor);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::IsNavigationBeingBuiltOrLocked",(const void*)IsNavigationBeingBuiltOrLocked);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::IsNavigationBeingBuilt",(const void*)IsNavigationBeingBuilt);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetPathLength",(const void*)GetPathLength);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetPathCost",(const void*)GetPathCost);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::K2_GetRandomPointInNavigableRadius",(const void*)K2_GetRandomPointInNavigableRadius);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::K2_GetRandomReachablePointInRadius",(const void*)K2_GetRandomReachablePointInRadius);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::K2_ProjectPointToNavigation",(const void*)K2_ProjectPointToNavigation);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::GetNavigationSystem",(const void*)GetNavigationSystem);
			mono_add_internal_call("UnrealEngine.UNavigationSystem::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
