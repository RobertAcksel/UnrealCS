//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidget:UVisual 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwningPlayer(IntPtr _this);
	public  APlayerController GetOwningPlayer()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwningPlayer(_this.Get());
		if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FGeometry GetCachedGeometry(IntPtr _this);
	public  FGeometry GetCachedGeometry()
	{
		CheckIsValid();
		FGeometry ___ret = GetCachedGeometry(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveFromParent(IntPtr _this);
	public  void RemoveFromParent()
	{
		CheckIsValid();
		RemoveFromParent(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetParent(IntPtr _this);
	public  UPanelWidget GetParent()
	{
		CheckIsValid();
		IntPtr ___ret = GetParent(_this.Get());
		if(___ret==IntPtr.Zero) return null; UPanelWidget ___ret2= new UPanelWidget(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D GetDesiredSize(IntPtr _this);
	public  FVector2D GetDesiredSize()
	{
		CheckIsValid();
		FVector2D ___ret = GetDesiredSize(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void InvalidateLayoutAndVolatility(IntPtr _this);
	public  void InvalidateLayoutAndVolatility()
	{
		CheckIsValid();
		InvalidateLayoutAndVolatility(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceLayoutPrepass(IntPtr _this);
	public  void ForceLayoutPrepass()
	{
		CheckIsValid();
		ForceLayoutPrepass(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetUserFocus(IntPtr _this,IntPtr PlayerController);
	public  void SetUserFocus(APlayerController PlayerController)
	{
		CheckIsValid();
		SetUserFocus(_this.Get(),PlayerController);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasUserFocusedDescendants(IntPtr _this,IntPtr PlayerController);
	public  bool HasUserFocusedDescendants(APlayerController PlayerController)
	{
		CheckIsValid();
		int ___ret = HasUserFocusedDescendants(_this.Get(),PlayerController);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasFocusedDescendants(IntPtr _this);
	public  bool HasFocusedDescendants()
	{
		CheckIsValid();
		int ___ret = HasFocusedDescendants(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasAnyUserFocus(IntPtr _this);
	public  bool HasAnyUserFocus()
	{
		CheckIsValid();
		int ___ret = HasAnyUserFocus(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasUserFocus(IntPtr _this,IntPtr PlayerController);
	public  bool HasUserFocus(APlayerController PlayerController)
	{
		CheckIsValid();
		int ___ret = HasUserFocus(_this.Get(),PlayerController);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetKeyboardFocus(IntPtr _this);
	public  void SetKeyboardFocus()
	{
		CheckIsValid();
		SetKeyboardFocus(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasMouseCapture(IntPtr _this);
	public  bool HasMouseCapture()
	{
		CheckIsValid();
		int ___ret = HasMouseCapture(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasKeyboardFocus(IntPtr _this);
	public  bool HasKeyboardFocus()
	{
		CheckIsValid();
		int ___ret = HasKeyboardFocus(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsHovered(IntPtr _this);
	public  bool IsHovered()
	{
		CheckIsValid();
		int ___ret = IsHovered(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ForceVolatile(IntPtr _this,int bForce);
	public  void ForceVolatile(bool bForce)
	{
		CheckIsValid();
		ForceVolatile(_this.Get(),bForce?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsVisible(IntPtr _this);
	public  bool IsVisible()
	{
		CheckIsValid();
		int ___ret = IsVisible(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetCursor(IntPtr _this);
	public  void ResetCursor()
	{
		CheckIsValid();
		ResetCursor(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCursor(IntPtr _this,int InCursor);
	public  void SetCursor(EMouseCursor InCursor)
	{
		CheckIsValid();
		SetCursor(_this.Get(),(int)InCursor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetToolTip(IntPtr _this,IntPtr Widget);
	public  void SetToolTip(UWidget Widget)
	{
		CheckIsValid();
		SetToolTip(_this.Get(),Widget);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetToolTipText(IntPtr _this,string InToolTipText);
	public  void SetToolTipText(string InToolTipText)
	{
		CheckIsValid();
		SetToolTipText(_this.Get(),InToolTipText);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsEnabled(IntPtr _this,int bInIsEnabled);
	public  void SetIsEnabled(bool bInIsEnabled)
	{
		CheckIsValid();
		SetIsEnabled(_this.Get(),bInIsEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetIsEnabled(IntPtr _this);
	public  bool GetIsEnabled()
	{
		CheckIsValid();
		int ___ret = GetIsEnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderTransformPivot(IntPtr _this,ref FVector2D Pivot);
	public  void SetRenderTransformPivot(FVector2D Pivot)
	{
		CheckIsValid();
		SetRenderTransformPivot(_this.Get(),ref Pivot);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderTranslation(IntPtr _this,ref FVector2D Translation);
	public  void SetRenderTranslation(FVector2D Translation)
	{
		CheckIsValid();
		SetRenderTranslation(_this.Get(),ref Translation);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderAngle(IntPtr _this,float Angle);
	public  void SetRenderAngle(float Angle)
	{
		CheckIsValid();
		SetRenderAngle(_this.Get(),Angle);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderShear(IntPtr _this,ref FVector2D Shear);
	public  void SetRenderShear(FVector2D Shear)
	{
		CheckIsValid();
		SetRenderShear(_this.Get(),ref Shear);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderScale(IntPtr _this,ref FVector2D Scale);
	public  void SetRenderScale(FVector2D Scale)
	{
		CheckIsValid();
		SetRenderScale(_this.Get(),ref Scale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRenderTransform(IntPtr _this,ref FWidgetTransform InTransform);
	public  void SetRenderTransform(FWidgetTransform InTransform)
	{
		CheckIsValid();
		SetRenderTransform(_this.Get(),ref InTransform);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
