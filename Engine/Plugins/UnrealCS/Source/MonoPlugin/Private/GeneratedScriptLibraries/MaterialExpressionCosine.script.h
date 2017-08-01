#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionCosine
	{
		static UClass* StaticClass(){return UMaterialExpressionCosine::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionCosine::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
