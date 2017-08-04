//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class URadialForceComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveObjectTypeToAffect(IntPtr _this,int ObjectType);
	public  void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType)
	{
		CheckIsValid();
		RemoveObjectTypeToAffect(_this.Get(),(int)ObjectType);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddObjectTypeToAffect(IntPtr _this,int ObjectType);
	public  void AddObjectTypeToAffect(EObjectTypeQuery ObjectType)
	{
		CheckIsValid();
		AddObjectTypeToAffect(_this.Get(),(int)ObjectType);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FireImpulse(IntPtr _this);
	public  void FireImpulse()
	{
		CheckIsValid();
		FireImpulse(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
