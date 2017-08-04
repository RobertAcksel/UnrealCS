//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class APawn:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsMoveInputIgnored(IntPtr _this);
	public  bool IsMoveInputIgnored()
	{
		CheckIsValid();
		int ___ret = IsMoveInputIgnored(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddControllerRollInput(IntPtr _this,float Val);
	public  void AddControllerRollInput(float Val)
	{
		CheckIsValid();
		AddControllerRollInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddControllerYawInput(IntPtr _this,float Val);
	public  void AddControllerYawInput(float Val)
	{
		CheckIsValid();
		AddControllerYawInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddControllerPitchInput(IntPtr _this,float Val);
	public  void AddControllerPitchInput(float Val)
	{
		CheckIsValid();
		AddControllerPitchInput(_this.Get(),Val);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ConsumeMovementInputVector(IntPtr _this);
	public  FVector ConsumeMovementInputVector()
	{
		CheckIsValid();
		FVector ___ret = ConsumeMovementInputVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetLastMovementInputVector(IntPtr _this);
	public  FVector GetLastMovementInputVector()
	{
		CheckIsValid();
		FVector ___ret = GetLastMovementInputVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetPendingMovementInputVector(IntPtr _this);
	public  FVector GetPendingMovementInputVector()
	{
		CheckIsValid();
		FVector ___ret = GetPendingMovementInputVector(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddMovementInput(IntPtr _this,ref FVector WorldDirection,float ScaleValue,int bForce);
	public  void AddMovementInput(FVector WorldDirection,float ScaleValue=1.000000f,bool bForce=false)
	{
		CheckIsValid();
		AddMovementInput(_this.Get(),ref WorldDirection,ScaleValue,bForce?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SpawnDefaultController(IntPtr _this);
	public  void SpawnDefaultController()
	{
		CheckIsValid();
		SpawnDefaultController(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DetachFromControllerPendingDestroy(IntPtr _this);
	public  void DetachFromControllerPendingDestroy()
	{
		CheckIsValid();
		DetachFromControllerPendingDestroy(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator GetBaseAimRotation(IntPtr _this);
	public  FRotator GetBaseAimRotation()
	{
		CheckIsValid();
		FRotator ___ret = GetBaseAimRotation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPlayerControlled(IntPtr _this);
	public  bool IsPlayerControlled()
	{
		CheckIsValid();
		int ___ret = IsPlayerControlled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLocallyControlled(IntPtr _this);
	public  bool IsLocallyControlled()
	{
		CheckIsValid();
		int ___ret = IsLocallyControlled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetNavAgentLocation(IntPtr _this);
	public  FVector GetNavAgentLocation()
	{
		CheckIsValid();
		FVector ___ret = GetNavAgentLocation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCanAffectNavigationGeneration(IntPtr _this,int bNewValue,int bForceUpdate);
	public  void SetCanAffectNavigationGeneration(bool bNewValue,bool bForceUpdate=false)
	{
		CheckIsValid();
		SetCanAffectNavigationGeneration(_this.Get(),bNewValue?1:0,bForceUpdate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_PlayerState(IntPtr _this);
	public  void OnRep_PlayerState()
	{
		CheckIsValid();
		OnRep_PlayerState(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_Controller(IntPtr _this);
	public  void OnRep_Controller()
	{
		CheckIsValid();
		OnRep_Controller(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator GetControlRotation(IntPtr _this);
	public  FRotator GetControlRotation()
	{
		CheckIsValid();
		FRotator ___ret = GetControlRotation(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetController(IntPtr _this);
	public  AController GetController()
	{
		CheckIsValid();
		IntPtr ___ret = GetController(_this.Get());
		if(___ret==IntPtr.Zero) return null; AController ___ret2= new AController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsControlled(IntPtr _this);
	public  bool IsControlled()
	{
		CheckIsValid();
		int ___ret = IsControlled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetMovementBaseActor(IntPtr _this,IntPtr Pawn);
	public static AActor GetMovementBaseActor(APawn Pawn)
	{
		IntPtr ___ret = GetMovementBaseActor(IntPtr.Zero,Pawn);
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void PawnMakeNoise(IntPtr _this,float Loudness,ref FVector NoiseLocation,int bUseNoiseMakerLocation,IntPtr NoiseMaker);
	public  void PawnMakeNoise(float Loudness,FVector NoiseLocation,bool bUseNoiseMakerLocation=true,AActor NoiseMaker=default(AActor))
	{
		CheckIsValid();
		PawnMakeNoise(_this.Get(),Loudness,ref NoiseLocation,bUseNoiseMakerLocation?1:0,NoiseMaker);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetMovementComponent(IntPtr _this);
	public  UPawnMovementComponent GetMovementComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetMovementComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPawnMovementComponent ___ret2= new UPawnMovementComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
