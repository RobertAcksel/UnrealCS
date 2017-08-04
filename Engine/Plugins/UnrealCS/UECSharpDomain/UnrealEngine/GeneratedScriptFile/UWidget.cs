//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWidget:UVisual 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetOwningPlayer(IntPtr _this);
public  APlayerController GetOwningPlayer()
{
	CheckIsValid();
	IntPtr ___ret = GetOwningPlayer(_this.Get());
	if(___ret==IntPtr.Zero) return null; APlayerController ___ret2= new APlayerController(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FGeometry GetCachedGeometry(IntPtr _this);
public  FGeometry GetCachedGeometry()
{
	CheckIsValid();
	FGeometry ___ret = GetCachedGeometry(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveFromParent(IntPtr _this);
public  void RemoveFromParent()
{
	CheckIsValid();
	RemoveFromParent(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetParent(IntPtr _this);
public  UPanelWidget GetParent()
{
	CheckIsValid();
	IntPtr ___ret = GetParent(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPanelWidget ___ret2= new UPanelWidget(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D GetDesiredSize(IntPtr _this);
public  FVector2D GetDesiredSize()
{
	CheckIsValid();
	FVector2D ___ret = GetDesiredSize(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvalidateLayoutAndVolatility(IntPtr _this);
public  void InvalidateLayoutAndVolatility()
{
	CheckIsValid();
	InvalidateLayoutAndVolatility(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceLayoutPrepass(IntPtr _this);
public  void ForceLayoutPrepass()
{
	CheckIsValid();
	ForceLayoutPrepass(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUserFocus(IntPtr _this,IntPtr PlayerController);
public  void SetUserFocus(APlayerController PlayerController)
{
	CheckIsValid();
	SetUserFocus(_this.Get(),PlayerController);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasUserFocusedDescendants(IntPtr _this,IntPtr PlayerController);
public  bool HasUserFocusedDescendants(APlayerController PlayerController)
{
	CheckIsValid();
	int ___ret = HasUserFocusedDescendants(_this.Get(),PlayerController);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasFocusedDescendants(IntPtr _this);
public  bool HasFocusedDescendants()
{
	CheckIsValid();
	int ___ret = HasFocusedDescendants(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasAnyUserFocus(IntPtr _this);
public  bool HasAnyUserFocus()
{
	CheckIsValid();
	int ___ret = HasAnyUserFocus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasUserFocus(IntPtr _this,IntPtr PlayerController);
public  bool HasUserFocus(APlayerController PlayerController)
{
	CheckIsValid();
	int ___ret = HasUserFocus(_this.Get(),PlayerController);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetKeyboardFocus(IntPtr _this);
public  void SetKeyboardFocus()
{
	CheckIsValid();
	SetKeyboardFocus(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMouseCapture(IntPtr _this);
public  bool HasMouseCapture()
{
	CheckIsValid();
	int ___ret = HasMouseCapture(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasKeyboardFocus(IntPtr _this);
public  bool HasKeyboardFocus()
{
	CheckIsValid();
	int ___ret = HasKeyboardFocus(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsHovered(IntPtr _this);
public  bool IsHovered()
{
	CheckIsValid();
	int ___ret = IsHovered(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ForceVolatile(IntPtr _this,int bForce);
public  void ForceVolatile(bool bForce)
{
	CheckIsValid();
	ForceVolatile(_this.Get(),bForce?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVisible(IntPtr _this);
public  bool IsVisible()
{
	CheckIsValid();
	int ___ret = IsVisible(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetCursor(IntPtr _this);
public  void ResetCursor()
{
	CheckIsValid();
	ResetCursor(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCursor(IntPtr _this,int InCursor);
public  void SetCursor(EMouseCursor InCursor)
{
	CheckIsValid();
	SetCursor(_this.Get(),(int)InCursor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetToolTip(IntPtr _this,IntPtr Widget);
public  void SetToolTip(UWidget Widget)
{
	CheckIsValid();
	SetToolTip(_this.Get(),Widget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetToolTipText(IntPtr _this,string InToolTipText);
public  void SetToolTipText(string InToolTipText)
{
	CheckIsValid();
	SetToolTipText(_this.Get(),InToolTipText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIsEnabled(IntPtr _this,int bInIsEnabled);
public  void SetIsEnabled(bool bInIsEnabled)
{
	CheckIsValid();
	SetIsEnabled(_this.Get(),bInIsEnabled?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetIsEnabled(IntPtr _this);
public  bool GetIsEnabled()
{
	CheckIsValid();
	int ___ret = GetIsEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTransformPivot(IntPtr _this,ref FVector2D Pivot);
public  void SetRenderTransformPivot(FVector2D Pivot)
{
	CheckIsValid();
	SetRenderTransformPivot(_this.Get(),ref Pivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTranslation(IntPtr _this,ref FVector2D Translation);
public  void SetRenderTranslation(FVector2D Translation)
{
	CheckIsValid();
	SetRenderTranslation(_this.Get(),ref Translation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderAngle(IntPtr _this,float Angle);
public  void SetRenderAngle(float Angle)
{
	CheckIsValid();
	SetRenderAngle(_this.Get(),Angle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderShear(IntPtr _this,ref FVector2D Shear);
public  void SetRenderShear(FVector2D Shear)
{
	CheckIsValid();
	SetRenderShear(_this.Get(),ref Shear);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderScale(IntPtr _this,ref FVector2D Scale);
public  void SetRenderScale(FVector2D Scale)
{
	CheckIsValid();
	SetRenderScale(_this.Get(),ref Scale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRenderTransform(IntPtr _this,ref FWidgetTransform InTransform);
public  void SetRenderTransform(FWidgetTransform InTransform)
{
	CheckIsValid();
	SetRenderTransform(_this.Get(),ref InTransform);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
