//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMeshComponent:UPrimitiveComponent 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVectorParameterValueOnMaterials(IntPtr _this,string ParameterName,ref FVector ParameterValue);
	
	/// <summary>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
	public  void SetVectorParameterValueOnMaterials(string ParameterName,FVector ParameterValue)
	{
		CheckIsValid();
		SetVectorParameterValueOnMaterials(_this.Get(),ParameterName,ref ParameterValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetScalarParameterValueOnMaterials(IntPtr _this,string ParameterName,float ParameterValue);
	
	/// <summary>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
	public  void SetScalarParameterValueOnMaterials(string ParameterName,float ParameterValue)
	{
		CheckIsValid();
		SetScalarParameterValueOnMaterials(_this.Get(),ParameterName,ParameterValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsMaterialSlotNameValid(IntPtr _this,string MaterialSlotName);
	
	public  bool IsMaterialSlotNameValid(string MaterialSlotName)
	{
		CheckIsValid();
		int ___ret = IsMaterialSlotNameValid(_this.Get(),MaterialSlotName);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FName[] GetMaterialSlotNames(IntPtr _this);
	
	public  FName[] GetMaterialSlotNames()
	{
		CheckIsValid();
		FName[] ___ret = GetMaterialSlotNames(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMaterialIndex(IntPtr _this,string MaterialSlotName);
	
	public  int GetMaterialIndex(string MaterialSlotName)
	{
		CheckIsValid();
		int ___ret = GetMaterialIndex(_this.Get(),MaterialSlotName);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr[] GetMaterials(IntPtr _this);
	
	public  UMaterialInterface[] GetMaterials()
	{
		CheckIsValid();
		IntPtr[] ___ret = GetMaterials(_this.Get());
		return MarshalUtil.IntPtrArrayToObjectArray<UMaterialInterface>(___ret);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
