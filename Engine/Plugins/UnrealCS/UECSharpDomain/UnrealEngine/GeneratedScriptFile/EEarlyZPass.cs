using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EEarlyZPass:byte
	{
		None=0,
		OpaqueOnly=1,
		OpaqueAndMasked=2,
		Auto=3,
		EEarlyZPass_MAX=4,
		
	}
	
}
