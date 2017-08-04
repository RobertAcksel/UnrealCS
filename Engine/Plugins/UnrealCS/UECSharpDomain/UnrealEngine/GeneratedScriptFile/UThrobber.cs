//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UThrobber:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateOpacity(IntPtr _this,int bInAnimateOpacity);
public  void SetAnimateOpacity(bool bInAnimateOpacity)
{
	CheckIsValid();
	SetAnimateOpacity(_this.Get(),bInAnimateOpacity?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateVertically(IntPtr _this,int bInAnimateVertically);
public  void SetAnimateVertically(bool bInAnimateVertically)
{
	CheckIsValid();
	SetAnimateVertically(_this.Get(),bInAnimateVertically?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAnimateHorizontally(IntPtr _this,int bInAnimateHorizontally);
public  void SetAnimateHorizontally(bool bInAnimateHorizontally)
{
	CheckIsValid();
	SetAnimateHorizontally(_this.Get(),bInAnimateHorizontally?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNumberOfPieces(IntPtr _this,int InNumberOfPieces);
public  void SetNumberOfPieces(int InNumberOfPieces)
{
	CheckIsValid();
	SetNumberOfPieces(_this.Get(),InNumberOfPieces);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
