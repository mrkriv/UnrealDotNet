using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// The line batch component buffers and draws lines (and some other line-based shapes) in a scene.
	/// This can be useful for debug drawing, but is not very performant for runtime use.
	/// </summary>
	public partial class ULineBatchComponent : UPrimitiveComponent
	{
		public ULineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(ULineBatchComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULineBatchComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ULineBatchComponent(Adress);
		}}}
