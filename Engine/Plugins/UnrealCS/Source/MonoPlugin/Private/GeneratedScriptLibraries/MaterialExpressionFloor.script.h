#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFloor
	{
		static UClass* StaticClass(){return UMaterialExpressionFloor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFloor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
