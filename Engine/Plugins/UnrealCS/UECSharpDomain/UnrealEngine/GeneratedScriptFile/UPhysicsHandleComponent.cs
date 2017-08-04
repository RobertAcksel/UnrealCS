//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsHandleComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetInterpolationSpeed(IntPtr _this,float NewInterpolationSpeed);
	public  void SetInterpolationSpeed(float NewInterpolationSpeed)
	{
		CheckIsValid();
		SetInterpolationSpeed(_this.Get(),NewInterpolationSpeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularStiffness(IntPtr _this,float NewAngularStiffness);
	public  void SetAngularStiffness(float NewAngularStiffness)
	{
		CheckIsValid();
		SetAngularStiffness(_this.Get(),NewAngularStiffness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAngularDamping(IntPtr _this,float NewAngularDamping);
	public  void SetAngularDamping(float NewAngularDamping)
	{
		CheckIsValid();
		SetAngularDamping(_this.Get(),NewAngularDamping);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearStiffness(IntPtr _this,float NewLinearStiffness);
	public  void SetLinearStiffness(float NewLinearStiffness)
	{
		CheckIsValid();
		SetLinearStiffness(_this.Get(),NewLinearStiffness);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetLinearDamping(IntPtr _this,float NewLinearDamping);
	public  void SetLinearDamping(float NewLinearDamping)
	{
		CheckIsValid();
		SetLinearDamping(_this.Get(),NewLinearDamping);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetTargetLocationAndRotation(IntPtr _this,out FVector TargetLocation,out FRotator TargetRotation);
	public  void GetTargetLocationAndRotation(out FVector TargetLocation,out FRotator TargetRotation)
	{
		CheckIsValid();
		GetTargetLocationAndRotation(_this.Get(),out TargetLocation,out TargetRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetLocationAndRotation(IntPtr _this,ref FVector NewLocation,ref FRotator NewRotation);
	public  void SetTargetLocationAndRotation(FVector NewLocation,FRotator NewRotation)
	{
		CheckIsValid();
		SetTargetLocationAndRotation(_this.Get(),ref NewLocation,ref NewRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetRotation(IntPtr _this,ref FRotator NewRotation);
	public  void SetTargetRotation(FRotator NewRotation)
	{
		CheckIsValid();
		SetTargetRotation(_this.Get(),ref NewRotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTargetLocation(IntPtr _this,ref FVector NewLocation);
	public  void SetTargetLocation(FVector NewLocation)
	{
		CheckIsValid();
		SetTargetLocation(_this.Get(),ref NewLocation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGrabbedComponent(IntPtr _this);
	public  UPrimitiveComponent GetGrabbedComponent()
	{
		CheckIsValid();
		IntPtr ___ret = GetGrabbedComponent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPrimitiveComponent ___ret2= new UPrimitiveComponent(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ReleaseComponent(IntPtr _this);
	public  void ReleaseComponent()
	{
		CheckIsValid();
		ReleaseComponent(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GrabComponentAtLocationWithRotation(IntPtr _this,IntPtr Component,string InBoneName,ref FVector Location,ref FRotator Rotation);
	public  void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component,string InBoneName,FVector Location,FRotator Rotation)
	{
		CheckIsValid();
		GrabComponentAtLocationWithRotation(_this.Get(),Component,InBoneName,ref Location,ref Rotation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GrabComponentAtLocation(IntPtr _this,IntPtr Component,string InBoneName,ref FVector GrabLocation);
	public  void GrabComponentAtLocation(UPrimitiveComponent Component,string InBoneName,FVector GrabLocation)
	{
		CheckIsValid();
		GrabComponentAtLocation(_this.Get(),Component,InBoneName,ref GrabLocation);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
