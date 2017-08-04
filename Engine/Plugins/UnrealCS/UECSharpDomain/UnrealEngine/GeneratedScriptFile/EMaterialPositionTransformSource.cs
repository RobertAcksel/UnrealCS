using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaterialPositionTransformSource:byte
	{
		TRANSFORMPOSSOURCE_Local=0,
		TRANSFORMPOSSOURCE_World=1,
		TRANSFORMPOSSOURCE_TranslatedWorld=2,
		TRANSFORMPOSSOURCE_View=3,
		TRANSFORMPOSSOURCE_Camera=4,
		TRANSFORMPOSSOURCE_Particle=5,
		TRANSFORMPOSSOURCE_MAX=6,
		
	}
	
}
