//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCircularThrobber:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRadius(IntPtr _this,float InRadius);
	public  void SetRadius(float InRadius)
	{
		CheckIsValid();
		SetRadius(_this.Get(),InRadius);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPeriod(IntPtr _this,float InPeriod);
	public  void SetPeriod(float InPeriod)
	{
		CheckIsValid();
		SetPeriod(_this.Get(),InPeriod);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetNumberOfPieces(IntPtr _this,int InNumberOfPieces);
	public  void SetNumberOfPieces(int InNumberOfPieces)
	{
		CheckIsValid();
		SetNumberOfPieces(_this.Get(),InNumberOfPieces);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
