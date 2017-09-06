//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMultiLineEditableText:UTextLayoutWidget 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsReadOnly(IntPtr _this,int bReadOnly);
	
	public  void SetIsReadOnly(bool bReadOnly)
	{
		CheckIsValid();
		SetIsReadOnly(_this.Get(),bReadOnly?1:0);
		
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
