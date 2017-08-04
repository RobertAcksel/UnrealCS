using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECollisionResponse:byte
	{
		ECR_Ignore=0,
		ECR_Overlap=1,
		ECR_Block=2,
		ECR_MAX=3,
		
	}
	
}
