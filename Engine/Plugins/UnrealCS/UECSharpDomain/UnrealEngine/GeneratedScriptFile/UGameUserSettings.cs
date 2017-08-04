//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameUserSettings:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsHDREnabled(IntPtr _this);
	public  bool IsHDREnabled()
	{
		CheckIsValid();
		int ___ret = IsHDREnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetCurrentHDRDisplayNits(IntPtr _this);
	public  int GetCurrentHDRDisplayNits()
	{
		CheckIsValid();
		int ___ret = GetCurrentHDRDisplayNits(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void EnableHDRDisplayOutput(IntPtr _this,int bEnable,int DisplayNits);
	public  void EnableHDRDisplayOutput(bool bEnable,int DisplayNits=1000)
	{
		CheckIsValid();
		EnableHDRDisplayOutput(_this.Get(),bEnable?1:0,DisplayNits);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int SupportsHDRDisplayOutput(IntPtr _this);
	public  bool SupportsHDRDisplayOutput()
	{
		CheckIsValid();
		int ___ret = SupportsHDRDisplayOutput(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyHardwareBenchmarkResults(IntPtr _this);
	public  void ApplyHardwareBenchmarkResults()
	{
		CheckIsValid();
		ApplyHardwareBenchmarkResults(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RunHardwareBenchmark(IntPtr _this,int WorkScale,float CPUMultiplier,float GPUMultiplier);
	public  void RunHardwareBenchmark(int WorkScale=10,float CPUMultiplier=1.000000f,float GPUMultiplier=1.000000f)
	{
		CheckIsValid();
		RunHardwareBenchmark(_this.Get(),WorkScale,CPUMultiplier,GPUMultiplier);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern IntPtr GetGameUserSettings(IntPtr _this);
	public static UGameUserSettings GetGameUserSettings()
	{
		IntPtr ___ret = GetGameUserSettings(IntPtr.Zero);
		if(___ret==IntPtr.Zero) return null; UGameUserSettings ___ret2= new UGameUserSettings(){ _this = ___ret }; return ___ret2;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetDefaultWindowMode(IntPtr _this);
	public static EWindowMode GetDefaultWindowMode()
	{
		int ___ret = GetDefaultWindowMode(IntPtr.Zero);
		return (EWindowMode)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntPoint GetDefaultWindowPosition(IntPtr _this);
	public static FIntPoint GetDefaultWindowPosition()
	{
		FIntPoint ___ret = GetDefaultWindowPosition(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntPoint GetDefaultResolution(IntPtr _this);
	public static FIntPoint GetDefaultResolution()
	{
		FIntPoint ___ret = GetDefaultResolution(IntPtr.Zero);
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetRecommendedResolutionScale(IntPtr _this);
	public  float GetRecommendedResolutionScale()
	{
		CheckIsValid();
		float ___ret = GetRecommendedResolutionScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetDefaultResolutionScale(IntPtr _this);
	public  float GetDefaultResolutionScale()
	{
		CheckIsValid();
		float ___ret = GetDefaultResolutionScale(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetToDefaults(IntPtr _this);
	public  void SetToDefaults()
	{
		CheckIsValid();
		SetToDefaults(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ResetToCurrentSettings(IntPtr _this);
	public  void ResetToCurrentSettings()
	{
		CheckIsValid();
		ResetToCurrentSettings(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SaveSettings(IntPtr _this);
	public  void SaveSettings()
	{
		CheckIsValid();
		SaveSettings(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void LoadSettings(IntPtr _this,int bForceReload);
	public  void LoadSettings(bool bForceReload=false)
	{
		CheckIsValid();
		LoadSettings(_this.Get(),bForceReload?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ValidateSettings(IntPtr _this);
	public  void ValidateSettings()
	{
		CheckIsValid();
		ValidateSettings(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsDirty(IntPtr _this);
	public  bool IsDirty()
	{
		CheckIsValid();
		int ___ret = IsDirty(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetFoliageQuality(IntPtr _this);
	public  int GetFoliageQuality()
	{
		CheckIsValid();
		int ___ret = GetFoliageQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFoliageQuality(IntPtr _this,int Value);
	public  void SetFoliageQuality(int Value)
	{
		CheckIsValid();
		SetFoliageQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPostProcessingQuality(IntPtr _this);
	public  int GetPostProcessingQuality()
	{
		CheckIsValid();
		int ___ret = GetPostProcessingQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetPostProcessingQuality(IntPtr _this,int Value);
	public  void SetPostProcessingQuality(int Value)
	{
		CheckIsValid();
		SetPostProcessingQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetVisualEffectQuality(IntPtr _this);
	public  int GetVisualEffectQuality()
	{
		CheckIsValid();
		int ___ret = GetVisualEffectQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVisualEffectQuality(IntPtr _this,int Value);
	public  void SetVisualEffectQuality(int Value)
	{
		CheckIsValid();
		SetVisualEffectQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetTextureQuality(IntPtr _this);
	public  int GetTextureQuality()
	{
		CheckIsValid();
		int ___ret = GetTextureQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetTextureQuality(IntPtr _this,int Value);
	public  void SetTextureQuality(int Value)
	{
		CheckIsValid();
		SetTextureQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetAntiAliasingQuality(IntPtr _this);
	public  int GetAntiAliasingQuality()
	{
		CheckIsValid();
		int ___ret = GetAntiAliasingQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAntiAliasingQuality(IntPtr _this,int Value);
	public  void SetAntiAliasingQuality(int Value)
	{
		CheckIsValid();
		SetAntiAliasingQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetShadowQuality(IntPtr _this);
	public  int GetShadowQuality()
	{
		CheckIsValid();
		int ___ret = GetShadowQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetShadowQuality(IntPtr _this,int Value);
	public  void SetShadowQuality(int Value)
	{
		CheckIsValid();
		SetShadowQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetViewDistanceQuality(IntPtr _this);
	public  int GetViewDistanceQuality()
	{
		CheckIsValid();
		int ___ret = GetViewDistanceQuality(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetViewDistanceQuality(IntPtr _this,int Value);
	public  void SetViewDistanceQuality(int Value)
	{
		CheckIsValid();
		SetViewDistanceQuality(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetResolutionScaleNormalized(IntPtr _this,float NewScaleNormalized);
	public  void SetResolutionScaleNormalized(float NewScaleNormalized)
	{
		CheckIsValid();
		SetResolutionScaleNormalized(_this.Get(),NewScaleNormalized);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetResolutionScaleValueEx(IntPtr _this,float NewScaleValue);
	public  void SetResolutionScaleValueEx(float NewScaleValue)
	{
		CheckIsValid();
		SetResolutionScaleValueEx(_this.Get(),NewScaleValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetResolutionScaleInformationEx(IntPtr _this,out float CurrentScaleNormalized,out float CurrentScaleValue,out float MinScaleValue,out float MaxScaleValue);
	public  void GetResolutionScaleInformationEx(out float CurrentScaleNormalized,out float CurrentScaleValue,out float MinScaleValue,out float MaxScaleValue)
	{
		CheckIsValid();
		GetResolutionScaleInformationEx(_this.Get(),out CurrentScaleNormalized,out CurrentScaleValue,out MinScaleValue,out MaxScaleValue);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetOverallScalabilityLevel(IntPtr _this);
	public  int GetOverallScalabilityLevel()
	{
		CheckIsValid();
		int ___ret = GetOverallScalabilityLevel(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetOverallScalabilityLevel(IntPtr _this,int Value);
	public  void SetOverallScalabilityLevel(int Value)
	{
		CheckIsValid();
		SetOverallScalabilityLevel(_this.Get(),Value);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern float GetFrameRateLimit(IntPtr _this);
	public  float GetFrameRateLimit()
	{
		CheckIsValid();
		float ___ret = GetFrameRateLimit(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFrameRateLimit(IntPtr _this,float NewLimit);
	public  void SetFrameRateLimit(float NewLimit)
	{
		CheckIsValid();
		SetFrameRateLimit(_this.Get(),NewLimit);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetAudioQualityLevel(IntPtr _this);
	public  int GetAudioQualityLevel()
	{
		CheckIsValid();
		int ___ret = GetAudioQualityLevel(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetAudioQualityLevel(IntPtr _this,int QualityLevel);
	public  void SetAudioQualityLevel(int QualityLevel)
	{
		CheckIsValid();
		SetAudioQualityLevel(_this.Get(),QualityLevel);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetBenchmarkFallbackValues(IntPtr _this);
	public  void SetBenchmarkFallbackValues()
	{
		CheckIsValid();
		SetBenchmarkFallbackValues(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void RevertVideoMode(IntPtr _this);
	public  void RevertVideoMode()
	{
		CheckIsValid();
		RevertVideoMode(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ConfirmVideoMode(IntPtr _this);
	public  void ConfirmVideoMode()
	{
		CheckIsValid();
		ConfirmVideoMode(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsVSyncDirty(IntPtr _this);
	public  bool IsVSyncDirty()
	{
		CheckIsValid();
		int ___ret = IsVSyncDirty(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsFullscreenModeDirty(IntPtr _this);
	public  bool IsFullscreenModeDirty()
	{
		CheckIsValid();
		int ___ret = IsFullscreenModeDirty(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsScreenResolutionDirty(IntPtr _this);
	public  bool IsScreenResolutionDirty()
	{
		CheckIsValid();
		int ___ret = IsScreenResolutionDirty(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int IsVSyncEnabled(IntPtr _this);
	public  bool IsVSyncEnabled()
	{
		CheckIsValid();
		int ___ret = IsVSyncEnabled(_this.Get());
		return ___ret!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetVSyncEnabled(IntPtr _this,int bEnable);
	public  void SetVSyncEnabled(bool bEnable)
	{
		CheckIsValid();
		SetVSyncEnabled(_this.Get(),bEnable?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetPreferredFullscreenMode(IntPtr _this);
	public  EWindowMode GetPreferredFullscreenMode()
	{
		CheckIsValid();
		int ___ret = GetPreferredFullscreenMode(_this.Get());
		return (EWindowMode)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetFullscreenMode(IntPtr _this,int InFullscreenMode);
	public  void SetFullscreenMode(EWindowMode InFullscreenMode)
	{
		CheckIsValid();
		SetFullscreenMode(_this.Get(),(int)InFullscreenMode);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetLastConfirmedFullscreenMode(IntPtr _this);
	public  EWindowMode GetLastConfirmedFullscreenMode()
	{
		CheckIsValid();
		int ___ret = GetLastConfirmedFullscreenMode(_this.Get());
		return (EWindowMode)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern int GetFullscreenMode(IntPtr _this);
	public  EWindowMode GetFullscreenMode()
	{
		CheckIsValid();
		int ___ret = GetFullscreenMode(_this.Get());
		return (EWindowMode)___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void SetScreenResolution(IntPtr _this,ref FIntPoint Resolution);
	public  void SetScreenResolution(FIntPoint Resolution)
	{
		CheckIsValid();
		SetScreenResolution(_this.Get(),ref Resolution);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntPoint GetDesktopResolution(IntPtr _this);
	public  FIntPoint GetDesktopResolution()
	{
		CheckIsValid();
		FIntPoint ___ret = GetDesktopResolution(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntPoint GetLastConfirmedScreenResolution(IntPtr _this);
	public  FIntPoint GetLastConfirmedScreenResolution()
	{
		CheckIsValid();
		FIntPoint ___ret = GetLastConfirmedScreenResolution(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern FIntPoint GetScreenResolution(IntPtr _this);
	public  FIntPoint GetScreenResolution()
	{
		CheckIsValid();
		FIntPoint ___ret = GetScreenResolution(_this.Get());
		return ___ret;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyResolutionSettings(IntPtr _this,int bCheckForCommandLineOverrides);
	public  void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
	{
		CheckIsValid();
		ApplyResolutionSettings(_this.Get(),bCheckForCommandLineOverrides?1:0);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplyNonResolutionSettings(IntPtr _this);
	public  void ApplyNonResolutionSettings()
	{
		CheckIsValid();
		ApplyNonResolutionSettings(_this.Get());
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ApplySettings(IntPtr _this,int bCheckForCommandLineOverrides);
	public  void ApplySettings(bool bCheckForCommandLineOverrides)
	{
		CheckIsValid();
		ApplySettings(_this.Get(),bCheckForCommandLineOverrides?1:0);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
