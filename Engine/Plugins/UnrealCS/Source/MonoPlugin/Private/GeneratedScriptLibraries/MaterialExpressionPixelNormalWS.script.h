#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionPixelNormalWS
	{
		static UClass* StaticClass(){return UMaterialExpressionPixelNormalWS::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionPixelNormalWS::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
