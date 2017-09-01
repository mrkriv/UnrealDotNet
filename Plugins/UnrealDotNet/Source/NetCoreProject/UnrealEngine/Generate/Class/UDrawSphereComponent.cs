using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A sphere generally used for simple collision. Bounds are rendered as lines in the editor.
	/// </summary>
	public partial class UDrawSphereComponent : USphereComponent
	{
		public UDrawSphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UDrawSphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawSphereComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UDrawSphereComponent(Adress);
		}}}
