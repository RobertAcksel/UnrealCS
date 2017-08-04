//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInputKeySelector:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetIsSelectingKey(IntPtr _this);
	public  bool GetIsSelectingKey()
	{
		CheckIsValid();
		int ___ret = GetIsSelectingKey(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAllowModifierKeys(IntPtr _this,int bInAllowModifierKeys);
	public  void SetAllowModifierKeys(bool bInAllowModifierKeys)
	{
		CheckIsValid();
		SetAllowModifierKeys(_this.Get(),bInAllowModifierKeys?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetKeySelectionText(IntPtr _this,string InKeySelectionText);
	public  void SetKeySelectionText(string InKeySelectionText)
	{
		CheckIsValid();
		SetKeySelectionText(_this.Get(),InKeySelectionText);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSelectedKey(IntPtr _this,ref FInputChord InSelectedKey);
	public  void SetSelectedKey(FInputChord InSelectedKey)
	{
		CheckIsValid();
		SetSelectedKey(_this.Get(),ref InSelectedKey);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
