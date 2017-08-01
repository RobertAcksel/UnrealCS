using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETextureMipValueMode:byte
	{
		TMVM_None=0,
		TMVM_MipLevel=1,
		TMVM_MipBias=2,
		TMVM_Derivative=3,
		TMVM_MAX=4,
		
	}
	
}
