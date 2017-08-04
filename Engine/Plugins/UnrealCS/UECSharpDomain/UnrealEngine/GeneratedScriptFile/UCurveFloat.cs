//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCurveFloat:UCurveBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetFloatValue(IntPtr _this,float InTime);
	public  float GetFloatValue(float InTime)
	{
		CheckIsValid();
		float ___ret = GetFloatValue(_this.Get(),InTime);
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
