//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UUserWidget:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlayingAnimation(IntPtr _this);
	public  bool IsPlayingAnimation()
	{
		CheckIsValid();
		int ___ret = IsPlayingAnimation(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ReverseAnimation(IntPtr _this,IntPtr InAnimation);
	public  void ReverseAnimation(UWidgetAnimation InAnimation)
	{
		CheckIsValid();
		ReverseAnimation(_this.Get(),InAnimation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPlaybackSpeed(IntPtr _this,IntPtr InAnimation,float PlaybackSpeed);
	public  void SetPlaybackSpeed(UWidgetAnimation InAnimation,float PlaybackSpeed=1.000000f)
	{
		CheckIsValid();
		SetPlaybackSpeed(_this.Get(),InAnimation,PlaybackSpeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNumLoopsToPlay(IntPtr _this,IntPtr InAnimation,int NumLoopsToPlay);
	public  void SetNumLoopsToPlay(UWidgetAnimation InAnimation,int NumLoopsToPlay)
	{
		CheckIsValid();
		SetNumLoopsToPlay(_this.Get(),InAnimation,NumLoopsToPlay);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsAnyAnimationPlaying(IntPtr _this);
	public  bool IsAnyAnimationPlaying()
	{
		CheckIsValid();
		int ___ret = IsAnyAnimationPlaying(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsAnimationPlaying(IntPtr _this,IntPtr InAnimation);
	public  bool IsAnimationPlaying(UWidgetAnimation InAnimation)
	{
		CheckIsValid();
		int ___ret = IsAnimationPlaying(_this.Get(),InAnimation);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetAnimationCurrentTime(IntPtr _this,IntPtr InAnimation);
	public  float GetAnimationCurrentTime(UWidgetAnimation InAnimation)
	{
		CheckIsValid();
		float ___ret = GetAnimationCurrentTime(_this.Get(),InAnimation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float PauseAnimation(IntPtr _this,IntPtr InAnimation);
	public  float PauseAnimation(UWidgetAnimation InAnimation)
	{
		CheckIsValid();
		float ___ret = PauseAnimation(_this.Get(),InAnimation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void StopAnimation(IntPtr _this,IntPtr InAnimation);
	public  void StopAnimation(UWidgetAnimation InAnimation)
	{
		CheckIsValid();
		StopAnimation(_this.Get(),InAnimation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayAnimationTo(IntPtr _this,IntPtr InAnimation,float StartAtTime,float EndAtTime,int NumLoopsToPlay,int PlayMode,float PlaybackSpeed);
	public  void PlayAnimationTo(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,float EndAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f)
	{
		CheckIsValid();
		PlayAnimationTo(_this.Get(),InAnimation,StartAtTime,EndAtTime,NumLoopsToPlay,(int)PlayMode,PlaybackSpeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PlayAnimation(IntPtr _this,IntPtr InAnimation,float StartAtTime,int NumLoopsToPlay,int PlayMode,float PlaybackSpeed);
	public  void PlayAnimation(UWidgetAnimation InAnimation,float StartAtTime=0.000000f,int NumLoopsToPlay=1,EUMGSequencePlayMode PlayMode=EUMGSequencePlayMode.Forward,float PlaybackSpeed=1.000000f)
	{
		CheckIsValid();
		PlayAnimation(_this.Get(),InAnimation,StartAtTime,NumLoopsToPlay,(int)PlayMode,PlaybackSpeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPadding(IntPtr _this,ref FMargin InPadding);
	public  void SetPadding(FMargin InPadding)
	{
		CheckIsValid();
		SetPadding(_this.Get(),ref InPadding);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetForegroundColor(IntPtr _this,ref FSlateColor InForegroundColor);
	public  void SetForegroundColor(FSlateColor InForegroundColor)
	{
		CheckIsValid();
		SetForegroundColor(_this.Get(),ref InForegroundColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetColorAndOpacity(IntPtr _this,ref FLinearColor InColorAndOpacity);
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckIsValid();
		SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningPlayerPawn(IntPtr _this);
	public  APawn GetOwningPlayerPawn()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningPlayerPawn(_this.Get());
		if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOwningPlayer(IntPtr _this,IntPtr LocalPlayerController);
	public  void SetOwningPlayer(APlayerController LocalPlayerController)
	{
		CheckIsValid();
		SetOwningPlayer(_this.Get(),LocalPlayerController);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningPlayer(IntPtr _this);
	public  APlayerController GetOwningPlayer()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningPlayer(_this.Get());
		if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOwningLocalPlayer(IntPtr _this,IntPtr LocalPlayer);
	public  void SetOwningLocalPlayer(ULocalPlayer LocalPlayer)
	{
		CheckIsValid();
		SetOwningLocalPlayer(_this.Get(),LocalPlayer);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningLocalPlayer(IntPtr _this);
	public  ULocalPlayer GetOwningLocalPlayer()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningLocalPlayer(_this.Get());
		if(___ret==IntPtr.Zero) return null; ULocalPlayer ___ret2= new ULocalPlayer(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInViewport(IntPtr _this);
	public  bool IsInViewport()
	{
		CheckIsValid();
		int ___ret = IsInViewport(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetAlignmentInViewport(IntPtr _this);
	public  FVector2D GetAlignmentInViewport()
	{
		CheckIsValid();
		FVector2D ___ret = GetAlignmentInViewport(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FAnchors GetAnchorsInViewport(IntPtr _this);
	public  FAnchors GetAnchorsInViewport()
	{
		CheckIsValid();
		FAnchors ___ret = GetAnchorsInViewport(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAlignmentInViewport(IntPtr _this,ref FVector2D Alignment);
	public  void SetAlignmentInViewport(FVector2D Alignment)
	{
		CheckIsValid();
		SetAlignmentInViewport(_this.Get(),ref Alignment);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAnchorsInViewport(IntPtr _this,ref FAnchors Anchors);
	public  void SetAnchorsInViewport(FAnchors Anchors)
	{
		CheckIsValid();
		SetAnchorsInViewport(_this.Get(),ref Anchors);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDesiredSizeInViewport(IntPtr _this,ref FVector2D Size);
	public  void SetDesiredSizeInViewport(FVector2D Size)
	{
		CheckIsValid();
		SetDesiredSizeInViewport(_this.Get(),ref Size);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPositionInViewport(IntPtr _this,ref FVector2D Position,int bRemoveDPIScale);
	public  void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale=true)
	{
		CheckIsValid();
		SetPositionInViewport(_this.Get(),ref Position,bRemoveDPIScale?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int AddToPlayerScreen(IntPtr _this,int ZOrder);
	public  bool AddToPlayerScreen(int ZOrder=0)
	{
		CheckIsValid();
		int ___ret = AddToPlayerScreen(_this.Get(),ZOrder);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddToViewport(IntPtr _this,int ZOrder);
	public  void AddToViewport(int ZOrder=0)
	{
		CheckIsValid();
		AddToViewport(_this.Get(),ZOrder);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
