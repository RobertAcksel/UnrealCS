//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetAnimation:UMovieSceneSequence 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetEndTime(IntPtr _this);
public  float GetEndTime()
{
	CheckIsValid();
	float ___ret = GetEndTime(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetStartTime(IntPtr _this);
public  float GetStartTime()
{
	CheckIsValid();
	float ___ret = GetStartTime(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
