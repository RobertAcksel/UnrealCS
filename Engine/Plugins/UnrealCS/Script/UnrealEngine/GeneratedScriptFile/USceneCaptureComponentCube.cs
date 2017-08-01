//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneCaptureComponentCube:USceneCaptureComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CaptureScene(IntPtr _this);
public  void CaptureScene()
{
	CheckIsValid();
	CaptureScene(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
