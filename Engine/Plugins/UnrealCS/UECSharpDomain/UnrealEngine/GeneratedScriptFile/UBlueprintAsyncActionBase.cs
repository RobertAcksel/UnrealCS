//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBlueprintAsyncActionBase:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Activate(IntPtr _this);
	public  void Activate()
	{
		CheckIsValid();
		Activate(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
