//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidgetComponent:UMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBackgroundColor(IntPtr _this,ref FLinearColor NewBackgroundColor);
	public  void SetBackgroundColor(FLinearColor NewBackgroundColor)
	{
		CheckIsValid();
		SetBackgroundColor(_this.Get(),ref NewBackgroundColor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RequestRedraw(IntPtr _this);
	public  void RequestRedraw()
	{
		CheckIsValid();
		RequestRedraw(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDrawSize(IntPtr _this,ref FVector2D Size);
	public  void SetDrawSize(FVector2D Size)
	{
		CheckIsValid();
		SetDrawSize(_this.Get(),ref Size);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetDrawSize(IntPtr _this);
	public  FVector2D GetDrawSize()
	{
		CheckIsValid();
		FVector2D ___ret = GetDrawSize(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwnerPlayer(IntPtr _this);
	public  ULocalPlayer GetOwnerPlayer()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwnerPlayer(_this.Get());
		if(___ret==IntPtr.Zero) return null; ULocalPlayer ___ret2= new ULocalPlayer(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOwnerPlayer(IntPtr _this,IntPtr LocalPlayer);
	public  void SetOwnerPlayer(ULocalPlayer LocalPlayer)
	{
		CheckIsValid();
		SetOwnerPlayer(_this.Get(),LocalPlayer);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetWidget(IntPtr _this,IntPtr Widget);
	public  void SetWidget(UUserWidget Widget)
	{
		CheckIsValid();
		SetWidget(_this.Get(),Widget);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetMaterialInstance(IntPtr _this);
	public  UMaterialInstanceDynamic GetMaterialInstance()
	{
		CheckIsValid();
		IntPtr ___ret = GetMaterialInstance(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetRenderTarget(IntPtr _this);
	public  UTextureRenderTarget2D GetRenderTarget()
	{
		CheckIsValid();
		IntPtr ___ret = GetRenderTarget(_this.Get());
		if(___ret==IntPtr.Zero) return null; UTextureRenderTarget2D ___ret2= new UTextureRenderTarget2D(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetUserWidgetObject(IntPtr _this);
	public  UUserWidget GetUserWidgetObject()
	{
		CheckIsValid();
		IntPtr ___ret = GetUserWidgetObject(_this.Get());
		if(___ret==IntPtr.Zero) return null; UUserWidget ___ret2= new UUserWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
