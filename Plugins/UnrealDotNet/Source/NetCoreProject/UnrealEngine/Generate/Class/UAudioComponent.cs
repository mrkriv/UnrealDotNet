using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

namespace UnrealEngine
{
	public  partial class UAudioComponent : USceneComponent
	{
		public UAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UAudioComponent(UObject Parent = null, string Name = "AudioComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAudioComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAudioComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachLocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachLocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachRotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachRotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_AutoAttachScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachScaleRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UAudioComponent_AutoAttachSocketName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_AutoAttachSocketName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UAudioComponent_bAutoManageAttachment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAudioComponent_bAutoManageAttachment_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAudioComponent_GetAudioComponentUserID(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_PlayInternal(IntPtr Self, float StartTime, float FadeInDuration, float FadeVolumeLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAudioComponent_SetSoundParameter(IntPtr Self, IntPtr Param);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachLocationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachLocationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachLocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our rotation when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachRotationRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachRotationRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachRotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Options for how we handle our scale when we attach to the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment, EAttachmentRule </para>
		/// </summary>
		public EAttachmentRule AutoAttachScaleRule
		{
			get => (EAttachmentRule)E_PROP_UAudioComponent_AutoAttachScaleRule_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachScaleRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true. </para>
		/// <para>@see bAutoManageAttachment </para>
		/// </summary>
		public string AutoAttachSocketName
		{
			get => E_PROP_UAudioComponent_AutoAttachSocketName_GET(NativePointer);
			set => E_PROP_UAudioComponent_AutoAttachSocketName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True if we should automatically attach to AutoAttachParent when Played, and detach from our parent when playback is completed. </para>
		/// <para>This overrides any current attachment that may be present at the time of activation (deferring initial attachment until activation, if AutoAttachParent is null). </para>
		/// <para>If enabled, this AudioComponent's WorldLocation will no longer be reliable when not currently playing audio, and any attach children will also be detached/attached along with it. </para>
		/// <para>When enabled, detachment occurs regardless of whether AutoAttachParent is assigned, and the relative transform from the time of activation is restored. </para>
		/// <para>This also disables attachment on dedicated servers, where we don't actually activate even if bAutoActivate is true. </para>
		/// <para>@see AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType </para>
		/// </summary>
		public byte bAutoManageAttachment
		{
			get => E_PROP_UAudioComponent_bAutoManageAttachment_GET(NativePointer);
			set => E_PROP_UAudioComponent_bAutoManageAttachment_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public string GetAudioComponentUserID()
			=> E_UAudioComponent_GetAudioComponentUserID(this);
		
		
		/// <summary>
		/// <para>Utility function called by Play and FadeIn to start a sound playing. </para>
		/// </summary>
		protected void PlayInternal(float StartTime, float FadeInDuration, float FadeVolumeLevel)
			=> E_UAudioComponent_PlayInternal(this, StartTime, FadeInDuration, FadeVolumeLevel);
		
		
		/// <summary>
		/// <para>Sets the sound instance parameter. </para>
		/// </summary>
		public void SetSoundParameter(FAudioComponentParam Param)
			=> E_UAudioComponent_SetSoundParameter(this, Param);
		
		#endregion
		
		public static implicit operator IntPtr(UAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAudioComponent>(PtrDesc);
		}}}
