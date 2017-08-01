//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UHeadMountedDisplayFunctionLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetVRFocusState(IntPtr _this,out int bUseFocus,out int bHasFocus);
public static void GetVRFocusState(out bool bUseFocus,out bool bHasFocus)
{
	int bUseFocus_temp;
	int bHasFocus_temp;
	GetVRFocusState(IntPtr.Zero,out bUseFocus_temp,out bHasFocus_temp);
	bUseFocus=bUseFocus_temp!=0;
	bHasFocus=bHasFocus_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTrackingOrigin(IntPtr _this);
public static EHMDTrackingOrigin GetTrackingOrigin()
{
	int ___ret = GetTrackingOrigin(IntPtr.Zero);
	return (EHMDTrackingOrigin)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTrackingOrigin(IntPtr _this,int Origin);
public static void SetTrackingOrigin(EHMDTrackingOrigin Origin)
{
	SetTrackingOrigin(IntPtr.Zero,(int)Origin);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetWorldToMetersScale(IntPtr _this,IntPtr WorldContext);
public static float GetWorldToMetersScale(UObject WorldContext)
{
	float ___ret = GetWorldToMetersScale(IntPtr.Zero,WorldContext);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldToMetersScale(IntPtr _this,IntPtr WorldContext,float NewScale);
public static void SetWorldToMetersScale(UObject WorldContext,float NewScale=100.000000f)
{
	SetWorldToMetersScale(IntPtr.Zero,WorldContext,NewScale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetScreenPercentage(IntPtr _this);
public static float GetScreenPercentage()
{
	float ___ret = GetScreenPercentage(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetClippingPlanes(IntPtr _this,float Near,float Far);
public static void SetClippingPlanes(float Near,float Far)
{
	SetClippingPlanes(IntPtr.Zero,Near,Far);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetOrientationAndPosition(IntPtr _this,float Yaw,int Options);
public static void ResetOrientationAndPosition(float Yaw=0.000000f,EOrientPositionSelector Options=EOrientPositionSelector.OrientationAndPosition)
{
	ResetOrientationAndPosition(IntPtr.Zero,Yaw,(int)Options);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTrackingSensorParameters(IntPtr _this,out FVector Origin,out FRotator Rotation,out float LeftFOV,out float RightFOV,out float TopFOV,out float BottomFOV,out float Distance,out float NearPlane,out float FarPlane,out int IsActive,int Index);
public static void GetTrackingSensorParameters(out FVector Origin,out FRotator Rotation,out float LeftFOV,out float RightFOV,out float TopFOV,out float BottomFOV,out float Distance,out float NearPlane,out float FarPlane,out bool IsActive,int Index=0)
{
	int IsActive_temp;
	GetTrackingSensorParameters(IntPtr.Zero,out Origin,out Rotation,out LeftFOV,out RightFOV,out TopFOV,out BottomFOV,out Distance,out NearPlane,out FarPlane,out IsActive_temp,Index);
	IsActive=IsActive_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumOfTrackingSensors(IntPtr _this);
public static int GetNumOfTrackingSensors()
{
	int ___ret = GetNumOfTrackingSensors(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasValidTrackingPosition(IntPtr _this);
public static bool HasValidTrackingPosition()
{
	int ___ret = HasValidTrackingPosition(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetOrientationAndPosition(IntPtr _this,out FRotator DeviceRotation,out FVector DevicePosition);
public static void GetOrientationAndPosition(out FRotator DeviceRotation,out FVector DevicePosition)
{
	GetOrientationAndPosition(IntPtr.Zero,out DeviceRotation,out DevicePosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetHMDDeviceName(IntPtr _this);
public static string GetHMDDeviceName()
{
	string ___ret = GetHMDDeviceName(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EnableHMD(IntPtr _this,int bEnable);
public static bool EnableHMD(bool bEnable)
{
	int ___ret = EnableHMD(IntPtr.Zero,bEnable?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsHeadMountedDisplayConnected(IntPtr _this);
public static bool IsHeadMountedDisplayConnected()
{
	int ___ret = IsHeadMountedDisplayConnected(IntPtr.Zero);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsHeadMountedDisplayEnabled(IntPtr _this);
public static bool IsHeadMountedDisplayEnabled()
{
	int ___ret = IsHeadMountedDisplayEnabled(IntPtr.Zero);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
