using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTickPrerequisite : NativeStructWrapper
	{
		public FTickPrerequisite() : base(E_CreateStruct_FTickPrerequisite(), false)
		{
		}

		internal FTickPrerequisite(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FTickPrerequisite();
		
		#endregion
		
		public static implicit operator IntPtr(FTickPrerequisite Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTickPrerequisite(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTickPrerequisite(Adress, false);
		}}}
