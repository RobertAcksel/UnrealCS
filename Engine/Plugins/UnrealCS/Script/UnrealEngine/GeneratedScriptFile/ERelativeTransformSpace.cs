using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERelativeTransformSpace:byte
	{
		RTS_World=0,
		RTS_Actor=1,
		RTS_Component=2,
		RTS_ParentBoneSpace=3,
		RTS_MAX=4,
		
	}
	
}
