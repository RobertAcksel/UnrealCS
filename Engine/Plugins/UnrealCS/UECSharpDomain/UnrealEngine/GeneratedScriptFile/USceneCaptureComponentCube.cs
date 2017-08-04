//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneCaptureComponentCube:USceneCaptureComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CaptureScene(IntPtr _this);
	public  void CaptureScene()
	{
		CheckIsValid();
		CaptureScene(_this.Get());
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
