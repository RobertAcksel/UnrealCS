//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAnimSequenceBase:UAnimationAsset 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetPlayLength(IntPtr _this);
public  float GetPlayLength()
{
	CheckIsValid();
	float ___ret = GetPlayLength(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
