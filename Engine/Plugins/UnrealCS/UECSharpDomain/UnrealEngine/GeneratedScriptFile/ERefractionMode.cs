using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Determines how the refraction offset should be computed for the material.</summary>
	public enum ERefractionMode:byte
	{
		/// <summary>
		/// Refraction is computed based on the camera vector entering a medium whose index of refraction is defined by the Refraction material input.
		/// The new medium's surface is defined by the material's normal.  With this mode, a flat plane seen from the side will have a constant refraction offset.
		/// This is a physical model of refraction but causes reading outside the scene color texture so is a poor fit for large refractive surfaces like water.
		/// </summary>
		RM_IndexOfRefraction=0,
		/// <summary>
		/// The refraction offset into Scene Color is computed based on the difference between the per-pixel normal and the per-vertex normal.
		/// With this mode, a material whose normal is the default (0, 0, 1) will never cause any refraction.  This mode is only valid with tangent space normals.
		/// The refraction material input scales the offset, although a value of 1.0 maps to no refraction, and a value of 2 maps to a scale of 1.0 on the offset.
		/// This is a non-physical model of refraction but is useful on large refractive surfaces like water, since offsets have to stay small to avoid reading outside scene color.
		/// </summary>
		RM_PixelNormalOffset=1,
		RM_MAX=2,
		
	}
	
}
