//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UArrowComponent:UPrimitiveComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetArrowColor(IntPtr _this,ref FLinearColor NewColor);
	
	/// <summary>Updates the arrow's colour, and tells it to refresh</summary>
	public  void SetArrowColor(FLinearColor NewColor)
	{
		CheckIsValid();
		SetArrowColor(_this.Get(),ref NewColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
