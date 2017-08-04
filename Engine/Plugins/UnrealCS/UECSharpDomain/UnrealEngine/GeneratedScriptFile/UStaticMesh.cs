//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStaticMesh:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumSections(IntPtr _this,int InLOD);
	public  int GetNumSections(int InLOD)
	{
		CheckIsValid();
		int ___ret = GetNumSections(_this.Get(),InLOD);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBox GetBoundingBox(IntPtr _this);
	public  FBox GetBoundingBox()
	{
		CheckIsValid();
		FBox ___ret = GetBoundingBox(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBoxSphereBounds GetBounds(IntPtr _this);
	public  FBoxSphereBounds GetBounds()
	{
		CheckIsValid();
		FBoxSphereBounds ___ret = GetBounds(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumLODs(IntPtr _this);
	public  int GetNumLODs()
	{
		CheckIsValid();
		int ___ret = GetNumLODs(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
