using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialVectorCoordTransformSource:byte
	{
		TRANSFORMSOURCE_Tangent=0,
		TRANSFORMSOURCE_Local=1,
		TRANSFORMSOURCE_World=2,
		TRANSFORMSOURCE_View=3,
		TRANSFORMSOURCE_Camera=4,
		TRANSFORMSOURCE_ParticleWorld=5,
		TRANSFORMSOURCE_MAX=6,
		
	}
	
}
