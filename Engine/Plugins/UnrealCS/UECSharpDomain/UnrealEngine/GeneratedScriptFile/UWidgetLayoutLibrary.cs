//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetLayoutLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveAllWidgets(IntPtr _this,IntPtr WorldContextObject);
	public static void RemoveAllWidgets(UObject WorldContextObject)
	{
		RemoveAllWidgets(IntPtr.Zero,WorldContextObject);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsVerticalBoxSlot(IntPtr _this,IntPtr Widget);
	public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsVerticalBoxSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UVerticalBoxSlot ___ret2= new UVerticalBoxSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsUniformGridSlot(IntPtr _this,IntPtr Widget);
	public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsUniformGridSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UUniformGridSlot ___ret2= new UUniformGridSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsOverlaySlot(IntPtr _this,IntPtr Widget);
	public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsOverlaySlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UOverlaySlot ___ret2= new UOverlaySlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsHorizontalBoxSlot(IntPtr _this,IntPtr Widget);
	public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsHorizontalBoxSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UHorizontalBoxSlot ___ret2= new UHorizontalBoxSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsGridSlot(IntPtr _this,IntPtr Widget);
	public static UGridSlot SlotAsGridSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsGridSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UGridSlot ___ret2= new UGridSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsCanvasSlot(IntPtr _this,IntPtr Widget);
	public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsCanvasSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UCanvasPanelSlot ___ret2= new UCanvasPanelSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SlotAsBorderSlot(IntPtr _this,IntPtr Widget);
	public static UBorderSlot SlotAsBorderSlot(UWidget Widget)
	{
		IntPtr ___ret = SlotAsBorderSlot(IntPtr.Zero,Widget);
		if(___ret==IntPtr.Zero) return null; UBorderSlot ___ret2= new UBorderSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMousePositionScaledByDPI(IntPtr _this,IntPtr Player,out float LocationX,out float LocationY);
	public static bool GetMousePositionScaledByDPI(APlayerController Player,out float LocationX,out float LocationY)
	{
		int ___ret = GetMousePositionScaledByDPI(IntPtr.Zero,Player,out LocationX,out LocationY);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetViewportSize(IntPtr _this,IntPtr WorldContextObject);
	public static FVector2D GetViewportSize(UObject WorldContextObject)
	{
		FVector2D ___ret = GetViewportSize(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetViewportScale(IntPtr _this,IntPtr WorldContextObject);
	public static float GetViewportScale(UObject WorldContextObject)
	{
		float ___ret = GetViewportScale(IntPtr.Zero,WorldContextObject);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ProjectWorldLocationToWidgetPosition(IntPtr _this,IntPtr PlayerController,ref FVector WorldLocation,out FVector2D ScreenPosition);
	public static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController,FVector WorldLocation,out FVector2D ScreenPosition)
	{
		int ___ret = ProjectWorldLocationToWidgetPosition(IntPtr.Zero,PlayerController,ref WorldLocation,out ScreenPosition);
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
