//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvasRenderTarget2D:UTextureRenderTarget2D 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetSize(IntPtr _this,out int Width,out int Height);
public  void GetSize(out int Width,out int Height)
{
	CheckIsValid();
	GetSize(_this.Get(),out Width,out Height);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateCanvasRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,IntPtr CanvasRenderTarget2DClass,int Width,int Height);
public static UCanvasRenderTarget2D CreateCanvasRenderTarget2D(UObject WorldContextObject,TSubclassOf<UCanvasRenderTarget2D>  CanvasRenderTarget2DClass,int Width=1024,int Height=1024)
{
	IntPtr ___ret = CreateCanvasRenderTarget2D(IntPtr.Zero,WorldContextObject,CanvasRenderTarget2DClass.NativeClass,Width,Height);
	if(___ret==IntPtr.Zero) return null; UCanvasRenderTarget2D ___ret2= new UCanvasRenderTarget2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UpdateResource(IntPtr _this);
public  void UpdateResource()
{
	CheckIsValid();
	UpdateResource(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
