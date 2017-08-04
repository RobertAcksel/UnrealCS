using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EGBufferFormat:byte
	{
		Force8BitsPerChannel=0,
		Default=1,
		HighPrecisionNormals=3,
		Force16BitsPerChannel=5,
		EGBufferFormat_MAX=6,
		
	}
	
}
