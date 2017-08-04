//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UScrollBox:UPanelWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScrollWidgetIntoView(IntPtr _this,IntPtr WidgetToFind,int AnimateScroll);
	public  void ScrollWidgetIntoView(UWidget WidgetToFind,bool AnimateScroll=true)
	{
		CheckIsValid();
		ScrollWidgetIntoView(_this.Get(),WidgetToFind,AnimateScroll?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScrollToEnd(IntPtr _this);
	public  void ScrollToEnd()
	{
		CheckIsValid();
		ScrollToEnd(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScrollToStart(IntPtr _this);
	public  void ScrollToStart()
	{
		CheckIsValid();
		ScrollToStart(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetScrollOffset(IntPtr _this);
	public  float GetScrollOffset()
	{
		CheckIsValid();
		float ___ret = GetScrollOffset(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetScrollOffset(IntPtr _this,float NewScrollOffset);
	public  void SetScrollOffset(float NewScrollOffset)
	{
		CheckIsValid();
		SetScrollOffset(_this.Get(),NewScrollOffset);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
