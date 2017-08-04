//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UActorComponent:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
	public  void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckIsValid();
		RemoveTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
	public  void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckIsValid();
		RemoveTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddTickPrerequisiteComponent(IntPtr _this,IntPtr PrerequisiteComponent);
	public  void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckIsValid();
		AddTickPrerequisiteComponent(_this.Get(),PrerequisiteComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddTickPrerequisiteActor(IntPtr _this,IntPtr PrerequisiteActor);
	public  void AddTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckIsValid();
		AddTickPrerequisiteActor(_this.Get(),PrerequisiteActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTickGroup(IntPtr _this,int NewTickGroup);
	public  void SetTickGroup(ETickingGroup NewTickGroup)
	{
		CheckIsValid();
		SetTickGroup(_this.Get(),(int)NewTickGroup);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void K2_DestroyComponent(IntPtr _this,IntPtr Object);
	public  void K2_DestroyComponent(UObject Object)
	{
		CheckIsValid();
		K2_DestroyComponent(_this.Get(),Object);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetComponentTickInterval(IntPtr _this);
	public  float GetComponentTickInterval()
	{
		CheckIsValid();
		float ___ret = GetComponentTickInterval(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetComponentTickInterval(IntPtr _this,float TickInterval);
	public  void SetComponentTickInterval(float TickInterval)
	{
		CheckIsValid();
		SetComponentTickInterval(_this.Get(),TickInterval);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsComponentTickEnabled(IntPtr _this);
	public  bool IsComponentTickEnabled()
	{
		CheckIsValid();
		int ___ret = IsComponentTickEnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetComponentTickEnabled(IntPtr _this,int bEnabled);
	public  void SetComponentTickEnabled(bool bEnabled)
	{
		CheckIsValid();
		SetComponentTickEnabled(_this.Get(),bEnabled?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetIsReplicated(IntPtr _this,int ShouldReplicate);
	public  void SetIsReplicated(bool ShouldReplicate)
	{
		CheckIsValid();
		SetIsReplicated(_this.Get(),ShouldReplicate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTickableWhenPaused(IntPtr _this,int bTickableWhenPaused);
	public  void SetTickableWhenPaused(bool bTickableWhenPaused)
	{
		CheckIsValid();
		SetTickableWhenPaused(_this.Get(),bTickableWhenPaused?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAutoActivate(IntPtr _this,int bNewAutoActivate);
	public  void SetAutoActivate(bool bNewAutoActivate)
	{
		CheckIsValid();
		SetAutoActivate(_this.Get(),bNewAutoActivate?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsActive(IntPtr _this);
	public  bool IsActive()
	{
		CheckIsValid();
		int ___ret = IsActive(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ToggleActive(IntPtr _this);
	public  void ToggleActive()
	{
		CheckIsValid();
		ToggleActive(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetActive(IntPtr _this,int bNewActive,int bReset);
	public  void SetActive(bool bNewActive,bool bReset=false)
	{
		CheckIsValid();
		SetActive(_this.Get(),bNewActive?1:0,bReset?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Deactivate(IntPtr _this);
	public  void Deactivate()
	{
		CheckIsValid();
		Deactivate(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void Activate(IntPtr _this,int bReset);
	public  void Activate(bool bReset=false)
	{
		CheckIsValid();
		Activate(_this.Get(),bReset?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ComponentHasTag(IntPtr _this,string Tag);
	public  bool ComponentHasTag(string Tag)
	{
		CheckIsValid();
		int ___ret = ComponentHasTag(_this.Get(),Tag);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetOwner(IntPtr _this);
	public  AActor GetOwner()
	{
		CheckIsValid();
		IntPtr ___ret = GetOwner(_this.Get());
		if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void OnRep_IsActive(IntPtr _this);
	public  void OnRep_IsActive()
	{
		CheckIsValid();
		OnRep_IsActive(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsBeingDestroyed(IntPtr _this);
	public  bool IsBeingDestroyed()
	{
		CheckIsValid();
		int ___ret = IsBeingDestroyed(_this.Get());
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
