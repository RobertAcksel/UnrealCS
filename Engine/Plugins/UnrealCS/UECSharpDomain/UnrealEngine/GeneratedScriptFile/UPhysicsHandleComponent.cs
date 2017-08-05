//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsHandleComponent:UActorComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetInterpolationSpeed(IntPtr _this,float NewInterpolationSpeed);
	
	/// <summary>Set interpolation speed</summary>
	public  void SetInterpolationSpeed(float NewInterpolationSpeed)
	{
		CheckIsValid();
		SetInterpolationSpeed(_this.Get(),NewInterpolationSpeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularStiffness(IntPtr _this,float NewAngularStiffness);
	
	/// <summary>Set angular stiffness</summary>
	public  void SetAngularStiffness(float NewAngularStiffness)
	{
		CheckIsValid();
		SetAngularStiffness(_this.Get(),NewAngularStiffness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularDamping(IntPtr _this,float NewAngularDamping);
	
	/// <summary>Set angular damping</summary>
	public  void SetAngularDamping(float NewAngularDamping)
	{
		CheckIsValid();
		SetAngularDamping(_this.Get(),NewAngularDamping);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearStiffness(IntPtr _this,float NewLinearStiffness);
	
	/// <summary>Set linear stiffness</summary>
	public  void SetLinearStiffness(float NewLinearStiffness)
	{
		CheckIsValid();
		SetLinearStiffness(_this.Get(),NewLinearStiffness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearDamping(IntPtr _this,float NewLinearDamping);
	
	/// <summary>Set linear damping</summary>
	public  void SetLinearDamping(float NewLinearDamping)
	{
		CheckIsValid();
		SetLinearDamping(_this.Get(),NewLinearDamping);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetTargetLocationAndRotation(IntPtr _this,out FVector TargetLocation,out FRotator TargetRotation);
	
	/// <summary>Get the current location and rotation</summary>
	public  void GetTargetLocationAndRotation(out FVector TargetLocation,out FRotator TargetRotation)
	{
		CheckIsValid();
		GetTargetLocationAndRotation(_this.Get(),out TargetLocation,out TargetRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
	
	/// <summary>Set target location and rotation</summary>
	public  void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation)
	{
		CheckIsValid();
		SetTargetLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetRotation(IntPtr _this,ref FRotator NewRotation);
	
	/// <summary>Set the target rotation</summary>
	public  void SetTargetRotation(FRotator NewRotation)
	{
		CheckIsValid();
		SetTargetRotation(_this.Get(),ref NewRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetLocation(IntPtr _this,ref FVector NewLocation);
	
	/// <summary>Set the target location</summary>
	public  void SetTargetLocation(FVector NewLocation)
	{
		CheckIsValid();
		SetTargetLocation(_this.Get(),ref NewLocation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGrabbedComponent(IntPtr _this);
	
	/// <summary>Returns the currently grabbed component, or null if nothing is grabbed.</summary>
	public  UPrimitiveComponent GetGrabbedComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetGrabbedComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPrimitiveComponent ___ret2= new UPrimitiveComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ReleaseComponent(IntPtr _this);
	
	/// <summary>Release the currently held component</summary>
	public  void ReleaseComponent()
	{
		CheckIsValid();
		ReleaseComponent(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GrabComponentAtLocationWithRotation(IntPtr _this,IntPtr Component,string InBoneName,ref FVector Location,ref FRotator Rotation);
	
	/// <summary>Grab the specified component at a given location and rotation. Constrains rotation.</summary>
	public  void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component,string InBoneName,FVector Location,FRotator Rotation)
	{
		CheckIsValid();
		GrabComponentAtLocationWithRotation(_this.Get(),Component,InBoneName,ref Location,ref Rotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GrabComponentAtLocation(IntPtr _this,IntPtr Component,string InBoneName,ref FVector GrabLocation);
	
	/// <summary>Grab the specified component at a given location. Does NOT constraint rotation which means the handle will pivot about GrabLocation.</summary>
	public  void GrabComponentAtLocation(UPrimitiveComponent Component,string InBoneName,FVector GrabLocation)
	{
		CheckIsValid();
		GrabComponentAtLocation(_this.Get(),Component,InBoneName,ref GrabLocation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
