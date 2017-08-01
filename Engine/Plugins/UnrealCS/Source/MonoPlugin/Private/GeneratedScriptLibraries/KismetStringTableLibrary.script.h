#pragma once

namespace UnrealEngine
{
	class _UKismetStringTableLibrary
	{
		static MonoArray* GetMetaDataIdsFromStringTableEntry(UKismetStringTableLibrary* _this,MonoString* TableId,MonoString* Key)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			FString Key_temp=MonoStringToFString(Key);
			TArray<FName> ___ret = _this->GetMetaDataIdsFromStringTableEntry(TableId_temp,Key_temp);
			return TArrayToMonoArray(___ret,"UnrealEngine.FName,UnrealEngine");
			
		}
		static MonoArray* GetKeysFromStringTable(UKismetStringTableLibrary* _this,MonoString* TableId)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			TArray<FString> ___ret = _this->GetKeysFromStringTable(TableId_temp);
			return TArrayToMonoArray(___ret,"UnrealEngine.FString,UnrealEngine");
			
		}
		static MonoArray* GetRegisteredStringTables(UKismetStringTableLibrary* _this)
		{
			TArray<FName> ___ret = _this->GetRegisteredStringTables();
			return TArrayToMonoArray(___ret,"UnrealEngine.FName,UnrealEngine");
			
		}
		static MonoString* GetTableEntryMetaData(UKismetStringTableLibrary* _this,MonoString* TableId,MonoString* Key,MonoString* MetaDataId)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			FString Key_temp=MonoStringToFString(Key);
			FName MetaDataId_temp=MonoStringToFName(MetaDataId);
			FString ___ret = _this->GetTableEntryMetaData(TableId_temp,Key_temp,MetaDataId_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetTableEntrySourceString(UKismetStringTableLibrary* _this,MonoString* TableId,MonoString* Key)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			FString Key_temp=MonoStringToFString(Key);
			FString ___ret = _this->GetTableEntrySourceString(TableId_temp,Key_temp);
			return FStringToMonoString(___ret);
			
		}
		static MonoString* GetTableNamespace(UKismetStringTableLibrary* _this,MonoString* TableId)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			FString ___ret = _this->GetTableNamespace(TableId_temp);
			return FStringToMonoString(___ret);
			
		}
		static int32 IsRegisteredTableEntry(UKismetStringTableLibrary* _this,MonoString* TableId,MonoString* Key)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			FString Key_temp=MonoStringToFString(Key);
			bool ___ret = _this->IsRegisteredTableEntry(TableId_temp,Key_temp);
			return ___ret?1:0;
			
		}
		static int32 IsRegisteredTableId(UKismetStringTableLibrary* _this,MonoString* TableId)
		{
			FName TableId_temp=MonoStringToFName(TableId);
			bool ___ret = _this->IsRegisteredTableId(TableId_temp);
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return UKismetStringTableLibrary::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetMetaDataIdsFromStringTableEntry",(const void*)GetMetaDataIdsFromStringTableEntry);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetKeysFromStringTable",(const void*)GetKeysFromStringTable);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetRegisteredStringTables",(const void*)GetRegisteredStringTables);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetTableEntryMetaData",(const void*)GetTableEntryMetaData);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetTableEntrySourceString",(const void*)GetTableEntrySourceString);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::GetTableNamespace",(const void*)GetTableNamespace);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::IsRegisteredTableEntry",(const void*)IsRegisteredTableEntry);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::IsRegisteredTableId",(const void*)IsRegisteredTableId);
			mono_add_internal_call("UnrealEngine.UKismetStringTableLibrary::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
