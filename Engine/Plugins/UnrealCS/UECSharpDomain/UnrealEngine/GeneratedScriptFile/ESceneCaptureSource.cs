using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESceneCaptureSource:byte
	{
		SCS_SceneColorHDR=0,
		SCS_SceneColorHDRNoAlpha=1,
		SCS_FinalColorLDR=2,
		SCS_SceneColorSceneDepth=3,
		SCS_SceneDepth=4,
		SCS_DeviceDepth=5,
		SCS_Normal=6,
		SCS_BaseColor=7,
		SCS_MAX=8,
		
	}
	
}
