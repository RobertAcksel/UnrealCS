using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EParticleEventType:byte
	{
		EPET_Any=0,
		EPET_Spawn=1,
		EPET_Death=2,
		EPET_Collision=3,
		EPET_Burst=4,
		EPET_Blueprint=5,
		EPET_MAX=6,
		
	}
	
}
