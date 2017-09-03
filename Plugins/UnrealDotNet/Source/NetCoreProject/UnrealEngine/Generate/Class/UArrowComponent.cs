using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageArrowComponent
	/// <para>A simple arrow rendered using lines. Useful for indicating which way an object is facing. </para>
	/// </summary>
	public  partial class UArrowComponent : UPrimitiveComponent
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
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UArrowComponent ?? new UArrowComponent(Adress);
		}}}
