using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3300

namespace UnrealEngine
{
	public  partial class FReplicationFlags : NativeStructWrapper
	{
		internal FReplicationFlags(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FReplicationFlags() :
			base(E_CreateStruct_FReplicationFlags(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReplicationFlags();
		
		#endregion
		
		public static implicit operator IntPtr(FReplicationFlags Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FReplicationFlags(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FReplicationFlags(Adress, false);
		}}}
