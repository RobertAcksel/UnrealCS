//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UProgressBar:UWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsMarquee(IntPtr _this,int InbIsMarquee);
	
	/// <summary>Sets the progress bar to show as a marquee.</summary>
	public  void SetIsMarquee(bool InbIsMarquee)
	{
		CheckIsValid();
		SetIsMarquee(_this.Get(),InbIsMarquee?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFillColorAndOpacity(IntPtr _this,ref FLinearColor InColor);
	
	/// <summary>Sets the fill color of the progress bar.</summary>
	public  void SetFillColorAndOpacity(FLinearColor InColor)
	{
		CheckIsValid();
		SetFillColorAndOpacity(_this.Get(),ref InColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPercent(IntPtr _this,float InPercent);
	
	/// <summary>Sets the current value of the ProgressBar.</summary>
	public  void SetPercent(float InPercent)
	{
		CheckIsValid();
		SetPercent(_this.Get(),InPercent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
