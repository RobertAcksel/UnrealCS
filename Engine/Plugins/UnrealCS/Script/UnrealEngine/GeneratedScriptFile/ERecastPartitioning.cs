using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERecastPartitioning:byte
	{
		Monotone=0,
		Watershed=1,
		ChunkyMonotone=2,
		ERecastPartitioning_MAX=3,
		
	}
	
}
