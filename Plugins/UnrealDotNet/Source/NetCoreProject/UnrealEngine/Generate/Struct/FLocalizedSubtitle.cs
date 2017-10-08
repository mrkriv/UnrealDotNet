using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLocalizedSubtitle : NativeStructWrapper
	{
		internal FLocalizedSubtitle(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLocalizedSubtitle() :
			base(E_CreateStruct_FLocalizedSubtitle(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalizedSubtitle();
		
		#endregion
		
		public static implicit operator IntPtr(FLocalizedSubtitle Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLocalizedSubtitle(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLocalizedSubtitle(Adress, false);
		}}}
