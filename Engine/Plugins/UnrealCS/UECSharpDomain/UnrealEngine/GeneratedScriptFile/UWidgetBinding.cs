//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetBinding:UPropertyBinding 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetValue(IntPtr _this);
	
	public  UWidget GetValue()
	{
		CheckIsValid();
		IntPtr ___ret = GetValue(_this.Get());
		if(___ret==IntPtr.Zero) return null; UWidget ___ret2= new UWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
