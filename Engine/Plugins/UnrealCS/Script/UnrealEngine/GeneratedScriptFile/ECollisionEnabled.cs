using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ECollisionEnabled:byte
	{
		NoCollision=0,
		QueryOnly=1,
		PhysicsOnly=2,
		QueryAndPhysics=3,
		ECollisionEnabled_MAX=4,
		
	}
	
}
