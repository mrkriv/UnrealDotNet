using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USceneCaptureComponentCube : USceneCaptureComponent
	{
		public USceneCaptureComponentCube(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponentCube_CaptureScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponentCube_CaptureSceneDeferred(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponentCube_UpdateContent(IntPtr Self);
		
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
		
		public static implicit operator IntPtr(USceneCaptureComponentCube Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponentCube(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USceneCaptureComponentCube ?? new USceneCaptureComponentCube(Adress);
		}}}
