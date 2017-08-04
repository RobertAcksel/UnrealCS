//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGridSlot:UPanelSlot 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVerticalAlignment(IntPtr _this,int InVerticalAlignment);
public  void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
{
	CheckIsValid();
	SetVerticalAlignment(_this.Get(),(int)InVerticalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHorizontalAlignment(IntPtr _this,int InHorizontalAlignment);
public  void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
{
	CheckIsValid();
	SetHorizontalAlignment(_this.Get(),(int)InHorizontalAlignment);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLayer(IntPtr _this,int InLayer);
public  void SetLayer(int InLayer)
{
	CheckIsValid();
	SetLayer(_this.Get(),InLayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColumnSpan(IntPtr _this,int InColumnSpan);
public  void SetColumnSpan(int InColumnSpan)
{
	CheckIsValid();
	SetColumnSpan(_this.Get(),InColumnSpan);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetColumn(IntPtr _this,int InColumn);
public  void SetColumn(int InColumn)
{
	CheckIsValid();
	SetColumn(_this.Get(),InColumn);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRowSpan(IntPtr _this,int InRowSpan);
public  void SetRowSpan(int InRowSpan)
{
	CheckIsValid();
	SetRowSpan(_this.Get(),InRowSpan);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetRow(IntPtr _this,int InRow);
public  void SetRow(int InRow)
{
	CheckIsValid();
	SetRow(_this.Get(),InRow);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPadding(IntPtr _this,ref FMargin InPadding);
public  void SetPadding(FMargin InPadding)
{
	CheckIsValid();
	SetPadding(_this.Get(),ref InPadding);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
