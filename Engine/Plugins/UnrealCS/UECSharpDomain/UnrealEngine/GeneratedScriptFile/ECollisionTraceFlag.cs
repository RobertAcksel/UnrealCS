using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECollisionTraceFlag:byte
	{
		CTF_UseDefault=0,
		CTF_UseSimpleAndComplex=1,
		CTF_UseSimpleAsComplex=2,
		CTF_UseComplexAsSimple=3,
		CTF_MAX=4,
		
	}
	
}
