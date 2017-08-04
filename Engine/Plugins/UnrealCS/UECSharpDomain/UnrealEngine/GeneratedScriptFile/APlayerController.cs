//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APlayerController:AController 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetFocalLocation(IntPtr _this);
	public  FVector GetFocalLocation()
	{
		CheckIsValid();
		FVector ___ret = GetFocalLocation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetSpectatorPawn(IntPtr _this);
	public  ASpectatorPawn GetSpectatorPawn()
	{
		CheckIsValid();
		IntPtr ___ret = GetSpectatorPawn(_this.Get());
		if(___ret==IntPtr.Zero) return null; ASpectatorPawn ___ret2= new ASpectatorPawn(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnServerStartedVisualLogger(IntPtr _this,int bIsLogging);
	public  void OnServerStartedVisualLogger(bool bIsLogging)
	{
		CheckIsValid();
		OnServerStartedVisualLogger(_this.Get(),bIsLogging?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCinematicMode(IntPtr _this,int bInCinematicMode,int bHidePlayer,int bAffectsHUD,int bAffectsMovement,int bAffectsTurning);
	public  void SetCinematicMode(bool bInCinematicMode,bool bHidePlayer,bool bAffectsHUD,bool bAffectsMovement,bool bAffectsTurning)
	{
		CheckIsValid();
		SetCinematicMode(_this.Get(),bInCinematicMode?1:0,bHidePlayer?1:0,bAffectsHUD?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearAudioListenerOverride(IntPtr _this);
	public  void ClearAudioListenerOverride()
	{
		CheckIsValid();
		ClearAudioListenerOverride(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAudioListenerOverride(IntPtr _this,IntPtr AttachToComponent,ref FVector Location,ref FRotator Rotation);
	public  void SetAudioListenerOverride(USceneComponent AttachToComponent,FVector Location,FRotator Rotation)
	{
		CheckIsValid();
		SetAudioListenerOverride(_this.Get(),AttachToComponent,ref Location,ref Rotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetViewTargetWithBlend(IntPtr _this,IntPtr NewViewTarget,float BlendTime,int BlendFunc,float BlendExp,int bLockOutgoing);
	public  void SetViewTargetWithBlend(AActor NewViewTarget,float BlendTime=0.000000f,EViewTargetBlendFunction BlendFunc=EViewTargetBlendFunction.VTBlend_Linear,float BlendExp=0.000000f,bool bLockOutgoing=false)
	{
		CheckIsValid();
		SetViewTargetWithBlend(_this.Get(),NewViewTarget,BlendTime,(int)BlendFunc,BlendExp,bLockOutgoing?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Camera(IntPtr _this,string NewMode);
	public  void Camera(string NewMode)
	{
		CheckIsValid();
		Camera(_this.Get(),NewMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVirtualJoystickVisibility(IntPtr _this,int bVisible);
	public  void SetVirtualJoystickVisibility(bool bVisible)
	{
		CheckIsValid();
		SetVirtualJoystickVisibility(_this.Get(),bVisible?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ActivateTouchInterface(IntPtr _this,IntPtr NewTouchInterface);
	public  void ActivateTouchInterface(UTouchInterface NewTouchInterface)
	{
		CheckIsValid();
		ActivateTouchInterface(_this.Get(),NewTouchInterface);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetInputAnalogStickState(IntPtr _this,int WhichStick,out float StickX,out float StickY);
	public  void GetInputAnalogStickState(EControllerAnalogStick WhichStick,out float StickX,out float StickY)
	{
		CheckIsValid();
		GetInputAnalogStickState(_this.Get(),(int)WhichStick,out StickX,out StickY);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetInputMouseDelta(IntPtr _this,out float DeltaX,out float DeltaY);
	public  void GetInputMouseDelta(out float DeltaX,out float DeltaY)
	{
		CheckIsValid();
		GetInputMouseDelta(_this.Get(),out DeltaX,out DeltaY);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInputKeyTimeDown(IntPtr _this,ref FKey Key);
	public  float GetInputKeyTimeDown(FKey Key)
	{
		CheckIsValid();
		float ___ret = GetInputKeyTimeDown(_this.Get(),ref Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMousePosition(IntPtr _this,out float LocationX,out float LocationY);
	public  bool GetMousePosition(out float LocationX,out float LocationY)
	{
		CheckIsValid();
		int ___ret = GetMousePosition(_this.Get(),out LocationX,out LocationY);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetInputMotionState(IntPtr _this,out FVector Tilt,out FVector RotationRate,out FVector Gravity,out FVector Acceleration);
	public  void GetInputMotionState(out FVector Tilt,out FVector RotationRate,out FVector Gravity,out FVector Acceleration)
	{
		CheckIsValid();
		GetInputMotionState(_this.Get(),out Tilt,out RotationRate,out Gravity,out Acceleration);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetInputTouchState(IntPtr _this,int FingerIndex,out float LocationX,out float LocationY,out int bIsCurrentlyPressed);
	public  void GetInputTouchState(ETouchIndex FingerIndex,out float LocationX,out float LocationY,out bool bIsCurrentlyPressed)
	{
		CheckIsValid();
		int bIsCurrentlyPressed_temp;
		GetInputTouchState(_this.Get(),(int)FingerIndex,out LocationX,out LocationY,out bIsCurrentlyPressed_temp);
		bIsCurrentlyPressed=bIsCurrentlyPressed_temp!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetInputVectorKeyState(IntPtr _this,ref FKey Key);
	public  FVector GetInputVectorKeyState(FKey Key)
	{
		CheckIsValid();
		FVector ___ret = GetInputVectorKeyState(_this.Get(),ref Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetInputAnalogKeyState(IntPtr _this,ref FKey Key);
	public  float GetInputAnalogKeyState(FKey Key)
	{
		CheckIsValid();
		float ___ret = GetInputAnalogKeyState(_this.Get(),ref Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int WasInputKeyJustReleased(IntPtr _this,ref FKey Key);
	public  bool WasInputKeyJustReleased(FKey Key)
	{
		CheckIsValid();
		int ___ret = WasInputKeyJustReleased(_this.Get(),ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int WasInputKeyJustPressed(IntPtr _this,ref FKey Key);
	public  bool WasInputKeyJustPressed(FKey Key)
	{
		CheckIsValid();
		int ___ret = WasInputKeyJustPressed(_this.Get(),ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInputKeyDown(IntPtr _this,ref FKey Key);
	public  bool IsInputKeyDown(FKey Key)
	{
		CheckIsValid();
		int ___ret = IsInputKeyDown(_this.Get(),ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddRollInput(IntPtr _this,float Val);
	public  void AddRollInput(float Val)
	{
		CheckIsValid();
		AddRollInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddYawInput(IntPtr _this,float Val);
	public  void AddYawInput(float Val)
	{
		CheckIsValid();
		AddYawInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddPitchInput(IntPtr _this,float Val);
	public  void AddPitchInput(float Val)
	{
		CheckIsValid();
		AddPitchInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerToggleAILogging(IntPtr _this);
	public  void ServerToggleAILogging()
	{
		CheckIsValid();
		ServerToggleAILogging(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientTeamMessage(IntPtr _this,IntPtr SenderPlayerState,string S,string Type,float MsgLifeTime);
	public  void ClientTeamMessage(APlayerState SenderPlayerState,string S,string Type,float MsgLifeTime)
	{
		CheckIsValid();
		ClientTeamMessage(_this.Get(),SenderPlayerState,S,Type,MsgLifeTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerViewSelf(IntPtr _this,ref FViewTargetTransitionParams TransitionParams);
	public  void ServerViewSelf(FViewTargetTransitionParams TransitionParams)
	{
		CheckIsValid();
		ServerViewSelf(_this.Get(),ref TransitionParams);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerViewPrevPlayer(IntPtr _this);
	public  void ServerViewPrevPlayer()
	{
		CheckIsValid();
		ServerViewPrevPlayer(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerViewNextPlayer(IntPtr _this);
	public  void ServerViewNextPlayer()
	{
		CheckIsValid();
		ServerViewNextPlayer(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerVerifyViewTarget(IntPtr _this);
	public  void ServerVerifyViewTarget()
	{
		CheckIsValid();
		ServerVerifyViewTarget(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerUpdateLevelVisibility(IntPtr _this,string PackageName,int bIsVisible);
	public  void ServerUpdateLevelVisibility(string PackageName,bool bIsVisible)
	{
		CheckIsValid();
		ServerUpdateLevelVisibility(_this.Get(),PackageName,bIsVisible?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerUpdateCamera(IntPtr _this,ref FVector_NetQuantize CamLoc,int CamPitchAndYaw);
	public  void ServerUpdateCamera(FVector_NetQuantize CamLoc,int CamPitchAndYaw)
	{
		CheckIsValid();
		ServerUpdateCamera(_this.Get(),ref CamLoc,CamPitchAndYaw);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerShortTimeout(IntPtr _this);
	public  void ServerShortTimeout()
	{
		CheckIsValid();
		ServerShortTimeout(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerCheckClientPossessionReliable(IntPtr _this);
	public  void ServerCheckClientPossessionReliable()
	{
		CheckIsValid();
		ServerCheckClientPossessionReliable(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerCheckClientPossession(IntPtr _this);
	public  void ServerCheckClientPossession()
	{
		CheckIsValid();
		ServerCheckClientPossession(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerSetSpectatorLocation(IntPtr _this,ref FVector NewLoc,ref FRotator NewRot);
	public  void ServerSetSpectatorLocation(FVector NewLoc,FRotator NewRot)
	{
		CheckIsValid();
		ServerSetSpectatorLocation(_this.Get(),ref NewLoc,ref NewRot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerRestartPlayer(IntPtr _this);
	public  void ServerRestartPlayer()
	{
		CheckIsValid();
		ServerRestartPlayer(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerPause(IntPtr _this);
	public  void ServerPause()
	{
		CheckIsValid();
		ServerPause(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerNotifyLoadedWorld(IntPtr _this,string WorldPackageName);
	public  void ServerNotifyLoadedWorld(string WorldPackageName)
	{
		CheckIsValid();
		ServerNotifyLoadedWorld(_this.Get(),WorldPackageName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerChangeName(IntPtr _this,string S);
	public  void ServerChangeName(string S)
	{
		CheckIsValid();
		ServerChangeName(_this.Get(),S);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerCamera(IntPtr _this,string NewMode);
	public  void ServerCamera(string NewMode)
	{
		CheckIsValid();
		ServerCamera(_this.Get(),NewMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerAcknowledgePossession(IntPtr _this,IntPtr P);
	public  void ServerAcknowledgePossession(APawn P)
	{
		CheckIsValid();
		ServerAcknowledgePossession(_this.Get(),P);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientReceiveLocalizedMessage(IntPtr _this,IntPtr Message,int Switch,IntPtr RelatedPlayerState_1,IntPtr RelatedPlayerState_2,IntPtr OptionalObject);
	public  void ClientReceiveLocalizedMessage(TSubclassOf<ULocalMessage>  Message,int Switch,APlayerState RelatedPlayerState_1,APlayerState RelatedPlayerState_2,UObject OptionalObject)
	{
		CheckIsValid();
		ClientReceiveLocalizedMessage(_this.Get(),Message.NativeClass,Switch,RelatedPlayerState_1,RelatedPlayerState_2,OptionalObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientRetryClientRestart(IntPtr _this,IntPtr NewPawn);
	public  void ClientRetryClientRestart(APawn NewPawn)
	{
		CheckIsValid();
		ClientRetryClientRestart(_this.Get(),NewPawn);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientEndOnlineSession(IntPtr _this);
	public  void ClientEndOnlineSession()
	{
		CheckIsValid();
		ClientEndOnlineSession(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientStartOnlineSession(IntPtr _this);
	public  void ClientStartOnlineSession()
	{
		CheckIsValid();
		ClientStartOnlineSession(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientWasKicked(IntPtr _this,string KickReason);
	public  void ClientWasKicked(string KickReason)
	{
		CheckIsValid();
		ClientWasKicked(_this.Get(),KickReason);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientUpdateLevelStreamingStatus(IntPtr _this,string PackageName,int bNewShouldBeLoaded,int bNewShouldBeVisible,int bNewShouldBlockOnLoad,int LODIndex);
	public  void ClientUpdateLevelStreamingStatus(string PackageName,bool bNewShouldBeLoaded,bool bNewShouldBeVisible,bool bNewShouldBlockOnLoad,int LODIndex)
	{
		CheckIsValid();
		ClientUpdateLevelStreamingStatus(_this.Get(),PackageName,bNewShouldBeLoaded?1:0,bNewShouldBeVisible?1:0,bNewShouldBlockOnLoad?1:0,LODIndex);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientTravelInternal(IntPtr _this,string URL,int TravelType,int bSeamless,ref FGuid MapPackageGuid);
	public  void ClientTravelInternal(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid)
	{
		CheckIsValid();
		ClientTravelInternal(_this.Get(),URL,(int)TravelType,bSeamless?1:0,ref MapPackageGuid);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientTravel(IntPtr _this,string URL,int TravelType,int bSeamless,ref FGuid MapPackageGuid);
	public  void ClientTravel(string URL,ETravelType TravelType,bool bSeamless,FGuid MapPackageGuid)
	{
		CheckIsValid();
		ClientTravel(_this.Get(),URL,(int)TravelType,bSeamless?1:0,ref MapPackageGuid);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetControllerLightColor(IntPtr _this,ref FColor Color);
	public  void SetControllerLightColor(FColor Color)
	{
		CheckIsValid();
		SetControllerLightColor(_this.Get(),ref Color);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayDynamicForceFeedback(IntPtr _this,float Intensity,float Duration,int bAffectsLeftLarge,int bAffectsLeftSmall,int bAffectsRightLarge,int bAffectsRightSmall,int Action,ref FLatentActionInfo LatentInfo);
	public  void PlayDynamicForceFeedback(float Intensity,float Duration,bool bAffectsLeftLarge,bool bAffectsLeftSmall,bool bAffectsRightLarge,bool bAffectsRightSmall,EDynamicForceFeedbackAction Action,FLatentActionInfo LatentInfo)
	{
		CheckIsValid();
		PlayDynamicForceFeedback(_this.Get(),Intensity,Duration,bAffectsLeftLarge?1:0,bAffectsLeftSmall?1:0,bAffectsRightLarge?1:0,bAffectsRightSmall?1:0,(int)Action,ref LatentInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientStopForceFeedback(IntPtr _this,IntPtr ForceFeedbackEffect,string Tag);
	public  void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,string Tag)
	{
		CheckIsValid();
		ClientStopForceFeedback(_this.Get(),ForceFeedbackEffect,Tag);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPlayForceFeedback(IntPtr _this,IntPtr ForceFeedbackEffect,int bLooping,string Tag);
	public  void ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect,bool bLooping,string Tag)
	{
		CheckIsValid();
		ClientPlayForceFeedback(_this.Get(),ForceFeedbackEffect,bLooping?1:0,Tag);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientStopCameraShake(IntPtr _this,IntPtr Shake,int bImmediately);
	public  void ClientStopCameraShake(TSubclassOf<UCameraShake>  Shake,bool bImmediately=true)
	{
		CheckIsValid();
		ClientStopCameraShake(_this.Get(),Shake.NativeClass,bImmediately?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientStopCameraAnim(IntPtr _this,IntPtr AnimToStop);
	public  void ClientStopCameraAnim(UCameraAnim AnimToStop)
	{
		CheckIsValid();
		ClientStopCameraAnim(_this.Get(),AnimToStop);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientClearCameraLensEffects(IntPtr _this);
	public  void ClientClearCameraLensEffects()
	{
		CheckIsValid();
		ClientClearCameraLensEffects(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSpawnCameraLensEffect(IntPtr _this,IntPtr LensEffectEmitterClass);
	public  void ClientSpawnCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase>  LensEffectEmitterClass)
	{
		CheckIsValid();
		ClientSpawnCameraLensEffect(_this.Get(),LensEffectEmitterClass.NativeClass);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetViewTarget(IntPtr _this,IntPtr A,ref FViewTargetTransitionParams TransitionParams);
	public  void ClientSetViewTarget(AActor A,FViewTargetTransitionParams TransitionParams)
	{
		CheckIsValid();
		ClientSetViewTarget(_this.Get(),A,ref TransitionParams);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetHUD(IntPtr _this);
	public  AHUD GetHUD()
	{
		CheckIsValid();
		IntPtr ___ret = GetHUD(_this.Get());
		if(___ret==IntPtr.Zero) return null; AHUD ___ret2= new AHUD(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetViewportSize(IntPtr _this,out int SizeX,out int SizeY);
	public  void GetViewportSize(out int SizeX,out int SizeY)
	{
		CheckIsValid();
		GetViewportSize(_this.Get(),out SizeX,out SizeY);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetHUD(IntPtr _this,IntPtr NewHUDClass);
	public  void ClientSetHUD(TSubclassOf<AHUD>  NewHUDClass)
	{
		CheckIsValid();
		ClientSetHUD(_this.Get(),NewHUDClass.NativeClass);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetForceMipLevelsToBeResident(IntPtr _this,IntPtr Material,float ForceDuration,int CinematicTextureGroups);
	public  void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material,float ForceDuration,int CinematicTextureGroups)
	{
		CheckIsValid();
		ClientSetForceMipLevelsToBeResident(_this.Get(),Material,ForceDuration,CinematicTextureGroups);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetCinematicMode(IntPtr _this,int bInCinematicMode,int bAffectsMovement,int bAffectsTurning,int bAffectsHUD);
	public  void ClientSetCinematicMode(bool bInCinematicMode,bool bAffectsMovement,bool bAffectsTurning,bool bAffectsHUD)
	{
		CheckIsValid();
		ClientSetCinematicMode(_this.Get(),bInCinematicMode?1:0,bAffectsMovement?1:0,bAffectsTurning?1:0,bAffectsHUD?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetCameraMode(IntPtr _this,string NewCamMode);
	public  void ClientSetCameraMode(string NewCamMode)
	{
		CheckIsValid();
		ClientSetCameraMode(_this.Get(),NewCamMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetCameraFade(IntPtr _this,int bEnableFading,ref FColor FadeColor,ref FVector2D FadeAlpha,float FadeTime,int bFadeAudio);
	public  void ClientSetCameraFade(bool bEnableFading,FColor FadeColor,FVector2D FadeAlpha,float FadeTime,bool bFadeAudio)
	{
		CheckIsValid();
		ClientSetCameraFade(_this.Get(),bEnableFading?1:0,ref FadeColor,ref FadeAlpha,FadeTime,bFadeAudio?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetBlockOnAsyncLoading(IntPtr _this);
	public  void ClientSetBlockOnAsyncLoading()
	{
		CheckIsValid();
		ClientSetBlockOnAsyncLoading(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientRestart(IntPtr _this,IntPtr NewPawn);
	public  void ClientRestart(APawn NewPawn)
	{
		CheckIsValid();
		ClientRestart(_this.Get(),NewPawn);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientReset(IntPtr _this);
	public  void ClientReset()
	{
		CheckIsValid();
		ClientReset(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPrestreamTextures(IntPtr _this,IntPtr ForcedActor,float ForceDuration,int bEnableStreaming,int CinematicTextureGroups);
	public  void ClientPrestreamTextures(AActor ForcedActor,float ForceDuration,bool bEnableStreaming,int CinematicTextureGroups)
	{
		CheckIsValid();
		ClientPrestreamTextures(_this.Get(),ForcedActor,ForceDuration,bEnableStreaming?1:0,CinematicTextureGroups);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPrepareMapChange(IntPtr _this,string LevelName,int bFirst,int bLast);
	public  void ClientPrepareMapChange(string LevelName,bool bFirst,bool bLast)
	{
		CheckIsValid();
		ClientPrepareMapChange(_this.Get(),LevelName,bFirst?1:0,bLast?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPlaySoundAtLocation(IntPtr _this,IntPtr Sound,ref FVector Location,float VolumeMultiplier,float PitchMultiplier);
	public  void ClientPlaySoundAtLocation(USoundBase Sound,FVector Location,float VolumeMultiplier,float PitchMultiplier)
	{
		CheckIsValid();
		ClientPlaySoundAtLocation(_this.Get(),Sound,ref Location,VolumeMultiplier,PitchMultiplier);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPlaySound(IntPtr _this,IntPtr Sound,float VolumeMultiplier,float PitchMultiplier);
	public  void ClientPlaySound(USoundBase Sound,float VolumeMultiplier,float PitchMultiplier)
	{
		CheckIsValid();
		ClientPlaySound(_this.Get(),Sound,VolumeMultiplier,PitchMultiplier);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPlayCameraShake(IntPtr _this,IntPtr Shake,float Scale,int PlaySpace,ref FRotator UserPlaySpaceRot);
	public  void ClientPlayCameraShake(TSubclassOf<UCameraShake>  Shake,float Scale=1.000000f,ECameraAnimPlaySpace PlaySpace=ECameraAnimPlaySpace.CameraLocal,FRotator UserPlaySpaceRot=default(FRotator))
	{
		CheckIsValid();
		ClientPlayCameraShake(_this.Get(),Shake.NativeClass,Scale,(int)PlaySpace,ref UserPlaySpaceRot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientPlayCameraAnim(IntPtr _this,IntPtr AnimToPlay,float Scale,float Rate,float BlendInTime,float BlendOutTime,int bLoop,int bRandomStartTime,int Space,ref FRotator CustomPlaySpace);
	public  void ClientPlayCameraAnim(UCameraAnim AnimToPlay,float Scale=1.000000f,float Rate=1.000000f,float BlendInTime=0.000000f,float BlendOutTime=0.000000f,bool bLoop=false,bool bRandomStartTime=false,ECameraAnimPlaySpace Space=ECameraAnimPlaySpace.CameraLocal,FRotator CustomPlaySpace=default(FRotator))
	{
		CheckIsValid();
		ClientPlayCameraAnim(_this.Get(),AnimToPlay,Scale,Rate,BlendInTime,BlendOutTime,bLoop?1:0,bRandomStartTime?1:0,(int)Space,ref CustomPlaySpace);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientMessage(IntPtr _this,string S,string Type,float MsgLifeTime);
	public  void ClientMessage(string S,string Type,float MsgLifeTime)
	{
		CheckIsValid();
		ClientMessage(_this.Get(),S,Type,MsgLifeTime);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientIgnoreMoveInput(IntPtr _this,int bIgnore);
	public  void ClientIgnoreMoveInput(bool bIgnore)
	{
		CheckIsValid();
		ClientIgnoreMoveInput(_this.Get(),bIgnore?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientIgnoreLookInput(IntPtr _this,int bIgnore);
	public  void ClientIgnoreLookInput(bool bIgnore)
	{
		CheckIsValid();
		ClientIgnoreLookInput(_this.Get(),bIgnore?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientGotoState(IntPtr _this,string NewState);
	public  void ClientGotoState(string NewState)
	{
		CheckIsValid();
		ClientGotoState(_this.Get(),NewState);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientGameEnded(IntPtr _this,IntPtr EndGameFocus,int bIsWinner);
	public  void ClientGameEnded(AActor EndGameFocus,bool bIsWinner)
	{
		CheckIsValid();
		ClientGameEnded(_this.Get(),EndGameFocus,bIsWinner?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientForceGarbageCollection(IntPtr _this);
	public  void ClientForceGarbageCollection()
	{
		CheckIsValid();
		ClientForceGarbageCollection(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientFlushLevelStreaming(IntPtr _this);
	public  void ClientFlushLevelStreaming()
	{
		CheckIsValid();
		ClientFlushLevelStreaming(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientCommitMapChange(IntPtr _this);
	public  void ClientCommitMapChange()
	{
		CheckIsValid();
		ClientCommitMapChange(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientCapBandwidth(IntPtr _this,int Cap);
	public  void ClientCapBandwidth(int Cap)
	{
		CheckIsValid();
		ClientCapBandwidth(_this.Get(),Cap);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientCancelPendingMapChange(IntPtr _this);
	public  void ClientCancelPendingMapChange()
	{
		CheckIsValid();
		ClientCancelPendingMapChange(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientAddTextureStreamingLoc(IntPtr _this,ref FVector InLoc,float Duration,int bOverrideLocation);
	public  void ClientAddTextureStreamingLoc(FVector InLoc,float Duration,bool bOverrideLocation)
	{
		CheckIsValid();
		ClientAddTextureStreamingLoc(_this.Get(),ref InLoc,Duration,bOverrideLocation?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SendToConsole(IntPtr _this,string Command);
	public  void SendToConsole(string Command)
	{
		CheckIsValid();
		SendToConsole(_this.Get(),Command);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ConsoleKey(IntPtr _this,ref FKey Key);
	public  void ConsoleKey(FKey Key)
	{
		CheckIsValid();
		ConsoleKey(_this.Get(),ref Key);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientUnmutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
	public  void ClientUnmutePlayer(FUniqueNetIdRepl PlayerId)
	{
		CheckIsValid();
		ClientUnmutePlayer(_this.Get(),ref PlayerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientMutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
	public  void ClientMutePlayer(FUniqueNetIdRepl PlayerId)
	{
		CheckIsValid();
		ClientMutePlayer(_this.Get(),ref PlayerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerUnmutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
	public  void ServerUnmutePlayer(FUniqueNetIdRepl PlayerId)
	{
		CheckIsValid();
		ServerUnmutePlayer(_this.Get(),ref PlayerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerMutePlayer(IntPtr _this,ref FUniqueNetIdRepl PlayerId);
	public  void ServerMutePlayer(FUniqueNetIdRepl PlayerId)
	{
		CheckIsValid();
		ServerMutePlayer(_this.Get(),ref PlayerId);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientVoiceHandshakeComplete(IntPtr _this);
	public  void ClientVoiceHandshakeComplete()
	{
		CheckIsValid();
		ClientVoiceHandshakeComplete(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ToggleSpeaking(IntPtr _this,int bInSpeaking);
	public  void ToggleSpeaking(bool bInSpeaking)
	{
		CheckIsValid();
		ToggleSpeaking(_this.Get(),bInSpeaking?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientEnableNetworkVoice(IntPtr _this,int bEnable);
	public  void ClientEnableNetworkVoice(bool bEnable)
	{
		CheckIsValid();
		ClientEnableNetworkVoice(_this.Get(),bEnable?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StartFire(IntPtr _this,int FireModeNum);
	public  void StartFire(byte FireModeNum=0)
	{
		CheckIsValid();
		StartFire(_this.Get(),FireModeNum);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMouseLocation(IntPtr _this,int X,int Y);
	public  void SetMouseLocation(int X,int Y)
	{
		CheckIsValid();
		SetMouseLocation(_this.Get(),X,Y);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ProjectWorldLocationToScreen(IntPtr _this,ref FVector WorldLocation,out FVector2D ScreenLocation,int bPlayerViewportRelative);
	public  bool ProjectWorldLocationToScreen(FVector WorldLocation,out FVector2D ScreenLocation,bool bPlayerViewportRelative=false)
	{
		CheckIsValid();
		int ___ret = ProjectWorldLocationToScreen(_this.Get(),ref WorldLocation,out ScreenLocation,bPlayerViewportRelative?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DeprojectScreenPositionToWorld(IntPtr _this,float ScreenX,float ScreenY,out FVector WorldLocation,out FVector WorldDirection);
	public  bool DeprojectScreenPositionToWorld(float ScreenX,float ScreenY,out FVector WorldLocation,out FVector WorldDirection)
	{
		CheckIsValid();
		int ___ret = DeprojectScreenPositionToWorld(_this.Get(),ScreenX,ScreenY,out WorldLocation,out WorldDirection);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DeprojectMousePositionToWorld(IntPtr _this,out FVector WorldLocation,out FVector WorldDirection);
	public  bool DeprojectMousePositionToWorld(out FVector WorldLocation,out FVector WorldDirection)
	{
		CheckIsValid();
		int ___ret = DeprojectMousePositionToWorld(_this.Get(),out WorldLocation,out WorldDirection);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHitResultUnderFingerForObjects(IntPtr _this,int FingerIndex,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,out FHitResult HitResult);
	public  bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex,EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,out FHitResult HitResult)
	{
		CheckIsValid();
		int ___ret = GetHitResultUnderFingerForObjects(_this.Get(),(int)FingerIndex,ObjectTypes,bTraceComplex?1:0,out HitResult);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHitResultUnderFingerByChannel(IntPtr _this,int FingerIndex,int TraceChannel,int bTraceComplex,out FHitResult HitResult);
	public  bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex,ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult)
	{
		CheckIsValid();
		int ___ret = GetHitResultUnderFingerByChannel(_this.Get(),(int)FingerIndex,(int)TraceChannel,bTraceComplex?1:0,out HitResult);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHitResultUnderCursorForObjects(IntPtr _this,EObjectTypeQuery[] ObjectTypes,int bTraceComplex,out FHitResult HitResult);
	public  bool GetHitResultUnderCursorForObjects(EObjectTypeQuery[] ObjectTypes,bool bTraceComplex,out FHitResult HitResult)
	{
		CheckIsValid();
		int ___ret = GetHitResultUnderCursorForObjects(_this.Get(),ObjectTypes,bTraceComplex?1:0,out HitResult);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHitResultUnderCursorByChannel(IntPtr _this,int TraceChannel,int bTraceComplex,out FHitResult HitResult);
	public  bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel,bool bTraceComplex,out FHitResult HitResult)
	{
		CheckIsValid();
		int ___ret = GetHitResultUnderCursorByChannel(_this.Get(),(int)TraceChannel,bTraceComplex?1:0,out HitResult);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SwitchLevel(IntPtr _this,string URL);
	public  void SwitchLevel(string URL)
	{
		CheckIsValid();
		SwitchLevel(_this.Get(),URL);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetName(IntPtr _this,string S);
	public  void SetName(string S)
	{
		CheckIsValid();
		SetName(_this.Get(),S);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Pause(IntPtr _this);
	public  void Pause()
	{
		CheckIsValid();
		Pause(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientRepObjRef(IntPtr _this,IntPtr Object);
	public  void ClientRepObjRef(UObject Object)
	{
		CheckIsValid();
		ClientRepObjRef(_this.Get(),Object);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientReturnToMainMenu(IntPtr _this,string ReturnReason);
	public  void ClientReturnToMainMenu(string ReturnReason)
	{
		CheckIsValid();
		ClientReturnToMainMenu(_this.Get(),ReturnReason);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void LocalTravel(IntPtr _this,string URL);
	public  void LocalTravel(string URL)
	{
		CheckIsValid();
		LocalTravel(_this.Get(),URL);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RestartLevel(IntPtr _this);
	public  void RestartLevel()
	{
		CheckIsValid();
		RestartLevel(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FOV(IntPtr _this,float NewFOV);
	public  void FOV(float NewFOV)
	{
		CheckIsValid();
		FOV(_this.Get(),NewFOV);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EnableCheats(IntPtr _this);
	public  void EnableCheats()
	{
		CheckIsValid();
		EnableCheats(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClientSetSpectatorWaiting(IntPtr _this,int bWaiting);
	public  void ClientSetSpectatorWaiting(bool bWaiting)
	{
		CheckIsValid();
		ClientSetSpectatorWaiting(_this.Get(),bWaiting?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ServerSetSpectatorWaiting(IntPtr _this,int bWaiting);
	public  void ServerSetSpectatorWaiting(bool bWaiting)
	{
		CheckIsValid();
		ServerSetSpectatorWaiting(_this.Get(),bWaiting?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
