//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ASceneCaptureCube:ASceneCapture 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnInterpToggle(IntPtr _this,int bEnable);
	public  void OnInterpToggle(bool bEnable)
	{
		CheckIsValid();
		OnInterpToggle(_this.Get(),bEnable?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
