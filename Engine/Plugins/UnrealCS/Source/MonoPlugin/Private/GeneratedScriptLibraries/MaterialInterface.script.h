//GENERATED: C++ Code

#pragma once

namespace UnrealEngine
{
	class UMaterialInterface_
	{
		static UPhysicalMaterial* GetPhysicalMaterial(UMaterialInterface* _this)
		{
			UPhysicalMaterial* ___ret = _this->GetPhysicalMaterial();
			return ___ret;
			
		}
		static UMaterial* GetBaseMaterial(UMaterialInterface* _this)
		{
			UMaterial* ___ret = _this->GetBaseMaterial();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UMaterialInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialInterface::GetPhysicalMaterial",(const void*)GetPhysicalMaterial);
			mono_add_internal_call("UnrealEngine.UMaterialInterface::GetBaseMaterial",(const void*)GetBaseMaterial);
			mono_add_internal_call("UnrealEngine.UMaterialInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
