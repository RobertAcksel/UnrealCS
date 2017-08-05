using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EOcclusionCombineMode:byte
	{
		/// <summary>Take the minimum occlusion value.  This is effective for avoiding over-occlusion from multiple methods, but can result in indoors looking too flat.</summary>
		OCM_Minimum=0,
		/// <summary>
		/// Multiply together occlusion values from Distance Field Ambient Occlusion and Screen Space Ambient Occlusion.
		/// This gives a good sense of depth everywhere, but can cause over-occlusion.
		/// SSAO should be tweaked to be less strong compard to Minimum.
		/// </summary>
		OCM_Multiply=1,
		OCM_MAX=2,
		
	}
	
}
