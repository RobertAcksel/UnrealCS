//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetMathLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LinePlaneIntersection_OriginNormal(IntPtr _this,ref FVector LineStart,ref FVector LineEnd,ref FVector PlaneOrigin,ref FVector PlaneNormal,out float T,out FVector Intersection);
	public static bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,out float T,out FVector Intersection)
	{
		int ___ret = LinePlaneIntersection_OriginNormal(IntPtr.Zero,ref LineStart,ref LineEnd,ref PlaneOrigin,ref PlaneNormal,out T,out Intersection);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LinePlaneIntersection(IntPtr _this,ref FVector LineStart,ref FVector LineEnd,ref FPlane APlane,out float T,out FVector Intersection);
	public static bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,out float T,out FVector Intersection)
	{
		int ___ret = LinePlaneIntersection(IntPtr.Zero,ref LineStart,ref LineEnd,ref APlane,out T,out Intersection);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPointInBoxWithTransform(IntPtr _this,ref FVector Point,ref FTransform BoxWorldTransform,ref FVector BoxExtent);
	public static bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent)
	{
		int ___ret = IsPointInBoxWithTransform(IntPtr.Zero,ref Point,ref BoxWorldTransform,ref BoxExtent);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsPointInBox(IntPtr _this,ref FVector Point,ref FVector BoxOrigin,ref FVector BoxExtent);
	public static bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent)
	{
		int ___ret = IsPointInBox(IntPtr.Zero,ref Point,ref BoxOrigin,ref BoxExtent);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int PointsAreCoplanar(IntPtr _this,FVector[] Points,float Tolerance);
	public static bool PointsAreCoplanar(FVector[] Points,float Tolerance=0.100000f)
	{
		int ___ret = PointsAreCoplanar(IntPtr.Zero,Points,Tolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MinimumAreaRectangle(IntPtr _this,IntPtr WorldContextObject,FVector[] InVerts,ref FVector SampleSurfaceNormal,out FVector OutRectCenter,out FRotator OutRectRotation,out float OutSideLengthX,out float OutSideLengthY,int bDebugDraw);
	public static void MinimumAreaRectangle(UObject WorldContextObject,FVector[] InVerts,FVector SampleSurfaceNormal,out FVector OutRectCenter,out FRotator OutRectRotation,out float OutSideLengthX,out float OutSideLengthY,bool bDebugDraw=false)
	{
		MinimumAreaRectangle(IntPtr.Zero,WorldContextObject,InVerts,ref SampleSurfaceNormal,out OutRectCenter,out OutRectRotation,out OutSideLengthX,out OutSideLengthY,bDebugDraw?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetRandomStreamSeed(IntPtr _this,out FRandomStream Stream,int NewSeed);
	public static void SetRandomStreamSeed(out FRandomStream Stream,int NewSeed)
	{
		SetRandomStreamSeed(IntPtr.Zero,out Stream,NewSeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SeedRandomStream(IntPtr _this,out FRandomStream Stream);
	public static void SeedRandomStream(out FRandomStream Stream)
	{
		SeedRandomStream(IntPtr.Zero,out Stream);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetRandomStream(IntPtr _this,ref FRandomStream Stream);
	public static void ResetRandomStream(FRandomStream Stream)
	{
		ResetRandomStream(IntPtr.Zero,ref Stream);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RandomRotatorFromStream(IntPtr _this,int bRoll,ref FRandomStream Stream);
	public static FRotator RandomRotatorFromStream(bool bRoll,FRandomStream Stream)
	{
		FRotator ___ret = RandomRotatorFromStream(IntPtr.Zero,bRoll?1:0,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RandomUnitVectorFromStream(IntPtr _this,ref FRandomStream Stream);
	public static FVector RandomUnitVectorFromStream(FRandomStream Stream)
	{
		FVector ___ret = RandomUnitVectorFromStream(IntPtr.Zero,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float RandomFloatInRangeFromStream(IntPtr _this,float Min,float Max,ref FRandomStream Stream);
	public static float RandomFloatInRangeFromStream(float Min,float Max,FRandomStream Stream)
	{
		float ___ret = RandomFloatInRangeFromStream(IntPtr.Zero,Min,Max,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float RandomFloatFromStream(IntPtr _this,ref FRandomStream Stream);
	public static float RandomFloatFromStream(FRandomStream Stream)
	{
		float ___ret = RandomFloatFromStream(IntPtr.Zero,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomBoolFromStream(IntPtr _this,ref FRandomStream Stream);
	public static bool RandomBoolFromStream(FRandomStream Stream)
	{
		int ___ret = RandomBoolFromStream(IntPtr.Zero,ref Stream);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomIntegerInRangeFromStream(IntPtr _this,int Min,int Max,ref FRandomStream Stream);
	public static int RandomIntegerInRangeFromStream(int Min,int Max,FRandomStream Stream)
	{
		int ___ret = RandomIntegerInRangeFromStream(IntPtr.Zero,Min,Max,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomIntegerFromStream(IntPtr _this,int Max,ref FRandomStream Stream);
	public static int RandomIntegerFromStream(int Max,FRandomStream Stream)
	{
		int ___ret = RandomIntegerFromStream(IntPtr.Zero,Max,ref Stream);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetVectorSpringState(IntPtr _this,out FVectorSpringState SpringState);
	public static void ResetVectorSpringState(out FVectorSpringState SpringState)
	{
		ResetVectorSpringState(IntPtr.Zero,out SpringState);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetFloatSpringState(IntPtr _this,out FFloatSpringState SpringState);
	public static void ResetFloatSpringState(out FFloatSpringState SpringState)
	{
		ResetFloatSpringState(IntPtr.Zero,out SpringState);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector VectorSpringInterp(IntPtr _this,ref FVector Current,ref FVector Target,out FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass);
	public static FVector VectorSpringInterp(FVector Current,FVector Target,out FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f)
	{
		FVector ___ret = VectorSpringInterp(IntPtr.Zero,ref Current,ref Target,out SpringState,Stiffness,CriticalDampingFactor,DeltaTime,Mass);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FloatSpringInterp(IntPtr _this,float Current,float Target,out FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass);
	public static float FloatSpringInterp(float Current,float Target,out FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass=1.000000f)
	{
		float ___ret = FloatSpringInterp(IntPtr.Zero,Current,Target,out SpringState,Stiffness,CriticalDampingFactor,DeltaTime,Mass);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor CInterpTo(IntPtr _this,ref FLinearColor Current,ref FLinearColor Target,float DeltaTime,float InterpSpeed);
	public static FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed)
	{
		FLinearColor ___ret = CInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RInterpTo_Constant(IntPtr _this,ref FRotator Current,ref FRotator Target,float DeltaTime,float InterpSpeed);
	public static FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed)
	{
		FRotator ___ret = RInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RInterpTo(IntPtr _this,ref FRotator Current,ref FRotator Target,float DeltaTime,float InterpSpeed);
	public static FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed)
	{
		FRotator ___ret = RInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Vector2DInterpTo_Constant(IntPtr _this,ref FVector2D Current,ref FVector2D Target,float DeltaTime,float InterpSpeed);
	public static FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed)
	{
		FVector2D ___ret = Vector2DInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Vector2DInterpTo(IntPtr _this,ref FVector2D Current,ref FVector2D Target,float DeltaTime,float InterpSpeed);
	public static FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed)
	{
		FVector2D ___ret = Vector2DInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector VInterpTo_Constant(IntPtr _this,ref FVector Current,ref FVector Target,float DeltaTime,float InterpSpeed);
	public static FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed)
	{
		FVector ___ret = VInterpTo_Constant(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector VInterpTo(IntPtr _this,ref FVector Current,ref FVector Target,float DeltaTime,float InterpSpeed);
	public static FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed)
	{
		FVector ___ret = VInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FInterpTo_Constant(IntPtr _this,float Current,float Target,float DeltaTime,float InterpSpeed);
	public static float FInterpTo_Constant(float Current,float Target,float DeltaTime,float InterpSpeed)
	{
		float ___ret = FInterpTo_Constant(IntPtr.Zero,Current,Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FInterpTo(IntPtr _this,float Current,float Target,float DeltaTime,float InterpSpeed);
	public static float FInterpTo(float Current,float Target,float DeltaTime,float InterpSpeed)
	{
		float ___ret = FInterpTo(IntPtr.Zero,Current,Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B,float ErrorTolerance);
	public static bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f)
	{
		int ___ret = NotEqual_Vector2DVector2D(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B,float ErrorTolerance);
	public static bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance=0.000100f)
	{
		int ___ret = EqualEqual_Vector2DVector2D(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Subtract_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
	public static FVector2D Subtract_Vector2DFloat(FVector2D A,float B)
	{
		FVector2D ___ret = Subtract_Vector2DFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Add_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
	public static FVector2D Add_Vector2DFloat(FVector2D A,float B)
	{
		FVector2D ___ret = Add_Vector2DFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Divide_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
	public static FVector2D Divide_Vector2DFloat(FVector2D A,float B=1.000000f)
	{
		FVector2D ___ret = Divide_Vector2DFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Multiply_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
	public static FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B)
	{
		FVector2D ___ret = Multiply_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Multiply_Vector2DFloat(IntPtr _this,ref FVector2D A,float B);
	public static FVector2D Multiply_Vector2DFloat(FVector2D A,float B)
	{
		FVector2D ___ret = Multiply_Vector2DFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Subtract_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
	public static FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B)
	{
		FVector2D ___ret = Subtract_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Add_Vector2DVector2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
	public static FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B)
	{
		FVector2D ___ret = Add_Vector2DVector2D(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NearlyEqual_TransformTransform(IntPtr _this,ref FTransform A,ref FTransform B,float LocationTolerance,float RotationTolerance,float Scale3DTolerance);
	public static bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance=0.000100f,float RotationTolerance=0.000100f,float Scale3DTolerance=0.000100f)
	{
		int ___ret = NearlyEqual_TransformTransform(IntPtr.Zero,ref A,ref B,LocationTolerance,RotationTolerance,Scale3DTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_TransformTransform(IntPtr _this,ref FTransform A,ref FTransform B);
	public static bool EqualEqual_TransformTransform(FTransform A,FTransform B)
	{
		int ___ret = EqualEqual_TransformTransform(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform TInterpTo(IntPtr _this,ref FTransform Current,ref FTransform Target,float DeltaTime,float InterpSpeed);
	public static FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed)
	{
		FTransform ___ret = TInterpTo(IntPtr.Zero,ref Current,ref Target,DeltaTime,InterpSpeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform TEase(IntPtr _this,ref FTransform A,ref FTransform B,float Alpha,int EasingFunc,float BlendExp,int Steps);
	public static FTransform TEase(FTransform A,FTransform B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
	{
		FTransform ___ret = TEase(IntPtr.Zero,ref A,ref B,Alpha,(int)EasingFunc,BlendExp,Steps);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform TLerp(IntPtr _this,ref FTransform A,ref FTransform B,float Alpha,int InterpMode);
	public static FTransform TLerp(FTransform A,FTransform B,float Alpha,ELerpInterpolationMode InterpMode=ELerpInterpolationMode.QuatInterp)
	{
		FTransform ___ret = TLerp(IntPtr.Zero,ref A,ref B,Alpha,(int)InterpMode);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform InvertTransform(IntPtr _this,ref FTransform T);
	public static FTransform InvertTransform(FTransform T)
	{
		FTransform ___ret = InvertTransform(IntPtr.Zero,ref T);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform ConvertTransformToRelative(IntPtr _this,ref FTransform Transform,ref FTransform ParentTransform);
	public static FTransform ConvertTransformToRelative(FTransform Transform,FTransform ParentTransform)
	{
		FTransform ___ret = ConvertTransformToRelative(IntPtr.Zero,ref Transform,ref ParentTransform);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform ComposeTransforms(IntPtr _this,ref FTransform A,ref FTransform B);
	public static FTransform ComposeTransforms(FTransform A,FTransform B)
	{
		FTransform ___ret = ComposeTransforms(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector InverseTransformDirection(IntPtr _this,ref FTransform T,ref FVector Direction);
	public static FVector InverseTransformDirection(FTransform T,FVector Direction)
	{
		FVector ___ret = InverseTransformDirection(IntPtr.Zero,ref T,ref Direction);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector InverseTransformLocation(IntPtr _this,ref FTransform T,ref FVector Location);
	public static FVector InverseTransformLocation(FTransform T,FVector Location)
	{
		FVector ___ret = InverseTransformLocation(IntPtr.Zero,ref T,ref Location);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector TransformDirection(IntPtr _this,ref FTransform T,ref FVector Direction);
	public static FVector TransformDirection(FTransform T,FVector Direction)
	{
		FVector ___ret = TransformDirection(IntPtr.Zero,ref T,ref Direction);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector TransformLocation(IntPtr _this,ref FTransform T,ref FVector Location);
	public static FVector TransformLocation(FTransform T,FVector Location)
	{
		FVector ___ret = TransformLocation(IntPtr.Zero,ref T,ref Location);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_NameName(IntPtr _this,string A,string B);
	public static bool NotEqual_NameName(string A,string B)
	{
		int ___ret = NotEqual_NameName(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_NameName(IntPtr _this,string A,string B);
	public static bool EqualEqual_NameName(string A,string B)
	{
		int ___ret = EqualEqual_NameName(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int ClassIsChildOf(IntPtr _this,IntPtr TestClass,IntPtr ParentClass);
	public static bool ClassIsChildOf(TSubclassOf<UObject>  TestClass,TSubclassOf<UObject>  ParentClass)
	{
		int ___ret = ClassIsChildOf(IntPtr.Zero,TestClass.NativeClass,ParentClass.NativeClass);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_ClassClass(IntPtr _this,IntPtr A,IntPtr B);
	public static bool NotEqual_ClassClass(UClass A,UClass B)
	{
		int ___ret = NotEqual_ClassClass(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_ClassClass(IntPtr _this,IntPtr A,IntPtr B);
	public static bool EqualEqual_ClassClass(UClass A,UClass B)
	{
		int ___ret = EqualEqual_ClassClass(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_ObjectObject(IntPtr _this,IntPtr A,IntPtr B);
	public static bool NotEqual_ObjectObject(UObject A,UObject B)
	{
		int ___ret = NotEqual_ObjectObject(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_ObjectObject(IntPtr _this,IntPtr A,IntPtr B);
	public static bool EqualEqual_ObjectObject(UObject A,UObject B)
	{
		int ___ret = EqualEqual_ObjectObject(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Conv_RotatorToVector(IntPtr _this,ref FRotator InRot);
	public static FVector Conv_RotatorToVector(FRotator InRot)
	{
		FVector ___ret = Conv_RotatorToVector(IntPtr.Zero,ref InRot);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator Conv_VectorToRotator(IntPtr _this,ref FVector InVec);
	public static FRotator Conv_VectorToRotator(FVector InVec)
	{
		FRotator ___ret = Conv_VectorToRotator(IntPtr.Zero,ref InVec);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotationFromAxes(IntPtr _this,ref FVector Forward,ref FVector Right,ref FVector Up);
	public static FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up)
	{
		FRotator ___ret = MakeRotationFromAxes(IntPtr.Zero,ref Forward,ref Right,ref Up);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SelectClass(IntPtr _this,IntPtr A,IntPtr B,int bSelectA);
	public static UClass SelectClass(UClass A,UClass B,bool bSelectA)
	{
		IntPtr ___ret = SelectClass(IntPtr.Zero,A,B,bSelectA?1:0);
		if(___ret==IntPtr.Zero) return null; UClass ___ret2= new UClass(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr SelectObject(IntPtr _this,IntPtr A,IntPtr B,int bSelectA);
	public static UObject SelectObject(UObject A,UObject B,bool bSelectA)
	{
		IntPtr ___ret = SelectObject(IntPtr.Zero,A,B,bSelectA?1:0);
		if(___ret==IntPtr.Zero) return null; UObject ___ret2= new UObject(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform SelectTransform(IntPtr _this,ref FTransform A,ref FTransform B,int bPickA);
	public static FTransform SelectTransform(FTransform A,FTransform B,bool bPickA)
	{
		FTransform ___ret = SelectTransform(IntPtr.Zero,ref A,ref B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor SelectColor(IntPtr _this,ref FLinearColor A,ref FLinearColor B,int bPickA);
	public static FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA)
	{
		FLinearColor ___ret = SelectColor(IntPtr.Zero,ref A,ref B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator SelectRotator(IntPtr _this,ref FRotator A,ref FRotator B,int bPickA);
	public static FRotator SelectRotator(FRotator A,FRotator B,bool bPickA)
	{
		FRotator ___ret = SelectRotator(IntPtr.Zero,ref A,ref B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector SelectVector(IntPtr _this,ref FVector A,ref FVector B,int bPickA);
	public static FVector SelectVector(FVector A,FVector B,bool bPickA)
	{
		FVector ___ret = SelectVector(IntPtr.Zero,ref A,ref B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float SelectFloat(IntPtr _this,float A,float B,int bPickA);
	public static float SelectFloat(float A,float B,bool bPickA)
	{
		float ___ret = SelectFloat(IntPtr.Zero,A,B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SelectInt(IntPtr _this,int A,int B,int bPickA);
	public static int SelectInt(int A,int B,bool bPickA)
	{
		int ___ret = SelectInt(IntPtr.Zero,A,B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string SelectString(IntPtr _this,string A,string B,int bPickA);
	public static string SelectString(string A,string B,bool bPickA)
	{
		string ___ret = SelectString(IntPtr.Zero,A,B,bPickA?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RGBToHSV_Vector(IntPtr _this,ref FLinearColor RGB,out FLinearColor HSV);
	public static void RGBToHSV_Vector(FLinearColor RGB,out FLinearColor HSV)
	{
		RGBToHSV_Vector(IntPtr.Zero,ref RGB,out HSV);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void HSVToRGB_Vector(IntPtr _this,ref FLinearColor HSV,out FLinearColor RGB);
	public static void HSVToRGB_Vector(FLinearColor HSV,out FLinearColor RGB)
	{
		HSVToRGB_Vector(IntPtr.Zero,ref HSV,out RGB);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RGBToHSV(IntPtr _this,ref FLinearColor InColor,out float H,out float S,out float V,out float A);
	public static void RGBToHSV(FLinearColor InColor,out float H,out float S,out float V,out float A)
	{
		RGBToHSV(IntPtr.Zero,ref InColor,out H,out S,out V,out A);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor HSVToRGB(IntPtr _this,float H,float S,float V,float A);
	public static FLinearColor HSVToRGB(float H,float S,float V,float A=1.000000f)
	{
		FLinearColor ___ret = HSVToRGB(IntPtr.Zero,H,S,V,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakColor(IntPtr _this,ref FLinearColor InColor,out float R,out float G,out float B,out float A);
	public static void BreakColor(FLinearColor InColor,out float R,out float G,out float B,out float A)
	{
		BreakColor(IntPtr.Zero,ref InColor,out R,out G,out B,out A);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor MakeColor(IntPtr _this,float R,float G,float B,float A);
	public static FLinearColor MakeColor(float R,float G,float B,float A=1.000000f)
	{
		FLinearColor ___ret = MakeColor(IntPtr.Zero,R,G,B,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakRandomStream(IntPtr _this,ref FRandomStream InRandomStream,out int InitialSeed);
	public static void BreakRandomStream(FRandomStream InRandomStream,out int InitialSeed)
	{
		BreakRandomStream(IntPtr.Zero,ref InRandomStream,out InitialSeed);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRandomStream MakeRandomStream(IntPtr _this,int InitialSeed);
	public static FRandomStream MakeRandomStream(int InitialSeed)
	{
		FRandomStream ___ret = MakeRandomStream(IntPtr.Zero,InitialSeed);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakTransform(IntPtr _this,ref FTransform InTransform,out FVector Location,out FRotator Rotation,out FVector Scale);
	public static void BreakTransform(FTransform InTransform,out FVector Location,out FRotator Rotation,out FVector Scale)
	{
		BreakTransform(IntPtr.Zero,ref InTransform,out Location,out Rotation,out Scale);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform MakeTransform(IntPtr _this,ref FVector Location,ref FRotator Rotation,ref FVector Scale);
	public static FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale)
	{
		FTransform ___ret = MakeTransform(IntPtr.Zero,ref Location,ref Rotation,ref Scale);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakRotIntoAxes(IntPtr _this,ref FRotator InRot,out FVector X,out FVector Y,out FVector Z);
	public static void BreakRotIntoAxes(FRotator InRot,out FVector X,out FVector Y,out FVector Z)
	{
		BreakRotIntoAxes(IntPtr.Zero,ref InRot,out X,out Y,out Z);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakRotator(IntPtr _this,ref FRotator InRot,out float Roll,out float Pitch,out float Yaw);
	public static void BreakRotator(FRotator InRot,out float Roll,out float Pitch,out float Yaw)
	{
		BreakRotator(IntPtr.Zero,ref InRot,out Roll,out Pitch,out Yaw);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromZY(IntPtr _this,ref FVector Z,ref FVector Y);
	public static FRotator MakeRotFromZY(FVector Z,FVector Y)
	{
		FRotator ___ret = MakeRotFromZY(IntPtr.Zero,ref Z,ref Y);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromZX(IntPtr _this,ref FVector Z,ref FVector X);
	public static FRotator MakeRotFromZX(FVector Z,FVector X)
	{
		FRotator ___ret = MakeRotFromZX(IntPtr.Zero,ref Z,ref X);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromYZ(IntPtr _this,ref FVector Y,ref FVector Z);
	public static FRotator MakeRotFromYZ(FVector Y,FVector Z)
	{
		FRotator ___ret = MakeRotFromYZ(IntPtr.Zero,ref Y,ref Z);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromYX(IntPtr _this,ref FVector Y,ref FVector X);
	public static FRotator MakeRotFromYX(FVector Y,FVector X)
	{
		FRotator ___ret = MakeRotFromYX(IntPtr.Zero,ref Y,ref X);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromXZ(IntPtr _this,ref FVector X,ref FVector Z);
	public static FRotator MakeRotFromXZ(FVector X,FVector Z)
	{
		FRotator ___ret = MakeRotFromXZ(IntPtr.Zero,ref X,ref Z);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromXY(IntPtr _this,ref FVector X,ref FVector Y);
	public static FRotator MakeRotFromXY(FVector X,FVector Y)
	{
		FRotator ___ret = MakeRotFromXY(IntPtr.Zero,ref X,ref Y);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromZ(IntPtr _this,ref FVector Z);
	public static FRotator MakeRotFromZ(FVector Z)
	{
		FRotator ___ret = MakeRotFromZ(IntPtr.Zero,ref Z);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromY(IntPtr _this,ref FVector Y);
	public static FRotator MakeRotFromY(FVector Y)
	{
		FRotator ___ret = MakeRotFromY(IntPtr.Zero,ref Y);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotFromX(IntPtr _this,ref FVector X);
	public static FRotator MakeRotFromX(FVector X)
	{
		FRotator ___ret = MakeRotFromX(IntPtr.Zero,ref X);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator FindLookAtRotation(IntPtr _this,ref FVector Start,ref FVector Target);
	public static FRotator FindLookAtRotation(FVector Start,FVector Target)
	{
		FRotator ___ret = FindLookAtRotation(IntPtr.Zero,ref Start,ref Target);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator MakeRotator(IntPtr _this,float Roll,float Pitch,float Yaw);
	public static FRotator MakeRotator(float Roll,float Pitch,float Yaw)
	{
		FRotator ___ret = MakeRotator(IntPtr.Zero,Roll,Pitch,Yaw);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetYawPitchFromVector(IntPtr _this,ref FVector InVec,out float Yaw,out float Pitch);
	public static void GetYawPitchFromVector(FVector InVec,out float Yaw,out float Pitch)
	{
		GetYawPitchFromVector(IntPtr.Zero,ref InVec,out Yaw,out Pitch);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector CreateVectorFromYawPitch(IntPtr _this,float Yaw,float Pitch,float Length);
	public static FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length=1.000000f)
	{
		FVector ___ret = CreateVectorFromYawPitch(IntPtr.Zero,Yaw,Pitch,Length);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetUpVector(IntPtr _this,ref FRotator InRot);
	public static FVector GetUpVector(FRotator InRot)
	{
		FVector ___ret = GetUpVector(IntPtr.Zero,ref InRot);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetRightVector(IntPtr _this,ref FRotator InRot);
	public static FVector GetRightVector(FRotator InRot)
	{
		FVector ___ret = GetRightVector(IntPtr.Zero,ref InRot);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetForwardVector(IntPtr _this,ref FRotator InRot);
	public static FVector GetForwardVector(FRotator InRot)
	{
		FVector ___ret = GetForwardVector(IntPtr.Zero,ref InRot);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakVector2D(IntPtr _this,ref FVector2D InVec,out float X,out float Y);
	public static void BreakVector2D(FVector2D InVec,out float X,out float Y)
	{
		BreakVector2D(IntPtr.Zero,ref InVec,out X,out Y);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D MakeVector2D(IntPtr _this,float X,float Y);
	public static FVector2D MakeVector2D(float X,float Y)
	{
		FVector2D ___ret = MakeVector2D(IntPtr.Zero,X,Y);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakVector(IntPtr _this,ref FVector InVec,out float X,out float Y,out float Z);
	public static void BreakVector(FVector InVec,out float X,out float Y,out float Z)
	{
		BreakVector(IntPtr.Zero,ref InVec,out X,out Y,out Z);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector MakeVector(IntPtr _this,float X,float Y,float Z);
	public static FVector MakeVector(float X,float Y,float Z)
	{
		FVector ___ret = MakeVector(IntPtr.Zero,X,Y,Z);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBox2D MakeBox2D(IntPtr _this,ref FVector2D Min,ref FVector2D Max);
	public static FBox2D MakeBox2D(FVector2D Min,FVector2D Max)
	{
		FBox2D ___ret = MakeBox2D(IntPtr.Zero,ref Min,ref Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FBox MakeBox(IntPtr _this,ref FVector Min,ref FVector Max);
	public static FBox MakeBox(FVector Min,FVector Max)
	{
		FBox ___ret = MakeBox(IntPtr.Zero,ref Min,ref Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor Conv_FloatToLinearColor(IntPtr _this,float InFloat);
	public static FLinearColor Conv_FloatToLinearColor(float InFloat)
	{
		FLinearColor ___ret = Conv_FloatToLinearColor(IntPtr.Zero,InFloat);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Conv_FloatToVector(IntPtr _this,float InFloat);
	public static FVector Conv_FloatToVector(float InFloat)
	{
		FVector ___ret = Conv_FloatToVector(IntPtr.Zero,InFloat);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Conv_IntVectorToVector(IntPtr _this,ref FIntVector InIntVector);
	public static FVector Conv_IntVectorToVector(FIntVector InIntVector)
	{
		FVector ___ret = Conv_IntVectorToVector(IntPtr.Zero,ref InIntVector);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Conv_Vector2DToVector(IntPtr _this,ref FVector2D InVector2D,float Z);
	public static FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z=0.000000f)
	{
		FVector ___ret = Conv_Vector2DToVector(IntPtr.Zero,ref InVector2D,Z);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Conv_VectorToVector2D(IntPtr _this,ref FVector InVector);
	public static FVector2D Conv_VectorToVector2D(FVector InVector)
	{
		FVector2D ___ret = Conv_VectorToVector2D(IntPtr.Zero,ref InVector);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTransform Conv_VectorToTransform(IntPtr _this,ref FVector InLocation);
	public static FTransform Conv_VectorToTransform(FVector InLocation)
	{
		FTransform ___ret = Conv_VectorToTransform(IntPtr.Zero,ref InLocation);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FColor Conv_LinearColorToColor(IntPtr _this,ref FLinearColor InLinearColor);
	public static FColor Conv_LinearColorToColor(FLinearColor InLinearColor)
	{
		FColor ___ret = Conv_LinearColorToColor(IntPtr.Zero,ref InLinearColor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor Conv_ColorToLinearColor(IntPtr _this,ref FColor InColor);
	public static FLinearColor Conv_ColorToLinearColor(FColor InColor)
	{
		FLinearColor ___ret = Conv_ColorToLinearColor(IntPtr.Zero,ref InColor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Conv_LinearColorToVector(IntPtr _this,ref FLinearColor InLinearColor);
	public static FVector Conv_LinearColorToVector(FLinearColor InLinearColor)
	{
		FVector ___ret = Conv_LinearColorToVector(IntPtr.Zero,ref InLinearColor);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor Conv_VectorToLinearColor(IntPtr _this,ref FVector InVec);
	public static FLinearColor Conv_VectorToLinearColor(FVector InVec)
	{
		FLinearColor ___ret = Conv_VectorToLinearColor(IntPtr.Zero,ref InVec);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Conv_ByteToInt(IntPtr _this,int InByte);
	public static int Conv_ByteToInt(byte InByte)
	{
		int ___ret = Conv_ByteToInt(IntPtr.Zero,InByte);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Conv_BoolToByte(IntPtr _this,int InBool);
	public static byte Conv_BoolToByte(bool InBool)
	{
		int ___ret = Conv_BoolToByte(IntPtr.Zero,InBool?1:0);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Conv_BoolToFloat(IntPtr _this,int InBool);
	public static float Conv_BoolToFloat(bool InBool)
	{
		float ___ret = Conv_BoolToFloat(IntPtr.Zero,InBool?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Conv_BoolToInt(IntPtr _this,int InBool);
	public static int Conv_BoolToInt(bool InBool)
	{
		int ___ret = Conv_BoolToInt(IntPtr.Zero,InBool?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Conv_IntToBool(IntPtr _this,int InInt);
	public static bool Conv_IntToBool(int InInt)
	{
		int ___ret = Conv_IntToBool(IntPtr.Zero,InInt);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntVector Conv_IntToIntVector(IntPtr _this,int InInt);
	public static FIntVector Conv_IntToIntVector(int InInt)
	{
		FIntVector ___ret = Conv_IntToIntVector(IntPtr.Zero,InInt);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Conv_IntToByte(IntPtr _this,int InInt);
	public static byte Conv_IntToByte(int InInt)
	{
		int ___ret = Conv_IntToByte(IntPtr.Zero,InInt);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Conv_IntToFloat(IntPtr _this,int InInt);
	public static float Conv_IntToFloat(int InInt)
	{
		float ___ret = Conv_IntToFloat(IntPtr.Zero,InInt);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Conv_ByteToFloat(IntPtr _this,int InByte);
	public static float Conv_ByteToFloat(byte InByte)
	{
		float ___ret = Conv_ByteToFloat(IntPtr.Zero,InByte);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int TimespanFromString(IntPtr _this,string TimespanString,out FTimespan Result);
	public static bool TimespanFromString(string TimespanString,out FTimespan Result)
	{
		int ___ret = TimespanFromString(IntPtr.Zero,TimespanString,out Result);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan TimespanZeroValue(IntPtr _this);
	public static FTimespan TimespanZeroValue()
	{
		FTimespan ___ret = TimespanZeroValue(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float TimespanRatio(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static float TimespanRatio(FTimespan A,FTimespan B)
	{
		float ___ret = TimespanRatio(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan TimespanMinValue(IntPtr _this);
	public static FTimespan TimespanMinValue()
	{
		FTimespan ___ret = TimespanMinValue(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan TimespanMaxValue(IntPtr _this);
	public static FTimespan TimespanMaxValue()
	{
		FTimespan ___ret = TimespanMaxValue(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan FromSeconds(IntPtr _this,float Seconds);
	public static FTimespan FromSeconds(float Seconds)
	{
		FTimespan ___ret = FromSeconds(IntPtr.Zero,Seconds);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan FromMinutes(IntPtr _this,float Minutes);
	public static FTimespan FromMinutes(float Minutes)
	{
		FTimespan ___ret = FromMinutes(IntPtr.Zero,Minutes);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan FromMilliseconds(IntPtr _this,float Milliseconds);
	public static FTimespan FromMilliseconds(float Milliseconds)
	{
		FTimespan ___ret = FromMilliseconds(IntPtr.Zero,Milliseconds);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan FromHours(IntPtr _this,float Hours);
	public static FTimespan FromHours(float Hours)
	{
		FTimespan ___ret = FromHours(IntPtr.Zero,Hours);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan FromDays(IntPtr _this,float Days);
	public static FTimespan FromDays(float Days)
	{
		FTimespan ___ret = FromDays(IntPtr.Zero,Days);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTotalSeconds(IntPtr _this,ref FTimespan A);
	public static float GetTotalSeconds(FTimespan A)
	{
		float ___ret = GetTotalSeconds(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTotalMinutes(IntPtr _this,ref FTimespan A);
	public static float GetTotalMinutes(FTimespan A)
	{
		float ___ret = GetTotalMinutes(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTotalMilliseconds(IntPtr _this,ref FTimespan A);
	public static float GetTotalMilliseconds(FTimespan A)
	{
		float ___ret = GetTotalMilliseconds(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTotalHours(IntPtr _this,ref FTimespan A);
	public static float GetTotalHours(FTimespan A)
	{
		float ___ret = GetTotalHours(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTotalDays(IntPtr _this,ref FTimespan A);
	public static float GetTotalDays(FTimespan A)
	{
		float ___ret = GetTotalDays(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetSeconds(IntPtr _this,ref FTimespan A);
	public static int GetSeconds(FTimespan A)
	{
		int ___ret = GetSeconds(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMinutes(IntPtr _this,ref FTimespan A);
	public static int GetMinutes(FTimespan A)
	{
		int ___ret = GetMinutes(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMilliseconds(IntPtr _this,ref FTimespan A);
	public static int GetMilliseconds(FTimespan A)
	{
		int ___ret = GetMilliseconds(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHours(IntPtr _this,ref FTimespan A);
	public static int GetHours(FTimespan A)
	{
		int ___ret = GetHours(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan GetDuration(IntPtr _this,ref FTimespan A);
	public static FTimespan GetDuration(FTimespan A)
	{
		FTimespan ___ret = GetDuration(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetDays(IntPtr _this,ref FTimespan A);
	public static int GetDays(FTimespan A)
	{
		int ___ret = GetDays(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LessEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = LessEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Less_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool Less_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = Less_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GreaterEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = GreaterEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Greater_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool Greater_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = Greater_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = NotEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B)
	{
		int ___ret = EqualEqual_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan Multiply_TimespanFloat(IntPtr _this,ref FTimespan A,float Scalar);
	public static FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar)
	{
		FTimespan ___ret = Multiply_TimespanFloat(IntPtr.Zero,ref A,Scalar);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan Subtract_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B)
	{
		FTimespan ___ret = Subtract_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan Add_TimespanTimespan(IntPtr _this,ref FTimespan A,ref FTimespan B);
	public static FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B)
	{
		FTimespan ___ret = Add_TimespanTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakTimespan(IntPtr _this,ref FTimespan InTimespan,out int Days,out int Hours,out int Minutes,out int Seconds,out int Milliseconds);
	public static void BreakTimespan(FTimespan InTimespan,out int Days,out int Hours,out int Minutes,out int Seconds,out int Milliseconds)
	{
		BreakTimespan(IntPtr.Zero,ref InTimespan,out Days,out Hours,out Minutes,out Seconds,out Milliseconds);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan MakeTimespan(IntPtr _this,int Days,int Hours,int Minutes,int Seconds,int Milliseconds);
	public static FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds)
	{
		FTimespan ___ret = MakeTimespan(IntPtr.Zero,Days,Hours,Minutes,Seconds,Milliseconds);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DateTimeFromString(IntPtr _this,string DateTimeString,out FDateTime Result);
	public static bool DateTimeFromString(string DateTimeString,out FDateTime Result)
	{
		int ___ret = DateTimeFromString(IntPtr.Zero,DateTimeString,out Result);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DateTimeFromIsoString(IntPtr _this,string IsoString,out FDateTime Result);
	public static bool DateTimeFromIsoString(string IsoString,out FDateTime Result)
	{
		int ___ret = DateTimeFromIsoString(IntPtr.Zero,IsoString,out Result);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime UtcNow(IntPtr _this);
	public static FDateTime UtcNow()
	{
		FDateTime ___ret = UtcNow(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime Today(IntPtr _this);
	public static FDateTime Today()
	{
		FDateTime ___ret = Today(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime Now(IntPtr _this);
	public static FDateTime Now()
	{
		FDateTime ___ret = Now(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime DateTimeMinValue(IntPtr _this);
	public static FDateTime DateTimeMinValue()
	{
		FDateTime ___ret = DateTimeMinValue(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime DateTimeMaxValue(IntPtr _this);
	public static FDateTime DateTimeMaxValue()
	{
		FDateTime ___ret = DateTimeMaxValue(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsLeapYear(IntPtr _this,int Year);
	public static bool IsLeapYear(int Year)
	{
		int ___ret = IsLeapYear(IntPtr.Zero,Year);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DaysInYear(IntPtr _this,int Year);
	public static int DaysInYear(int Year)
	{
		int ___ret = DaysInYear(IntPtr.Zero,Year);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int DaysInMonth(IntPtr _this,int Year,int Month);
	public static int DaysInMonth(int Year,int Month)
	{
		int ___ret = DaysInMonth(IntPtr.Zero,Year,Month);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsMorning(IntPtr _this,ref FDateTime A);
	public static bool IsMorning(FDateTime A)
	{
		int ___ret = IsMorning(IntPtr.Zero,ref A);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsAfternoon(IntPtr _this,ref FDateTime A);
	public static bool IsAfternoon(FDateTime A)
	{
		int ___ret = IsAfternoon(IntPtr.Zero,ref A);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetYear(IntPtr _this,ref FDateTime A);
	public static int GetYear(FDateTime A)
	{
		int ___ret = GetYear(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan GetTimeOfDay(IntPtr _this,ref FDateTime A);
	public static FTimespan GetTimeOfDay(FDateTime A)
	{
		FTimespan ___ret = GetTimeOfDay(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetSecond(IntPtr _this,ref FDateTime A);
	public static int GetSecond(FDateTime A)
	{
		int ___ret = GetSecond(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMonth(IntPtr _this,ref FDateTime A);
	public static int GetMonth(FDateTime A)
	{
		int ___ret = GetMonth(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMinute(IntPtr _this,ref FDateTime A);
	public static int GetMinute(FDateTime A)
	{
		int ___ret = GetMinute(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetMillisecond(IntPtr _this,ref FDateTime A);
	public static int GetMillisecond(FDateTime A)
	{
		int ___ret = GetMillisecond(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHour12(IntPtr _this,ref FDateTime A);
	public static int GetHour12(FDateTime A)
	{
		int ___ret = GetHour12(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetHour(IntPtr _this,ref FDateTime A);
	public static int GetHour(FDateTime A)
	{
		int ___ret = GetHour(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetDayOfYear(IntPtr _this,ref FDateTime A);
	public static int GetDayOfYear(FDateTime A)
	{
		int ___ret = GetDayOfYear(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetDay(IntPtr _this,ref FDateTime A);
	public static int GetDay(FDateTime A)
	{
		int ___ret = GetDay(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime GetDate(IntPtr _this,ref FDateTime A);
	public static FDateTime GetDate(FDateTime A)
	{
		FDateTime ___ret = GetDate(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LessEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = LessEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Less_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool Less_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = Less_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GreaterEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = GreaterEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Greater_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool Greater_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = Greater_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = NotEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		int ___ret = EqualEqual_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FTimespan Subtract_DateTimeDateTime(IntPtr _this,ref FDateTime A,ref FDateTime B);
	public static FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B)
	{
		FTimespan ___ret = Subtract_DateTimeDateTime(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime Subtract_DateTimeTimespan(IntPtr _this,ref FDateTime A,ref FTimespan B);
	public static FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B)
	{
		FDateTime ___ret = Subtract_DateTimeTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime Add_DateTimeTimespan(IntPtr _this,ref FDateTime A,ref FTimespan B);
	public static FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B)
	{
		FDateTime ___ret = Add_DateTimeTimespan(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void BreakDateTime(IntPtr _this,ref FDateTime InDateTime,out int Year,out int Month,out int Day,out int Hour,out int Minute,out int Second,out int Millisecond);
	public static void BreakDateTime(FDateTime InDateTime,out int Year,out int Month,out int Day,out int Hour,out int Minute,out int Second,out int Millisecond)
	{
		BreakDateTime(IntPtr.Zero,ref InDateTime,out Year,out Month,out Day,out Hour,out Minute,out Second,out Millisecond);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FDateTime MakeDateTime(IntPtr _this,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond);
	public static FDateTime MakeDateTime(int Year,int Month,int Day,int Hour=0,int Minute=0,int Second=0,int Millisecond=0)
	{
		FDateTime ___ret = MakeDateTime(IntPtr.Zero,Year,Month,Day,Hour,Minute,Second,Millisecond);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FPlane MakePlaneFromPointAndNormal(IntPtr _this,ref FVector Point,ref FVector Normal);
	public static FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal)
	{
		FPlane ___ret = MakePlaneFromPointAndNormal(IntPtr.Zero,ref Point,ref Normal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor Multiply_LinearColorFloat(IntPtr _this,ref FLinearColor A,float B);
	public static FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B)
	{
		FLinearColor ___ret = Multiply_LinearColorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor Multiply_LinearColorLinearColor(IntPtr _this,ref FLinearColor A,ref FLinearColor B);
	public static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B)
	{
		FLinearColor ___ret = Multiply_LinearColorLinearColor(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor LinearColorLerpUsingHSV(IntPtr _this,ref FLinearColor A,ref FLinearColor B,float Alpha);
	public static FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha)
	{
		FLinearColor ___ret = LinearColorLerpUsingHSV(IntPtr.Zero,ref A,ref B,Alpha);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FLinearColor LinearColorLerp(IntPtr _this,ref FLinearColor A,ref FLinearColor B,float Alpha);
	public static FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha)
	{
		FLinearColor ___ret = LinearColorLerp(IntPtr.Zero,ref A,ref B,Alpha);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float NormalizeAxis(IntPtr _this,float Angle);
	public static float NormalizeAxis(float Angle)
	{
		float ___ret = NormalizeAxis(IntPtr.Zero,Angle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float ClampAxis(IntPtr _this,float Angle);
	public static float ClampAxis(float Angle)
	{
		float ___ret = ClampAxis(IntPtr.Zero,Angle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RotatorFromAxisAndAngle(IntPtr _this,ref FVector Axis,float Angle);
	public static FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle)
	{
		FRotator ___ret = RotatorFromAxisAndAngle(IntPtr.Zero,ref Axis,Angle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator NormalizedDeltaRotator(IntPtr _this,ref FRotator A,ref FRotator B);
	public static FRotator NormalizedDeltaRotator(FRotator A,FRotator B)
	{
		FRotator ___ret = NormalizedDeltaRotator(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator REase(IntPtr _this,ref FRotator A,ref FRotator B,float Alpha,int bShortestPath,int EasingFunc,float BlendExp,int Steps);
	public static FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
	{
		FRotator ___ret = REase(IntPtr.Zero,ref A,ref B,Alpha,bShortestPath?1:0,(int)EasingFunc,BlendExp,Steps);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RLerp(IntPtr _this,ref FRotator A,ref FRotator B,float Alpha,int bShortestPath);
	public static FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath)
	{
		FRotator ___ret = RLerp(IntPtr.Zero,ref A,ref B,Alpha,bShortestPath?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator RandomRotator(IntPtr _this,int bRoll);
	public static FRotator RandomRotator(bool bRoll=false)
	{
		FRotator ___ret = RandomRotator(IntPtr.Zero,bRoll?1:0);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetAxes(IntPtr _this,ref FRotator A,out FVector X,out FVector Y,out FVector Z);
	public static void GetAxes(FRotator A,out FVector X,out FVector Y,out FVector Z)
	{
		GetAxes(IntPtr.Zero,ref A,out X,out Y,out Z);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator NegateRotator(IntPtr _this,ref FRotator A);
	public static FRotator NegateRotator(FRotator A)
	{
		FRotator ___ret = NegateRotator(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator ComposeRotators(IntPtr _this,ref FRotator A,ref FRotator B);
	public static FRotator ComposeRotators(FRotator A,FRotator B)
	{
		FRotator ___ret = ComposeRotators(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator Multiply_RotatorInt(IntPtr _this,ref FRotator A,int B);
	public static FRotator Multiply_RotatorInt(FRotator A,int B)
	{
		FRotator ___ret = Multiply_RotatorInt(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FRotator Multiply_RotatorFloat(IntPtr _this,ref FRotator A,float B);
	public static FRotator Multiply_RotatorFloat(FRotator A,float B)
	{
		FRotator ___ret = Multiply_RotatorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_RotatorRotator(IntPtr _this,ref FRotator A,ref FRotator B,float ErrorTolerance);
	public static bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f)
	{
		int ___ret = NotEqual_RotatorRotator(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_RotatorRotator(IntPtr _this,ref FRotator A,ref FRotator B,float ErrorTolerance);
	public static bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance=0.000100f)
	{
		int ___ret = EqualEqual_RotatorRotator(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetDirectionUnitVector(IntPtr _this,ref FVector From,ref FVector To);
	public static FVector GetDirectionUnitVector(FVector From,FVector To)
	{
		FVector ___ret = GetDirectionUnitVector(IntPtr.Zero,ref From,ref To);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetVectorArrayAverage(IntPtr _this,FVector[] Vectors);
	public static FVector GetVectorArrayAverage(FVector[] Vectors)
	{
		FVector ___ret = GetVectorArrayAverage(IntPtr.Zero,Vectors);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMaxElement(IntPtr _this,ref FVector A);
	public static float GetMaxElement(FVector A)
	{
		float ___ret = GetMaxElement(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetMinElement(IntPtr _this,ref FVector A);
	public static float GetMinElement(FVector A)
	{
		float ___ret = GetMinElement(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ClampVectorSize(IntPtr _this,ref FVector A,float Min,float Max);
	public static FVector ClampVectorSize(FVector A,float Min,float Max)
	{
		FVector ___ret = ClampVectorSize(IntPtr.Zero,ref A,Min,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector NegateVector(IntPtr _this,ref FVector A);
	public static FVector NegateVector(FVector A)
	{
		FVector ___ret = NegateVector(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ProjectVectorOnToPlane(IntPtr _this,ref FVector V,ref FVector PlaneNormal);
	public static FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal)
	{
		FVector ___ret = ProjectVectorOnToPlane(IntPtr.Zero,ref V,ref PlaneNormal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ProjectPointOnToPlane(IntPtr _this,ref FVector Point,ref FVector PlaneBase,ref FVector PlaneNormal);
	public static FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal)
	{
		FVector ___ret = ProjectPointOnToPlane(IntPtr.Zero,ref Point,ref PlaneBase,ref PlaneNormal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPointDistanceToLine(IntPtr _this,ref FVector Point,ref FVector LineOrigin,ref FVector LineDirection);
	public static float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection)
	{
		float ___ret = GetPointDistanceToLine(IntPtr.Zero,ref Point,ref LineOrigin,ref LineDirection);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPointDistanceToSegment(IntPtr _this,ref FVector Point,ref FVector SegmentStart,ref FVector SegmentEnd);
	public static float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd)
	{
		float ___ret = GetPointDistanceToSegment(IntPtr.Zero,ref Point,ref SegmentStart,ref SegmentEnd);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindClosestPointOnLine(IntPtr _this,ref FVector Point,ref FVector LineOrigin,ref FVector LineDirection);
	public static FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection)
	{
		FVector ___ret = FindClosestPointOnLine(IntPtr.Zero,ref Point,ref LineOrigin,ref LineDirection);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector FindClosestPointOnSegment(IntPtr _this,ref FVector Point,ref FVector SegmentStart,ref FVector SegmentEnd);
	public static FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd)
	{
		FVector ___ret = FindClosestPointOnSegment(IntPtr.Zero,ref Point,ref SegmentStart,ref SegmentEnd);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void FindNearestPointsOnLineSegments(IntPtr _this,ref FVector Segment1Start,ref FVector Segment1End,ref FVector Segment2Start,ref FVector Segment2End,out FVector Segment1Point,out FVector Segment2Point);
	public static void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,out FVector Segment1Point,out FVector Segment2Point)
	{
		FindNearestPointsOnLineSegments(IntPtr.Zero,ref Segment1Start,ref Segment1End,ref Segment2Start,ref Segment2End,out Segment1Point,out Segment2Point);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GetReflectionVector(IntPtr _this,ref FVector Direction,ref FVector SurfaceNormal);
	public static FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal)
	{
		FVector ___ret = GetReflectionVector(IntPtr.Zero,ref Direction,ref SurfaceNormal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector ProjectVectorOnToVector(IntPtr _this,ref FVector V,ref FVector Target);
	public static FVector ProjectVectorOnToVector(FVector V,FVector Target)
	{
		FVector ___ret = ProjectVectorOnToVector(IntPtr.Zero,ref V,ref Target);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector MirrorVectorByNormal(IntPtr _this,ref FVector InVect,ref FVector InNormal);
	public static FVector MirrorVectorByNormal(FVector InVect,FVector InNormal)
	{
		FVector ___ret = MirrorVectorByNormal(IntPtr.Zero,ref InVect,ref InNormal);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RandomUnitVectorInConeWithYawAndPitch(IntPtr _this,ref FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees);
	public static FVector RandomUnitVectorInConeWithYawAndPitch(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees)
	{
		FVector ___ret = RandomUnitVectorInConeWithYawAndPitch(IntPtr.Zero,ref ConeDir,MaxYawInDegrees,MaxPitchInDegrees);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RandomUnitVectorInCone(IntPtr _this,ref FVector ConeDir,float ConeHalfAngle);
	public static FVector RandomUnitVectorInCone(FVector ConeDir,float ConeHalfAngle)
	{
		FVector ___ret = RandomUnitVectorInCone(IntPtr.Zero,ref ConeDir,ConeHalfAngle);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RandomPointInBoundingBox(IntPtr _this,ref FVector Origin,ref FVector BoxExtent);
	public static FVector RandomPointInBoundingBox(FVector Origin,FVector BoxExtent)
	{
		FVector ___ret = RandomPointInBoundingBox(IntPtr.Zero,ref Origin,ref BoxExtent);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RandomUnitVector(IntPtr _this);
	public static FVector RandomUnitVector()
	{
		FVector ___ret = RandomUnitVector(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector VEase(IntPtr _this,ref FVector A,ref FVector B,float Alpha,int EasingFunc,float BlendExp,int Steps);
	public static FVector VEase(FVector A,FVector B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
	{
		FVector ___ret = VEase(IntPtr.Zero,ref A,ref B,Alpha,(int)EasingFunc,BlendExp,Steps);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector VLerp(IntPtr _this,ref FVector A,ref FVector B,float Alpha);
	public static FVector VLerp(FVector A,FVector B,float Alpha)
	{
		FVector ___ret = VLerp(IntPtr.Zero,ref A,ref B,Alpha);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector2D Normal2D(IntPtr _this,ref FVector2D A);
	public static FVector2D Normal2D(FVector2D A)
	{
		FVector2D ___ret = Normal2D(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Normal(IntPtr _this,ref FVector A);
	public static FVector Normal(FVector A)
	{
		FVector ___ret = Normal(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float VSize2DSquared(IntPtr _this,ref FVector2D A);
	public static float VSize2DSquared(FVector2D A)
	{
		float ___ret = VSize2DSquared(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float VSizeSquared(IntPtr _this,ref FVector A);
	public static float VSizeSquared(FVector A)
	{
		float ___ret = VSizeSquared(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float VSize2D(IntPtr _this,ref FVector2D A);
	public static float VSize2D(FVector2D A)
	{
		float ___ret = VSize2D(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float VSize(IntPtr _this,ref FVector A);
	public static float VSize(FVector A)
	{
		float ___ret = VSize(IntPtr.Zero,ref A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float CrossProduct2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
	public static float CrossProduct2D(FVector2D A,FVector2D B)
	{
		float ___ret = CrossProduct2D(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DotProduct2D(IntPtr _this,ref FVector2D A,ref FVector2D B);
	public static float DotProduct2D(FVector2D A,FVector2D B)
	{
		float ___ret = DotProduct2D(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Cross_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static FVector Cross_VectorVector(FVector A,FVector B)
	{
		FVector ___ret = Cross_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Dot_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static float Dot_VectorVector(FVector A,FVector B)
	{
		float ___ret = Dot_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_VectorVector(IntPtr _this,ref FVector A,ref FVector B,float ErrorTolerance);
	public static bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f)
	{
		int ___ret = NotEqual_VectorVector(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_VectorVector(IntPtr _this,ref FVector A,ref FVector B,float ErrorTolerance);
	public static bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance=0.000100f)
	{
		int ___ret = EqualEqual_VectorVector(IntPtr.Zero,ref A,ref B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector RotateAngleAxis(IntPtr _this,ref FVector InVect,float AngleDeg,ref FVector Axis);
	public static FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis)
	{
		FVector ___ret = RotateAngleAxis(IntPtr.Zero,ref InVect,AngleDeg,ref Axis);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector GreaterGreater_VectorRotator(IntPtr _this,ref FVector A,ref FRotator B);
	public static FVector GreaterGreater_VectorRotator(FVector A,FRotator B)
	{
		FVector ___ret = GreaterGreater_VectorRotator(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector LessLess_VectorRotator(IntPtr _this,ref FVector A,ref FRotator B);
	public static FVector LessLess_VectorRotator(FVector A,FRotator B)
	{
		FVector ___ret = LessLess_VectorRotator(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Subtract_VectorInt(IntPtr _this,ref FVector A,int B);
	public static FVector Subtract_VectorInt(FVector A,int B)
	{
		FVector ___ret = Subtract_VectorInt(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Subtract_VectorFloat(IntPtr _this,ref FVector A,float B);
	public static FVector Subtract_VectorFloat(FVector A,float B)
	{
		FVector ___ret = Subtract_VectorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Subtract_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static FVector Subtract_VectorVector(FVector A,FVector B)
	{
		FVector ___ret = Subtract_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Add_VectorInt(IntPtr _this,ref FVector A,int B);
	public static FVector Add_VectorInt(FVector A,int B)
	{
		FVector ___ret = Add_VectorInt(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Add_VectorFloat(IntPtr _this,ref FVector A,float B);
	public static FVector Add_VectorFloat(FVector A,float B)
	{
		FVector ___ret = Add_VectorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Add_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static FVector Add_VectorVector(FVector A,FVector B)
	{
		FVector ___ret = Add_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Divide_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static FVector Divide_VectorVector(FVector A,FVector B=default(FVector))
	{
		FVector ___ret = Divide_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Divide_VectorInt(IntPtr _this,ref FVector A,int B);
	public static FVector Divide_VectorInt(FVector A,int B=1)
	{
		FVector ___ret = Divide_VectorInt(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Divide_VectorFloat(IntPtr _this,ref FVector A,float B);
	public static FVector Divide_VectorFloat(FVector A,float B=1.000000f)
	{
		FVector ___ret = Divide_VectorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Multiply_VectorVector(IntPtr _this,ref FVector A,ref FVector B);
	public static FVector Multiply_VectorVector(FVector A,FVector B)
	{
		FVector ___ret = Multiply_VectorVector(IntPtr.Zero,ref A,ref B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Multiply_VectorInt(IntPtr _this,ref FVector A,int B);
	public static FVector Multiply_VectorInt(FVector A,int B)
	{
		FVector ___ret = Multiply_VectorInt(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FVector Multiply_VectorFloat(IntPtr _this,ref FVector A,float B);
	public static FVector Multiply_VectorFloat(FVector A,float B)
	{
		FVector ___ret = Multiply_VectorFloat(IntPtr.Zero,ref A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FixedTurn(IntPtr _this,float InCurrent,float InDesired,float InDeltaRate);
	public static float FixedTurn(float InCurrent,float InDesired,float InDeltaRate)
	{
		float ___ret = FixedTurn(IntPtr.Zero,InCurrent,InDesired,InDeltaRate);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MakePulsatingValue(IntPtr _this,float InCurrentTime,float InPulsesPerSecond,float InPhase);
	public static float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond=1.000000f,float InPhase=0.000000f)
	{
		float ___ret = MakePulsatingValue(IntPtr.Zero,InCurrentTime,InPulsesPerSecond,InPhase);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FInterpEaseInOut(IntPtr _this,float A,float B,float Alpha,float Exponent);
	public static float FInterpEaseInOut(float A,float B,float Alpha,float Exponent)
	{
		float ___ret = FInterpEaseInOut(IntPtr.Zero,A,B,Alpha,Exponent);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MultiplyByPi(IntPtr _this,float Value);
	public static float MultiplyByPi(float Value)
	{
		float ___ret = MultiplyByPi(IntPtr.Zero,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MapRangeClamped(IntPtr _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
	public static float MapRangeClamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
	{
		float ___ret = MapRangeClamped(IntPtr.Zero,Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MapRangeUnclamped(IntPtr _this,float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB);
	public static float MapRangeUnclamped(float Value,float InRangeA,float InRangeB,float OutRangeA,float OutRangeB)
	{
		float ___ret = MapRangeUnclamped(IntPtr.Zero,Value,InRangeA,InRangeB,OutRangeA,OutRangeB);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float NormalizeToRange(IntPtr _this,float Value,float RangeMin,float RangeMax);
	public static float NormalizeToRange(float Value,float RangeMin,float RangeMax)
	{
		float ___ret = NormalizeToRange(IntPtr.Zero,Value,RangeMin,RangeMax);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float SignOfFloat(IntPtr _this,float A);
	public static float SignOfFloat(float A)
	{
		float ___ret = SignOfFloat(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FMod(IntPtr _this,float Dividend,float Divisor,out float Remainder);
	public static int FMod(float Dividend,float Divisor,out float Remainder)
	{
		int ___ret = FMod(IntPtr.Zero,Dividend,Divisor,out Remainder);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FCeil(IntPtr _this,float A);
	public static int FCeil(float A)
	{
		int ___ret = FCeil(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntVector FTruncVector(IntPtr _this,ref FVector InVector);
	public static FIntVector FTruncVector(FVector InVector)
	{
		FIntVector ___ret = FTruncVector(IntPtr.Zero,ref InVector);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FTrunc(IntPtr _this,float A);
	public static int FTrunc(float A)
	{
		int ___ret = FTrunc(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int FFloor(IntPtr _this,float A);
	public static int FFloor(float A)
	{
		int ___ret = FFloor(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Round(IntPtr _this,float A);
	public static int Round(float A)
	{
		int ___ret = Round(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Ease(IntPtr _this,float A,float B,float Alpha,int EasingFunc,float BlendExp,int Steps);
	public static float Ease(float A,float B,float Alpha,EEasingFunc EasingFunc,float BlendExp=2.000000f,int Steps=2)
	{
		float ___ret = Ease(IntPtr.Zero,A,B,Alpha,(int)EasingFunc,BlendExp,Steps);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float InverseLerp(IntPtr _this,float A,float B,float Value);
	public static float InverseLerp(float A,float B,float Value)
	{
		float ___ret = InverseLerp(IntPtr.Zero,A,B,Value);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Lerp(IntPtr _this,float A,float B,float Alpha);
	public static float Lerp(float A,float B,float Alpha)
	{
		float ___ret = Lerp(IntPtr.Zero,A,B,Alpha);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MinOfByteArray(IntPtr _this,byte[] ByteArray,out int IndexOfMinValue,out int MinValue);
	public static void MinOfByteArray(byte[] ByteArray,out int IndexOfMinValue,out byte MinValue)
	{
		int MinValue_temp;
		MinOfByteArray(IntPtr.Zero,ByteArray,out IndexOfMinValue,out MinValue_temp);
		MinValue=(byte)MinValue_temp;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MaxOfByteArray(IntPtr _this,byte[] ByteArray,out int IndexOfMaxValue,out int MaxValue);
	public static void MaxOfByteArray(byte[] ByteArray,out int IndexOfMaxValue,out byte MaxValue)
	{
		int MaxValue_temp;
		MaxOfByteArray(IntPtr.Zero,ByteArray,out IndexOfMaxValue,out MaxValue_temp);
		MaxValue=(byte)MaxValue_temp;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MinOfFloatArray(IntPtr _this,float[] FloatArray,out int IndexOfMinValue,out float MinValue);
	public static void MinOfFloatArray(float[] FloatArray,out int IndexOfMinValue,out float MinValue)
	{
		MinOfFloatArray(IntPtr.Zero,FloatArray,out IndexOfMinValue,out MinValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MaxOfFloatArray(IntPtr _this,float[] FloatArray,out int IndexOfMaxValue,out float MaxValue);
	public static void MaxOfFloatArray(float[] FloatArray,out int IndexOfMaxValue,out float MaxValue)
	{
		MaxOfFloatArray(IntPtr.Zero,FloatArray,out IndexOfMaxValue,out MaxValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MinOfIntArray(IntPtr _this,int[] IntArray,out int IndexOfMinValue,out int MinValue);
	public static void MinOfIntArray(int[] IntArray,out int IndexOfMinValue,out int MinValue)
	{
		MinOfIntArray(IntPtr.Zero,IntArray,out IndexOfMinValue,out MinValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void MaxOfIntArray(IntPtr _this,int[] IntArray,out int IndexOfMaxValue,out int MaxValue);
	public static void MaxOfIntArray(int[] IntArray,out int IndexOfMaxValue,out int MaxValue)
	{
		MaxOfIntArray(IntPtr.Zero,IntArray,out IndexOfMaxValue,out MaxValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FClamp(IntPtr _this,float Value,float Min,float Max);
	public static float FClamp(float Value,float Min,float Max)
	{
		float ___ret = FClamp(IntPtr.Zero,Value,Min,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FMax(IntPtr _this,float A,float B);
	public static float FMax(float A,float B)
	{
		float ___ret = FMax(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float FMin(IntPtr _this,float A,float B);
	public static float FMin(float A,float B)
	{
		float ___ret = FMin(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float ClampAngle(IntPtr _this,float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees);
	public static float ClampAngle(float AngleDegrees,float MinAngleDegrees,float MaxAngleDegrees)
	{
		float ___ret = ClampAngle(IntPtr.Zero,AngleDegrees,MinAngleDegrees,MaxAngleDegrees);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegAtan2(IntPtr _this,float A,float B);
	public static float DegAtan2(float A,float B)
	{
		float ___ret = DegAtan2(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegAtan(IntPtr _this,float A);
	public static float DegAtan(float A)
	{
		float ___ret = DegAtan(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegTan(IntPtr _this,float A);
	public static float DegTan(float A)
	{
		float ___ret = DegTan(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegAcos(IntPtr _this,float A);
	public static float DegAcos(float A)
	{
		float ___ret = DegAcos(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegCos(IntPtr _this,float A);
	public static float DegCos(float A)
	{
		float ___ret = DegCos(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegAsin(IntPtr _this,float A);
	public static float DegAsin(float A)
	{
		float ___ret = DegAsin(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegSin(IntPtr _this,float A);
	public static float DegSin(float A)
	{
		float ___ret = DegSin(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float RadiansToDegrees(IntPtr _this,float A);
	public static float RadiansToDegrees(float A)
	{
		float ___ret = RadiansToDegrees(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float DegreesToRadians(IntPtr _this,float A);
	public static float DegreesToRadians(float A)
	{
		float ___ret = DegreesToRadians(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetTAU(IntPtr _this);
	public static float GetTAU()
	{
		float ___ret = GetTAU(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetPI(IntPtr _this);
	public static float GetPI()
	{
		float ___ret = GetPI(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float RandomFloatInRange(IntPtr _this,float Min,float Max);
	public static float RandomFloatInRange(float Min,float Max)
	{
		float ___ret = RandomFloatInRange(IntPtr.Zero,Min,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float RandomFloat(IntPtr _this);
	public static float RandomFloat()
	{
		float ___ret = RandomFloat(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Square(IntPtr _this,float A);
	public static float Square(float A)
	{
		float ___ret = Square(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Sqrt(IntPtr _this,float A);
	public static float Sqrt(float A)
	{
		float ___ret = Sqrt(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Loge(IntPtr _this,float A);
	public static float Loge(float A)
	{
		float ___ret = Loge(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Log(IntPtr _this,float A,float Base);
	public static float Log(float A,float Base=1.000000f)
	{
		float ___ret = Log(IntPtr.Zero,A,Base);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Exp(IntPtr _this,float A);
	public static float Exp(float A)
	{
		float ___ret = Exp(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Atan2(IntPtr _this,float A,float B);
	public static float Atan2(float A,float B)
	{
		float ___ret = Atan2(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Atan(IntPtr _this,float A);
	public static float Atan(float A)
	{
		float ___ret = Atan(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Tan(IntPtr _this,float A);
	public static float Tan(float A)
	{
		float ___ret = Tan(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Acos(IntPtr _this,float A);
	public static float Acos(float A)
	{
		float ___ret = Acos(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Cos(IntPtr _this,float A);
	public static float Cos(float A)
	{
		float ___ret = Cos(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Asin(IntPtr _this,float A);
	public static float Asin(float A)
	{
		float ___ret = Asin(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Sin(IntPtr _this,float A);
	public static float Sin(float A)
	{
		float ___ret = Sin(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Abs(IntPtr _this,float A);
	public static float Abs(float A)
	{
		float ___ret = Abs(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GridSnap_Float(IntPtr _this,float Location,float GridSize);
	public static float GridSnap_Float(float Location,float GridSize)
	{
		float ___ret = GridSnap_Float(IntPtr.Zero,Location,GridSize);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Hypotenuse(IntPtr _this,float Width,float Height);
	public static float Hypotenuse(float Width,float Height)
	{
		float ___ret = Hypotenuse(IntPtr.Zero,Width,Height);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int InRange_FloatFloat(IntPtr _this,float Value,float Min,float Max,int InclusiveMin,int InclusiveMax);
	public static bool InRange_FloatFloat(float Value,float Min,float Max,bool InclusiveMin=true,bool InclusiveMax=true)
	{
		int ___ret = InRange_FloatFloat(IntPtr.Zero,Value,Min,Max,InclusiveMin?1:0,InclusiveMax?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_FloatFloat(IntPtr _this,float A,float B);
	public static bool NotEqual_FloatFloat(float A,float B)
	{
		int ___ret = NotEqual_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NearlyEqual_FloatFloat(IntPtr _this,float A,float B,float ErrorTolerance);
	public static bool NearlyEqual_FloatFloat(float A,float B,float ErrorTolerance=0.000001f)
	{
		int ___ret = NearlyEqual_FloatFloat(IntPtr.Zero,A,B,ErrorTolerance);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_FloatFloat(IntPtr _this,float A,float B);
	public static bool EqualEqual_FloatFloat(float A,float B)
	{
		int ___ret = EqualEqual_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GreaterEqual_FloatFloat(IntPtr _this,float A,float B);
	public static bool GreaterEqual_FloatFloat(float A,float B)
	{
		int ___ret = GreaterEqual_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LessEqual_FloatFloat(IntPtr _this,float A,float B);
	public static bool LessEqual_FloatFloat(float A,float B)
	{
		int ___ret = LessEqual_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Greater_FloatFloat(IntPtr _this,float A,float B);
	public static bool Greater_FloatFloat(float A,float B)
	{
		int ___ret = Greater_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Less_FloatFloat(IntPtr _this,float A,float B);
	public static bool Less_FloatFloat(float A,float B)
	{
		int ___ret = Less_FloatFloat(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Subtract_FloatFloat(IntPtr _this,float A,float B);
	public static float Subtract_FloatFloat(float A,float B=1.000000f)
	{
		float ___ret = Subtract_FloatFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Add_FloatFloat(IntPtr _this,float A,float B);
	public static float Add_FloatFloat(float A,float B=1.000000f)
	{
		float ___ret = Add_FloatFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Fraction(IntPtr _this,float A);
	public static float Fraction(float A)
	{
		float ___ret = Fraction(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Percent_FloatFloat(IntPtr _this,float A,float B);
	public static float Percent_FloatFloat(float A,float B=1.000000f)
	{
		float ___ret = Percent_FloatFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Divide_FloatFloat(IntPtr _this,float A,float B);
	public static float Divide_FloatFloat(float A,float B=1.000000f)
	{
		float ___ret = Divide_FloatFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Multiply_IntFloat(IntPtr _this,int A,float B);
	public static float Multiply_IntFloat(int A,float B)
	{
		float ___ret = Multiply_IntFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float Multiply_FloatFloat(IntPtr _this,float A,float B);
	public static float Multiply_FloatFloat(float A,float B)
	{
		float ___ret = Multiply_FloatFloat(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float MultiplyMultiply_FloatFloat(IntPtr _this,float Base,float Exp);
	public static float MultiplyMultiply_FloatFloat(float Base,float Exp)
	{
		float ___ret = MultiplyMultiply_FloatFloat(IntPtr.Zero,Base,Exp);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Abs_Int(IntPtr _this,int A);
	public static int Abs_Int(int A)
	{
		int ___ret = Abs_Int(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Clamp(IntPtr _this,int Value,int Min,int Max);
	public static int Clamp(int Value,int Min,int Max)
	{
		int ___ret = Clamp(IntPtr.Zero,Value,Min,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Max(IntPtr _this,int A,int B);
	public static int Max(int A,int B)
	{
		int ___ret = Max(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Min(IntPtr _this,int A,int B);
	public static int Min(int A,int B)
	{
		int ___ret = Min(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomIntegerInRange(IntPtr _this,int Min,int Max);
	public static int RandomIntegerInRange(int Min,int Max)
	{
		int ___ret = RandomIntegerInRange(IntPtr.Zero,Min,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomInteger(IntPtr _this,int Max);
	public static int RandomInteger(int Max)
	{
		int ___ret = RandomInteger(IntPtr.Zero,Max);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SignOfInteger(IntPtr _this,int A);
	public static int SignOfInteger(int A)
	{
		int ___ret = SignOfInteger(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Not_Int(IntPtr _this,int A);
	public static int Not_Int(int A)
	{
		int ___ret = Not_Int(IntPtr.Zero,A);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Or_IntInt(IntPtr _this,int A,int B);
	public static int Or_IntInt(int A,int B)
	{
		int ___ret = Or_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Xor_IntInt(IntPtr _this,int A,int B);
	public static int Xor_IntInt(int A,int B)
	{
		int ___ret = Xor_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int And_IntInt(IntPtr _this,int A,int B);
	public static int And_IntInt(int A,int B)
	{
		int ___ret = And_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_IntInt(IntPtr _this,int A,int B);
	public static bool NotEqual_IntInt(int A,int B)
	{
		int ___ret = NotEqual_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_IntInt(IntPtr _this,int A,int B);
	public static bool EqualEqual_IntInt(int A,int B)
	{
		int ___ret = EqualEqual_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GreaterEqual_IntInt(IntPtr _this,int A,int B);
	public static bool GreaterEqual_IntInt(int A,int B)
	{
		int ___ret = GreaterEqual_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LessEqual_IntInt(IntPtr _this,int A,int B);
	public static bool LessEqual_IntInt(int A,int B)
	{
		int ___ret = LessEqual_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Greater_IntInt(IntPtr _this,int A,int B);
	public static bool Greater_IntInt(int A,int B)
	{
		int ___ret = Greater_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Less_IntInt(IntPtr _this,int A,int B);
	public static bool Less_IntInt(int A,int B)
	{
		int ___ret = Less_IntInt(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Subtract_IntInt(IntPtr _this,int A,int B);
	public static int Subtract_IntInt(int A,int B=1)
	{
		int ___ret = Subtract_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Add_IntInt(IntPtr _this,int A,int B);
	public static int Add_IntInt(int A,int B=1)
	{
		int ___ret = Add_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Percent_IntInt(IntPtr _this,int A,int B);
	public static int Percent_IntInt(int A,int B=1)
	{
		int ___ret = Percent_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Divide_IntInt(IntPtr _this,int A,int B);
	public static int Divide_IntInt(int A,int B=1)
	{
		int ___ret = Divide_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Multiply_IntInt(IntPtr _this,int A,int B);
	public static int Multiply_IntInt(int A,int B)
	{
		int ___ret = Multiply_IntInt(IntPtr.Zero,A,B);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_ByteByte(IntPtr _this,int A,int B);
	public static bool NotEqual_ByteByte(byte A,byte B)
	{
		int ___ret = NotEqual_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_ByteByte(IntPtr _this,int A,int B);
	public static bool EqualEqual_ByteByte(byte A,byte B)
	{
		int ___ret = EqualEqual_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GreaterEqual_ByteByte(IntPtr _this,int A,int B);
	public static bool GreaterEqual_ByteByte(byte A,byte B)
	{
		int ___ret = GreaterEqual_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int LessEqual_ByteByte(IntPtr _this,int A,int B);
	public static bool LessEqual_ByteByte(byte A,byte B)
	{
		int ___ret = LessEqual_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Greater_ByteByte(IntPtr _this,int A,int B);
	public static bool Greater_ByteByte(byte A,byte B)
	{
		int ___ret = Greater_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Less_ByteByte(IntPtr _this,int A,int B);
	public static bool Less_ByteByte(byte A,byte B)
	{
		int ___ret = Less_ByteByte(IntPtr.Zero,A,B);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BMax(IntPtr _this,int A,int B);
	public static byte BMax(byte A,byte B)
	{
		int ___ret = BMax(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BMin(IntPtr _this,int A,int B);
	public static byte BMin(byte A,byte B)
	{
		int ___ret = BMin(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Subtract_ByteByte(IntPtr _this,int A,int B);
	public static byte Subtract_ByteByte(byte A,byte B=1)
	{
		int ___ret = Subtract_ByteByte(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Add_ByteByte(IntPtr _this,int A,int B);
	public static byte Add_ByteByte(byte A,byte B=1)
	{
		int ___ret = Add_ByteByte(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Percent_ByteByte(IntPtr _this,int A,int B);
	public static byte Percent_ByteByte(byte A,byte B=1)
	{
		int ___ret = Percent_ByteByte(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Divide_ByteByte(IntPtr _this,int A,int B);
	public static byte Divide_ByteByte(byte A,byte B=1)
	{
		int ___ret = Divide_ByteByte(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Multiply_ByteByte(IntPtr _this,int A,int B);
	public static byte Multiply_ByteByte(byte A,byte B)
	{
		int ___ret = Multiply_ByteByte(IntPtr.Zero,A,B);
		return (byte)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BooleanNOR(IntPtr _this,int A,int B);
	public static bool BooleanNOR(bool A,bool B)
	{
		int ___ret = BooleanNOR(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BooleanXOR(IntPtr _this,int A,int B);
	public static bool BooleanXOR(bool A,bool B)
	{
		int ___ret = BooleanXOR(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BooleanOR(IntPtr _this,int A,int B);
	public static bool BooleanOR(bool A,bool B)
	{
		int ___ret = BooleanOR(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BooleanNAND(IntPtr _this,int A,int B);
	public static bool BooleanNAND(bool A,bool B)
	{
		int ___ret = BooleanNAND(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int BooleanAND(IntPtr _this,int A,int B);
	public static bool BooleanAND(bool A,bool B)
	{
		int ___ret = BooleanAND(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int NotEqual_BoolBool(IntPtr _this,int A,int B);
	public static bool NotEqual_BoolBool(bool A,bool B)
	{
		int ___ret = NotEqual_BoolBool(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int EqualEqual_BoolBool(IntPtr _this,int A,int B);
	public static bool EqualEqual_BoolBool(bool A,bool B)
	{
		int ___ret = EqualEqual_BoolBool(IntPtr.Zero,A?1:0,B?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int Not_PreBool(IntPtr _this,int A);
	public static bool Not_PreBool(bool A)
	{
		int ___ret = Not_PreBool(IntPtr.Zero,A?1:0);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomBoolWithWeightFromStream(IntPtr _this,float Weight,ref FRandomStream RandomStream);
	public static bool RandomBoolWithWeightFromStream(float Weight,FRandomStream RandomStream)
	{
		int ___ret = RandomBoolWithWeightFromStream(IntPtr.Zero,Weight,ref RandomStream);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomBoolWithWeight(IntPtr _this,float Weight);
	public static bool RandomBoolWithWeight(float Weight)
	{
		int ___ret = RandomBoolWithWeight(IntPtr.Zero,Weight);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int RandomBool(IntPtr _this);
	public static bool RandomBool()
	{
		int ___ret = RandomBool(IntPtr.Zero);
		return ___ret!=0;
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
