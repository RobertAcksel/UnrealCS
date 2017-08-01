//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class ADefaultPawn:APawn 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LookUpAtRate(IntPtr _this,float Rate);
public  void LookUpAtRate(float Rate)
{
	CheckIsValid();
	LookUpAtRate(_this.Get(),Rate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TurnAtRate(IntPtr _this,float Rate);
public  void TurnAtRate(float Rate)
{
	CheckIsValid();
	TurnAtRate(_this.Get(),Rate);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveUp_World(IntPtr _this,float Val);
public  void MoveUp_World(float Val)
{
	CheckIsValid();
	MoveUp_World(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveRight(IntPtr _this,float Val);
public  void MoveRight(float Val)
{
	CheckIsValid();
	MoveRight(_this.Get(),Val);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void MoveForward(IntPtr _this,float Val);
public  void MoveForward(float Val)
{
	CheckIsValid();
	MoveForward(_this.Get(),Val);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
