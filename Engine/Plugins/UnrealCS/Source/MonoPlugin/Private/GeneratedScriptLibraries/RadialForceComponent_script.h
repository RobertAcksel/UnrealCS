//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/PhysicsEngine/RadialForceComponent.h"
#include "RadialForceComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API URadialForceComponent_ : public URadialForceComponent
{
	GENERATED_BODY()
	static void RemoveObjectTypeToAffect(URadialForceComponent* _this,int32 ObjectType)
	{
		_this->RemoveObjectTypeToAffect((TEnumAsByte<EObjectTypeQuery>)ObjectType);
		
	}
	static void AddObjectTypeToAffect(URadialForceComponent* _this,int32 ObjectType)
	{
		_this->AddObjectTypeToAffect((TEnumAsByte<EObjectTypeQuery>)ObjectType);
		
	}
	static void FireImpulse(URadialForceComponent* _this)
	{
		_this->FireImpulse();
		
	}
	static UClass* _StaticClassForProxy(){return URadialForceComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.URadialForceComponent::RemoveObjectTypeToAffect",(const void*)RemoveObjectTypeToAffect);
		mono_add_internal_call("UnrealEngine.URadialForceComponent::AddObjectTypeToAffect",(const void*)AddObjectTypeToAffect);
		mono_add_internal_call("UnrealEngine.URadialForceComponent::FireImpulse",(const void*)FireImpulse);
		mono_add_internal_call("UnrealEngine.URadialForceComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;