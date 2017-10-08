using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorSpawnParameters : NativeStructWrapper
	{
		internal FActorSpawnParameters(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorSpawnParameters() :
			base(E_CreateStruct_FActorSpawnParameters(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorSpawnParameters();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public bool IsRemoteOwned()
			=> E_FActorSpawnParameters_IsRemoteOwned(this);
		
		#endregion
		
		public static implicit operator IntPtr(FActorSpawnParameters Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorSpawnParameters(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorSpawnParameters(Adress, false);
		}}}
