//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetBlueprintLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SetHardwareCursor(IntPtr _this,IntPtr WorldContextObject,int CursorShape,string CursorName,ref FVector2D HotSpot);
public static bool SetHardwareCursor(UObject WorldContextObject,EMouseCursor CursorShape,string CursorName,FVector2D HotSpot)
{
	int ___ret = SetHardwareCursor(IntPtr.Zero,WorldContextObject,(int)CursorShape,CursorName,ref HotSpot);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetSafeZonePadding(IntPtr _this,IntPtr WorldContextObject,out FVector2D SafePadding,out FVector2D SafePaddingScale,out FVector2D SpillOverPadding);
public static void GetSafeZonePadding(UObject WorldContextObject,out FVector2D SafePadding,out FVector2D SafePaddingScale,out FVector2D SpillOverPadding)
{
	GetSafeZonePadding(IntPtr.Zero,WorldContextObject,out SafePadding,out SafePaddingScale,out SpillOverPadding);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromNavigationEvent(IntPtr _this,ref FNavigationEvent Event);
public static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event)
{
	FInputEvent ___ret = GetInputEventFromNavigationEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromControllerEvent(IntPtr _this,ref FControllerEvent Event);
public static FInputEvent GetInputEventFromControllerEvent(FControllerEvent Event)
{
	FInputEvent ___ret = GetInputEventFromControllerEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromPointerEvent(IntPtr _this,ref FPointerEvent Event);
public static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event)
{
	FInputEvent ___ret = GetInputEventFromPointerEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromCharacterEvent(IntPtr _this,ref FCharacterEvent Event);
public static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event)
{
	FInputEvent ___ret = GetInputEventFromCharacterEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FKeyEvent GetKeyEventFromAnalogInputEvent(IntPtr _this,ref FAnalogInputEvent Event);
public static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event)
{
	FKeyEvent ___ret = GetKeyEventFromAnalogInputEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FInputEvent GetInputEventFromKeyEvent(IntPtr _this,ref FKeyEvent Event);
public static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event)
{
	FInputEvent ___ret = GetInputEventFromKeyEvent(IntPtr.Zero,ref Event);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllWidgetsWithInterface(IntPtr _this,IntPtr WorldContextObject,IntPtr Interface,out IntPtr[] FoundWidgets,int TopLevelOnly);
public static void GetAllWidgetsWithInterface(UObject WorldContextObject,TSubclassOf<UInterface>  Interface,out UUserWidget[] FoundWidgets,bool TopLevelOnly)
{
	IntPtr[] FoundWidgets_temp;
	GetAllWidgetsWithInterface(IntPtr.Zero,WorldContextObject,Interface.NativeClass,out FoundWidgets_temp,TopLevelOnly?1:0);
	FoundWidgets = MarshalUtil.IntPtrArrayToObjectArray<UUserWidget>(FoundWidgets_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetAllWidgetsOfClass(IntPtr _this,IntPtr WorldContextObject,out IntPtr[] FoundWidgets,IntPtr WidgetClass,int TopLevelOnly);
public static void GetAllWidgetsOfClass(UObject WorldContextObject,out UUserWidget[] FoundWidgets,TSubclassOf<UUserWidget>  WidgetClass,bool TopLevelOnly=true)
{
	IntPtr[] FoundWidgets_temp;
	GetAllWidgetsOfClass(IntPtr.Zero,WorldContextObject,out FoundWidgets_temp,WidgetClass.NativeClass,TopLevelOnly?1:0);
	FoundWidgets = MarshalUtil.IntPtrArrayToObjectArray<UUserWidget>(FoundWidgets_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DismissAllMenus(IntPtr _this);
public static void DismissAllMenus()
{
	DismissAllMenus(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDynamicMaterial(IntPtr _this,out FSlateBrush Brush);
public static UMaterialInstanceDynamic GetDynamicMaterial(out FSlateBrush Brush)
{
	IntPtr ___ret = GetDynamicMaterial(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush NoResourceBrush(IntPtr _this);
public static FSlateBrush NoResourceBrush()
{
	FSlateBrush ___ret = NoResourceBrush(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushResourceToMaterial(IntPtr _this,out FSlateBrush Brush,IntPtr Material);
public static void SetBrushResourceToMaterial(out FSlateBrush Brush,UMaterialInterface Material)
{
	SetBrushResourceToMaterial(IntPtr.Zero,out Brush,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrushResourceToTexture(IntPtr _this,out FSlateBrush Brush,IntPtr Texture);
public static void SetBrushResourceToTexture(out FSlateBrush Brush,UTexture2D Texture)
{
	SetBrushResourceToTexture(IntPtr.Zero,out Brush,Texture);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResourceAsMaterial(IntPtr _this,out FSlateBrush Brush);
public static UMaterialInterface GetBrushResourceAsMaterial(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResourceAsMaterial(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResourceAsTexture2D(IntPtr _this,out FSlateBrush Brush);
public static UTexture2D GetBrushResourceAsTexture2D(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResourceAsTexture2D(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UTexture2D ___ret2= new UTexture2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBrushResource(IntPtr _this,out FSlateBrush Brush);
public static UObject GetBrushResource(out FSlateBrush Brush)
{
	IntPtr ___ret = GetBrushResource(IntPtr.Zero,out Brush);
	if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromMaterial(IntPtr _this,IntPtr Material,int Width,int Height);
public static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material,int Width=32,int Height=32)
{
	FSlateBrush ___ret = MakeBrushFromMaterial(IntPtr.Zero,Material,Width,Height);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromTexture(IntPtr _this,IntPtr Texture,int Width,int Height);
public static FSlateBrush MakeBrushFromTexture(UTexture2D Texture,int Width=0,int Height=0)
{
	FSlateBrush ___ret = MakeBrushFromTexture(IntPtr.Zero,Texture,Width,Height);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush MakeBrushFromAsset(IntPtr _this,IntPtr BrushAsset);
public static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset)
{
	FSlateBrush ___ret = MakeBrushFromAsset(IntPtr.Zero,BrushAsset);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CancelDragDrop(IntPtr _this);
public static void CancelDragDrop()
{
	CancelDragDrop(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDragDroppingContent(IntPtr _this);
public static UDragDropOperation GetDragDroppingContent()
{
	IntPtr ___ret = GetDragDroppingContent(IntPtr.Zero);
	if(___ret==IntPtr.Zero) return null; UDragDropOperation ___ret2= new UDragDropOperation(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsDragDropping(IntPtr _this);
public static bool IsDragDropping()
{
	int ___ret = IsDragDropping(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply EndDragDrop(IntPtr _this,out FEventReply Reply);
public static FEventReply EndDragDrop(out FEventReply Reply)
{
	FEventReply ___ret = EndDragDrop(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply DetectDragIfPressed(IntPtr _this,ref FPointerEvent PointerEvent,IntPtr WidgetDetectingDrag,ref FKey DragKey);
public static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UWidget WidgetDetectingDrag,FKey DragKey)
{
	FEventReply ___ret = DetectDragIfPressed(IntPtr.Zero,ref PointerEvent,WidgetDetectingDrag,ref DragKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply DetectDrag(IntPtr _this,out FEventReply Reply,IntPtr WidgetDetectingDrag,ref FKey DragKey);
public static FEventReply DetectDrag(out FEventReply Reply,UWidget WidgetDetectingDrag,FKey DragKey)
{
	FEventReply ___ret = DetectDrag(IntPtr.Zero,out Reply,WidgetDetectingDrag,ref DragKey);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply SetMousePosition(IntPtr _this,out FEventReply Reply,ref FVector2D NewMousePosition);
public static FEventReply SetMousePosition(out FEventReply Reply,FVector2D NewMousePosition)
{
	FEventReply ___ret = SetMousePosition(IntPtr.Zero,out Reply,ref NewMousePosition);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply ClearUserFocus(IntPtr _this,out FEventReply Reply,int bInAllUsers);
public static FEventReply ClearUserFocus(out FEventReply Reply,bool bInAllUsers=false)
{
	FEventReply ___ret = ClearUserFocus(IntPtr.Zero,out Reply,bInAllUsers?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply SetUserFocus(IntPtr _this,out FEventReply Reply,IntPtr FocusWidget,int bInAllUsers);
public static FEventReply SetUserFocus(out FEventReply Reply,UWidget FocusWidget,bool bInAllUsers=false)
{
	FEventReply ___ret = SetUserFocus(IntPtr.Zero,out Reply,FocusWidget,bInAllUsers?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply UnlockMouse(IntPtr _this,out FEventReply Reply);
public static FEventReply UnlockMouse(out FEventReply Reply)
{
	FEventReply ___ret = UnlockMouse(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply LockMouse(IntPtr _this,out FEventReply Reply,IntPtr CapturingWidget);
public static FEventReply LockMouse(out FEventReply Reply,UWidget CapturingWidget)
{
	FEventReply ___ret = LockMouse(IntPtr.Zero,out Reply,CapturingWidget);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply ReleaseMouseCapture(IntPtr _this,out FEventReply Reply);
public static FEventReply ReleaseMouseCapture(out FEventReply Reply)
{
	FEventReply ___ret = ReleaseMouseCapture(IntPtr.Zero,out Reply);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply CaptureMouse(IntPtr _this,out FEventReply Reply,IntPtr CapturingWidget);
public static FEventReply CaptureMouse(out FEventReply Reply,UWidget CapturingWidget)
{
	FEventReply ___ret = CaptureMouse(IntPtr.Zero,out Reply,CapturingWidget);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply Unhandled(IntPtr _this);
public static FEventReply Unhandled()
{
	FEventReply ___ret = Unhandled(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FEventReply Handled(IntPtr _this);
public static FEventReply Handled()
{
	FEventReply ___ret = Handled(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTextFormatted(IntPtr _this,out FPaintContext Context,string Text,ref FVector2D Position,IntPtr Font,int FontSize,string FontTypeFace,ref FLinearColor Tint);
public static void DrawTextFormatted(out FPaintContext Context,string Text,FVector2D Position,UFont Font,int FontSize=16,string FontTypeFace="Regular",FLinearColor Tint=default(FLinearColor))
{
	DrawTextFormatted(IntPtr.Zero,out Context,Text,ref Position,Font,FontSize,FontTypeFace,ref Tint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLines(IntPtr _this,out FPaintContext Context,FVector2D[] Points,ref FLinearColor Tint,int bAntiAlias);
public static void DrawLines(out FPaintContext Context,FVector2D[] Points,FLinearColor Tint=default(FLinearColor),bool bAntiAlias=true)
{
	DrawLines(IntPtr.Zero,out Context,Points,ref Tint,bAntiAlias?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLine(IntPtr _this,out FPaintContext Context,ref FVector2D PositionA,ref FVector2D PositionB,ref FLinearColor Tint,int bAntiAlias);
public static void DrawLine(out FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint=default(FLinearColor),bool bAntiAlias=true)
{
	DrawLine(IntPtr.Zero,out Context,ref PositionA,ref PositionB,ref Tint,bAntiAlias?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawBox(IntPtr _this,out FPaintContext Context,ref FVector2D Position,ref FVector2D Size,IntPtr Brush,ref FLinearColor Tint);
public static void DrawBox(out FPaintContext Context,FVector2D Position,FVector2D Size,USlateBrushAsset Brush,FLinearColor Tint=default(FLinearColor))
{
	DrawBox(IntPtr.Zero,out Context,ref Position,ref Size,Brush,ref Tint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFocusToGameViewport(IntPtr _this);
public static void SetFocusToGameViewport()
{
	SetFocusToGameViewport(IntPtr.Zero);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInputMode_GameOnly(IntPtr _this,IntPtr Target);
public static void SetInputMode_GameOnly(APlayerController Target)
{
	SetInputMode_GameOnly(IntPtr.Zero,Target);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDragDropOperation(IntPtr _this,IntPtr OperationClass);
public static UDragDropOperation CreateDragDropOperation(TSubclassOf<UDragDropOperation>  OperationClass)
{
	IntPtr ___ret = CreateDragDropOperation(IntPtr.Zero,OperationClass.NativeClass);
	if(___ret==IntPtr.Zero) return null; UDragDropOperation ___ret2= new UDragDropOperation(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr Create(IntPtr _this,IntPtr WorldContextObject,IntPtr WidgetType,IntPtr OwningPlayer);
public static UUserWidget Create(UObject WorldContextObject,TSubclassOf<UUserWidget>  WidgetType,APlayerController OwningPlayer)
{
	IntPtr ___ret = Create(IntPtr.Zero,WorldContextObject,WidgetType.NativeClass,OwningPlayer);
	if(___ret==IntPtr.Zero) return null; UUserWidget ___ret2= new UUserWidget(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
