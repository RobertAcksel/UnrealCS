using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EStretch:byte
	{
		None=0,
		Fill=1,
		ScaleToFit=2,
		ScaleToFitX=3,
		ScaleToFitY=4,
		ScaleToFill=5,
		ScaleBySafeZone=6,
		UserSpecified=7,
		EStretch_MAX=8,
		
	}
	
}
