//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ACameraActor:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAutoActivatePlayerIndex(IntPtr _this);
public  int GetAutoActivatePlayerIndex()
{
	CheckIsValid();
	int ___ret = GetAutoActivatePlayerIndex(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
