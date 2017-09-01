using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Used to capture a 'snapshot' of the scene from a single plane and feed it to a render target.
	/// </summary>
	public partial class USceneCaptureComponent2D : USceneCaptureComponent
	{
		public USceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USceneCaptureComponent2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USceneCaptureComponent2D(Adress);
		}}}
