//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetInputLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D PointerEvent_GetGestureDelta(IntPtr _this,ref FPointerEvent Input);
	public static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input)
	{
		FVector2D ___ret = PointerEvent_GetGestureDelta(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointerEvent_IsTouchEvent(IntPtr _this,ref FPointerEvent Input);
	public static bool PointerEvent_IsTouchEvent(FPointerEvent Input)
	{
		int ___ret = PointerEvent_IsTouchEvent(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointerEvent_GetTouchpadIndex(IntPtr _this,ref FPointerEvent Input);
	public static int PointerEvent_GetTouchpadIndex(FPointerEvent Input)
	{
		int ___ret = PointerEvent_GetTouchpadIndex(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointerEvent_GetPointerIndex(IntPtr _this,ref FPointerEvent Input);
	public static int PointerEvent_GetPointerIndex(FPointerEvent Input)
	{
		int ___ret = PointerEvent_GetPointerIndex(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointerEvent_GetUserIndex(IntPtr _this,ref FPointerEvent Input);
	public static int PointerEvent_GetUserIndex(FPointerEvent Input)
	{
		int ___ret = PointerEvent_GetUserIndex(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float PointerEvent_GetWheelDelta(IntPtr _this,ref FPointerEvent Input);
	public static float PointerEvent_GetWheelDelta(FPointerEvent Input)
	{
		float ___ret = PointerEvent_GetWheelDelta(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FKey PointerEvent_GetEffectingButton(IntPtr _this,ref FPointerEvent Input);
	public static FKey PointerEvent_GetEffectingButton(FPointerEvent Input)
	{
		FKey ___ret = PointerEvent_GetEffectingButton(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointerEvent_IsMouseButtonDown(IntPtr _this,ref FPointerEvent Input,ref FKey MouseButton);
	public static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input,FKey MouseButton)
	{
		int ___ret = PointerEvent_IsMouseButtonDown(IntPtr.Zero,ref Input,ref MouseButton);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D PointerEvent_GetCursorDelta(IntPtr _this,ref FPointerEvent Input);
	public static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input)
	{
		FVector2D ___ret = PointerEvent_GetCursorDelta(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D PointerEvent_GetLastScreenSpacePosition(IntPtr _this,ref FPointerEvent Input);
	public static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input)
	{
		FVector2D ___ret = PointerEvent_GetLastScreenSpacePosition(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D PointerEvent_GetScreenSpacePosition(IntPtr _this,ref FPointerEvent Input);
	public static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input)
	{
		FVector2D ___ret = PointerEvent_GetScreenSpacePosition(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetAnalogValue(IntPtr _this,ref FAnalogInputEvent Input);
	public static float GetAnalogValue(FAnalogInputEvent Input)
	{
		float ___ret = GetAnalogValue(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetUserIndex(IntPtr _this,ref FKeyEvent Input);
	public static int GetUserIndex(FKeyEvent Input)
	{
		int ___ret = GetUserIndex(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FKey GetKey(IntPtr _this,ref FKeyEvent Input);
	public static FKey GetKey(FKeyEvent Input)
	{
		FKey ___ret = GetKey(IntPtr.Zero,ref Input);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsRightCommandDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsRightCommandDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsRightCommandDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsLeftCommandDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsLeftCommandDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsLeftCommandDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsCommandDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsCommandDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsCommandDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsRightAltDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsRightAltDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsRightAltDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsLeftAltDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsLeftAltDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsLeftAltDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsAltDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsAltDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsAltDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsRightControlDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsRightControlDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsRightControlDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsLeftControlDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsLeftControlDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsLeftControlDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsControlDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsControlDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsControlDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsRightShiftDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsRightShiftDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsRightShiftDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsLeftShiftDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsLeftShiftDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsLeftShiftDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsShiftDown(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsShiftDown(FInputEvent Input)
	{
		int ___ret = InputEvent_IsShiftDown(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InputEvent_IsRepeat(IntPtr _this,ref FInputEvent Input);
	public static bool InputEvent_IsRepeat(FInputEvent Input)
	{
		int ___ret = InputEvent_IsRepeat(IntPtr.Zero,ref Input);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string Key_GetDisplayName(IntPtr _this,ref FKey Key);
	public static string Key_GetDisplayName(FKey Key)
	{
		string ___ret = Key_GetDisplayName(IntPtr.Zero,ref Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsVectorAxis(IntPtr _this,ref FKey Key);
	public static bool Key_IsVectorAxis(FKey Key)
	{
		int ___ret = Key_IsVectorAxis(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsFloatAxis(IntPtr _this,ref FKey Key);
	public static bool Key_IsFloatAxis(FKey Key)
	{
		int ___ret = Key_IsFloatAxis(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsKeyboardKey(IntPtr _this,ref FKey Key);
	public static bool Key_IsKeyboardKey(FKey Key)
	{
		int ___ret = Key_IsKeyboardKey(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsMouseButton(IntPtr _this,ref FKey Key);
	public static bool Key_IsMouseButton(FKey Key)
	{
		int ___ret = Key_IsMouseButton(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsGamepadKey(IntPtr _this,ref FKey Key);
	public static bool Key_IsGamepadKey(FKey Key)
	{
		int ___ret = Key_IsGamepadKey(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Key_IsModifierKey(IntPtr _this,ref FKey Key);
	public static bool Key_IsModifierKey(FKey Key)
	{
		int ___ret = Key_IsModifierKey(IntPtr.Zero,ref Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_InputChordInputChord(IntPtr _this,ref FInputChord A,ref FInputChord B);
	public static bool EqualEqual_InputChordInputChord(FInputChord A,FInputChord B)
	{
		int ___ret = EqualEqual_InputChordInputChord(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_KeyKey(IntPtr _this,ref FKey A,ref FKey B);
	public static bool EqualEqual_KeyKey(FKey A,FKey B)
	{
		int ___ret = EqualEqual_KeyKey(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CalibrateTilt(IntPtr _this);
	public static void CalibrateTilt()
	{
		CalibrateTilt(IntPtr.Zero);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
