using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FComponentSocketDescription : NativeStructWrapper
	{
		internal FComponentSocketDescription(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FComponentSocketDescription() :
			base(E_CreateStruct_FComponentSocketDescription(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentSocketDescription();
		
		#endregion
		
		public static implicit operator IntPtr(FComponentSocketDescription Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FComponentSocketDescription(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FComponentSocketDescription(Adress, false);
		}}}
