//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UStereoLayerComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MarkTextureForUpdate(IntPtr _this);
	public  void MarkTextureForUpdate()
	{
		CheckIsValid();
		MarkTextureForUpdate(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPriority(IntPtr _this);
	public  int GetPriority()
	{
		CheckIsValid();
		int ___ret = GetPriority(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPriority(IntPtr _this,int InPriority);
	public  void SetPriority(int InPriority)
	{
		CheckIsValid();
		SetPriority(_this.Get(),InPriority);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBox2D GetUVRect(IntPtr _this);
	public  FBox2D GetUVRect()
	{
		CheckIsValid();
		FBox2D ___ret = GetUVRect(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUVRect(IntPtr _this,ref FBox2D InUVRect);
	public  void SetUVRect(FBox2D InUVRect)
	{
		CheckIsValid();
		SetUVRect(_this.Get(),ref InUVRect);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetQuadSize(IntPtr _this);
	public  FVector2D GetQuadSize()
	{
		CheckIsValid();
		FVector2D ___ret = GetQuadSize(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetQuadSize(IntPtr _this,ref FVector2D InQuadSize);
	public  void SetQuadSize(FVector2D InQuadSize)
	{
		CheckIsValid();
		SetQuadSize(_this.Get(),ref InQuadSize);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetTexture(IntPtr _this);
	public  UTexture GetTexture()
	{
		CheckIsValid();
		IntPtr ___ret = GetTexture(_this.Get());
		if(___ret==IntPtr.Zero) return null; UTexture ___ret2= new UTexture(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTexture(IntPtr _this,IntPtr InTexture);
	public  void SetTexture(UTexture InTexture)
	{
		CheckIsValid();
		SetTexture(_this.Get(),InTexture);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
