using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETravelFailure:byte
	{
		NoLevel=0,
		LoadMapFailure=1,
		InvalidURL=2,
		PackageMissing=3,
		PackageVersion=4,
		NoDownload=5,
		TravelFailure=6,
		CheatCommands=7,
		PendingNetGameCreateFailure=8,
		CloudSaveFailure=9,
		ServerTravelFailure=10,
		ClientTravelFailure=11,
		ETravelFailure_MAX=12,
		
	}
	
}
