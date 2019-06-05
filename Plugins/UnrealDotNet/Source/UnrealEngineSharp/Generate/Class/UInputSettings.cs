// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\InputSettings.h:20

namespace UnrealEngine
{
	public partial class UInputSettings : UObject
	{
		public UInputSettings(IntPtr adress)
			: base(adress)
		{
		}

		public UInputSettings(UObject Parent = null, string Name = "InputSettings")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInputSettings(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bAltEnterTogglesFullscreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bAltEnterTogglesFullscreen_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bAlwaysShowTouchInterface_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bAlwaysShowTouchInterface_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bCaptureMouseOnLaunch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bCaptureMouseOnLaunch_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bEnableFOVScaling_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bEnableFOVScaling_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bEnableGestureRecognizer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bEnableGestureRecognizer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bEnableMouseSmoothing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bEnableMouseSmoothing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bF11TogglesFullscreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bF11TogglesFullscreen_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UInputSettings_bUseAutocorrect_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bUseAutocorrect_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_bUseMouseForTouch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_bUseMouseForTouch_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInputSettings_DefaultViewportMouseLockMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_DefaultViewportMouseLockMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UInputSettings_DoubleClickTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_DoubleClickTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UInputSettings_FOVScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInputSettings_FOVScale_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInputSettings(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_AddActionMapping(IntPtr self, IntPtr keyMapping, bool bForceRebuildKeymaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_AddAxisMapping(IntPtr self, IntPtr keyMapping, bool bForceRebuildKeymaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_ForceRebuildKeymaps(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UInputSettings_GetInputSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_RemoveActionMapping(IntPtr self, IntPtr keyMapping, bool bForceRebuildKeymaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_RemoveAxisMapping(IntPtr self, IntPtr keyMapping, bool bForceRebuildKeymaps);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInputSettings_SaveKeyMappings(IntPtr self);
		
		#endregion
		
		#region Property
		public byte bAltEnterTogglesFullscreen
		{
			get => E_PROP_UInputSettings_bAltEnterTogglesFullscreen_GET(NativePointer);
			set => E_PROP_UInputSettings_bAltEnterTogglesFullscreen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Should the touch input interface be shown always, or only when the platform has a touch screen?
		/// </summary>
		public byte bAlwaysShowTouchInterface
		{
			get => E_PROP_UInputSettings_bAlwaysShowTouchInterface_GET(NativePointer);
			set => E_PROP_UInputSettings_bAlwaysShowTouchInterface_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls if the viewport will capture the mouse on Launch of the application
		/// </summary>
		public byte bCaptureMouseOnLaunch
		{
			get => E_PROP_UInputSettings_bCaptureMouseOnLaunch_GET(NativePointer);
			set => E_PROP_UInputSettings_bCaptureMouseOnLaunch_SET(NativePointer, value);
		}

		public byte bDefaultViewportMouseLock_DEPRECATED
		{
			get => E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_GET(NativePointer);
			set => E_PROP_UInputSettings_bDefaultViewportMouseLock_DEPRECATED_SET(NativePointer, value);
		}

		public byte bEnableFOVScaling
		{
			get => E_PROP_UInputSettings_bEnableFOVScaling_GET(NativePointer);
			set => E_PROP_UInputSettings_bEnableFOVScaling_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not to use the gesture recognition system to convert touches in to gestures that can be bound and queried
		/// </summary>
		public byte bEnableGestureRecognizer
		{
			get => E_PROP_UInputSettings_bEnableGestureRecognizer_GET(NativePointer);
			set => E_PROP_UInputSettings_bEnableGestureRecognizer_SET(NativePointer, value);
		}

		public byte bEnableMouseSmoothing
		{
			get => E_PROP_UInputSettings_bEnableMouseSmoothing_GET(NativePointer);
			set => E_PROP_UInputSettings_bEnableMouseSmoothing_SET(NativePointer, value);
		}

		public byte bF11TogglesFullscreen
		{
			get => E_PROP_UInputSettings_bF11TogglesFullscreen_GET(NativePointer);
			set => E_PROP_UInputSettings_bF11TogglesFullscreen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not to show the console on 4 finger tap, on mobile platforms
		/// </summary>
		public byte bShowConsoleOnFourFingerTap
		{
			get => E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_GET(NativePointer);
			set => E_PROP_UInputSettings_bShowConsoleOnFourFingerTap_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, virtual keyboards will have autocorrect enabled. Currently only supported on mobile devices.
		/// </summary>
		public bool bUseAutocorrect
		{
			get => E_PROP_UInputSettings_bUseAutocorrect_GET(NativePointer);
			set => E_PROP_UInputSettings_bUseAutocorrect_SET(NativePointer, value);
		}

		public byte bUseMouseForTouch
		{
			get => E_PROP_UInputSettings_bUseMouseForTouch_GET(NativePointer);
			set => E_PROP_UInputSettings_bUseMouseForTouch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The default mouse capture mode for the game viewport
		/// </summary>
		public EMouseCaptureMode DefaultViewportMouseCaptureMode
		{
			get => (EMouseCaptureMode)E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_GET(NativePointer);
			set => E_PROP_UInputSettings_DefaultViewportMouseCaptureMode_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// The default mouse lock state behavior when the viewport acquires capture
		/// </summary>
		public EMouseLockMode DefaultViewportMouseLockMode
		{
			get => (EMouseLockMode)E_PROP_UInputSettings_DefaultViewportMouseLockMode_GET(NativePointer);
			set => E_PROP_UInputSettings_DefaultViewportMouseLockMode_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// If a key is pressed twice in this amount of time it is considered a "double click"
		/// </summary>
		public float DoubleClickTime
		{
			get => E_PROP_UInputSettings_DoubleClickTime_GET(NativePointer);
			set => E_PROP_UInputSettings_DoubleClickTime_SET(NativePointer, value);
		}

		public float FOVScale
		{
			get => E_PROP_UInputSettings_FOVScale_GET(NativePointer);
			set => E_PROP_UInputSettings_FOVScale_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Programmatically add an action mapping to the project defaults
		/// </summary>
		public void AddActionMapping(FInputActionKeyMapping keyMapping, bool bForceRebuildKeymaps = true)
			=> E_UInputSettings_AddActionMapping(this, keyMapping, bForceRebuildKeymaps);
		
		
		/// <summary>
		/// Programmatically add an axis mapping to the project defaults
		/// </summary>
		public void AddAxisMapping(FInputAxisKeyMapping keyMapping, bool bForceRebuildKeymaps = true)
			=> E_UInputSettings_AddAxisMapping(this, keyMapping, bForceRebuildKeymaps);
		
		
		/// <summary>
		/// When changes are made to the default mappings, push those changes out to PlayerInput key maps
		/// </summary>
		public void ForceRebuildKeymaps()
			=> E_UInputSettings_ForceRebuildKeymaps(this);
		
		
		/// <summary>
		/// Returns the game local input settings (action mappings, axis mappings, etc...)
		/// </summary>
		public UInputSettings GetInputSettings()
			=> E_UInputSettings_GetInputSettings(this);
		
		
		/// <summary>
		/// Programmatically remove an action mapping to the project defaults
		/// </summary>
		public void RemoveActionMapping(FInputActionKeyMapping keyMapping, bool bForceRebuildKeymaps = true)
			=> E_UInputSettings_RemoveActionMapping(this, keyMapping, bForceRebuildKeymaps);
		
		
		/// <summary>
		/// Programmatically remove an axis mapping to the project defaults
		/// </summary>
		public void RemoveAxisMapping(FInputAxisKeyMapping keyMapping, bool bForceRebuildKeymaps = true)
			=> E_UInputSettings_RemoveAxisMapping(this, keyMapping, bForceRebuildKeymaps);
		
		
		/// <summary>
		/// Flush the current mapping values to the config file
		/// </summary>
		public void SaveKeyMappings()
			=> E_UInputSettings_SaveKeyMappings(this);
		
		#endregion
		
		public static implicit operator IntPtr(UInputSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UInputSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInputSettings>(PtrDesc);
		}}}
