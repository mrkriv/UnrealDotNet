// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraPhotography.h:18

namespace UnrealEngine
{
	public partial class FCameraPhotographyManager : NativeStructWrapper
	{
		public FCameraPhotographyManager(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_DefaultConstrainCamera(IntPtr self, IntPtr newCameraLocation, IntPtr previousCameraLocation, IntPtr originalCameraLocation, IntPtr outCameraLocation, IntPtr pCMgr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_Destroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FCameraPhotographyManager_Get(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FCameraPhotographyManager_IsSupported(IntPtr self, IntPtr inWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_SetUIControlVisibility(IntPtr self, byte uIControlTarget, bool bIsVisible);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_StartSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_StopSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FCameraPhotographyManager_UpdateCamera(IntPtr self, IntPtr inOutPOV, IntPtr pCMgr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraPhotographyManager_UpdatePostProcessing(IntPtr self, IntPtr inOutPostProcessingSettings);
		
		#endregion
		
		#region ExternMethods
		public void DefaultConstrainCamera(FVector newCameraLocation, FVector previousCameraLocation, FVector originalCameraLocation, FVector outCameraLocation, APlayerCameraManager pCMgr)
			=> E_FCameraPhotographyManager_DefaultConstrainCamera(this, newCameraLocation, previousCameraLocation, originalCameraLocation, outCameraLocation, pCMgr);
		
		
		/// <summary>
		/// Destroy current FCameraPhotography (if any); recreated by next Get()
		/// </summary>
		public void Destroy()
			=> E_FCameraPhotographyManager_Destroy(this);
		
		
		/// <summary>
		/// Get (& possibly create) singleton FCameraPhotography
		/// </summary>
		public FCameraPhotographyManager Get()
			=> E_FCameraPhotographyManager_Get(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public bool IsSupported(UWorld inWorld)
			=> E_FCameraPhotographyManager_IsSupported(this, inWorld);
		
		
		/// <summary>
		/// Show or hide controls in the photography UI; see documentation for UAnselFunctionLibrary::SetUIControlVisibility
		/// </summary>
		public void SetUIControlVisibility(byte uIControlTarget, bool bIsVisible)
			=> E_FCameraPhotographyManager_SetUIControlVisibility(this, uIControlTarget, bIsVisible);
		
		
		/// <summary>
		/// Starts a photography session
		/// </summary>
		public void StartSession()
			=> E_FCameraPhotographyManager_StartSession(this);
		
		
		/// <summary>
		/// Stops a photography session
		/// </summary>
		public void StopSession()
			=> E_FCameraPhotographyManager_StopSession(this);
		
		
		/// <summary>
		/// Modify input camera according to cumulative free-camera transforms (if any).
		/// <para>Safe to call this even if IsSupported()==false, in which case it will leave camera </para>
		/// unchanged and return false.
		/// </summary>
		/// <param name="inOutPOV">camera info to modify</param>
		/// <param name="pCMgr">player camera manager (non-NULL)</param>
		/// <return>Returns</return>
		public bool UpdateCamera(FMinimalViewInfo inOutPOV, APlayerCameraManager pCMgr)
			=> E_FCameraPhotographyManager_UpdateCamera(this, inOutPOV, pCMgr);
		
		
		/// <summary>
		/// Modify input postprocessing settings according to Photography requirements.
		/// <para>Safe to call this even if IsSupported()==false, in which case it will do nothing. </para>
		/// </summary>
		/// <param name="inOutPostProcessingSettings">the FPostProcessSettings to modify</param>
		public void UpdatePostProcessing(FPostProcessSettings inOutPostProcessingSettings)
			=> E_FCameraPhotographyManager_UpdatePostProcessing(this, inOutPostProcessingSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FCameraPhotographyManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCameraPhotographyManager(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCameraPhotographyManager(adress, false);
		}}}
