using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialVectorCoordTransform:byte
	{
		TRANSFORM_Tangent=0,
		TRANSFORM_Local=1,
		TRANSFORM_World=2,
		TRANSFORM_View=3,
		TRANSFORM_Camera=4,
		TRANSFORM_ParticleWorld=5,
		TRANSFORM_MAX=6,
		
	}
	
}
