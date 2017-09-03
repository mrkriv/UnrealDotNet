using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageNamedNetDriver
	/// <para>Active and named net drivers instantiated from an FNetDriverDefinition </para>
	/// <para>The net driver will remain instantiated on this struct until it is destroyed </para>
	/// </summary>
	public  partial class FNamedNetDriver : NativeStructWrapper
	{
		public FNamedNetDriver() : base(E_CreateStruct_FNamedNetDriver(), false)
		{
		}

		internal FNamedNetDriver(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FNamedNetDriver();
		
		#endregion
		
		public static implicit operator IntPtr(FNamedNetDriver Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNamedNetDriver(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNamedNetDriver(Adress, false);
		}}}
