#pragma once

namespace UnrealEngine
{
	class _UStringTable
	{
		static UClass* StaticClass(){return UStringTable::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UStringTable::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
