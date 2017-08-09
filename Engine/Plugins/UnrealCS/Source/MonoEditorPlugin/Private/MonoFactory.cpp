// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoFactory.h"
#include "MonoEditorPluginPrivatePCH.h"

#include "MonoBlueprintGeneratedClass.h"
#include "MonoScriptBind_Component.h"
#include "MonoBlueprint.h"
#include "Kismet2/KismetEditorUtilities.h"
#include "AssetRegistryModule.h"

UMonoFactory::UMonoFactory(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	SupportedClass = UMonoBlueprint::StaticClass();
	ParentClass = UMonoScriptBind_Component::StaticClass();

	//FScriptContextBase::GetSupportedScriptFileFormats(Formats);

	bCreateNew = true;
	bEditorImport = false;
	bText = true;
	bEditAfterNew = true;
}

bool UMonoFactory::ConfigureProperties()
{
	//// Null the parent class so we can check for selection later
	//ParentClass = NULL;

	//// Load the class viewer module to display a class picker
	//FClassViewerModule& ClassViewerModule = FModuleManager::LoadModuleChecked<FClassViewerModule>("ClassViewer");

	//// Fill in options
	//FClassViewerInitializationOptions Options;
	//Options.Mode = EClassViewerMode::ClassPicker;
	//Options.DisplayMode = EClassViewerDisplayMode::TreeView;
	//Options.bShowObjectRootClass = true;
	//Options.bIsBlueprintBaseOnly = true;
	//Options.bShowUnloadedBlueprints = true;

	//const FText TitleText = NSLOCTEXT("EditorFactories", "CreateScriptOptions", "Pick Parent Class");
	//UClass* ChosenClass = NULL;
	//const bool bPressedOk = SClassPickerDialog::PickClass(TitleText, Options, ChosenClass, UScriptBlueprintGeneratedClass::StaticClass());
	//if (bPressedOk)
	//{
	//	ParentClass = ChosenClass;
	//}

	return true;
}


bool UMonoFactory::DoesSupportClass(UClass* Class)
{
	return Class == UMonoBlueprint::StaticClass();
}

//UObject* UMonoFactory::FactoryCreateText(UClass* InClass, UObject* InParent, FName InName, EObjectFlags Flags, UObject* Context, const TCHAR* Type, const TCHAR*& Buffer, const TCHAR* BufferEnd, FFeedbackContext* Warn)
//{
//	GEditor->SelectNone(true, true, false);
//
//	UMonoBlueprint* NewBlueprint = nullptr;
//	TAutoPtr<FScriptContextBase> ScriptContext(FScriptContextBase::CreateContext(Buffer, nullptr, nullptr));
//	if (ScriptContext.IsValid())
//	{
//		NewBlueprint = Cast<UMonoBlueprint>(FindObject<UBlueprint>(InParent, *InName.ToString()));
//		if (NewBlueprint != nullptr)
//		{
//			NewBlueprint->Modify();
//		}
//		else
//		{
//			NewBlueprint = CastChecked<UMonoBlueprint>(FKismetEditorUtilities::CreateBlueprint(ParentClass, InParent, InName, BPTYPE_Normal, UMonoBlueprint::StaticClass(), UScriptBlueprintGeneratedClass::StaticClass(), "UMonoFactory"));
//		}
//		NewBlueprint->SourceFilePath = FReimportManager::SanitizeImportFilename(CurrentFilename, NewBlueprint);
//		NewBlueprint->ClassName = Buffer;
//		NewBlueprint->SourceFileTimestamp = IFileManager::Get().GetTimeStamp(*NewBlueprint->SourceFilePath).ToString();
//
//		// Need to make sure we compile with the new source code
//		FKismetEditorUtilities::CompileBlueprint(NewBlueprint);
//
//		FEditorDelegates::OnAssetPostImport.Broadcast(this, NewBlueprint);
//	}
//	else
//	{
//		UE_LOG(LogScriptEditorPlugin, Warning, TEXT("Failed to import %s: could not compile script."), *CurrentFilename);
//	}
//
//	return NewBlueprint;
//}

UPackage* FindOrCreatePackage(const FString& Name)
{
    FString PackageName = TEXT("/Game/Scripts/Blueprints/") + Name;
    UPackage* ClassPackage = LoadPackage(NULL, *PackageName, 0);
    if (ClassPackage == NULL)
    {
        UE_LOG(LogMonoEditor, Log, TEXT("Create New Packgage %s"), *PackageName);
        ClassPackage = CreatePackage(NULL, *PackageName);
        ClassPackage->AddToRoot();
    }

    return ClassPackage;
}

UObject* UMonoFactory::FactoryCreateNew(UClass* InClass, UObject* InParent, FName InName, EObjectFlags Flags, UObject* Context, FFeedbackContext* Warn)
{
    //TODO: here we have to integrate support for rename and rebind functionality in case the user renames his class. the user may need to give us a hint what the old name was or another hint to unique identify a class. a unique id would be usefull here which could be done via an csharp attribute

    auto nameString = InName.ToString();
    UPackage* ClassPackage = FindOrCreatePackage(nameString);

    UMonoBlueprint* NewBlueprint = Cast<UMonoBlueprint>(FindObject<UBlueprint>(ClassPackage, *nameString));
	if (NewBlueprint != nullptr)	{
		NewBlueprint->Modify();
	}
	else
	{
        //If there is a concrete parent class
        UClass* ParentClassNew = Cast<UClass>(InParent);
        if(ParentClassNew == nullptr)        {
            //The default blueprint for the parent class is UMonoConpententClass
            //TODO: evaluate this and change this
            ParentClassNew = ParentClass;
        }

		NewBlueprint = CastChecked<UMonoBlueprint>(FKismetEditorUtilities::CreateBlueprint(ParentClassNew, ClassPackage, InName, BPTYPE_Normal, UMonoBlueprint::StaticClass(), UMonoScriptClass::StaticClass(), "UMonoFactory"));
	}
    //NewBlueprint->AssetImportData->Update(CurrentFilename);
	//NewBlueprint->SourceFilePath = FReimportManager::SanitizeImportFilename(CurrentFilename, NewBlueprint);
	NewBlueprint->ClassName = InName.ToString();
	NewBlueprint->SourceFileTimestamp = IFileManager::Get().GetTimeStamp(*NewBlueprint->SourceFilePath).ToString();
	
	// Need to make sure we compile with the new source code
	FKismetEditorUtilities::CompileBlueprint(NewBlueprint);
	
	FEditorDelegates::OnAssetPostImport.Broadcast(this, NewBlueprint);

    if (NewBlueprint)
    {
        // Notify the asset registry
        FAssetRegistryModule::AssetCreated(NewBlueprint);

        // analytics create record
        //FAssetTools::OnNewCreateRecord(ClassToUse, false);

        // Mark the package dirty...
        ClassPackage->MarkPackageDirty();
    }

    return NewBlueprint;
}