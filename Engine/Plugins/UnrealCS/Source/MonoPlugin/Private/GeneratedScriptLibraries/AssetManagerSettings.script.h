#pragma once

namespace UnrealEngine
{
	class _UAssetManagerSettings
	{
		static UClass* StaticClass(){return UAssetManagerSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAssetManagerSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
