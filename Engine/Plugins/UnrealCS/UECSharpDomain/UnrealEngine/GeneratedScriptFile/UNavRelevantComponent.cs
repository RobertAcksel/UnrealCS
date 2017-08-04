//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UNavRelevantComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNavigationRelevancy(IntPtr _this,int bRelevant);
	public  void SetNavigationRelevancy(bool bRelevant)
	{
		CheckIsValid();
		SetNavigationRelevancy(_this.Get(),bRelevant?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
