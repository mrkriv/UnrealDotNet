using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageWorldProxy
	/// <para>Proxy class that allows verification on GWorld accesses. </para>
	/// </summary>
	public  partial class UWorldProxy : NativeWrapper
	{
		public UWorldProxy(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UWorldProxy_GetReference(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public UWorld GetReference()
			=> E_UWorldProxy_GetReference(this);
		
		#endregion
		
		public static implicit operator IntPtr(UWorldProxy Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWorldProxy(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UWorldProxy ?? new UWorldProxy(Adress);
		}}}
