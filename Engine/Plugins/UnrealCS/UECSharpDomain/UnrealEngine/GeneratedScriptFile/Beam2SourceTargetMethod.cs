using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum Beam2SourceTargetMethod:byte
	{
		PEB2STM_Default=0,
		PEB2STM_UserSet=1,
		PEB2STM_Emitter=2,
		PEB2STM_Particle=3,
		PEB2STM_Actor=4,
		PEB2STM_MAX=5,
		
	}
	
}
