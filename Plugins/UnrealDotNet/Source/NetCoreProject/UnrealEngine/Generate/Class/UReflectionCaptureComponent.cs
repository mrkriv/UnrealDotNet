using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Construct the reflection source from the specified cubemap.
	/// </summary>
	public partial class UReflectionCaptureComponent : USceneComponent
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
			return Adress == IntPtr.Zero ? null : new UReflectionCaptureComponent(Adress);
		}}}
