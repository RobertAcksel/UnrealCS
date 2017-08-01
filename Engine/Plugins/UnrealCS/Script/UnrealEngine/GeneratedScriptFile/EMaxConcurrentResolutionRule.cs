using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaxConcurrentResolutionRule:byte
	{
		PreventNew=0,
		StopOldest=1,
		StopFarthestThenPreventNew=2,
		StopFarthestThenOldest=3,
		StopLowestPriority=4,
		StopQuietest=5,
		StopLowestPriorityThenPreventNew=6,
		EMaxConcurrentResolutionRule_MAX=7,
		
	}
	
}
