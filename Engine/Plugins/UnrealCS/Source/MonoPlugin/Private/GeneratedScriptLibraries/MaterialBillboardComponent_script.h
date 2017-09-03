//GENERATED: C++ Code

#pragma once

#include "MaterialBillboardComponent_script.generated.h"
UCLASS()
class MONOPLUGIN_API UMaterialBillboardComponent_ : public UMaterialBillboardComponent
{
	GENERATED_BODY()
	static void AddElement(UMaterialBillboardComponent* _this,UMaterialInterface* Material,UCurveFloat* DistanceToOpacityCurve,int32 bSizeIsInScreenSpace,float BaseSizeX,float BaseSizeY,UCurveFloat* DistanceToSizeCurve)
	{
		_this->AddElement(Material,DistanceToOpacityCurve,bSizeIsInScreenSpace>0?true:false,BaseSizeX,BaseSizeY,DistanceToSizeCurve);
		
	}
	static void SetElements(UMaterialBillboardComponent* _this,MonoArray* NewElements)
	{
		_this->SetElements(MonoArrayToTArray<FMaterialSpriteElement>(NewElements));
		
	}
	static UClass* StaticClass(){return UMaterialBillboardComponent::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UMaterialBillboardComponent::AddElement",(const void*)AddElement);
		mono_add_internal_call("UnrealEngine.UMaterialBillboardComponent::SetElements",(const void*)SetElements);
		mono_add_internal_call("UnrealEngine.UMaterialBillboardComponent::StaticClass",(const void*)StaticClass);
		
	}
	
}
;