using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESplinePointType:byte
	{
		Linear=0,
		Curve=1,
		Constant=2,
		CurveClamped=3,
		CurveCustomTangent=4,
		ESplinePointType_MAX=5,
		
	}
	
}
