//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class URetainerBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTextureParameter(IntPtr _this,string TextureParameter);
	public  void SetTextureParameter(string TextureParameter)
	{
		CheckIsValid();
		SetTextureParameter(_this.Get(),TextureParameter);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetEffectMaterial(IntPtr _this,IntPtr EffectMaterial);
	public  void SetEffectMaterial(UMaterialInterface EffectMaterial)
	{
		CheckIsValid();
		SetEffectMaterial(_this.Get(),EffectMaterial);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetEffectMaterial(IntPtr _this);
	public  UMaterialInstanceDynamic GetEffectMaterial()
	{
		CheckIsValid();
		IntPtr ___ret = GetEffectMaterial(_this.Get());
		if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
