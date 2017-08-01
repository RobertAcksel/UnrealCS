#pragma once

namespace UnrealEngine
{
	class _UPrimaryAssetLabel
	{
		static UClass* StaticClass(){return UPrimaryAssetLabel::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPrimaryAssetLabel::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
