using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EParticleAxisLock:byte
	{
		EPAL_NONE=0,
		EPAL_X=1,
		EPAL_Y=2,
		EPAL_Z=3,
		EPAL_NEGATIVE_X=4,
		EPAL_NEGATIVE_Y=5,
		EPAL_NEGATIVE_Z=6,
		EPAL_ROTATE_X=7,
		EPAL_ROTATE_Y=8,
		EPAL_ROTATE_Z=9,
		EPAL_MAX=10,
		
	}
	
}