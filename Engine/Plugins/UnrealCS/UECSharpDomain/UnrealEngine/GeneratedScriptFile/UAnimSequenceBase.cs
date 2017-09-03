//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAnimSequenceBase:UAnimationAsset 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPlayLength(IntPtr _this);
	
	/// <summary>Returns the total play length of the montage, if played back with a speed of 1.0.</summary>
	public  float GetPlayLength()
	{
		CheckIsValid();
		float ___ret = GetPlayLength(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
