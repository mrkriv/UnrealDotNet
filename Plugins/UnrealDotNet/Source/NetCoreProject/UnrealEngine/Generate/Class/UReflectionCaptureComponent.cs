using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageReflectionCaptureComponent
	/// <para>Construct the reflection source from the specified cubemap. </para>
	/// </summary>
	public  partial class UReflectionCaptureComponent : USceneComponent
	{
		public UReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UReflectionCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UReflectionCaptureComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UReflectionCaptureComponent ?? new UReflectionCaptureComponent(Adress);
		}}}
