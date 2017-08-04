//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkeletalMesh:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsSectionUsingCloth(IntPtr _this,int InSectionIndex,int bCheckCorrespondingSections);
	public  bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections=true)
	{
		CheckIsValid();
		int ___ret = IsSectionUsingCloth(_this.Get(),InSectionIndex,bCheckCorrespondingSections?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetSocketByIndex(IntPtr _this,int Index);
	public  USkeletalMeshSocket GetSocketByIndex(int Index)
	{
		CheckIsValid();
		IntPtr ___ret = GetSocketByIndex(_this.Get(),Index);
		if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NumSockets(IntPtr _this);
	public  int NumSockets()
	{
		CheckIsValid();
		int ___ret = NumSockets(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr FindSocketAndIndex(IntPtr _this,string InSocketName,out int OutIndex);
	public  USkeletalMeshSocket FindSocketAndIndex(string InSocketName,out int OutIndex)
	{
		CheckIsValid();
		IntPtr ___ret = FindSocketAndIndex(_this.Get(),InSocketName,out OutIndex);
		if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr FindSocket(IntPtr _this,string InSocketName);
	public  USkeletalMeshSocket FindSocket(string InSocketName)
	{
		CheckIsValid();
		IntPtr ___ret = FindSocket(_this.Get(),InSocketName);
		if(___ret==IntPtr.Zero) return null; USkeletalMeshSocket ___ret2= new USkeletalMeshSocket(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetNodeMappingContainer(IntPtr _this,IntPtr SourceAsset);
	public  UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset)
	{
		CheckIsValid();
		IntPtr ___ret = GetNodeMappingContainer(_this.Get(),SourceAsset);
		if(___ret==IntPtr.Zero) return null; UNodeMappingContainer ___ret2= new UNodeMappingContainer(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBoxSphereBounds GetImportedBounds(IntPtr _this);
	public  FBoxSphereBounds GetImportedBounds()
	{
		CheckIsValid();
		FBoxSphereBounds ___ret = GetImportedBounds(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBoxSphereBounds GetBounds(IntPtr _this);
	public  FBoxSphereBounds GetBounds()
	{
		CheckIsValid();
		FBoxSphereBounds ___ret = GetBounds(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
