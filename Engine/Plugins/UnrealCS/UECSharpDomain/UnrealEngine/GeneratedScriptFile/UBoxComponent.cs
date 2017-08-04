//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBoxComponent:UShapeComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetUnscaledBoxExtent(IntPtr _this);
	public  FVector GetUnscaledBoxExtent()
	{
		CheckIsValid();
		FVector ___ret = GetUnscaledBoxExtent(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetScaledBoxExtent(IntPtr _this);
	public  FVector GetScaledBoxExtent()
	{
		CheckIsValid();
		FVector ___ret = GetScaledBoxExtent(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBoxExtent(IntPtr _this,ref FVector InBoxExtent,int bUpdateOverlaps);
	public  void SetBoxExtent(FVector InBoxExtent,bool bUpdateOverlaps=true)
	{
		CheckIsValid();
		SetBoxExtent(_this.Get(),ref InBoxExtent,bUpdateOverlaps?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
