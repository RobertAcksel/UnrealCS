//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UExpandableArea:UWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsExpanded_Animated(IntPtr _this,int IsExpanded);
	
	public  void SetIsExpanded_Animated(bool IsExpanded)
	{
		CheckIsValid();
		SetIsExpanded_Animated(_this.Get(),IsExpanded?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsExpanded(IntPtr _this,int IsExpanded);
	
	public  void SetIsExpanded(bool IsExpanded)
	{
		CheckIsValid();
		SetIsExpanded(_this.Get(),IsExpanded?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetIsExpanded(IntPtr _this);
	
	public  bool GetIsExpanded()
	{
		CheckIsValid();
		int ___ret = GetIsExpanded(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
