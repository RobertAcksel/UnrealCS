//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USceneCaptureComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCaptureSortPriority(IntPtr _this,int NewCaptureSortPriority);
	public  void SetCaptureSortPriority(int NewCaptureSortPriority)
	{
		CheckIsValid();
		SetCaptureSortPriority(_this.Get(),NewCaptureSortPriority);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearShowOnlyComponents(IntPtr _this,IntPtr InComponent);
	public  void ClearShowOnlyComponents(UPrimitiveComponent InComponent)
	{
		CheckIsValid();
		ClearShowOnlyComponents(_this.Get(),InComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveShowOnlyActorComponents(IntPtr _this,IntPtr InActor);
	public  void RemoveShowOnlyActorComponents(AActor InActor)
	{
		CheckIsValid();
		RemoveShowOnlyActorComponents(_this.Get(),InActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RemoveShowOnlyComponent(IntPtr _this,IntPtr InComponent);
	public  void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
	{
		CheckIsValid();
		RemoveShowOnlyComponent(_this.Get(),InComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowOnlyActorComponents(IntPtr _this,IntPtr InActor);
	public  void ShowOnlyActorComponents(AActor InActor)
	{
		CheckIsValid();
		ShowOnlyActorComponents(_this.Get(),InActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ShowOnlyComponent(IntPtr _this,IntPtr InComponent);
	public  void ShowOnlyComponent(UPrimitiveComponent InComponent)
	{
		CheckIsValid();
		ShowOnlyComponent(_this.Get(),InComponent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void HideActorComponents(IntPtr _this,IntPtr InActor);
	public  void HideActorComponents(AActor InActor)
	{
		CheckIsValid();
		HideActorComponents(_this.Get(),InActor);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void HideComponent(IntPtr _this,IntPtr InComponent);
	public  void HideComponent(UPrimitiveComponent InComponent)
	{
		CheckIsValid();
		HideComponent(_this.Get(),InComponent);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
