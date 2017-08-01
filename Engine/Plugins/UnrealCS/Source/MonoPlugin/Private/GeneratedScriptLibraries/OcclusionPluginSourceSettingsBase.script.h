#pragma once

namespace UnrealEngine
{
	class _UOcclusionPluginSourceSettingsBase
	{
		static UClass* StaticClass(){return UOcclusionPluginSourceSettingsBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOcclusionPluginSourceSettingsBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
