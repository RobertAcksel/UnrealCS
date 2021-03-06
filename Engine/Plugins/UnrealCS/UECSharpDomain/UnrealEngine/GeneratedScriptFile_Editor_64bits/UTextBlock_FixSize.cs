#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A simple static text widget.
	/// * No Children
	/// * Text
	/// </summary>
	public partial class UTextBlock
	{
		static readonly int Text__Offset;
		/// <summary>The text to display</summary>
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int ColorAndOpacity__Offset;
		/// <summary>The color of the text</summary>
		public FSlateColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		/// <summary>The font to render the text with</summary>
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int ShadowOffset__Offset;
		/// <summary>The direction the shadow is cast</summary>
		public FVector2D ShadowOffset
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+ShadowOffset__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowOffset__Offset, false);}
			
		}
		
		static readonly int ShadowColorAndOpacity__Offset;
		/// <summary>The color of the shadow</summary>
		public FLinearColor ShadowColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ShadowColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int MinDesiredWidth__Offset;
		/// <summary>The minimum desired size for the text</summary>
		public float MinDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredWidth__Offset, false);}
			
		}
		
		static readonly int bWrapWithInvalidationPanel__Offset;
		/// <summary>If true, it will automatically wrap this text widget with an invalidation panel</summary>
		public bool bWrapWithInvalidationPanel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWrapWithInvalidationPanel__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWrapWithInvalidationPanel__Offset, 1,0,1,255);}
			
		}
		
		static UTextBlock()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextBlock");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			ShadowOffset__Offset=GetPropertyOffset(NativeClassPtr,"ShadowOffset");
			ShadowColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ShadowColorAndOpacity");
			MinDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredWidth");
			bWrapWithInvalidationPanel__Offset=GetPropertyOffset(NativeClassPtr,"bWrapWithInvalidationPanel");
			
		}
		
	}
	
}
#endif
#endif
