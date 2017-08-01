//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AHUD:AActor 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddHitBox(IntPtr _this,ref FVector2D Position,ref FVector2D Size,string InName,int bConsumesInput,int Priority);
public  void AddHitBox(FVector2D Position,FVector2D Size,string InName,bool bConsumesInput,int Priority=0)
{
	CheckIsValid();
	AddHitBox(_this.Get(),ref Position,ref Size,InName,bConsumesInput?1:0,Priority);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetActorsInSelectionRectangle(IntPtr _this,IntPtr ClassFilter,ref FVector2D FirstPoint,ref FVector2D SecondPoint,out IntPtr[] OutActors,int bIncludeNonCollidingComponents,int bActorMustBeFullyEnclosed);
public  void GetActorsInSelectionRectangle(TSubclassOf<AActor>  ClassFilter,FVector2D FirstPoint,FVector2D SecondPoint,out AActor[] OutActors,bool bIncludeNonCollidingComponents=true,bool bActorMustBeFullyEnclosed=false)
{
	CheckIsValid();
	IntPtr[] OutActors_temp;
	GetActorsInSelectionRectangle(_this.Get(),ClassFilter.NativeClass,ref FirstPoint,ref SecondPoint,out OutActors_temp,bIncludeNonCollidingComponents?1:0,bActorMustBeFullyEnclosed?1:0);
	OutActors = MarshalUtil.IntPtrArrayToObjectArray<AActor>(OutActors_temp);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Deproject(IntPtr _this,float ScreenX,float ScreenY,out FVector WorldPosition,out FVector WorldDirection);
public  void Deproject(float ScreenX,float ScreenY,out FVector WorldPosition,out FVector WorldDirection)
{
	CheckIsValid();
	Deproject(_this.Get(),ScreenX,ScreenY,out WorldPosition,out WorldDirection);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FVector Project(IntPtr _this,ref FVector Location);
public  FVector Project(FVector Location)
{
	CheckIsValid();
	FVector ___ret = Project(_this.Get(),ref Location);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialTriangle(IntPtr _this,IntPtr Material,ref FVector2D V0_Pos,ref FVector2D V1_Pos,ref FVector2D V2_Pos,ref FVector2D V0_UV,ref FVector2D V1_UV,ref FVector2D V2_UV,ref FLinearColor V0_Color,ref FLinearColor V1_Color,ref FLinearColor V2_Color);
public  void DrawMaterialTriangle(UMaterialInterface Material,FVector2D V0_Pos,FVector2D V1_Pos,FVector2D V2_Pos,FVector2D V0_UV,FVector2D V1_UV,FVector2D V2_UV,FLinearColor V0_Color=default(FLinearColor),FLinearColor V1_Color=default(FLinearColor),FLinearColor V2_Color=default(FLinearColor))
{
	CheckIsValid();
	DrawMaterialTriangle(_this.Get(),Material,ref V0_Pos,ref V1_Pos,ref V2_Pos,ref V0_UV,ref V1_UV,ref V2_UV,ref V0_Color,ref V1_Color,ref V2_Color);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterialSimple(IntPtr _this,IntPtr Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale,int bScalePosition);
public  void DrawMaterialSimple(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawMaterialSimple(_this.Get(),Material,ScreenX,ScreenY,ScreenW,ScreenH,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawMaterial(IntPtr _this,IntPtr Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale,int bScalePosition,float Rotation,ref FVector2D RotPivot);
public  void DrawMaterial(UMaterialInterface Material,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float MaterialU,float MaterialV,float MaterialUWidth,float MaterialVHeight,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D))
{
	CheckIsValid();
	DrawMaterial(_this.Get(),Material,ScreenX,ScreenY,ScreenW,ScreenH,MaterialU,MaterialV,MaterialUWidth,MaterialVHeight,Scale,bScalePosition?1:0,Rotation,ref RotPivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTextureSimple(IntPtr _this,IntPtr Texture,float ScreenX,float ScreenY,float Scale,int bScalePosition);
public  void DrawTextureSimple(UTexture Texture,float ScreenX,float ScreenY,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawTextureSimple(_this.Get(),Texture,ScreenX,ScreenY,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawTexture(IntPtr _this,IntPtr Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,ref FLinearColor TintColor,int BlendMode,float Scale,int bScalePosition,float Rotation,ref FVector2D RotPivot);
public  void DrawTexture(UTexture Texture,float ScreenX,float ScreenY,float ScreenW,float ScreenH,float TextureU,float TextureV,float TextureUWidth,float TextureVHeight,FLinearColor TintColor=default(FLinearColor),EBlendMode BlendMode=EBlendMode.BLEND_Translucent,float Scale=1.000000f,bool bScalePosition=false,float Rotation=0.000000f,FVector2D RotPivot=default(FVector2D))
{
	CheckIsValid();
	DrawTexture(_this.Get(),Texture,ScreenX,ScreenY,ScreenW,ScreenH,TextureU,TextureV,TextureUWidth,TextureVHeight,ref TintColor,(int)BlendMode,Scale,bScalePosition?1:0,Rotation,ref RotPivot);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawRect(IntPtr _this,ref FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH);
public  void DrawRect(FLinearColor RectColor,float ScreenX,float ScreenY,float ScreenW,float ScreenH)
{
	CheckIsValid();
	DrawRect(_this.Get(),ref RectColor,ScreenX,ScreenY,ScreenW,ScreenH);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawLine(IntPtr _this,float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,ref FLinearColor LineColor,float LineThickness);
public  void DrawLine(float StartScreenX,float StartScreenY,float EndScreenX,float EndScreenY,FLinearColor LineColor,float LineThickness=0.000000f)
{
	CheckIsValid();
	DrawLine(_this.Get(),StartScreenX,StartScreenY,EndScreenX,EndScreenY,ref LineColor,LineThickness);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DrawText(IntPtr _this,string Text,ref FLinearColor TextColor,float ScreenX,float ScreenY,IntPtr Font,float Scale,int bScalePosition);
public  void DrawText(string Text,FLinearColor TextColor,float ScreenX,float ScreenY,UFont Font,float Scale=1.000000f,bool bScalePosition=false)
{
	CheckIsValid();
	DrawText(_this.Get(),Text,ref TextColor,ScreenX,ScreenY,Font,Scale,bScalePosition?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetTextSize(IntPtr _this,string Text,out float OutWidth,out float OutHeight,IntPtr Font,float Scale);
public  void GetTextSize(string Text,out float OutWidth,out float OutHeight,UFont Font,float Scale=1.000000f)
{
	CheckIsValid();
	GetTextSize(_this.Get(),Text,out OutWidth,out OutHeight,Font,Scale);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveDebugText(IntPtr _this,IntPtr SrcActor,int bLeaveDurationText);
public  void RemoveDebugText(AActor SrcActor,bool bLeaveDurationText)
{
	CheckIsValid();
	RemoveDebugText(_this.Get(),SrcActor,bLeaveDurationText?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RemoveAllDebugStrings(IntPtr _this);
public  void RemoveAllDebugStrings()
{
	CheckIsValid();
	RemoveAllDebugStrings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AddDebugText(IntPtr _this,string DebugText,IntPtr SrcActor,float Duration,ref FVector Offset,ref FVector DesiredOffset,ref FColor TextColor,int bSkipOverwriteCheck,int bAbsoluteLocation,int bKeepAttachedToActor,IntPtr InFont,float FontScale,int bDrawShadow);
public  void AddDebugText(string DebugText,AActor SrcActor,float Duration,FVector Offset,FVector DesiredOffset,FColor TextColor,bool bSkipOverwriteCheck,bool bAbsoluteLocation,bool bKeepAttachedToActor,UFont InFont,float FontScale,bool bDrawShadow)
{
	CheckIsValid();
	AddDebugText(_this.Get(),DebugText,SrcActor,Duration,ref Offset,ref DesiredOffset,ref TextColor,bSkipOverwriteCheck?1:0,bAbsoluteLocation?1:0,bKeepAttachedToActor?1:0,InFont,FontScale,bDrawShadow?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebugForReticleTargetToggle(IntPtr _this,IntPtr DesiredClass);
public  void ShowDebugForReticleTargetToggle(TSubclassOf<AActor>  DesiredClass)
{
	CheckIsValid();
	ShowDebugForReticleTargetToggle(_this.Get(),DesiredClass.NativeClass);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebugToggleSubCategory(IntPtr _this,string Category);
public  void ShowDebugToggleSubCategory(string Category)
{
	CheckIsValid();
	ShowDebugToggleSubCategory(_this.Get(),Category);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowDebug(IntPtr _this,string DebugType);
public  void ShowDebug(string DebugType="None")
{
	CheckIsValid();
	ShowDebug(_this.Get(),DebugType);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ShowHUD(IntPtr _this);
public  void ShowHUD()
{
	CheckIsValid();
	ShowHUD(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
