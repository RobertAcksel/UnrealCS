//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTextBlock:UTextLayoutWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetText(IntPtr _this,string InText);
	public  void SetText(string InText)
	{
		CheckIsValid();
		SetText(_this.Get(),InText);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetText(IntPtr _this);
	public  string GetText()
	{
		CheckIsValid();
		string ___ret = GetText(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMinDesiredWidth(IntPtr _this,float InMinDesiredWidth);
	public  void SetMinDesiredWidth(float InMinDesiredWidth)
	{
		CheckIsValid();
		SetMinDesiredWidth(_this.Get(),InMinDesiredWidth);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetJustification(IntPtr _this,int InJustification);
	public  void SetJustification(ETextJustify InJustification)
	{
		CheckIsValid();
		SetJustification(_this.Get(),(int)InJustification);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFont(IntPtr _this,ref FSlateFontInfo InFontInfo);
	public  void SetFont(FSlateFontInfo InFontInfo)
	{
		CheckIsValid();
		SetFont(_this.Get(),ref InFontInfo);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetShadowOffset(IntPtr _this,ref FVector2D InShadowOffset);
	public  void SetShadowOffset(FVector2D InShadowOffset)
	{
		CheckIsValid();
		SetShadowOffset(_this.Get(),ref InShadowOffset);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetShadowColorAndOpacity(IntPtr _this,ref FLinearColor InShadowColorAndOpacity);
	public  void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity)
	{
		CheckIsValid();
		SetShadowColorAndOpacity(_this.Get(),ref InShadowColorAndOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOpacity(IntPtr _this,float InOpacity);
	public  void SetOpacity(float InOpacity)
	{
		CheckIsValid();
		SetOpacity(_this.Get(),InOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetColorAndOpacity(IntPtr _this,ref FSlateColor InColorAndOpacity);
	public  void SetColorAndOpacity(FSlateColor InColorAndOpacity)
	{
		CheckIsValid();
		SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
