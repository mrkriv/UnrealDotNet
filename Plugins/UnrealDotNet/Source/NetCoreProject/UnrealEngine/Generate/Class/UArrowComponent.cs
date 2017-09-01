using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A simple arrow rendered using lines. Useful for indicating which way an object is facing.
	/// </summary>
	public partial class UArrowComponent : UPrimitiveComponent
	{
		public UArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UArrowComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UArrowComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UArrowComponent(Adress);
		}}}
