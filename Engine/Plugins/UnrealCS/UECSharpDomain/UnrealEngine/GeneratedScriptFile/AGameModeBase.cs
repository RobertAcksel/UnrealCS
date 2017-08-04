//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AGameModeBase:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayerAtTransform(IntPtr _this,IntPtr NewPlayer,ref FTransform SpawnTransform);
public  void RestartPlayerAtTransform(AController NewPlayer,FTransform SpawnTransform)
{
	CheckIsValid();
	RestartPlayerAtTransform(_this.Get(),NewPlayer,ref SpawnTransform);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayerAtPlayerStart(IntPtr _this,IntPtr NewPlayer,IntPtr StartSpot);
public  void RestartPlayerAtPlayerStart(AController NewPlayer,AActor StartSpot)
{
	CheckIsValid();
	RestartPlayerAtPlayerStart(_this.Get(),NewPlayer,StartSpot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RestartPlayer(IntPtr _this,IntPtr NewPlayer);
public  void RestartPlayer(AController NewPlayer)
{
	CheckIsValid();
	RestartPlayer(_this.Get(),NewPlayer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr K2_FindPlayerStart(IntPtr _this,IntPtr Player,string IncomingName);
public  AActor K2_FindPlayerStart(AController Player,string IncomingName)
{
	CheckIsValid();
	IntPtr ___ret = K2_FindPlayerStart(_this.Get(),Player,IncomingName);
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangeName(IntPtr _this,IntPtr Controller,string NewName,int bNameChange);
public  void ChangeName(AController Controller,string NewName,bool bNameChange)
{
	CheckIsValid();
	ChangeName(_this.Get(),Controller,NewName,bNameChange?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ReturnToMainMenuHost(IntPtr _this);
public  void ReturnToMainMenuHost()
{
	CheckIsValid();
	ReturnToMainMenuHost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetLevel(IntPtr _this);
public  void ResetLevel()
{
	CheckIsValid();
	ResetLevel(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasMatchStarted(IntPtr _this);
public  bool HasMatchStarted()
{
	CheckIsValid();
	int ___ret = HasMatchStarted(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StartPlay(IntPtr _this);
public  void StartPlay()
{
	CheckIsValid();
	StartPlay(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumSpectators(IntPtr _this);
public  int GetNumSpectators()
{
	CheckIsValid();
	int ___ret = GetNumSpectators(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumPlayers(IntPtr _this);
public  int GetNumPlayers()
{
	CheckIsValid();
	int ___ret = GetNumPlayers(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
