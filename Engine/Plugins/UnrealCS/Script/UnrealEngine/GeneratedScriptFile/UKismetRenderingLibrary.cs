//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetRenderingLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakSkinWeightInfo(IntPtr _this,ref FSkelMeshSkinWeightInfo InWeight,out int Bone0,out int Weight0,out int Bone1,out int Weight1,out int Bone2,out int Weight2,out int Bone3,out int Weight3);
public static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight,out int Bone0,out byte Weight0,out int Bone1,out byte Weight1,out int Bone2,out byte Weight2,out int Bone3,out byte Weight3)
{
	int Weight0_temp;
	int Weight1_temp;
	int Weight2_temp;
	int Weight3_temp;
	BreakSkinWeightInfo(IntPtr.Zero,ref InWeight,out Bone0,out Weight0_temp,out Bone1,out Weight1_temp,out Bone2,out Weight2_temp,out Bone3,out Weight3_temp);
	Weight0=(byte)Weight0_temp;
	Weight1=(byte)Weight1_temp;
	Weight2=(byte)Weight2_temp;
	Weight3=(byte)Weight3_temp;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(IntPtr _this,int Bone0,int Weight0,int Bone1,int Weight1,int Bone2,int Weight2,int Bone3,int Weight3);
public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0,byte Weight0,int Bone1,byte Weight1,int Bone2,byte Weight2,int Bone3,byte Weight3)
{
	FSkelMeshSkinWeightInfo ___ret = MakeSkinWeightInfo(IntPtr.Zero,Bone0,Weight0,Bone1,Weight1,Bone2,Weight2,Bone3,Weight3);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EndDrawCanvasToRenderTarget(IntPtr _this,IntPtr WorldContextObject,ref FDrawToRenderTargetContext Context);
public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject,FDrawToRenderTargetContext Context)
{
	EndDrawCanvasToRenderTarget(IntPtr.Zero,WorldContextObject,ref Context);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BeginDrawCanvasToRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,out IntPtr Canvas,out FVector2D Size,out FDrawToRenderTargetContext Context);
public static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,out UCanvas Canvas,out FVector2D Size,out FDrawToRenderTargetContext Context)
{
	IntPtr Canvas_temp;
	BeginDrawCanvasToRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,out Canvas_temp,out Size,out Context);
	Canvas=new UCanvas(){ _this=Canvas_temp};
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ExportTexture2D(IntPtr _this,IntPtr WorldContextObject,IntPtr Texture,string FilePath,string FileName);
public static void ExportTexture2D(UObject WorldContextObject,UTexture2D Texture,string FilePath,string FileName)
{
	ExportTexture2D(IntPtr.Zero,WorldContextObject,Texture,FilePath,FileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ExportRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,string FilePath,string FileName);
public static void ExportRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,string FilePath,string FileName)
{
	ExportRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,FilePath,FileName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ConvertRenderTargetToTexture2DEditorOnly(IntPtr _this,IntPtr WorldContextObject,IntPtr RenderTarget,IntPtr Texture);
public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject,UTextureRenderTarget2D RenderTarget,UTexture2D Texture)
{
	ConvertRenderTargetToTexture2DEditorOnly(IntPtr.Zero,WorldContextObject,RenderTarget,Texture);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialToRenderTarget(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,IntPtr Material);
public static void DrawMaterialToRenderTarget(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,UMaterialInterface Material)
{
	DrawMaterialToRenderTarget(IntPtr.Zero,WorldContextObject,TextureRenderTarget,Material);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,int Width,int Height);
public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject,int Width=256,int Height=256)
{
	IntPtr ___ret = CreateRenderTarget2D(IntPtr.Zero,WorldContextObject,Width,Height);
	if(___ret==IntPtr.Zero) return null; UTextureRenderTarget2D ___ret2= new UTextureRenderTarget2D(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearRenderTarget2D(IntPtr _this,IntPtr WorldContextObject,IntPtr TextureRenderTarget,ref FLinearColor ClearColor);
public static void ClearRenderTarget2D(UObject WorldContextObject,UTextureRenderTarget2D TextureRenderTarget,FLinearColor ClearColor=default(FLinearColor))
{
	ClearRenderTarget2D(IntPtr.Zero,WorldContextObject,TextureRenderTarget,ref ClearColor);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
