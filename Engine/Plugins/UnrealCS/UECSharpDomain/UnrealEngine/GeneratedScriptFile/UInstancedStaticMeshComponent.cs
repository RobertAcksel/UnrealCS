//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInstancedStaticMeshComponent:UStaticMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int[] GetInstancesOverlappingBox(IntPtr _this,ref FBox Box,int bBoxInWorldSpace);
	public  int[] GetInstancesOverlappingBox(FBox Box,bool bBoxInWorldSpace=true)
	{
		CheckIsValid();
		int[] ___ret = GetInstancesOverlappingBox(_this.Get(),ref Box,bBoxInWorldSpace?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int[] GetInstancesOverlappingSphere(IntPtr _this,ref FVector Center,float Radius,int bSphereInWorldSpace);
	public  int[] GetInstancesOverlappingSphere(FVector Center,float Radius,bool bSphereInWorldSpace=true)
	{
		CheckIsValid();
		int[] ___ret = GetInstancesOverlappingSphere(_this.Get(),ref Center,Radius,bSphereInWorldSpace?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetCullDistances(IntPtr _this,int StartCullDistance,int EndCullDistance);
	public  void SetCullDistances(int StartCullDistance,int EndCullDistance)
	{
		CheckIsValid();
		SetCullDistances(_this.Get(),StartCullDistance,EndCullDistance);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetInstanceCount(IntPtr _this);
	public  int GetInstanceCount()
	{
		CheckIsValid();
		int ___ret = GetInstanceCount(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearInstances(IntPtr _this);
	public  void ClearInstances()
	{
		CheckIsValid();
		ClearInstances(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RemoveInstance(IntPtr _this,int InstanceIndex);
	public  bool RemoveInstance(int InstanceIndex)
	{
		CheckIsValid();
		int ___ret = RemoveInstance(_this.Get(),InstanceIndex);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int UpdateInstanceTransform(IntPtr _this,int InstanceIndex,ref FTransform NewInstanceTransform,int bWorldSpace,int bMarkRenderStateDirty,int bTeleport);
	public  bool UpdateInstanceTransform(int InstanceIndex,FTransform NewInstanceTransform,bool bWorldSpace=false,bool bMarkRenderStateDirty=false,bool bTeleport=false)
	{
		CheckIsValid();
		int ___ret = UpdateInstanceTransform(_this.Get(),InstanceIndex,ref NewInstanceTransform,bWorldSpace?1:0,bMarkRenderStateDirty?1:0,bTeleport?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetInstanceTransform(IntPtr _this,int InstanceIndex,out FTransform OutInstanceTransform,int bWorldSpace);
	public  bool GetInstanceTransform(int InstanceIndex,out FTransform OutInstanceTransform,bool bWorldSpace=false)
	{
		CheckIsValid();
		int ___ret = GetInstanceTransform(_this.Get(),InstanceIndex,out OutInstanceTransform,bWorldSpace?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int AddInstanceWorldSpace(IntPtr _this,ref FTransform WorldTransform);
	public  int AddInstanceWorldSpace(FTransform WorldTransform)
	{
		CheckIsValid();
		int ___ret = AddInstanceWorldSpace(_this.Get(),ref WorldTransform);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int AddInstance(IntPtr _this,ref FTransform InstanceTransform);
	public  int AddInstance(FTransform InstanceTransform)
	{
		CheckIsValid();
		int ___ret = AddInstance(_this.Get(),ref InstanceTransform);
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
