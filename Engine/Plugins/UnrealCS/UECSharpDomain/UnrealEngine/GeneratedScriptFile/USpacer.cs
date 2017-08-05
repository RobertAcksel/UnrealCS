//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USpacer:UWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSize(IntPtr _this,ref FVector2D InSize);
	
	/// <summary>Sets the size of the spacer</summary>
	public  void SetSize(FVector2D InSize)
	{
		CheckIsValid();
		SetSize(_this.Get(),ref InSize);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
