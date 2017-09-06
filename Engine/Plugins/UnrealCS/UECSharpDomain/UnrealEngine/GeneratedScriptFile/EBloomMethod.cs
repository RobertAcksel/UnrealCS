using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EBloomMethod:byte
	{
		/// <summary>Sum of Gaussian formulation</summary>
		BM_SOG=0,
		/// <summary>Fast Fourier Transform Image based convolution, intended for cinematics (too expensive for games)</summary>
		BM_FFT=1,
		BM_MAX=2,
		
	}
	
}
