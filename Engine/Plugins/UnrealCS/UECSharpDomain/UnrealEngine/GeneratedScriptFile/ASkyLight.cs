//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ASkyLight:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_bEnabled(IntPtr _this);
	public  void OnRep_bEnabled()
	{
		CheckIsValid();
		OnRep_bEnabled(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
