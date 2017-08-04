//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetAnimation:UMovieSceneSequence 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetEndTime(IntPtr _this);
	public  float GetEndTime()
	{
		CheckIsValid();
		float ___ret = GetEndTime(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetStartTime(IntPtr _this);
	public  float GetStartTime()
	{
		CheckIsValid();
		float ___ret = GetStartTime(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
