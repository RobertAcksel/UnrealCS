//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMaterialBillboardComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void AddElement(IntPtr _this,IntPtr Material,IntPtr DistanceToOpacityCurve,int bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,IntPtr DistanceToSizeCurve);
	public  void AddElement(UMaterialInterface Material,UCurveFloat DistanceToOpacityCurve,bool bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UCurveFloat DistanceToSizeCurve)
	{
		CheckIsValid();
		AddElement(_this.Get(),Material,DistanceToOpacityCurve,bSizeIsInScreenSpace?1:0,BaseSizeX,BaseSizeY,DistanceToSizeCurve);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetElements(IntPtr _this,FMaterialSpriteElement[] NewElements);
	public  void SetElements(FMaterialSpriteElement[] NewElements)
	{
		CheckIsValid();
		SetElements(_this.Get(),NewElements);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
