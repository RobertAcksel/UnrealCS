//GENERATED: C++ Code
#pragma once

#include "CoreMinimal.h"
#include "ObjectMacros.h"
#include "MonoScriptBindHelper.h"
#include "F:/UnrealEngineSource/Engine/Source/Runtime/Engine/Classes/AI/Navigation/NavMeshRenderingComponent.h"
#include "NavMeshRenderingComponent_script.generated.h"

UCLASS()
class MONOPLUGIN_API UNavMeshRenderingComponent_ : public UNavMeshRenderingComponent
{
	GENERATED_BODY()
	static UClass* _StaticClassForProxy(){return UNavMeshRenderingComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UNavMeshRenderingComponent::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;