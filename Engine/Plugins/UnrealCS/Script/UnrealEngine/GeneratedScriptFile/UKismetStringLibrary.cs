//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetStringLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TimeSecondsToString(IntPtr _this,float InSeconds);
public static string TimeSecondsToString(float InSeconds)
{
	string ___ret = TimeSecondsToString(IntPtr.Zero,InSeconds);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Mid(IntPtr _this,string SourceString,int Start,int Count);
public static string Mid(string SourceString,int Start,int Count)
{
	string ___ret = Mid(IntPtr.Zero,SourceString,Start,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string RightChop(IntPtr _this,string SourceString,int Count);
public static string RightChop(string SourceString,int Count)
{
	string ___ret = RightChop(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Right(IntPtr _this,string SourceString,int Count);
public static string Right(string SourceString,int Count)
{
	string ___ret = Right(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string LeftChop(IntPtr _this,string SourceString,int Count);
public static string LeftChop(string SourceString,int Count)
{
	string ___ret = LeftChop(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Left(IntPtr _this,string SourceString,int Count);
public static string Left(string SourceString,int Count)
{
	string ___ret = Left(IntPtr.Zero,SourceString,Count);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Split(IntPtr _this,string SourceString,string InStr,out string LeftS,out string RightS,int SearchCase,int SearchDir);
public static bool Split(string SourceString,string InStr,out string LeftS,out string RightS,ESearchCase SearchCase=ESearchCase.IgnoreCase,ESearchDir SearchDir=ESearchDir.FromStart)
{
	int ___ret = Split(IntPtr.Zero,SourceString,InStr,out LeftS,out RightS,(int)SearchCase,(int)SearchDir);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int ReplaceInline(IntPtr _this,out string SourceString,string SearchText,string ReplacementText,int SearchCase);
public static int ReplaceInline(out string SourceString,string SearchText,string ReplacementText,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = ReplaceInline(IntPtr.Zero,out SourceString,SearchText,ReplacementText,(int)SearchCase);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Replace(IntPtr _this,string SourceString,string From,string To,int SearchCase);
public static string Replace(string SourceString,string From,string To,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	string ___ret = Replace(IntPtr.Zero,SourceString,From,To,(int)SearchCase);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Reverse(IntPtr _this,string SourceString);
public static string Reverse(string SourceString)
{
	string ___ret = Reverse(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int CullArray(IntPtr _this,string SourceString,out FString[] InArray);
public static int CullArray(string SourceString,out FString[] InArray)
{
	int ___ret = CullArray(IntPtr.Zero,SourceString,out InArray);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string TrimTrailing(IntPtr _this,string SourceString);
public static string TrimTrailing(string SourceString)
{
	string ___ret = TrimTrailing(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Trim(IntPtr _this,string SourceString);
public static string Trim(string SourceString)
{
	string ___ret = Trim(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int MatchesWildcard(IntPtr _this,string SourceString,string Wildcard,int SearchCase);
public static bool MatchesWildcard(string SourceString,string Wildcard,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = MatchesWildcard(IntPtr.Zero,SourceString,Wildcard,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EndsWith(IntPtr _this,string SourceString,string InSuffix,int SearchCase);
public static bool EndsWith(string SourceString,string InSuffix,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = EndsWith(IntPtr.Zero,SourceString,InSuffix,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int StartsWith(IntPtr _this,string SourceString,string InPrefix,int SearchCase);
public static bool StartsWith(string SourceString,string InPrefix,ESearchCase SearchCase=ESearchCase.IgnoreCase)
{
	int ___ret = StartsWith(IntPtr.Zero,SourceString,InPrefix,(int)SearchCase);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsNumeric(IntPtr _this,string SourceString);
public static bool IsNumeric(string SourceString)
{
	int ___ret = IsNumeric(IntPtr.Zero,SourceString);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string RightPad(IntPtr _this,string SourceString,int ChCount);
public static string RightPad(string SourceString,int ChCount)
{
	string ___ret = RightPad(IntPtr.Zero,SourceString,ChCount);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string LeftPad(IntPtr _this,string SourceString,int ChCount);
public static string LeftPad(string SourceString,int ChCount)
{
	string ___ret = LeftPad(IntPtr.Zero,SourceString,ChCount);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string ToLower(IntPtr _this,string SourceString);
public static string ToLower(string SourceString)
{
	string ___ret = ToLower(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string ToUpper(IntPtr _this,string SourceString);
public static string ToUpper(string SourceString)
{
	string ___ret = ToUpper(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FString[] GetCharacterArrayFromString(IntPtr _this,string SourceString);
public static FString[] GetCharacterArrayFromString(string SourceString)
{
	FString[] ___ret = GetCharacterArrayFromString(IntPtr.Zero,SourceString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string JoinStringArray(IntPtr _this,FString[] SourceArray,string Separator);
public static string JoinStringArray(FString[] SourceArray,string Separator=" ")
{
	string ___ret = JoinStringArray(IntPtr.Zero,SourceArray,Separator);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FString[] ParseIntoArray(IntPtr _this,string SourceString,string Delimiter,int CullEmptyStrings);
public static FString[] ParseIntoArray(string SourceString,string Delimiter=" ",bool CullEmptyStrings=true)
{
	FString[] ___ret = ParseIntoArray(IntPtr.Zero,SourceString,Delimiter,CullEmptyStrings?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCharacterAsNumber(IntPtr _this,string SourceString,int Index);
public static int GetCharacterAsNumber(string SourceString,int Index=0)
{
	int ___ret = GetCharacterAsNumber(IntPtr.Zero,SourceString,Index);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Contains(IntPtr _this,string SearchIn,string Substring,int bUseCase,int bSearchFromEnd);
public static bool Contains(string SearchIn,string Substring,bool bUseCase=false,bool bSearchFromEnd=false)
{
	int ___ret = Contains(IntPtr.Zero,SearchIn,Substring,bUseCase?1:0,bSearchFromEnd?1:0);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int FindSubstring(IntPtr _this,string SearchIn,string Substring,int bUseCase,int bSearchFromEnd,int StartPosition);
public static int FindSubstring(string SearchIn,string Substring,bool bUseCase=false,bool bSearchFromEnd=false,int StartPosition=-1)
{
	int ___ret = FindSubstring(IntPtr.Zero,SearchIn,Substring,bUseCase?1:0,bSearchFromEnd?1:0,StartPosition);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetSubstring(IntPtr _this,string SourceString,int StartIndex,int Length);
public static string GetSubstring(string SourceString,int StartIndex=0,int Length=1)
{
	string ___ret = GetSubstring(IntPtr.Zero,SourceString,StartIndex,Length);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Len(IntPtr _this,string S);
public static int Len(string S)
{
	int ___ret = Len(IntPtr.Zero,S);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_StriStri(IntPtr _this,string A,string B);
public static bool NotEqual_StriStri(string A,string B)
{
	int ___ret = NotEqual_StriStri(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int NotEqual_StrStr(IntPtr _this,string A,string B);
public static bool NotEqual_StrStr(string A,string B)
{
	int ___ret = NotEqual_StrStr(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_StriStri(IntPtr _this,string A,string B);
public static bool EqualEqual_StriStri(string A,string B)
{
	int ___ret = EqualEqual_StriStri(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int EqualEqual_StrStr(IntPtr _this,string A,string B);
public static bool EqualEqual_StrStr(string A,string B)
{
	int ___ret = EqualEqual_StrStr(IntPtr.Zero,A,B);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Concat_StrStr(IntPtr _this,string A,string B);
public static string Concat_StrStr(string A,string B)
{
	string ___ret = Concat_StrStr(IntPtr.Zero,A,B);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Name(IntPtr _this,string AppendTo,string Prefix,string InName,string Suffix);
public static string BuildString_Name(string AppendTo,string Prefix,string InName,string Suffix)
{
	string ___ret = BuildString_Name(IntPtr.Zero,AppendTo,Prefix,InName,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Color(IntPtr _this,string AppendTo,string Prefix,ref FLinearColor InColor,string Suffix);
public static string BuildString_Color(string AppendTo,string Prefix,FLinearColor InColor,string Suffix)
{
	string ___ret = BuildString_Color(IntPtr.Zero,AppendTo,Prefix,ref InColor,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Object(IntPtr _this,string AppendTo,string Prefix,IntPtr InObj,string Suffix);
public static string BuildString_Object(string AppendTo,string Prefix,UObject InObj,string Suffix)
{
	string ___ret = BuildString_Object(IntPtr.Zero,AppendTo,Prefix,InObj,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Rotator(IntPtr _this,string AppendTo,string Prefix,ref FRotator InRot,string Suffix);
public static string BuildString_Rotator(string AppendTo,string Prefix,FRotator InRot,string Suffix)
{
	string ___ret = BuildString_Rotator(IntPtr.Zero,AppendTo,Prefix,ref InRot,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Vector2d(IntPtr _this,string AppendTo,string Prefix,ref FVector2D InVector2d,string Suffix);
public static string BuildString_Vector2d(string AppendTo,string Prefix,FVector2D InVector2d,string Suffix)
{
	string ___ret = BuildString_Vector2d(IntPtr.Zero,AppendTo,Prefix,ref InVector2d,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_IntVector(IntPtr _this,string AppendTo,string Prefix,ref FIntVector InIntVector,string Suffix);
public static string BuildString_IntVector(string AppendTo,string Prefix,FIntVector InIntVector,string Suffix)
{
	string ___ret = BuildString_IntVector(IntPtr.Zero,AppendTo,Prefix,ref InIntVector,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Vector(IntPtr _this,string AppendTo,string Prefix,ref FVector InVector,string Suffix);
public static string BuildString_Vector(string AppendTo,string Prefix,FVector InVector,string Suffix)
{
	string ___ret = BuildString_Vector(IntPtr.Zero,AppendTo,Prefix,ref InVector,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Bool(IntPtr _this,string AppendTo,string Prefix,int InBool,string Suffix);
public static string BuildString_Bool(string AppendTo,string Prefix,bool InBool,string Suffix)
{
	string ___ret = BuildString_Bool(IntPtr.Zero,AppendTo,Prefix,InBool?1:0,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Int(IntPtr _this,string AppendTo,string Prefix,int InInt,string Suffix);
public static string BuildString_Int(string AppendTo,string Prefix,int InInt,string Suffix)
{
	string ___ret = BuildString_Int(IntPtr.Zero,AppendTo,Prefix,InInt,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string BuildString_Float(IntPtr _this,string AppendTo,string Prefix,float InFloat,string Suffix);
public static string BuildString_Float(string AppendTo,string Prefix,float InFloat,string Suffix)
{
	string ___ret = BuildString_Float(IntPtr.Zero,AppendTo,Prefix,InFloat,Suffix);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToColor(IntPtr _this,string InString,out FLinearColor OutConvertedColor,out int OutIsValid);
public static void Conv_StringToColor(string InString,out FLinearColor OutConvertedColor,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToColor(IntPtr.Zero,InString,out OutConvertedColor,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToRotator(IntPtr _this,string InString,out FRotator OutConvertedRotator,out int OutIsValid);
public static void Conv_StringToRotator(string InString,out FRotator OutConvertedRotator,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToRotator(IntPtr.Zero,InString,out OutConvertedRotator,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToVector2D(IntPtr _this,string InString,out FVector2D OutConvertedVector2D,out int OutIsValid);
public static void Conv_StringToVector2D(string InString,out FVector2D OutConvertedVector2D,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToVector2D(IntPtr.Zero,InString,out OutConvertedVector2D,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Conv_StringToVector(IntPtr _this,string InString,out FVector OutConvertedVector,out int OutIsValid);
public static void Conv_StringToVector(string InString,out FVector OutConvertedVector,out bool OutIsValid)
{
	int OutIsValid_temp;
	Conv_StringToVector(IntPtr.Zero,InString,out OutConvertedVector,out OutIsValid_temp);
	OutIsValid=OutIsValid_temp!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float Conv_StringToFloat(IntPtr _this,string InString);
public static float Conv_StringToFloat(string InString)
{
	float ___ret = Conv_StringToFloat(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int Conv_StringToInt(IntPtr _this,string InString);
public static int Conv_StringToInt(string InString)
{
	int ___ret = Conv_StringToInt(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_StringToName(IntPtr _this,string InString);
public static string Conv_StringToName(string InString)
{
	string ___ret = Conv_StringToName(IntPtr.Zero,InString);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_NameToString(IntPtr _this,string InName);
public static string Conv_NameToString(string InName)
{
	string ___ret = Conv_NameToString(IntPtr.Zero,InName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ColorToString(IntPtr _this,ref FLinearColor InColor);
public static string Conv_ColorToString(FLinearColor InColor)
{
	string ___ret = Conv_ColorToString(IntPtr.Zero,ref InColor);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ObjectToString(IntPtr _this,IntPtr InObj);
public static string Conv_ObjectToString(UObject InObj)
{
	string ___ret = Conv_ObjectToString(IntPtr.Zero,InObj);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_TransformToString(IntPtr _this,ref FTransform InTrans);
public static string Conv_TransformToString(FTransform InTrans)
{
	string ___ret = Conv_TransformToString(IntPtr.Zero,ref InTrans);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_RotatorToString(IntPtr _this,ref FRotator InRot);
public static string Conv_RotatorToString(FRotator InRot)
{
	string ___ret = Conv_RotatorToString(IntPtr.Zero,ref InRot);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_Vector2dToString(IntPtr _this,ref FVector2D InVec);
public static string Conv_Vector2dToString(FVector2D InVec)
{
	string ___ret = Conv_Vector2dToString(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_IntVectorToString(IntPtr _this,ref FIntVector InIntVec);
public static string Conv_IntVectorToString(FIntVector InIntVec)
{
	string ___ret = Conv_IntVectorToString(IntPtr.Zero,ref InIntVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_VectorToString(IntPtr _this,ref FVector InVec);
public static string Conv_VectorToString(FVector InVec)
{
	string ___ret = Conv_VectorToString(IntPtr.Zero,ref InVec);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_BoolToString(IntPtr _this,int InBool);
public static string Conv_BoolToString(bool InBool)
{
	string ___ret = Conv_BoolToString(IntPtr.Zero,InBool?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_ByteToString(IntPtr _this,int InByte);
public static string Conv_ByteToString(byte InByte)
{
	string ___ret = Conv_ByteToString(IntPtr.Zero,InByte);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_IntToString(IntPtr _this,int InInt);
public static string Conv_IntToString(int InInt)
{
	string ___ret = Conv_IntToString(IntPtr.Zero,InInt);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string Conv_FloatToString(IntPtr _this,float InFloat);
public static string Conv_FloatToString(float InFloat)
{
	string ___ret = Conv_FloatToString(IntPtr.Zero,InFloat);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
