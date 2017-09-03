//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UChildActorComponent:USceneComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetChildActorClass(IntPtr _this,IntPtr InClass);
	
	public  void SetChildActorClass(TSubclassOf<AActor>  InClass)
	{
		CheckIsValid();
		SetChildActorClass(_this.Get(),InClass.NativeClass);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
