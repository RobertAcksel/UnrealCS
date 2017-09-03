//GENERATED: C++ Code

#pragma once

#include "DocumentationActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ADocumentationActor_ : public ADocumentationActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ADocumentationActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADocumentationActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;