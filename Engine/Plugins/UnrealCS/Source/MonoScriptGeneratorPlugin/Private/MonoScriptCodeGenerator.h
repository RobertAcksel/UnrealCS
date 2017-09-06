// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

#include "ScriptCodeGeneratorBase.h"
#include "InclusionLists.h"
#include "PropertyHandler.h"
#include "MonoTextBuilder.h"
#include "Array.h"

/**
* Lua glue generator.
*/
class FMonoScriptCodeGenerator : public FScriptCodeGeneratorBase
{
	FInclusionLists BlackList;
    FInclusionLists InheritanceBlackList;

	TArray<FString> AllSourceClassHeaders;
	TArray<FString> AllScriptHeaders;
	struct ClassInfo
	{
        ///the header of the source header file beeing processed by the generator
		FString SourceHeader;
		FString ClassHeader;
		bool CanExport;
		UClass* Class;
	};
	TArray<ClassInfo> ClassInfos;
	//ȫ����
	TArray<UClass*> NeededExportedClass;
	TArray<UScriptStruct*> NeededExportedStruct;
	TArray<UEnum*> NeededExportedEnums;

	FString CSFileExportPath;
	FString GeneratedCSFile;

	PropertyHandlerFactroy Factory;
	FMonoTextBuilder CppText;
	FMonoTextBuilder CsText;

	void GlueAllGeneratedFiles();
    bool IsChildOfClassByName(UClass const *const Class, FName const name);

    //�����ṹ��
	FString GetStructNameCPP(UStruct* Class);

	/** Exports a wrapper function */
	void ExportClass(ClassInfo& ci);
	FMonoTextBuilder ExportFunction(const FString& ClassNameCPP, UClass* Class, UFunction* Function);
	void ExportEnum(UEnum* e);

	bool CollectExportInfo(UStruct* Struct);
	void CollectExportInfo(UFunction* Struct);
	void CollectExportInfo(UProperty* Property);

	virtual bool IsStructSupported(UScriptStruct* Struct);
	virtual bool IsClassSupported(UClass* Class);
	bool IsEnumSupported(UEnum* Property);
	bool IsFunctionSupported(UClass* Class, UFunction* Func);
public:

	FMonoScriptCodeGenerator(const FString& RootLocalPath, const FString& RootBuildPath, const FString& OutputDirectory, const FString& InIncludeBase);

	// FScriptCodeGeneratorBase interface
	virtual void ExportClass(UClass* Class, const FString& SourceHeaderFilename, const FString& GeneratedHeaderFilename, bool bHasChanged) override;
	virtual void FinishExport() override;
};