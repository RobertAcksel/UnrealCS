//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/GameFramework/DefaultPawn.h"
#include "DefaultPawn_script.generated.h"

UCLASS()
class MONOPLUGIN_API ADefaultPawn_ : public ADefaultPawn
{
	GENERATED_BODY()
	static void LookUpAtRate(ADefaultPawn* _this,float Rate)
	{
		_this->LookUpAtRate(Rate);
		
	}
	static void TurnAtRate(ADefaultPawn* _this,float Rate)
	{
		_this->TurnAtRate(Rate);
		
	}
	static void MoveUp_World(ADefaultPawn* _this,float Val)
	{
		_this->MoveUp_World(Val);
		
	}
	static void MoveRight(ADefaultPawn* _this,float Val)
	{
		_this->MoveRight(Val);
		
	}
	static void MoveForward(ADefaultPawn* _this,float Val)
	{
		_this->MoveForward(Val);
		
	}
	static UClass* _StaticClassForProxy(){return ADefaultPawn::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.ADefaultPawn::LookUpAtRate",(const void*)LookUpAtRate);
		mono_add_internal_call("UnrealEngine.ADefaultPawn::TurnAtRate",(const void*)TurnAtRate);
		mono_add_internal_call("UnrealEngine.ADefaultPawn::MoveUp_World",(const void*)MoveUp_World);
		mono_add_internal_call("UnrealEngine.ADefaultPawn::MoveRight",(const void*)MoveRight);
		mono_add_internal_call("UnrealEngine.ADefaultPawn::MoveForward",(const void*)MoveForward);
		mono_add_internal_call("UnrealEngine.ADefaultPawn::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;