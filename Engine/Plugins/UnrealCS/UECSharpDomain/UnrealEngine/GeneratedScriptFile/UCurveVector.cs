//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCurveVector:UCurveBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetVectorValue(IntPtr _this,float InTime);
	public  FVector GetVectorValue(float InTime)
	{
		CheckIsValid();
		FVector ___ret = GetVectorValue(_this.Get(),InTime);
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
