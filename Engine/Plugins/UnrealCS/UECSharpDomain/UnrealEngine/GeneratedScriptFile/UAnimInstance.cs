//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAnimInstance:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FMarkerSyncAnimPosition GetSyncGroupPosition(IntPtr _this,string InSyncGroupName);
	public  FMarkerSyncAnimPosition GetSyncGroupPosition(string InSyncGroupName)
	{
		CheckIsValid();
		FMarkerSyncAnimPosition ___ret = GetSyncGroupPosition(_this.Get(),InSyncGroupName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsSyncGroupBetweenMarkers(IntPtr _this,string InSyncGroupName,string PreviousMarker,string NextMarker,int bRespectMarkerOrder);
	public  bool IsSyncGroupBetweenMarkers(string InSyncGroupName,string PreviousMarker,string NextMarker,bool bRespectMarkerOrder=true)
	{
		CheckIsValid();
		int ___ret = IsSyncGroupBetweenMarkers(_this.Get(),InSyncGroupName,PreviousMarker,NextMarker,bRespectMarkerOrder?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasMarkerBeenHitThisFrame(IntPtr _this,string SyncGroup,string MarkerName);
	public  bool HasMarkerBeenHitThisFrame(string SyncGroup,string MarkerName)
	{
		CheckIsValid();
		int ___ret = HasMarkerBeenHitThisFrame(_this.Get(),SyncGroup,MarkerName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetTimeToClosestMarker(IntPtr _this,string SyncGroup,string MarkerName,out float OutMarkerTime);
	public  bool GetTimeToClosestMarker(string SyncGroup,string MarkerName,out float OutMarkerTime)
	{
		CheckIsValid();
		int ___ret = GetTimeToClosestMarker(_this.Get(),SyncGroup,MarkerName,out OutMarkerTime);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float CalculateDirection(IntPtr _this,ref FVector Velocity,ref FRotator BaseRotation);
	public  float CalculateDirection(FVector Velocity,FRotator BaseRotation)
	{
		CheckIsValid();
		float ___ret = CalculateDirection(_this.Get(),ref Velocity,ref BaseRotation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearMorphTargets(IntPtr _this);
	public  void ClearMorphTargets()
	{
		CheckIsValid();
		ClearMorphTargets(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMorphTarget(IntPtr _this,string MorphTargetName,float Value);
	public  void SetMorphTarget(string MorphTargetName,float Value)
	{
		CheckIsValid();
		SetMorphTarget(_this.Get(),MorphTargetName,Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetCurrentStateName(IntPtr _this,int MachineIndex);
	public  string GetCurrentStateName(int MachineIndex)
	{
		CheckIsValid();
		string ___ret = GetCurrentStateName(_this.Get(),MachineIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetCurveValue(IntPtr _this,string CurveName);
	public  float GetCurveValue(string CurveName)
	{
		CheckIsValid();
		float ___ret = GetCurveValue(_this.Get(),CurveName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRelevantAnimTimeFraction(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetRelevantAnimTimeFraction(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRelevantAnimTime(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetRelevantAnimTime(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetRelevantAnimTime(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRelevantAnimLength(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetRelevantAnimLength(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetRelevantAnimLength(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRelevantAnimTimeRemainingFraction(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetRelevantAnimTimeRemainingFraction(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRelevantAnimTimeRemaining(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetRelevantAnimTimeRemaining(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceTransitionTimeElapsedFraction(IntPtr _this,int MachineIndex,int TransitionIndex);
	public  float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceTransitionTimeElapsedFraction(_this.Get(),MachineIndex,TransitionIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceTransitionTimeElapsed(IntPtr _this,int MachineIndex,int TransitionIndex);
	public  float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceTransitionTimeElapsed(_this.Get(),MachineIndex,TransitionIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceTransitionCrossfadeDuration(IntPtr _this,int MachineIndex,int TransitionIndex);
	public  float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceTransitionCrossfadeDuration(_this.Get(),MachineIndex,TransitionIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceCurrentStateElapsedTime(IntPtr _this,int MachineIndex);
	public  float GetInstanceCurrentStateElapsedTime(int MachineIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceCurrentStateElapsedTime(_this.Get(),MachineIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceStateWeight(IntPtr _this,int MachineIndex,int StateIndex);
	public  float GetInstanceStateWeight(int MachineIndex,int StateIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceStateWeight(_this.Get(),MachineIndex,StateIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceMachineWeight(IntPtr _this,int MachineIndex);
	public  float GetInstanceMachineWeight(int MachineIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceMachineWeight(_this.Get(),MachineIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceAssetPlayerTimeFromEndFraction(IntPtr _this,int AssetPlayerIndex);
	public  float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceAssetPlayerTimeFromEndFraction(_this.Get(),AssetPlayerIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceAssetPlayerTimeFromEnd(IntPtr _this,int AssetPlayerIndex);
	public  float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceAssetPlayerTimeFromEnd(_this.Get(),AssetPlayerIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceAssetPlayerTimeFraction(IntPtr _this,int AssetPlayerIndex);
	public  float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceAssetPlayerTimeFraction(_this.Get(),AssetPlayerIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceAssetPlayerTime(IntPtr _this,int AssetPlayerIndex);
	public  float GetInstanceAssetPlayerTime(int AssetPlayerIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceAssetPlayerTime(_this.Get(),AssetPlayerIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInstanceAssetPlayerLength(IntPtr _this,int AssetPlayerIndex);
	public  float GetInstanceAssetPlayerLength(int AssetPlayerIndex)
	{
		CheckIsValid();
		float ___ret = GetInstanceAssetPlayerLength(_this.Get(),AssetPlayerIndex);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRootMotionMode(IntPtr _this,int Value);
	public  void SetRootMotionMode(ERootMotionMode Value)
	{
		CheckIsValid();
		SetRootMotionMode(_this.Get(),(int)Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetCurrentActiveMontage(IntPtr _this);
	public  UAnimMontage GetCurrentActiveMontage()
	{
		CheckIsValid();
		IntPtr ___ret = GetCurrentActiveMontage(_this.Get());
		if(___ret==IntPtr.Zero) return null; UAnimMontage ___ret2= new UAnimMontage(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsAnyMontagePlaying(IntPtr _this);
	public  bool IsAnyMontagePlaying()
	{
		CheckIsValid();
		int ___ret = IsAnyMontagePlaying(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Montage_GetPlayRate(IntPtr _this,IntPtr Montage);
	public  float Montage_GetPlayRate(UAnimMontage Montage)
	{
		CheckIsValid();
		float ___ret = Montage_GetPlayRate(_this.Get(),Montage);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Montage_GetBlendTime(IntPtr _this,IntPtr Montage);
	public  float Montage_GetBlendTime(UAnimMontage Montage)
	{
		CheckIsValid();
		float ___ret = Montage_GetBlendTime(_this.Get(),Montage);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Montage_GetIsStopped(IntPtr _this,IntPtr Montage);
	public  bool Montage_GetIsStopped(UAnimMontage Montage)
	{
		CheckIsValid();
		int ___ret = Montage_GetIsStopped(_this.Get(),Montage);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_SetPosition(IntPtr _this,IntPtr Montage,float NewPosition);
	public  void Montage_SetPosition(UAnimMontage Montage,float NewPosition)
	{
		CheckIsValid();
		Montage_SetPosition(_this.Get(),Montage,NewPosition);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Montage_GetPosition(IntPtr _this,IntPtr Montage);
	public  float Montage_GetPosition(UAnimMontage Montage)
	{
		CheckIsValid();
		float ___ret = Montage_GetPosition(_this.Get(),Montage);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string Montage_GetCurrentSection(IntPtr _this,IntPtr Montage);
	public  string Montage_GetCurrentSection(UAnimMontage Montage)
	{
		CheckIsValid();
		string ___ret = Montage_GetCurrentSection(_this.Get(),Montage);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Montage_IsPlaying(IntPtr _this,IntPtr Montage);
	public  bool Montage_IsPlaying(UAnimMontage Montage)
	{
		CheckIsValid();
		int ___ret = Montage_IsPlaying(_this.Get(),Montage);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Montage_IsActive(IntPtr _this,IntPtr Montage);
	public  bool Montage_IsActive(UAnimMontage Montage)
	{
		CheckIsValid();
		int ___ret = Montage_IsActive(_this.Get(),Montage);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_SetPlayRate(IntPtr _this,IntPtr Montage,float NewPlayRate);
	public  void Montage_SetPlayRate(UAnimMontage Montage,float NewPlayRate=1.000000f)
	{
		CheckIsValid();
		Montage_SetPlayRate(_this.Get(),Montage,NewPlayRate);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_SetNextSection(IntPtr _this,string SectionNameToChange,string NextSection,IntPtr Montage);
	public  void Montage_SetNextSection(string SectionNameToChange,string NextSection,UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_SetNextSection(_this.Get(),SectionNameToChange,NextSection,Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_JumpToSectionsEnd(IntPtr _this,string SectionName,IntPtr Montage);
	public  void Montage_JumpToSectionsEnd(string SectionName,UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_JumpToSectionsEnd(_this.Get(),SectionName,Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_JumpToSection(IntPtr _this,string SectionName,IntPtr Montage);
	public  void Montage_JumpToSection(string SectionName,UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_JumpToSection(_this.Get(),SectionName,Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_Resume(IntPtr _this,IntPtr Montage);
	public  void Montage_Resume(UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_Resume(_this.Get(),Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_Pause(IntPtr _this,IntPtr Montage);
	public  void Montage_Pause(UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_Pause(_this.Get(),Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Montage_Stop(IntPtr _this,float InBlendOutTime,IntPtr Montage);
	public  void Montage_Stop(float InBlendOutTime,UAnimMontage Montage)
	{
		CheckIsValid();
		Montage_Stop(_this.Get(),InBlendOutTime,Montage);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlayingSlotAnimation(IntPtr _this,IntPtr Asset,string SlotNodeName);
	public  bool IsPlayingSlotAnimation(UAnimSequenceBase Asset,string SlotNodeName)
	{
		CheckIsValid();
		int ___ret = IsPlayingSlotAnimation(_this.Get(),Asset,SlotNodeName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StopSlotAnimation(IntPtr _this,float InBlendOutTime,string SlotNodeName);
	public  void StopSlotAnimation(float InBlendOutTime=0.250000f,string SlotNodeName="None")
	{
		CheckIsValid();
		StopSlotAnimation(_this.Get(),InBlendOutTime,SlotNodeName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr PlaySlotAnimationAsDynamicMontage(IntPtr _this,IntPtr Asset,string SlotNodeName,float BlendInTime,float BlendOutTime,float InPlayRate,int LoopCount,float BlendOutTriggerTime,float InTimeToStartMontageAt);
	public  UAnimMontage PlaySlotAnimationAsDynamicMontage(UAnimSequenceBase Asset,string SlotNodeName,float BlendInTime=0.250000f,float BlendOutTime=0.250000f,float InPlayRate=1.000000f,int LoopCount=1,float BlendOutTriggerTime=-1.000000f,float InTimeToStartMontageAt=0.000000f)
	{
		CheckIsValid();
		IntPtr ___ret = PlaySlotAnimationAsDynamicMontage(_this.Get(),Asset,SlotNodeName,BlendInTime,BlendOutTime,InPlayRate,LoopCount,BlendOutTriggerTime,InTimeToStartMontageAt);
		if(___ret==IntPtr.Zero) return null; UAnimMontage ___ret2= new UAnimMontage(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningComponent(IntPtr _this);
	public  USkeletalMeshComponent GetOwningComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; USkeletalMeshComponent ___ret2= new USkeletalMeshComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningActor(IntPtr _this);
	public  AActor GetOwningActor()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningActor(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SnapshotPose(IntPtr _this,out FPoseSnapshot Snapshot);
	public  void SnapshotPose(out FPoseSnapshot Snapshot)
	{
		CheckIsValid();
		SnapshotPose(_this.Get(),out Snapshot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SavePoseSnapshot(IntPtr _this,string SnapshotName);
	public  void SavePoseSnapshot(string SnapshotName)
	{
		CheckIsValid();
		SavePoseSnapshot(_this.Get(),SnapshotName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr TryGetPawnOwner(IntPtr _this);
	public  APawn TryGetPawnOwner()
	{
		CheckIsValid();
		IntPtr ___ret = TryGetPawnOwner(_this.Get());
		if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
