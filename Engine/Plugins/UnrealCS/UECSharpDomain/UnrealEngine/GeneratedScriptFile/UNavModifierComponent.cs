//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavModifierComponent:UNavRelevantComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAreaClass(IntPtr _this,IntPtr NewAreaClass);
	
	public  void SetAreaClass(TSubclassOf<UNavArea>  NewAreaClass)
	{
		CheckIsValid();
		SetAreaClass(_this.Get(),NewAreaClass.NativeClass);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
