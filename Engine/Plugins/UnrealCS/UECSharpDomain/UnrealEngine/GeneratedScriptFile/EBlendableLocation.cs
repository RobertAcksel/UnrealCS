using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EBlendableLocation:byte
	{
		BL_AfterTonemapping=0,
		BL_BeforeTonemapping=1,
		BL_BeforeTranslucency=2,
		BL_ReplacingTonemapper=3,
		BL_MAX=4,
		
	}
	
}
