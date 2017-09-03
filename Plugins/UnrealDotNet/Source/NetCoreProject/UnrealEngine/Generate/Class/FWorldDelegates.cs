using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageWorldDelegates
	/// <para>World delegates </para>
	/// </summary>
	public  partial class FWorldDelegates : NativeWrapper
	{
		public FWorldDelegates(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(FWorldDelegates Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWorldDelegates(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as FWorldDelegates ?? new FWorldDelegates(Adress);
		}}}
