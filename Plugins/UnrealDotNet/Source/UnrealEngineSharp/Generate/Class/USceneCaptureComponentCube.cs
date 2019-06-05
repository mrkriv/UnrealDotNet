// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

namespace UnrealEngine
{
	public partial class USceneCaptureComponentCube : USceneCaptureComponent
	{
		public USceneCaptureComponentCube(IntPtr adress)
			: base(adress)
		{
		}

		public USceneCaptureComponentCube(UObject Parent = null, string Name = "SceneCaptureComponentCube")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponentCube(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USceneCaptureComponentCube_IPD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponentCube_IPD_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponentCube(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponentCube_CaptureScene(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponentCube_CaptureSceneDeferred(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponentCube_UpdateContent(IntPtr self);
		
		#endregion
		
		#region Property
		public float InterpupillaryDistancecm
		{
			get => E_PROP_USceneCaptureComponentCube_IPD_GET(NativePointer);
			set => E_PROP_USceneCaptureComponentCube_IPD_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Render the scene to the texture target immediately.
		/// <para>This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly. </para>
		/// </summary>
		public void CaptureScene()
			=> E_USceneCaptureComponentCube_CaptureScene(this);
		
		
		/// <summary>
		/// Render the scene to the texture the next time the main view is rendered.
		/// </summary>
		public void CaptureSceneDeferred()
			=> E_USceneCaptureComponentCube_CaptureSceneDeferred(this);
		
		public void UpdateContent()
			=> E_USceneCaptureComponentCube_UpdateContent(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponentCube self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USceneCaptureComponentCube(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponentCube>(PtrDesc);
		}}}
