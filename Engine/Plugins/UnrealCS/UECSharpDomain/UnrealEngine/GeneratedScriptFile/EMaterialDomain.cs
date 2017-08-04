using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialDomain:byte
	{
		MD_Surface=0,
		MD_DeferredDecal=1,
		MD_LightFunction=2,
		MD_Volume=3,
		MD_PostProcess=4,
		MD_UI=5,
		MD_MAX=6,
		
	}
	
}
