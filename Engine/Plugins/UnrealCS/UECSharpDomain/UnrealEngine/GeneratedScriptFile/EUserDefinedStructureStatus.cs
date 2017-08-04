using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EUserDefinedStructureStatus:byte
	{
		UDSS_UpToDate=0,
		UDSS_Dirty=1,
		UDSS_Error=2,
		UDSS_Duplicate=3,
		UDSS_MAX=4,
		
	}
	
}
