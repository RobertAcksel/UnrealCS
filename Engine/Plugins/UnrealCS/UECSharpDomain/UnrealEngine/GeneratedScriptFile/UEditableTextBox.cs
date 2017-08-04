//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UEditableTextBox:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int HasError(IntPtr _this);
	public  bool HasError()
	{
		CheckIsValid();
		int ___ret = HasError(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearError(IntPtr _this);
	public  void ClearError()
	{
		CheckIsValid();
		ClearError(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsReadOnly(IntPtr _this,int bReadOnly);
	public  void SetIsReadOnly(bool bReadOnly)
	{
		CheckIsValid();
		SetIsReadOnly(_this.Get(),bReadOnly?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetError(IntPtr _this,string InError);
	public  void SetError(string InError)
	{
		CheckIsValid();
		SetError(_this.Get(),InError);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetHintText(IntPtr _this,string InText);
	public  void SetHintText(string InText)
	{
		CheckIsValid();
		SetHintText(_this.Get(),InText);
		
	}
	
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
	public static extern new IntPtr StaticClass();
}
}
