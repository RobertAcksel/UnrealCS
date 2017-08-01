using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENetRole:byte
	{
		ROLE_None=0,
		ROLE_SimulatedProxy=1,
		ROLE_AutonomousProxy=2,
		ROLE_Authority=3,
		ROLE_MAX=4,
		
	}
	
}
