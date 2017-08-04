//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetNodeHelperLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetEnumeratorValueFromIndex(IntPtr _this,IntPtr Enum,int EnumeratorIndex);
	public static byte GetEnumeratorValueFromIndex(UEnum Enum,byte EnumeratorIndex)
	{
		int ___ret = GetEnumeratorValueFromIndex(IntPtr.Zero,Enum,EnumeratorIndex);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetValidValue(IntPtr _this,IntPtr Enum,int EnumeratorValue);
	public static byte GetValidValue(UEnum Enum,byte EnumeratorValue)
	{
		int ___ret = GetValidValue(IntPtr.Zero,Enum,EnumeratorValue);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetEnumeratorUserFriendlyName(IntPtr _this,IntPtr Enum,int EnumeratorValue);
	public static string GetEnumeratorUserFriendlyName(UEnum Enum,byte EnumeratorValue)
	{
		string ___ret = GetEnumeratorUserFriendlyName(IntPtr.Zero,Enum,EnumeratorValue);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetEnumeratorName(IntPtr _this,IntPtr Enum,int EnumeratorValue);
	public static string GetEnumeratorName(UEnum Enum,byte EnumeratorValue)
	{
		string ___ret = GetEnumeratorName(IntPtr.Zero,Enum,EnumeratorValue);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetFirstUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits);
	public static int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits)
	{
		int ___ret = GetFirstUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetRandomUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits);
	public static int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits)
	{
		int ___ret = GetRandomUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetUnmarkedBit(IntPtr _this,int Data,int StartIdx,int NumBits,int bRandom);
	public static int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom)
	{
		int ___ret = GetUnmarkedBit(IntPtr.Zero,Data,StartIdx,NumBits,bRandom?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasMarkedBit(IntPtr _this,int Data,int NumBits);
	public static bool HasMarkedBit(int Data,int NumBits)
	{
		int ___ret = HasMarkedBit(IntPtr.Zero,Data,NumBits);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasUnmarkedBit(IntPtr _this,int Data,int NumBits);
	public static bool HasUnmarkedBit(int Data,int NumBits)
	{
		int ___ret = HasUnmarkedBit(IntPtr.Zero,Data,NumBits);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearAllBits(IntPtr _this,out int Data);
	public static void ClearAllBits(out int Data)
	{
		ClearAllBits(IntPtr.Zero,out Data);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearBit(IntPtr _this,out int Data,int Index);
	public static void ClearBit(out int Data,int Index)
	{
		ClearBit(IntPtr.Zero,out Data,Index);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MarkBit(IntPtr _this,out int Data,int Index);
	public static void MarkBit(out int Data,int Index)
	{
		MarkBit(IntPtr.Zero,out Data,Index);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BitIsMarked(IntPtr _this,int Data,int Index);
	public static bool BitIsMarked(int Data,int Index)
	{
		int ___ret = BitIsMarked(IntPtr.Zero,Data,Index);
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
