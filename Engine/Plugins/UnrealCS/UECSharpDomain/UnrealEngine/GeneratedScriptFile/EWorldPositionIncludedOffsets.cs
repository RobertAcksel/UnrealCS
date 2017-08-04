using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EWorldPositionIncludedOffsets:byte
	{
		WPT_Default=0,
		WPT_ExcludeAllShaderOffsets=1,
		WPT_CameraRelative=2,
		WPT_CameraRelativeNoOffsets=3,
		WPT_MAX=4,
		
	}
	
}
