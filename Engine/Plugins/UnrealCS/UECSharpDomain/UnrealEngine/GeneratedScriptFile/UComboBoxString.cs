//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UComboBoxString:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetOptionCount(IntPtr _this);
	public  int GetOptionCount()
	{
		CheckIsValid();
		int ___ret = GetOptionCount(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetSelectedOption(IntPtr _this);
	public  string GetSelectedOption()
	{
		CheckIsValid();
		string ___ret = GetSelectedOption(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSelectedOption(IntPtr _this,string Option);
	public  void SetSelectedOption(string Option)
	{
		CheckIsValid();
		SetSelectedOption(_this.Get(),Option);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RefreshOptions(IntPtr _this);
	public  void RefreshOptions()
	{
		CheckIsValid();
		RefreshOptions(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSelection(IntPtr _this);
	public  void ClearSelection()
	{
		CheckIsValid();
		ClearSelection(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearOptions(IntPtr _this);
	public  void ClearOptions()
	{
		CheckIsValid();
		ClearOptions(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetOptionAtIndex(IntPtr _this,int Index);
	public  string GetOptionAtIndex(int Index)
	{
		CheckIsValid();
		string ___ret = GetOptionAtIndex(_this.Get(),Index);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FindOptionIndex(IntPtr _this,string Option);
	public  int FindOptionIndex(string Option)
	{
		CheckIsValid();
		int ___ret = FindOptionIndex(_this.Get(),Option);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RemoveOption(IntPtr _this,string Option);
	public  bool RemoveOption(string Option)
	{
		CheckIsValid();
		int ___ret = RemoveOption(_this.Get(),Option);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddOption(IntPtr _this,string Option);
	public  void AddOption(string Option)
	{
		CheckIsValid();
		AddOption(_this.Get(),Option);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
