//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBoolBinding:UPropertyBinding 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetValue(IntPtr _this);
	
	public  bool GetValue()
	{
		CheckIsValid();
		int ___ret = GetValue(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
