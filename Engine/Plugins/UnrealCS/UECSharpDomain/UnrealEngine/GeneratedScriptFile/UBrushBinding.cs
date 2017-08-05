//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBrushBinding:UPropertyBinding 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FSlateBrush GetValue(IntPtr _this);
	
	public  FSlateBrush GetValue()
	{
		CheckIsValid();
		FSlateBrush ___ret = GetValue(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
