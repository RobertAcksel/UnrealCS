//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCameraModifier:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EnableModifier(IntPtr _this);
	public  void EnableModifier()
	{
		CheckIsValid();
		EnableModifier(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void DisableModifier(IntPtr _this,int bImmediate);
	public  void DisableModifier(bool bImmediate=false)
	{
		CheckIsValid();
		DisableModifier(_this.Get(),bImmediate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetViewTarget(IntPtr _this);
	public  AActor GetViewTarget()
	{
		CheckIsValid();
		IntPtr ___ret = GetViewTarget(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsDisabled(IntPtr _this);
	public  bool IsDisabled()
	{
		CheckIsValid();
		int ___ret = IsDisabled(_this.Get());
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
