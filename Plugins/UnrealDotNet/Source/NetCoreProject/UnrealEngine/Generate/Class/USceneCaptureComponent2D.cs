using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageSceneCaptureComponent2D
	/// <para>Used to capture a 'snapshot' of the scene from a single plane and feed it to a render target. </para>
	/// </summary>
	public  partial class USceneCaptureComponent2D : USceneCaptureComponent
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
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USceneCaptureComponent2D ?? new USceneCaptureComponent2D(Adress);
		}}}
