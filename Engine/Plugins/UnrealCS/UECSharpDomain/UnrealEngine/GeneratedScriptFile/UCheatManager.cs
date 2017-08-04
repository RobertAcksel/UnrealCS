//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheatManager:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void CheatScript(IntPtr _this,string ScriptName);
public  void CheatScript(string ScriptName)
{
	CheckIsValid();
	CheatScript(_this.Get(),ScriptName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvertMouse(IntPtr _this);
public  void InvertMouse()
{
	CheckIsValid();
	InvertMouse(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMouseSensitivityToDefault(IntPtr _this);
public  void SetMouseSensitivityToDefault()
{
	CheckIsValid();
	SetMouseSensitivityToDefault(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetWorldOrigin(IntPtr _this);
public  void SetWorldOrigin()
{
	CheckIsValid();
	SetWorldOrigin(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LogLoc(IntPtr _this);
public  void LogLoc()
{
	CheckIsValid();
	LogLoc(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FlushLog(IntPtr _this);
public  void FlushLog()
{
	CheckIsValid();
	FlushLog(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugItStringCreator(IntPtr _this,ref FVector ViewLocation,ref FRotator ViewRotation,out string GoString,out string LocString);
public  void BugItStringCreator(FVector ViewLocation,FRotator ViewRotation,out string GoString,out string LocString)
{
	CheckIsValid();
	BugItStringCreator(_this.Get(),ref ViewLocation,ref ViewRotation,out GoString,out LocString);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugIt(IntPtr _this,string ScreenShotDescription);
public  void BugIt(string ScreenShotDescription)
{
	CheckIsValid();
	BugIt(_this.Get(),ScreenShotDescription);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BugItGo(IntPtr _this,float X,float Y,float Z,float Pitch,float Yaw,float Roll);
public  void BugItGo(float X,float Y,float Z,float Pitch,float Yaw,float Roll)
{
	CheckIsValid();
	BugItGo(_this.Get(),X,Y,Z,Pitch,Yaw,Roll);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpVoiceMutingState(IntPtr _this);
public  void DumpVoiceMutingState()
{
	CheckIsValid();
	DumpVoiceMutingState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpChatState(IntPtr _this);
public  void DumpChatState()
{
	CheckIsValid();
	DumpChatState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpPartyState(IntPtr _this);
public  void DumpPartyState()
{
	CheckIsValid();
	DumpPartyState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DumpOnlineSessionState(IntPtr _this);
public  void DumpOnlineSessionState()
{
	CheckIsValid();
	DumpOnlineSessionState(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetNavDrawDistance(IntPtr _this,float DrawDistance);
public  void SetNavDrawDistance(float DrawDistance)
{
	CheckIsValid();
	SetNavDrawDistance(_this.Get(),DrawDistance);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RebuildNavigation(IntPtr _this);
public  void RebuildNavigation()
{
	CheckIsValid();
	RebuildNavigation(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TestCollisionDistance(IntPtr _this);
public  void TestCollisionDistance()
{
	CheckIsValid();
	TestCollisionDistance(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepClear(IntPtr _this);
public  void DebugCapsuleSweepClear()
{
	CheckIsValid();
	DebugCapsuleSweepClear(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepPawn(IntPtr _this);
public  void DebugCapsuleSweepPawn()
{
	CheckIsValid();
	DebugCapsuleSweepPawn(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepCapture(IntPtr _this);
public  void DebugCapsuleSweepCapture()
{
	CheckIsValid();
	DebugCapsuleSweepCapture(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepComplex(IntPtr _this,int bTraceComplex);
public  void DebugCapsuleSweepComplex(bool bTraceComplex)
{
	CheckIsValid();
	DebugCapsuleSweepComplex(_this.Get(),bTraceComplex?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepChannel(IntPtr _this,int Channel);
public  void DebugCapsuleSweepChannel(ECollisionChannel Channel)
{
	CheckIsValid();
	DebugCapsuleSweepChannel(_this.Get(),(int)Channel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweepSize(IntPtr _this,float HalfHeight,float Radius);
public  void DebugCapsuleSweepSize(float HalfHeight,float Radius)
{
	CheckIsValid();
	DebugCapsuleSweepSize(_this.Get(),HalfHeight,Radius);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DebugCapsuleSweep(IntPtr _this);
public  void DebugCapsuleSweep()
{
	CheckIsValid();
	DebugCapsuleSweep(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ServerToggleAILogging(IntPtr _this);
public  void ServerToggleAILogging()
{
	CheckIsValid();
	ServerToggleAILogging(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleAILogging(IntPtr _this);
public  void ToggleAILogging()
{
	CheckIsValid();
	ToggleAILogging(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ToggleDebugCamera(IntPtr _this);
public  void ToggleDebugCamera()
{
	CheckIsValid();
	ToggleDebugCamera(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StreamLevelOut(IntPtr _this,string PackageName);
public  void StreamLevelOut(string PackageName)
{
	CheckIsValid();
	StreamLevelOut(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnlyLoadLevel(IntPtr _this,string PackageName);
public  void OnlyLoadLevel(string PackageName)
{
	CheckIsValid();
	OnlyLoadLevel(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void StreamLevelIn(IntPtr _this,string PackageName);
public  void StreamLevelIn(string PackageName)
{
	CheckIsValid();
	StreamLevelIn(_this.Get(),PackageName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewClass(IntPtr _this,IntPtr DesiredClass);
public  void ViewClass(TSubclassOf<AActor>  DesiredClass)
{
	CheckIsValid();
	ViewClass(_this.Get(),DesiredClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewActor(IntPtr _this,string ActorName);
public  void ViewActor(string ActorName)
{
	CheckIsValid();
	ViewActor(_this.Get(),ActorName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewPlayer(IntPtr _this,string S);
public  void ViewPlayer(string S)
{
	CheckIsValid();
	ViewPlayer(_this.Get(),S);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ViewSelf(IntPtr _this);
public  void ViewSelf()
{
	CheckIsValid();
	ViewSelf(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void PlayersOnly(IntPtr _this);
public  void PlayersOnly()
{
	CheckIsValid();
	PlayersOnly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Summon(IntPtr _this,string ClassName);
public  void Summon(string ClassName)
{
	CheckIsValid();
	Summon(_this.Get(),ClassName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyPawns(IntPtr _this,IntPtr aClass);
public  void DestroyPawns(TSubclassOf<APawn>  aClass)
{
	CheckIsValid();
	DestroyPawns(_this.Get(),aClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyAllPawnsExceptTarget(IntPtr _this);
public  void DestroyAllPawnsExceptTarget()
{
	CheckIsValid();
	DestroyAllPawnsExceptTarget(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyAll(IntPtr _this,IntPtr aClass);
public  void DestroyAll(TSubclassOf<AActor>  aClass)
{
	CheckIsValid();
	DestroyAll(_this.Get(),aClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DestroyTarget(IntPtr _this);
public  void DestroyTarget()
{
	CheckIsValid();
	DestroyTarget(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DamageTarget(IntPtr _this,float DamageAmount);
public  void DamageTarget(float DamageAmount)
{
	CheckIsValid();
	DamageTarget(_this.Get(),DamageAmount);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Slomo(IntPtr _this,float NewTimeDilation);
public  void Slomo(float NewTimeDilation)
{
	CheckIsValid();
	Slomo(_this.Get(),NewTimeDilation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void God(IntPtr _this);
public  void God()
{
	CheckIsValid();
	God(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Ghost(IntPtr _this);
public  void Ghost()
{
	CheckIsValid();
	Ghost(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Walk(IntPtr _this);
public  void Walk()
{
	CheckIsValid();
	Walk(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Fly(IntPtr _this);
public  void Fly()
{
	CheckIsValid();
	Fly(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ChangeSize(IntPtr _this,float F);
public  void ChangeSize(float F)
{
	CheckIsValid();
	ChangeSize(_this.Get(),F);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Teleport(IntPtr _this);
public  void Teleport()
{
	CheckIsValid();
	Teleport(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void FreezeFrame(IntPtr _this,float Delay);
public  void FreezeFrame(float Delay)
{
	CheckIsValid();
	FreezeFrame(_this.Get(),Delay);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
