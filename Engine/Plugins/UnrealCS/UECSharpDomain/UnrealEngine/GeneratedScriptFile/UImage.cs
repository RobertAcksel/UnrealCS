//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UImage:UWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetDynamicMaterial(IntPtr _this);
	
	public  UMaterialInstanceDynamic GetDynamicMaterial()
	{
		CheckIsValid();
		IntPtr ___ret = GetDynamicMaterial(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBrushFromMaterial(IntPtr _this,IntPtr Material);
	
	public  void SetBrushFromMaterial(UMaterialInterface Material)
	{
		CheckIsValid();
		SetBrushFromMaterial(_this.Get(),Material);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBrushFromTextureDynamic(IntPtr _this,IntPtr Texture,int bMatchSize);
	
	public  void SetBrushFromTextureDynamic(UTexture2DDynamic Texture,bool bMatchSize=false)
	{
		CheckIsValid();
		SetBrushFromTextureDynamic(_this.Get(),Texture,bMatchSize?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBrushFromTexture(IntPtr _this,IntPtr Texture,int bMatchSize);
	
	public  void SetBrushFromTexture(UTexture2D Texture,bool bMatchSize=false)
	{
		CheckIsValid();
		SetBrushFromTexture(_this.Get(),Texture,bMatchSize?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBrushFromAsset(IntPtr _this,IntPtr Asset);
	
	public  void SetBrushFromAsset(USlateBrushAsset Asset)
	{
		CheckIsValid();
		SetBrushFromAsset(_this.Get(),Asset);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBrush(IntPtr _this,ref FSlateBrush InBrush);
	
	public  void SetBrush(FSlateBrush InBrush)
	{
		CheckIsValid();
		SetBrush(_this.Get(),ref InBrush);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOpacity(IntPtr _this,float InOpacity);
	
	public  void SetOpacity(float InOpacity)
	{
		CheckIsValid();
		SetOpacity(_this.Get(),InOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetColorAndOpacity(IntPtr _this,ref FLinearColor InColorAndOpacity);
	
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckIsValid();
		SetColorAndOpacity(_this.Get(),ref InColorAndOpacity);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
