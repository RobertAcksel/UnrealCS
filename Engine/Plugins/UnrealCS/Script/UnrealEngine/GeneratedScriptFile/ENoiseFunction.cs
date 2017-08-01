using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENoiseFunction:byte
	{
		NOISEFUNCTION_SimplexTex=0,
		NOISEFUNCTION_GradientTex=1,
		NOISEFUNCTION_GradientTex3D=2,
		NOISEFUNCTION_GradientALU=3,
		NOISEFUNCTION_ValueALU=4,
		NOISEFUNCTION_VoronoiALU=5,
		NOISEFUNCTION_MAX=6,
		
	}
	
}
