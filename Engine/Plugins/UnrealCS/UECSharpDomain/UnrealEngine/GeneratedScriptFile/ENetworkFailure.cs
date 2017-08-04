using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENetworkFailure:byte
	{
		NetDriverAlreadyExists=0,
		NetDriverCreateFailure=1,
		NetDriverListenFailure=2,
		ConnectionLost=3,
		ConnectionTimeout=4,
		FailureReceived=5,
		OutdatedClient=6,
		OutdatedServer=7,
		PendingConnectionFailure=8,
		NetGuidMismatch=9,
		NetChecksumMismatch=10,
		ENetworkFailure_MAX=11,
		
	}
	
}
