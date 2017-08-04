//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStereoLayerFunctionLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableAutoLoadingSplashScreen(IntPtr _this,int InAutoShowEnabled);
public static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled)
{
	EnableAutoLoadingSplashScreen(IntPtr.Zero,InAutoShowEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideSplashScreen(IntPtr _this);
public static void HideSplashScreen()
{
	HideSplashScreen(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowSplashScreen(IntPtr _this);
public static void ShowSplashScreen()
{
	ShowSplashScreen(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSplashScreen(IntPtr _this,IntPtr Texture,ref FVector2D Scale,ref FVector2D Offset,int bShowLoadingMovie,int bShowOnSet);
public static void SetSplashScreen(UTexture Texture,FVector2D Scale=default(FVector2D),FVector2D Offset=default(FVector2D),bool bShowLoadingMovie=false,bool bShowOnSet=false)
{
	SetSplashScreen(IntPtr.Zero,Texture,ref Scale,ref Offset,bShowLoadingMovie?1:0,bShowOnSet?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
