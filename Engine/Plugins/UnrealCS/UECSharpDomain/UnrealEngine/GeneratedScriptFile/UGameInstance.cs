//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameInstance:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugRemovePlayer(IntPtr _this,int ControllerId);
public  void DebugRemovePlayer(int ControllerId)
{
	CheckIsValid();
	DebugRemovePlayer(_this.Get(),ControllerId);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCreatePlayer(IntPtr _this,int ControllerId);
public  void DebugCreatePlayer(int ControllerId)
{
	CheckIsValid();
	DebugCreatePlayer(_this.Get(),ControllerId);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
