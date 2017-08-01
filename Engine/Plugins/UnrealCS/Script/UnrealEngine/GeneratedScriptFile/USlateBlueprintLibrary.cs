//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USlateBlueprintLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToViewport(IntPtr _this,IntPtr WorldContextObject,ref FVector2D ScreenPosition,out FVector2D ViewportPosition);
public static void ScreenToViewport(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D ViewportPosition)
{
	ScreenToViewport(IntPtr.Zero,WorldContextObject,ref ScreenPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToWidgetAbsolute(IntPtr _this,IntPtr WorldContextObject,ref FVector2D ScreenPosition,out FVector2D AbsoluteCoordinate);
public static void ScreenToWidgetAbsolute(UObject WorldContextObject,FVector2D ScreenPosition,out FVector2D AbsoluteCoordinate)
{
	ScreenToWidgetAbsolute(IntPtr.Zero,WorldContextObject,ref ScreenPosition,out AbsoluteCoordinate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ScreenToWidgetLocal(IntPtr _this,IntPtr WorldContextObject,ref FGeometry Geometry,ref FVector2D ScreenPosition,out FVector2D LocalCoordinate);
public static void ScreenToWidgetLocal(UObject WorldContextObject,FGeometry Geometry,FVector2D ScreenPosition,out FVector2D LocalCoordinate)
{
	ScreenToWidgetLocal(IntPtr.Zero,WorldContextObject,ref Geometry,ref ScreenPosition,out LocalCoordinate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AbsoluteToViewport(IntPtr _this,IntPtr WorldContextObject,ref FVector2D AbsoluteDesktopCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
public static void AbsoluteToViewport(UObject WorldContextObject,FVector2D AbsoluteDesktopCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition)
{
	AbsoluteToViewport(IntPtr.Zero,WorldContextObject,ref AbsoluteDesktopCoordinate,out PixelPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LocalToViewport(IntPtr _this,IntPtr WorldContextObject,ref FGeometry Geometry,ref FVector2D LocalCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition);
public static void LocalToViewport(UObject WorldContextObject,FGeometry Geometry,FVector2D LocalCoordinate,out FVector2D PixelPosition,out FVector2D ViewportPosition)
{
	LocalToViewport(IntPtr.Zero,WorldContextObject,ref Geometry,ref LocalCoordinate,out PixelPosition,out ViewportPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_SlateBrush(IntPtr _this,ref FSlateBrush A,ref FSlateBrush B);
public static bool EqualEqual_SlateBrush(FSlateBrush A,FSlateBrush B)
{
	int ___ret = EqualEqual_SlateBrush(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetLocalSize(IntPtr _this,ref FGeometry Geometry);
public static FVector2D GetLocalSize(FGeometry Geometry)
{
	FVector2D ___ret = GetLocalSize(IntPtr.Zero,ref Geometry);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D LocalToAbsolute(IntPtr _this,ref FGeometry Geometry,ref FVector2D LocalCoordinate);
public static FVector2D LocalToAbsolute(FGeometry Geometry,FVector2D LocalCoordinate)
{
	FVector2D ___ret = LocalToAbsolute(IntPtr.Zero,ref Geometry,ref LocalCoordinate);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D AbsoluteToLocal(IntPtr _this,ref FGeometry Geometry,ref FVector2D AbsoluteCoordinate);
public static FVector2D AbsoluteToLocal(FGeometry Geometry,FVector2D AbsoluteCoordinate)
{
	FVector2D ___ret = AbsoluteToLocal(IntPtr.Zero,ref Geometry,ref AbsoluteCoordinate);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsUnderLocation(IntPtr _this,ref FGeometry Geometry,ref FVector2D AbsoluteCoordinate);
public static bool IsUnderLocation(FGeometry Geometry,FVector2D AbsoluteCoordinate)
{
	int ___ret = IsUnderLocation(IntPtr.Zero,ref Geometry,ref AbsoluteCoordinate);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
