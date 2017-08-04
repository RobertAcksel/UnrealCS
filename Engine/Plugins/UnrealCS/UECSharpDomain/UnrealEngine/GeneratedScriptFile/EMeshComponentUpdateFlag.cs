using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMeshComponentUpdateFlag:byte
	{
		AlwaysTickPoseAndRefreshBones=0,
		AlwaysTickPose=1,
		OnlyTickPoseWhenRendered=2,
		EMeshComponentUpdateFlag_MAX=3,
		
	}
	
}
