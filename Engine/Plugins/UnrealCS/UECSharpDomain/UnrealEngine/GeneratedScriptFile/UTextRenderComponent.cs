//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTextRenderComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetTextWorldSize(IntPtr _this);
public  FVector GetTextWorldSize()
{
	CheckIsValid();
	FVector ___ret = GetTextWorldSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector GetTextLocalSize(IntPtr _this);
public  FVector GetTextLocalSize()
{
	CheckIsValid();
	FVector ___ret = GetTextLocalSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldSize(IntPtr _this,float Value);
public  void SetWorldSize(float Value)
{
	CheckIsValid();
	SetWorldSize(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVertSpacingAdjust(IntPtr _this,float Value);
public  void SetVertSpacingAdjust(float Value)
{
	CheckIsValid();
	SetVertSpacingAdjust(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHorizSpacingAdjust(IntPtr _this,float Value);
public  void SetHorizSpacingAdjust(float Value)
{
	CheckIsValid();
	SetHorizSpacingAdjust(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetYScale(IntPtr _this,float Value);
public  void SetYScale(float Value)
{
	CheckIsValid();
	SetYScale(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetXScale(IntPtr _this,float Value);
public  void SetXScale(float Value)
{
	CheckIsValid();
	SetXScale(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTextRenderColor(IntPtr _this,ref FColor Value);
public  void SetTextRenderColor(FColor Value)
{
	CheckIsValid();
	SetTextRenderColor(_this.Get(),ref Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVerticalAlignment(IntPtr _this,int Value);
public  void SetVerticalAlignment(EVerticalTextAligment Value)
{
	CheckIsValid();
	SetVerticalAlignment(_this.Get(),(int)Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHorizontalAlignment(IntPtr _this,int Value);
public  void SetHorizontalAlignment(EHorizTextAligment Value)
{
	CheckIsValid();
	SetHorizontalAlignment(_this.Get(),(int)Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFont(IntPtr _this,IntPtr Value);
public  void SetFont(UFont Value)
{
	CheckIsValid();
	SetFont(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTextMaterial(IntPtr _this,IntPtr Material);
public  void SetTextMaterial(UMaterialInterface Material)
{
	CheckIsValid();
	SetTextMaterial(_this.Get(),Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_SetText(IntPtr _this,string Value);
public  void K2_SetText(string Value)
{
	CheckIsValid();
	K2_SetText(_this.Get(),Value);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
