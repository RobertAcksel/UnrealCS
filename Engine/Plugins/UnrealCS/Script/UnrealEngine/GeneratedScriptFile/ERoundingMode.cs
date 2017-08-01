using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERoundingMode:byte
	{
		HalfToEven=0,
		HalfFromZero=1,
		HalfToZero=2,
		FromZero=3,
		ToZero=4,
		ToNegativeInfinity=5,
		ToPositiveInfinity=6,
		AX=7,
		
	}
	
}
