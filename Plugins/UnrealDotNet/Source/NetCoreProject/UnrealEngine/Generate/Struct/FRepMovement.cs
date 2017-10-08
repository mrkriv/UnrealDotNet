using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepMovement : NativeStructWrapper
	{
		internal FRepMovement(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepMovement() :
			base(E_CreateStruct_FRepMovement(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepMovement();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_CopyTo(IntPtr Self, IntPtr RBState, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepMovement_FillFrom(IntPtr Self, IntPtr RBState, IntPtr Actor);
		
		#endregion
		
		#region ExternMethods
		public void CopyTo(FRigidBodyState RBState, AActor Actor = null)
			=> E_FRepMovement_CopyTo(this, RBState, Actor);
		
		public void FillFrom(FRigidBodyState RBState, AActor Actor = null)
			=> E_FRepMovement_FillFrom(this, RBState, Actor);
		
		#endregion
		
		public static implicit operator IntPtr(FRepMovement Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepMovement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepMovement(Adress, false);
		}}}
