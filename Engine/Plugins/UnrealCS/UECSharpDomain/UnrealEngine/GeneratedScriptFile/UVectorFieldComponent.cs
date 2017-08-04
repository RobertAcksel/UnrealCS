//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVectorFieldComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensity(IntPtr _this,float NewIntensity);
public  void SetIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIntensity(_this.Get(),NewIntensity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
