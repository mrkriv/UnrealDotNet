using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Used to capture a 'snapshot' of the scene from a 6 planes and feed it to a render target.
	/// </summary>
	public partial class USceneCaptureComponentCube : USceneCaptureComponent
	{
		public USceneCaptureComponentCube(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USceneCaptureComponentCube Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponentCube(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USceneCaptureComponentCube(Adress);
		}}}
