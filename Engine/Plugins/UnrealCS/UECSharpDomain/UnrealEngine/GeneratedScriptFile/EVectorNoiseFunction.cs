using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EVectorNoiseFunction:byte
	{
		VNF_CellnoiseALU=0,
		VNF_VectorALU=1,
		VNF_GradientALU=2,
		VNF_CurlALU=3,
		VNF_VoronoiALU=4,
		VNF_MAX=5,
		
	}
	
}
