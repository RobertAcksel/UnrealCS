using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERichCurveTangentWeightMode:byte
	{
		RCTWM_WeightedNone=0,
		RCTWM_WeightedArrive=1,
		RCTWM_WeightedLeave=2,
		RCTWM_WeightedBoth=3,
		RCTWM_MAX=4,
		
	}
	
}
