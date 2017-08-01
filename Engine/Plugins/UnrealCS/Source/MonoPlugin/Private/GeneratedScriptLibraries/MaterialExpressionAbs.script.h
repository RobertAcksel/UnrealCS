#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionAbs
	{
		static UClass* StaticClass(){return UMaterialExpressionAbs::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionAbs::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
