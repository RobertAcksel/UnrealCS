#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSegmentCompilerTestSection
	{
		static UClass* StaticClass(){return UMovieSceneSegmentCompilerTestSection::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSegmentCompilerTestSection::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
