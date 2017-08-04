using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EDOFMode:byte
	{
		Default=0,
		SixDOF=1,
		YZPlane=2,
		XZPlane=3,
		XYPlane=4,
		CustomPlane=5,
		None=6,
		EDOFMode_MAX=7,
		
	}
	
}
