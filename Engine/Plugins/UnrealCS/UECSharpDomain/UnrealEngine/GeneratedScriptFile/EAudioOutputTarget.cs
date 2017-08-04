using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAudioOutputTarget:byte
	{
		Speaker=0,
		Controller=1,
		ControllerFallbackToSpeaker=2,
		EAudioOutputTarget_MAX=3,
		
	}
	
}
