//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCameraAnimInst:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScale(IntPtr _this,float NewDuration);
public  void SetScale(float NewDuration)
{
	CheckIsValid();
	SetScale(_this.Get(),NewDuration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDuration(IntPtr _this,float NewDuration);
public  void SetDuration(float NewDuration)
{
	CheckIsValid();
	SetDuration(_this.Get(),NewDuration);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this,int bImmediate);
public  void Stop(bool bImmediate=false)
{
	CheckIsValid();
	Stop(_this.Get(),bImmediate?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
