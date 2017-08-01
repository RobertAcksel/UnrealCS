using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERootMotionMode:byte
	{
		NoRootMotionExtraction=0,
		IgnoreRootMotion=1,
		RootMotionFromEverything=2,
		RootMotionFromMontagesOnly=3,
		ERootMotionMode_MAX=4,
		
	}
	
}
