//GENERATED: C++ Code

#pragma once

#include "TextRenderActor_script.generated.h"
UCLASS()
class MONOPLUGIN_API ATextRenderActor_ : public ATextRenderActor
{
	GENERATED_BODY()
	static UClass* StaticClass(){return ATextRenderActor::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ATextRenderActor::StaticClass",(const void*)StaticClass);
		
	}
	
}
;