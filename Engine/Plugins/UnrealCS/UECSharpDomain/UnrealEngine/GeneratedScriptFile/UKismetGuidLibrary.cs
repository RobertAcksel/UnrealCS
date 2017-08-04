//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetGuidLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Parse_StringToGuid(IntPtr _this,string GuidString,out FGuid OutGuid,out int Success);
public static void Parse_StringToGuid(string GuidString,out FGuid OutGuid,out bool Success)
{
	int Success_temp;
	Parse_StringToGuid(IntPtr.Zero,GuidString,out OutGuid,out Success_temp);
	Success=Success_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_GuidToString(IntPtr _this,ref FGuid InGuid);
public static string Conv_GuidToString(FGuid InGuid)
{
	string ___ret = Conv_GuidToString(IntPtr.Zero,ref InGuid);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FGuid NewGuid(IntPtr _this);
public static FGuid NewGuid()
{
	FGuid ___ret = NewGuid(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Invalidate_Guid(IntPtr _this,out FGuid InGuid);
public static void Invalidate_Guid(out FGuid InGuid)
{
	Invalidate_Guid(IntPtr.Zero,out InGuid);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsValid_Guid(IntPtr _this,ref FGuid InGuid);
public static bool IsValid_Guid(FGuid InGuid)
{
	int ___ret = IsValid_Guid(IntPtr.Zero,ref InGuid);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_GuidGuid(IntPtr _this,ref FGuid A,ref FGuid B);
public static bool NotEqual_GuidGuid(FGuid A,FGuid B)
{
	int ___ret = NotEqual_GuidGuid(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_GuidGuid(IntPtr _this,ref FGuid A,ref FGuid B);
public static bool EqualEqual_GuidGuid(FGuid A,FGuid B)
{
	int ___ret = EqualEqual_GuidGuid(IntPtr.Zero,ref A,ref B);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
