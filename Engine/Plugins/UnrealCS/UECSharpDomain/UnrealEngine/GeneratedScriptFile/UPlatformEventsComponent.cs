//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlatformEventsComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SupportsConvertibleLaptops(IntPtr _this);
	public  bool SupportsConvertibleLaptops()
	{
		CheckIsValid();
		int ___ret = SupportsConvertibleLaptops(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInTabletMode(IntPtr _this);
	public  bool IsInTabletMode()
	{
		CheckIsValid();
		int ___ret = IsInTabletMode(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsInLaptopMode(IntPtr _this);
	public  bool IsInLaptopMode()
	{
		CheckIsValid();
		int ___ret = IsInLaptopMode(_this.Get());
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
