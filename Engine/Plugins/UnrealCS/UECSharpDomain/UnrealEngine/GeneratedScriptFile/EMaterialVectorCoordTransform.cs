using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialVectorCoordTransform:byte
	{
		/// <summary>Tangent space (relative to the surface)</summary>
		TRANSFORM_Tangent=0,
		/// <summary>Local space (relative to the rendered object, = object space)</summary>
		TRANSFORM_Local=1,
		/// <summary>World space, a unit is 1cm</summary>
		TRANSFORM_World=2,
		/// <summary>View space (relative to the camera/eye, = camera space, differs from camera space in the shadow passes)</summary>
		TRANSFORM_View=3,
		/// <summary>Camera space</summary>
		TRANSFORM_Camera=4,
		/// <summary>Particle space</summary>
		TRANSFORM_ParticleWorld=5,
		TRANSFORM_MAX=6,
		
	}
	
}
