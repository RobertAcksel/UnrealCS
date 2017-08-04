//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlayerInput:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearSmoothing(IntPtr _this);
	public  void ClearSmoothing()
	{
		CheckIsValid();
		ClearSmoothing(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void InvertAxis(IntPtr _this,string AxisName);
	public  void InvertAxis(string AxisName)
	{
		CheckIsValid();
		InvertAxis(_this.Get(),AxisName);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void InvertAxisKey(IntPtr _this,ref FKey AxisKey);
	public  void InvertAxisKey(FKey AxisKey)
	{
		CheckIsValid();
		InvertAxisKey(_this.Get(),ref AxisKey);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBind(IntPtr _this,string BindName,string Command);
	public  void SetBind(string BindName,string Command)
	{
		CheckIsValid();
		SetBind(_this.Get(),BindName,Command);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetMouseSensitivity(IntPtr _this,float Sensitivity);
	public  void SetMouseSensitivity(float Sensitivity)
	{
		CheckIsValid();
		SetMouseSensitivity(_this.Get(),Sensitivity);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
