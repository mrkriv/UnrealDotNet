using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRedirector : NativeStructWrapper
	{
		internal FRedirector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRedirector() :
			base(E_CreateStruct_FRedirector(), false)
		{
		}

		public FRedirector(string InOldName, string InNewName) :
			base(E_CreateStruct_FRedirector_FName_FName(InOldName, InNewName), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector_FName_FName(string InOldName, string InNewName);
		
		#endregion
		
		public static implicit operator IntPtr(FRedirector Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRedirector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRedirector(Adress, false);
		}}}
