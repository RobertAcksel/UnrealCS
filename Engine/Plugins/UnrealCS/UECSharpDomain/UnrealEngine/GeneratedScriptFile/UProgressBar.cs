//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UProgressBar:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsMarquee(IntPtr _this,int InbIsMarquee);
	public  void SetIsMarquee(bool InbIsMarquee)
	{
		CheckIsValid();
		SetIsMarquee(_this.Get(),InbIsMarquee?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFillColorAndOpacity(IntPtr _this,ref FLinearColor InColor);
	public  void SetFillColorAndOpacity(FLinearColor InColor)
	{
		CheckIsValid();
		SetFillColorAndOpacity(_this.Get(),ref InColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPercent(IntPtr _this,float InPercent);
	public  void SetPercent(float InPercent)
	{
		CheckIsValid();
		SetPercent(_this.Get(),InPercent);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
