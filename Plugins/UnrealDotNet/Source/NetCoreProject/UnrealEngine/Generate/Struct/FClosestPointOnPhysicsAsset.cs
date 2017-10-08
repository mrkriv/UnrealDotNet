using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FClosestPointOnPhysicsAsset : NativeStructWrapper
	{
		internal FClosestPointOnPhysicsAsset(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClosestPointOnPhysicsAsset() :
			base(E_CreateStruct_FClosestPointOnPhysicsAsset(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClosestPointOnPhysicsAsset();
		
		#endregion
		
		public static implicit operator IntPtr(FClosestPointOnPhysicsAsset Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClosestPointOnPhysicsAsset(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClosestPointOnPhysicsAsset(Adress, false);
		}}}
