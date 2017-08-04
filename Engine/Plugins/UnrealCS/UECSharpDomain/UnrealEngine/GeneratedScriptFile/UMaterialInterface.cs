//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMaterialInterface:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetPhysicalMaterial(IntPtr _this);
	public  UPhysicalMaterial GetPhysicalMaterial()
	{
		CheckIsValid();
		IntPtr ___ret = GetPhysicalMaterial(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPhysicalMaterial ___ret2= new UPhysicalMaterial(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetBaseMaterial(IntPtr _this);
	public  UMaterial GetBaseMaterial()
	{
		CheckIsValid();
		IntPtr ___ret = GetBaseMaterial(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterial ___ret2= new UMaterial(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
