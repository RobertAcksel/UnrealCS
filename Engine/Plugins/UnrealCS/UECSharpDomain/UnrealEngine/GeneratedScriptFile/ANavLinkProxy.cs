//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ANavLinkProxy:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasMovingAgents(IntPtr _this);
	public  bool HasMovingAgents()
	{
		CheckIsValid();
		int ___ret = HasMovingAgents(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSmartLinkEnabled(IntPtr _this,int bEnabled);
	public  void SetSmartLinkEnabled(bool bEnabled)
	{
		CheckIsValid();
		SetSmartLinkEnabled(_this.Get(),bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsSmartLinkEnabled(IntPtr _this);
	public  bool IsSmartLinkEnabled()
	{
		CheckIsValid();
		int ___ret = IsSmartLinkEnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResumePathFollowing(IntPtr _this,IntPtr Agent);
	public  void ResumePathFollowing(AActor Agent)
	{
		CheckIsValid();
		ResumePathFollowing(_this.Get(),Agent);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
