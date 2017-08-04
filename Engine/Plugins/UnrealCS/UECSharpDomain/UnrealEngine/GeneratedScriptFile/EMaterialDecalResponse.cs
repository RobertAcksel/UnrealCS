using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialDecalResponse:byte
	{
		MDR_None=0,
		MDR_ColorNormalRoughness=1,
		MDR_Color=2,
		MDR_ColorNormal=3,
		MDR_ColorRoughness=4,
		MDR_Normal=5,
		MDR_NormalRoughness=6,
		MDR_Roughness=7,
		MDR_MAX=8,
		
	}
	
}
