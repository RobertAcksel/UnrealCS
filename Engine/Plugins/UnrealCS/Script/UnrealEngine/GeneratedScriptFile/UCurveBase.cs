//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCurveBase:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetValueRange(IntPtr _this,out float MinValue,out float MaxValue);
public  void GetValueRange(out float MinValue,out float MaxValue)
{
	CheckIsValid();
	GetValueRange(_this.Get(),out MinValue,out MaxValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTimeRange(IntPtr _this,out float MinTime,out float MaxTime);
public  void GetTimeRange(out float MinTime,out float MaxTime)
{
	CheckIsValid();
	GetTimeRange(_this.Get(),out MinTime,out MaxTime);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
