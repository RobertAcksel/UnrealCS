//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AController:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreInputFlags(IntPtr _this);
public  void ResetIgnoreInputFlags()
{
	CheckIsValid();
	ResetIgnoreInputFlags(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLookInputIgnored(IntPtr _this);
public  bool IsLookInputIgnored()
{
	CheckIsValid();
	int ___ret = IsLookInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreLookInput(IntPtr _this);
public  void ResetIgnoreLookInput()
{
	CheckIsValid();
	ResetIgnoreLookInput(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreLookInput(IntPtr _this,int bNewLookInput);
public  void SetIgnoreLookInput(bool bNewLookInput)
{
	CheckIsValid();
	SetIgnoreLookInput(_this.Get(),bNewLookInput?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsMoveInputIgnored(IntPtr _this);
public  bool IsMoveInputIgnored()
{
	CheckIsValid();
	int ___ret = IsMoveInputIgnored(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetIgnoreMoveInput(IntPtr _this);
public  void ResetIgnoreMoveInput()
{
	CheckIsValid();
	ResetIgnoreMoveInput(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIgnoreMoveInput(IntPtr _this,int bNewMoveInput);
public  void SetIgnoreMoveInput(bool bNewMoveInput)
{
	CheckIsValid();
	SetIgnoreMoveInput(_this.Get(),bNewMoveInput?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StopMovement(IntPtr _this);
public  void StopMovement()
{
	CheckIsValid();
	StopMovement(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnPossess(IntPtr _this);
public  void UnPossess()
{
	CheckIsValid();
	UnPossess(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Possess(IntPtr _this,IntPtr InPawn);
public  void Possess(APawn InPawn)
{
	CheckIsValid();
	Possess(_this.Get(),InPawn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLocalController(IntPtr _this);
public  bool IsLocalController()
{
	CheckIsValid();
	int ___ret = IsLocalController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsLocalPlayerController(IntPtr _this);
public  bool IsLocalPlayerController()
{
	CheckIsValid();
	int ___ret = IsLocalPlayerController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsPlayerController(IntPtr _this);
public  bool IsPlayerController()
{
	CheckIsValid();
	int ___ret = IsPlayerController(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetDesiredRotation(IntPtr _this);
public  FRotator GetDesiredRotation()
{
	CheckIsValid();
	FRotator ___ret = GetDesiredRotation(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetViewTarget(IntPtr _this);
public  AActor GetViewTarget()
{
	CheckIsValid();
	IntPtr ___ret = GetViewTarget(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_GetPawn(IntPtr _this);
public  APawn K2_GetPawn()
{
	CheckIsValid();
	IntPtr ___ret = K2_GetPawn(_this.Get());
	if(___ret==IntPtr.Zero) return null; APawn ___ret2= new APawn(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetRotation(IntPtr _this,ref FRotator NewRotation,int bResetCamera);
public  void ClientSetRotation(FRotator NewRotation,bool bResetCamera)
{
	CheckIsValid();
	ClientSetRotation(_this.Get(),ref NewRotation,bResetCamera?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClientSetLocation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
public  void ClientSetLocation(FVector NewLocation,FRotator NewRotation)
{
	CheckIsValid();
	ClientSetLocation(_this.Get(),ref NewLocation,ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_PlayerState(IntPtr _this);
public  void OnRep_PlayerState()
{
	CheckIsValid();
	OnRep_PlayerState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_Pawn(IntPtr _this);
public  void OnRep_Pawn()
{
	CheckIsValid();
	OnRep_Pawn(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int LineOfSightTo(IntPtr _this,IntPtr Other,ref FVector ViewPoint,int bAlternateChecks);
public  bool LineOfSightTo(AActor Other,FVector ViewPoint,bool bAlternateChecks=false)
{
	CheckIsValid();
	int ___ret = LineOfSightTo(_this.Get(),Other,ref ViewPoint,bAlternateChecks?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInitialLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
public  void SetInitialLocationAndRotation(FVector NewLocation,FRotator NewRotation)
{
	CheckIsValid();
	SetInitialLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetControlRotation(IntPtr _this,ref FRotator NewRotation);
public  void SetControlRotation(FRotator NewRotation)
{
	CheckIsValid();
	SetControlRotation(_this.Get(),ref NewRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FRotator GetControlRotation(IntPtr _this);
public  FRotator GetControlRotation()
{
	CheckIsValid();
	FRotator ___ret = GetControlRotation(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
