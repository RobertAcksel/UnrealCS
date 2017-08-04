using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EEndPlayReason:byte
	{
		Destroyed=0,
		LevelTransition=1,
		EndPlayInEditor=2,
		RemovedFromWorld=3,
		Quit=4,
		EEndPlayReason_MAX=5,
		
	}
	
}
