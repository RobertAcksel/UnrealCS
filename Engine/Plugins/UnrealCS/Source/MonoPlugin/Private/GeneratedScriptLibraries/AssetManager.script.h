#pragma once

namespace UnrealEngine
{
	class _UAssetManager
	{
		static UClass* StaticClass(){return UAssetManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAssetManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
