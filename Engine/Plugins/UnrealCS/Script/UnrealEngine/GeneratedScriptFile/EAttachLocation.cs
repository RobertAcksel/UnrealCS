using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAttachLocation:byte
	{
		KeepRelativeOffset=0,
		KeepWorldPosition=1,
		SnapToTarget=2,
		SnapToTargetIncludingScale=3,
		EAttachLocation_MAX=4,
		
	}
	
}
