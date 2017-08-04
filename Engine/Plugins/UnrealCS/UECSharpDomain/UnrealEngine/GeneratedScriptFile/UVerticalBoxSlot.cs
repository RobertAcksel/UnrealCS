//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVerticalBoxSlot:UPanelSlot 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVerticalAlignment(IntPtr _this,int InVerticalAlignment);
	public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckIsValid();
		SetVerticalAlignment(_this.Get(),(int)InVerticalAlignment);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetHorizontalAlignment(IntPtr _this,int InHorizontalAlignment);
	public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckIsValid();
		SetHorizontalAlignment(_this.Get(),(int)InHorizontalAlignment);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSize(IntPtr _this,ref FSlateChildSize InSize);
	public  void SetSize(FSlateChildSize InSize)
	{
		CheckIsValid();
		SetSize(_this.Get(),ref InSize);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPadding(IntPtr _this,ref FMargin InPadding);
	public  void SetPadding(FMargin InPadding)
	{
		CheckIsValid();
		SetPadding(_this.Get(),ref InPadding);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
