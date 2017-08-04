//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPanelWidget:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearChildren(IntPtr _this);
	public  void ClearChildren()
	{
		CheckIsValid();
		ClearChildren(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasAnyChildren(IntPtr _this);
	public  bool HasAnyChildren()
	{
		CheckIsValid();
		int ___ret = HasAnyChildren(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RemoveChild(IntPtr _this,IntPtr Content);
	public  bool RemoveChild(UWidget Content)
	{
		CheckIsValid();
		int ___ret = RemoveChild(_this.Get(),Content);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr AddChild(IntPtr _this,IntPtr Content);
	public  UPanelSlot AddChild(UWidget Content)
	{
		CheckIsValid();
		IntPtr ___ret = AddChild(_this.Get(),Content);
		if(___ret==IntPtr.Zero) return null; UPanelSlot ___ret2= new UPanelSlot(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RemoveChildAt(IntPtr _this,int Index);
	public  bool RemoveChildAt(int Index)
	{
		CheckIsValid();
		int ___ret = RemoveChildAt(_this.Get(),Index);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasChild(IntPtr _this,IntPtr Content);
	public  bool HasChild(UWidget Content)
	{
		CheckIsValid();
		int ___ret = HasChild(_this.Get(),Content);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetChildIndex(IntPtr _this,IntPtr Content);
	public  int GetChildIndex(UWidget Content)
	{
		CheckIsValid();
		int ___ret = GetChildIndex(_this.Get(),Content);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetChildAt(IntPtr _this,int Index);
	public  UWidget GetChildAt(int Index)
	{
		CheckIsValid();
		IntPtr ___ret = GetChildAt(_this.Get(),Index);
		if(___ret==IntPtr.Zero) return null; UWidget ___ret2= new UWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetChildrenCount(IntPtr _this);
	public  int GetChildrenCount()
	{
		CheckIsValid();
		int ___ret = GetChildrenCount(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
