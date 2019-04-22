// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

namespace UnrealEngine
{
	public  partial class USceneCaptureComponentCube : USceneCaptureComponent
	{
		public USceneCaptureComponentCube(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponentCube(UObject Parent = null, string Name = "SceneCaptureComponentCube")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponentCube(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

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
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Render the scene to the texture target immediately. </para>
		/// <para>This should not be used if bCaptureEveryFrame is enabled, or the scene capture will render redundantly. </para>
		/// </summary>
		public void CaptureScene()
			=> E_USceneCaptureComponentCube_CaptureScene(this);
		
		
		/// <summary>
		/// <para>Render the scene to the texture the next time the main view is rendered. </para>
		/// </summary>
		public void CaptureSceneDeferred()
			=> E_USceneCaptureComponentCube_CaptureSceneDeferred(this);
		
		public void UpdateContent()
			=> E_USceneCaptureComponentCube_UpdateContent(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponentCube self)
		{
			return self.NativePointer;
		}

		public static implicit operator USceneCaptureComponentCube(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponentCube>(PtrDesc);
		}}}
