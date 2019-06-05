// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier.h:22

namespace UnrealEngine
{
	public partial class UCameraModifier : UObject
	{
		public UCameraModifier(IntPtr adress)
			: base(adress)
		{
		}

		public UCameraModifier(UObject Parent = null, string Name = "CameraModifier")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCameraModifier(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCameraModifier_Priority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCameraModifier_Priority_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCameraModifier(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_AddedToCamera(IntPtr self, IntPtr camera);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_BlueprintModifyCamera(IntPtr self, float deltaTime, IntPtr viewLocation, IntPtr viewRotation, float fOV, IntPtr newViewLocation, IntPtr newViewRotation, float newFOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_BlueprintModifyPostProcess(IntPtr self, float deltaTime, float postProcessBlendWeight, IntPtr postProcessSettings);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_DisableModifier(IntPtr self, bool bImmediate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_EnableModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCameraModifier_GetTargetAlpha(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCameraModifier_GetViewTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCameraModifier_GetWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraModifier_IsDisabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraModifier_ModifyCamera(IntPtr self, float deltaTime, IntPtr inOutPOV);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCameraModifier_ProcessViewRotation(IntPtr self, IntPtr viewTarget, float deltaTime, IntPtr outViewRotation, IntPtr outDeltaRot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_ToggleModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCameraModifier_UpdateAlpha(IntPtr self, float deltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Priority value that determines the order in which modifiers are applied. 0 = highest priority, 255 = lowest.
		/// </summary>
		public byte Priority
		{
			get => E_PROP_UCameraModifier_Priority_GET(NativePointer);
			set => E_PROP_UCameraModifier_Priority_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Allows any custom initialization. Called immediately after creation.
		/// </summary>
		/// <param name="camera">The camera this modifier should be associated with.</param>
		public virtual void AddedToCamera(APlayerCameraManager camera)
			=> E_UCameraModifier_AddedToCamera(this, camera);
		
		public void BlueprintModifyCamera(float deltaTime, FVector viewLocation, FRotator viewRotation, float fOV, FVector newViewLocation, FRotator newViewRotation, float newFOV)
			=> E_UCameraModifier_BlueprintModifyCamera(this, deltaTime, viewLocation, viewRotation, fOV, newViewLocation, newViewRotation, newFOV);
		
		public void BlueprintModifyPostProcess(float deltaTime, float postProcessBlendWeight, FPostProcessSettings postProcessSettings)
			=> E_UCameraModifier_BlueprintModifyPostProcess(this, deltaTime, postProcessBlendWeight, postProcessSettings);
		
		
		/// <summary>
		/// Disables this modifier.
		/// </summary>
		/// <param name="bImmediate">true to disable with no blend out, false (default) to allow blend out</param>
		public virtual void DisableModifier(bool bImmediate)
			=> E_UCameraModifier_DisableModifier(this, bImmediate);
		
		
		/// <summary>
		/// Enables this modifier.
		/// </summary>
		public virtual void EnableModifier()
			=> E_UCameraModifier_EnableModifier(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		protected virtual float GetTargetAlpha()
			=> E_UCameraModifier_GetTargetAlpha(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public virtual AActor GetViewTarget()
			=> E_UCameraModifier_GetViewTarget(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public UWorld GetWorld()
			=> E_UCameraModifier_GetWorld(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public virtual bool IsDisabled()
			=> E_UCameraModifier_IsDisabled(this);
		
		
		/// <summary>
		/// Directly modifies variables in the owning camera
		/// </summary>
		/// <param name="deltaTime">Change in time since last update</param>
		/// <param name="inOutPOV">Current Point of View, to be updated.</param>
		/// <return>bool</return>
		public virtual bool ModifyCamera(float deltaTime, FMinimalViewInfo inOutPOV)
			=> E_UCameraModifier_ModifyCamera(this, deltaTime, inOutPOV);
		
		
		/// <summary>
		/// Called to give modifiers a chance to adjust view rotation updates before they are applied.
		/// <para>Default just returns ViewRotation unchanged </para>
		/// </summary>
		/// <param name="viewTarget">Current view target.</param>
		/// <param name="deltaTime">Frame time in seconds.</param>
		/// <param name="outViewRotation">In/out. The view rotation to modify.</param>
		/// <param name="outDeltaRot">In/out. How much the rotation changed this frame.</param>
		/// <return>Return</return>
		public virtual bool ProcessViewRotation(AActor viewTarget, float deltaTime, FRotator outViewRotation, FRotator outDeltaRot)
			=> E_UCameraModifier_ProcessViewRotation(this, viewTarget, deltaTime, outViewRotation, outDeltaRot);
		
		
		/// <summary>
		/// Toggled disabled/enabled state of this modifier.
		/// </summary>
		public virtual void ToggleModifier()
			=> E_UCameraModifier_ToggleModifier(this);
		
		
		/// <summary>
		/// Responsible for updating alpha blend value.
		/// </summary>
		/// <param name="camera">Camera that is being updated</param>
		/// <param name="deltaTime">Amount of time since last update</param>
		public virtual void UpdateAlpha(float deltaTime)
			=> E_UCameraModifier_UpdateAlpha(this, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(UCameraModifier self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCameraModifier(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCameraModifier>(PtrDesc);
		}}}
