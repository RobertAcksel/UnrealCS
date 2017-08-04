//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UArrowComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetArrowColor(IntPtr _this,ref FLinearColor NewColor);
public  void SetArrowColor(FLinearColor NewColor)
{
	CheckIsValid();
	SetArrowColor(_this.Get(),ref NewColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
