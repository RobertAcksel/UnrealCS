//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAvoidanceManager:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetAvoidanceVelocity(IntPtr _this,ref FNavAvoidanceData AvoidanceData,float DeltaTime);
	public  FVector GetAvoidanceVelocity(FNavAvoidanceData AvoidanceData,float DeltaTime)
	{
		CheckIsValid();
		FVector ___ret = GetAvoidanceVelocity(_this.Get(),ref AvoidanceData,DeltaTime);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetAvoidanceVelocityIgnoringUID(IntPtr _this,ref FNavAvoidanceData AvoidanceData,float DeltaTime,int IgnoreThisUID);
	public  FVector GetAvoidanceVelocityIgnoringUID(FNavAvoidanceData AvoidanceData,float DeltaTime,int IgnoreThisUID)
	{
		CheckIsValid();
		FVector ___ret = GetAvoidanceVelocityIgnoringUID(_this.Get(),ref AvoidanceData,DeltaTime,IgnoreThisUID);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetAvoidanceVelocityForComponent(IntPtr _this,IntPtr MovementComp);
	public  FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp)
	{
		CheckIsValid();
		FVector ___ret = GetAvoidanceVelocityForComponent(_this.Get(),MovementComp);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RegisterMovementComponent(IntPtr _this,IntPtr MovementComp,float AvoidanceWeight);
	public  bool RegisterMovementComponent(UMovementComponent MovementComp,float AvoidanceWeight=0.500000f)
	{
		CheckIsValid();
		int ___ret = RegisterMovementComponent(_this.Get(),MovementComp,AvoidanceWeight);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNewAvoidanceUID(IntPtr _this);
	public  int GetNewAvoidanceUID()
	{
		CheckIsValid();
		int ___ret = GetNewAvoidanceUID(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetObjectCount(IntPtr _this);
	public  int GetObjectCount()
	{
		CheckIsValid();
		int ___ret = GetObjectCount(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
