//GENERATED: C++ Code

#pragma once

#include "GameSession_script.generated.h"
UCLASS()
class MONOPLUGIN_API AGameSession_ : public AGameSession
{
	GENERATED_BODY()
	static UClass* StaticClass(){return AGameSession::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.AGameSession::StaticClass",(const void*)StaticClass);
		
	}
	
}
;