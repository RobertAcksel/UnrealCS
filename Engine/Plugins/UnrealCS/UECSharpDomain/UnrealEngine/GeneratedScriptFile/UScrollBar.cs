//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UScrollBar:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetState(IntPtr _this,float InOffsetFraction,float InThumbSizeFraction);
public  void SetState(float InOffsetFraction,float InThumbSizeFraction)
{
	CheckIsValid();
	SetState(_this.Get(),InOffsetFraction,InThumbSizeFraction);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
