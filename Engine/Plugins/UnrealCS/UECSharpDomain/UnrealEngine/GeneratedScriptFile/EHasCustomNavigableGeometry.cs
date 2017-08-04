using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EHasCustomNavigableGeometry:byte
	{
		No=0,
		Yes=1,
		EvenIfNotCollidable=2,
		DontExport=3,
		EHasCustomNavigableGeometry_MAX=4,
		
	}
	
}
