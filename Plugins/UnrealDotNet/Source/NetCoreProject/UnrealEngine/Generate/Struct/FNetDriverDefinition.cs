using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FNetDriverDefinition : NativeStructWrapper
	{
		internal FNetDriverDefinition(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FNetDriverDefinition() :
			base(E_CreateStruct_FNetDriverDefinition(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FNetDriverDefinition();
		
		#endregion
		
		public static implicit operator IntPtr(FNetDriverDefinition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNetDriverDefinition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNetDriverDefinition(Adress, false);
		}}}
