using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageLineBatchComponent
	/// <para>The line batch component buffers and draws lines (and some other line-based shapes) in a scene. </para>
	/// <para>This can be useful for debug drawing, but is not very performant for runtime use. </para>
	/// </summary>
	public  partial class ULineBatchComponent : UPrimitiveComponent
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
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULineBatchComponent ?? new ULineBatchComponent(Adress);
		}}}
