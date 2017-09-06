//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/Engine/DocumentationActor.h"
#include "DocumentationActor_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADocumentationActor_ : public ADocumentationActor
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return ADocumentationActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADocumentationActor::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;