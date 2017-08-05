//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UColorBinding:UPropertyBinding 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor GetLinearValue(IntPtr _this);
	
	public  FLinearColor GetLinearValue()
	{
		CheckIsValid();
		FLinearColor ___ret = GetLinearValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FSlateColor GetSlateValue(IntPtr _this);
	
	public  FSlateColor GetSlateValue()
	{
		CheckIsValid();
		FSlateColor ___ret = GetSlateValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
