using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETextCommit:byte
	{
		Default=0,
		OnEnter=1,
		OnUserMovedFocus=2,
		OnCleared=3,
		ETextCommit_MAX=4,
		
	}
	
}
