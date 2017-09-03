//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTextRenderComponent:UPrimitiveComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetTextWorldSize(IntPtr _this);
	
	/// <summary>Get world space size of text</summary>
	public  FVector GetTextWorldSize()
	{
		CheckIsValid();
		FVector ___ret = GetTextWorldSize(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetTextLocalSize(IntPtr _this);
	
	/// <summary>Get local size of text</summary>
	public  FVector GetTextLocalSize()
	{
		CheckIsValid();
		FVector ___ret = GetTextLocalSize(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWorldSize(IntPtr _this,float Value);
	
	/// <summary>Change the world size of the text and signal the primitives to be rebuilt</summary>
	public  void SetWorldSize(float Value)
	{
		CheckIsValid();
		SetWorldSize(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVertSpacingAdjust(IntPtr _this,float Value);
	
	/// <summary>Change the text vertical spacing adjustment and signal the primitives to be rebuilt</summary>
	public  void SetVertSpacingAdjust(float Value)
	{
		CheckIsValid();
		SetVertSpacingAdjust(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetHorizSpacingAdjust(IntPtr _this,float Value);
	
	/// <summary>Change the text horizontal spacing adjustment and signal the primitives to be rebuilt</summary>
	public  void SetHorizSpacingAdjust(float Value)
	{
		CheckIsValid();
		SetHorizSpacingAdjust(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetYScale(IntPtr _this,float Value);
	
	/// <summary>Change the text Y scale and signal the primitives to be rebuilt</summary>
	public  void SetYScale(float Value)
	{
		CheckIsValid();
		SetYScale(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetXScale(IntPtr _this,float Value);
	
	/// <summary>Change the text X scale and signal the primitives to be rebuilt</summary>
	public  void SetXScale(float Value)
	{
		CheckIsValid();
		SetXScale(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTextRenderColor(IntPtr _this,ref FColor Value);
	
	/// <summary>Change the text render color and signal the primitives to be rebuilt</summary>
	public  void SetTextRenderColor(FColor Value)
	{
		CheckIsValid();
		SetTextRenderColor(_this.Get(),ref Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVerticalAlignment(IntPtr _this,int Value);
	
	/// <summary>Change the vertical alignment and signal the primitives to be rebuilt</summary>
	public  void SetVerticalAlignment(EVerticalTextAligment Value)
	{
		CheckIsValid();
		SetVerticalAlignment(_this.Get(),(int)Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetHorizontalAlignment(IntPtr _this,int Value);
	
	/// <summary>Change the horizontal alignment and signal the primitives to be rebuilt</summary>
	public  void SetHorizontalAlignment(EHorizTextAligment Value)
	{
		CheckIsValid();
		SetHorizontalAlignment(_this.Get(),(int)Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFont(IntPtr _this,IntPtr Value);
	
	/// <summary>Change the font and signal the primitives to be rebuilt</summary>
	public  void SetFont(UFont Value)
	{
		CheckIsValid();
		SetFont(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTextMaterial(IntPtr _this,IntPtr Material);
	
	/// <summary>Change the text material and signal the primitives to be rebuilt</summary>
	public  void SetTextMaterial(UMaterialInterface Material)
	{
		CheckIsValid();
		SetTextMaterial(_this.Get(),Material);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_SetText(IntPtr _this,string Value);
	
	/// <summary>Change the text value and signal the primitives to be rebuilt</summary>
	public  void SetText(string Value)
	{
		CheckIsValid();
		K2_SetText(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
