//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlatformInterfaceWebResponse:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetHeaderValue(IntPtr _this,string HeaderName);
	public  string GetHeaderValue(string HeaderName)
	{
		CheckIsValid();
		string ___ret = GetHeaderValue(_this.Get(),HeaderName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetHeader(IntPtr _this,int HeaderIndex,out string Header,out string Value);
	public  void GetHeader(int HeaderIndex,out string Header,out string Value)
	{
		CheckIsValid();
		GetHeader(_this.Get(),HeaderIndex,out Header,out Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetNumHeaders(IntPtr _this);
	public  int GetNumHeaders()
	{
		CheckIsValid();
		int ___ret = GetNumHeaders(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
