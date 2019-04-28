// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

namespace UnrealEngine
{
	public  partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UTextRenderComponent(UObject Parent = null, string Name = "TextRenderComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTextRenderComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_HorizSpacingAdjust_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_HorizSpacingAdjust_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_InvDefaultSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_InvDefaultSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UTextRenderComponent_Text_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_Text_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_VertSpacingAdjust_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_VertSpacingAdjust_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_WorldSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_WorldSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_XScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_XScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UTextRenderComponent_YScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UTextRenderComponent_YScale_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTextRenderComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UTextRenderComponent_GetTextLocalSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UTextRenderComponent_GetTextWorldSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_InitializeMIDCache(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_K2_SetText(IntPtr self, string value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetHorizontalAlignment(IntPtr self, byte value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetHorizSpacingAdjust(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetText(IntPtr self, string value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetText_o1(IntPtr self, string value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetVerticalAlignment(IntPtr self, byte value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetVertSpacingAdjust(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetWorldSize(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetXScale(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_SetYScale(IntPtr self, float value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UTextRenderComponent_ShutdownMIDCache(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Horizontal adjustment per character, default is 0.0 </para>
		/// </summary>
		public float HorizSpacingAdjust
		{
			get => E_PROP_UTextRenderComponent_HorizSpacingAdjust_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_HorizSpacingAdjust_SET(NativePointer, value);
		}

		public float InvDefaultSize
		{
			get => E_PROP_UTextRenderComponent_InvDefaultSize_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_InvDefaultSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Text content, can be multi line using <br> as line separator </para>
		/// </summary>
		public string Text
		{
			get => E_PROP_UTextRenderComponent_Text_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_Text_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vertical adjustment per character, default is 0.0 </para>
		/// </summary>
		public float VertSpacingAdjust
		{
			get => E_PROP_UTextRenderComponent_VertSpacingAdjust_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_VertSpacingAdjust_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vertical size of the fonts largest character in world units. Transform, XScale and YScale will affect final size. </para>
		/// </summary>
		public float WorldSize
		{
			get => E_PROP_UTextRenderComponent_WorldSize_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_WorldSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Horizontal scale, default is 1.0 </para>
		/// </summary>
		public float XScale
		{
			get => E_PROP_UTextRenderComponent_XScale_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_XScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vertical scale, default is 1.0 </para>
		/// </summary>
		public float YScale
		{
			get => E_PROP_UTextRenderComponent_YScale_GET(NativePointer);
			set => E_PROP_UTextRenderComponent_YScale_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Get local size of text </para>
		/// </summary>
		public FVector GetTextLocalSize()
			=> E_UTextRenderComponent_GetTextLocalSize(this);
		
		
		/// <summary>
		/// <para>Get world space size of text </para>
		/// </summary>
		public FVector GetTextWorldSize()
			=> E_UTextRenderComponent_GetTextWorldSize(this);
		
		public void InitializeMIDCache()
			=> E_UTextRenderComponent_InitializeMIDCache(this);
		
		
		/// <summary>
		/// <para>Change the text value and signal the primitives to be rebuilt </para>
		/// </summary>
		public void K2_SetText(string value)
			=> E_UTextRenderComponent_K2_SetText(this, value);
		
		
		/// <summary>
		/// <para>Change the horizontal alignment and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetHorizontalAlignment(EHorizTextAligment value)
			=> E_UTextRenderComponent_SetHorizontalAlignment(this, (byte)value);
		
		
		/// <summary>
		/// <para>Change the text horizontal spacing adjustment and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetHorizSpacingAdjust(float value)
			=> E_UTextRenderComponent_SetHorizSpacingAdjust(this, value);
		
		
		/// <summary>
		/// <para>Change the text value and signal the primitives to be rebuilt </para>
		/// <para>The FString variant is deprecated in favor of the FText variant </para>
		/// </summary>
		public void SetTextString(string value)
			=> E_UTextRenderComponent_SetText(this, value);
		
		
		/// <summary>
		/// <para>Change the text value and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetText(string value)
			=> E_UTextRenderComponent_SetText_o1(this, value);
		
		
		/// <summary>
		/// <para>Change the vertical alignment and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetVerticalAlignment(EVerticalTextAligment value)
			=> E_UTextRenderComponent_SetVerticalAlignment(this, (byte)value);
		
		
		/// <summary>
		/// <para>Change the text vertical spacing adjustment and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetVertSpacingAdjust(float value)
			=> E_UTextRenderComponent_SetVertSpacingAdjust(this, value);
		
		
		/// <summary>
		/// <para>Change the world size of the text and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetWorldSize(float value)
			=> E_UTextRenderComponent_SetWorldSize(this, value);
		
		
		/// <summary>
		/// <para>Change the text X scale and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetXScale(float value)
			=> E_UTextRenderComponent_SetXScale(this, value);
		
		
		/// <summary>
		/// <para>Change the text Y scale and signal the primitives to be rebuilt </para>
		/// </summary>
		public void SetYScale(float value)
			=> E_UTextRenderComponent_SetYScale(this, value);
		
		public void ShutdownMIDCache()
			=> E_UTextRenderComponent_ShutdownMIDCache(this);
		
		#endregion
		
		public static implicit operator IntPtr(UTextRenderComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTextRenderComponent>(PtrDesc);
		}}}
