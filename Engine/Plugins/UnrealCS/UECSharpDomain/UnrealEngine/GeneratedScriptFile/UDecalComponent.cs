//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UDecalComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr CreateDynamicMaterialInstance(IntPtr _this);
	public  UMaterialInstanceDynamic CreateDynamicMaterialInstance()
	{
		CheckIsValid();
		IntPtr ___ret = CreateDynamicMaterialInstance(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetDecalMaterial(IntPtr _this);
	public  UMaterialInterface GetDecalMaterial()
	{
		CheckIsValid();
		IntPtr ___ret = GetDecalMaterial(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetDecalMaterial(IntPtr _this,IntPtr NewDecalMaterial);
	public  void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
	{
		CheckIsValid();
		SetDecalMaterial(_this.Get(),NewDecalMaterial);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetSortOrder(IntPtr _this,int Value);
	public  void SetSortOrder(int Value)
	{
		CheckIsValid();
		SetSortOrder(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFadeOut(IntPtr _this,float StartDelay,float Duration,int DestroyOwnerAfterFade);
	public  void SetFadeOut(float StartDelay,float Duration,bool DestroyOwnerAfterFade=true)
	{
		CheckIsValid();
		SetFadeOut(_this.Get(),StartDelay,Duration,DestroyOwnerAfterFade?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetFadeDuration(IntPtr _this);
	public  float GetFadeDuration()
	{
		CheckIsValid();
		float ___ret = GetFadeDuration(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetFadeStartDelay(IntPtr _this);
	public  float GetFadeStartDelay()
	{
		CheckIsValid();
		float ___ret = GetFadeStartDelay(_this.Get());
		return ___ret;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
