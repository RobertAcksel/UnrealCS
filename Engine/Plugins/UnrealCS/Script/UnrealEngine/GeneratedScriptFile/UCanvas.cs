//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCanvas:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D K2_TextSize(IntPtr _this,IntPtr RenderFont,string RenderText,ref FVector2D Scale);
public  FVector2D K2_TextSize(UFont RenderFont,string RenderText,FVector2D Scale=default(FVector2D))
{
	CheckIsValid();
	FVector2D ___ret = K2_TextSize(_this.Get(),RenderFont,RenderText,ref Scale);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector2D K2_StrLen(IntPtr _this,IntPtr RenderFont,string RenderText);
public  FVector2D K2_StrLen(UFont RenderFont,string RenderText)
{
	CheckIsValid();
	FVector2D ___ret = K2_StrLen(_this.Get(),RenderFont,RenderText);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_Deproject(IntPtr _this,ref FVector2D ScreenPosition,out FVector WorldOrigin,out FVector WorldDirection);
public  void K2_Deproject(FVector2D ScreenPosition,out FVector WorldOrigin,out FVector WorldDirection)
{
	CheckIsValid();
	K2_Deproject(_this.Get(),ref ScreenPosition,out WorldOrigin,out WorldDirection);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector K2_Project(IntPtr _this,ref FVector WorldLocation);
public  FVector K2_Project(FVector WorldLocation)
{
	CheckIsValid();
	FVector ___ret = K2_Project(_this.Get(),ref WorldLocation);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawPolygon(IntPtr _this,IntPtr RenderTexture,ref FVector2D ScreenPosition,ref FVector2D Radius,int NumberOfSides,ref FLinearColor RenderColor);
public  void K2_DrawPolygon(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D Radius=default(FVector2D),int NumberOfSides=3,FLinearColor RenderColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawPolygon(_this.Get(),RenderTexture,ref ScreenPosition,ref Radius,NumberOfSides,ref RenderColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawMaterialTriangle(IntPtr _this,IntPtr RenderMaterial,FCanvasUVTri[] Triangles);
public  void K2_DrawMaterialTriangle(UMaterialInterface RenderMaterial,FCanvasUVTri[] Triangles)
{
	CheckIsValid();
	K2_DrawMaterialTriangle(_this.Get(),RenderMaterial,Triangles);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawTriangle(IntPtr _this,IntPtr RenderTexture,FCanvasUVTri[] Triangles);
public  void K2_DrawTriangle(UTexture RenderTexture,FCanvasUVTri[] Triangles)
{
	CheckIsValid();
	K2_DrawTriangle(_this.Get(),RenderTexture,Triangles);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawBox(IntPtr _this,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,float Thickness);
public  void K2_DrawBox(FVector2D ScreenPosition,FVector2D ScreenSize,float Thickness=1.000000f)
{
	CheckIsValid();
	K2_DrawBox(_this.Get(),ref ScreenPosition,ref ScreenSize,Thickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawBorder(IntPtr _this,IntPtr BorderTexture,IntPtr BackgroundTexture,IntPtr LeftBorderTexture,IntPtr RightBorderTexture,IntPtr TopBorderTexture,IntPtr BottomBorderTexture,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,ref FLinearColor RenderColor,ref FVector2D BorderScale,ref FVector2D BackgroundScale,float Rotation,ref FVector2D PivotPoint,ref FVector2D CornerSize);
public  void K2_DrawBorder(UTexture BorderTexture,UTexture BackgroundTexture,UTexture LeftBorderTexture,UTexture RightBorderTexture,UTexture TopBorderTexture,UTexture BottomBorderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),FVector2D BorderScale=default(FVector2D),FVector2D BackgroundScale=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D),FVector2D CornerSize=default(FVector2D))
{
	CheckIsValid();
	K2_DrawBorder(_this.Get(),BorderTexture,BackgroundTexture,LeftBorderTexture,RightBorderTexture,TopBorderTexture,BottomBorderTexture,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,ref RenderColor,ref BorderScale,ref BackgroundScale,Rotation,ref PivotPoint,ref CornerSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawText(IntPtr _this,IntPtr RenderFont,string RenderText,ref FVector2D ScreenPosition,ref FLinearColor RenderColor,float Kerning,ref FLinearColor ShadowColor,ref FVector2D ShadowOffset,int bCentreX,int bCentreY,int bOutlined,ref FLinearColor OutlineColor);
public  void K2_DrawText(UFont RenderFont,string RenderText,FVector2D ScreenPosition,FLinearColor RenderColor=default(FLinearColor),float Kerning=0.000000f,FLinearColor ShadowColor=default(FLinearColor),FVector2D ShadowOffset=default(FVector2D),bool bCentreX=false,bool bCentreY=false,bool bOutlined=false,FLinearColor OutlineColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawText(_this.Get(),RenderFont,RenderText,ref ScreenPosition,ref RenderColor,Kerning,ref ShadowColor,ref ShadowOffset,bCentreX?1:0,bCentreY?1:0,bOutlined?1:0,ref OutlineColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawMaterial(IntPtr _this,IntPtr RenderMaterial,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,float Rotation,ref FVector2D PivotPoint);
public  void K2_DrawMaterial(UMaterialInterface RenderMaterial,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D))
{
	CheckIsValid();
	K2_DrawMaterial(_this.Get(),RenderMaterial,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,Rotation,ref PivotPoint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawTexture(IntPtr _this,IntPtr RenderTexture,ref FVector2D ScreenPosition,ref FVector2D ScreenSize,ref FVector2D CoordinatePosition,ref FVector2D CoordinateSize,ref FLinearColor RenderColor,int BlendMode,float Rotation,ref FVector2D PivotPoint);
public  void K2_DrawTexture(UTexture RenderTexture,FVector2D ScreenPosition,FVector2D ScreenSize,FVector2D CoordinatePosition,FVector2D CoordinateSize=default(FVector2D),FLinearColor RenderColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Rotation=0.000000f,FVector2D PivotPoint=default(FVector2D))
{
	CheckIsValid();
	K2_DrawTexture(_this.Get(),RenderTexture,ref ScreenPosition,ref ScreenSize,ref CoordinatePosition,ref CoordinateSize,ref RenderColor,(int)BlendMode,Rotation,ref PivotPoint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void K2_DrawLine(IntPtr _this,ref FVector2D ScreenPositionA,ref FVector2D ScreenPositionB,float Thickness,ref FLinearColor RenderColor);
public  void K2_DrawLine(FVector2D ScreenPositionA,FVector2D ScreenPositionB,float Thickness=1.000000f,FLinearColor RenderColor=default(FLinearColor))
{
	CheckIsValid();
	K2_DrawLine(_this.Get(),ref ScreenPositionA,ref ScreenPositionB,Thickness,ref RenderColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
