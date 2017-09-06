//GENERATED: CS Code
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UKismetStringTableLibrary:UBlueprintFunctionLibrary 
{
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FName[] GetMetaDataIdsFromStringTableEntry(IntPtr _this,string TableId,string Key);
	
	/// <summary>Returns an array of all meta-data IDs within the given string table entry</summary>
	public static FName[] GetMetaDataIdsFromStringTableEntry(string TableId,string Key)
	{
		FName[] ___ret = GetMetaDataIdsFromStringTableEntry(IntPtr.Zero,TableId,Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FString[] GetKeysFromStringTable(IntPtr _this,string TableId);
	
	/// <summary>Returns an array of all keys within the given string table</summary>
	public static FString[] GetKeysFromStringTable(string TableId)
	{
		FString[] ___ret = GetKeysFromStringTable(IntPtr.Zero,TableId);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FName[] GetRegisteredStringTables(IntPtr _this);
	
	/// <summary>Returns an array of all registered string table IDs</summary>
	public static FName[] GetRegisteredStringTables()
	{
		FName[] ___ret = GetRegisteredStringTables(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetTableEntryMetaData(IntPtr _this,string TableId,string Key,string MetaDataId);
	
	/// <summary>Returns the specified meta-data of the given string table entry (or an empty string).</summary>
	public static string GetTableEntryMetaData(string TableId,string Key,string MetaDataId)
	{
		string ___ret = GetTableEntryMetaData(IntPtr.Zero,TableId,Key,MetaDataId);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetTableEntrySourceString(IntPtr _this,string TableId,string Key);
	
	/// <summary>Returns the source string of the given string table entry (or an empty string).</summary>
	public static string GetTableEntrySourceString(string TableId,string Key)
	{
		string ___ret = GetTableEntrySourceString(IntPtr.Zero,TableId,Key);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern string GetTableNamespace(IntPtr _this,string TableId);
	
	/// <summary>Returns the namespace of the given string table.</summary>
	public static string GetTableNamespace(string TableId)
	{
		string ___ret = GetTableNamespace(IntPtr.Zero,TableId);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsRegisteredTableEntry(IntPtr _this,string TableId,string Key);
	
	/// <summary>Returns true if the given table ID corresponds to a registered string table, and that table has.</summary>
	public static bool IsRegisteredTableEntry(string TableId,string Key)
	{
		int ___ret = IsRegisteredTableEntry(IntPtr.Zero,TableId,Key);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsRegisteredTableId(IntPtr _this,string TableId);
	
	/// <summary>Returns true if the given table ID corresponds to a registered string table.</summary>
	public static bool IsRegisteredTableId(string TableId)
	{
		int ___ret = IsRegisteredTableId(IntPtr.Zero,TableId);
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
