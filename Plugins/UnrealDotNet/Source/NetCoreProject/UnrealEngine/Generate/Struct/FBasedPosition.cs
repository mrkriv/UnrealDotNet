using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBasedPosition : NativeStructWrapper
	{
		internal FBasedPosition(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBasedPosition() :
			base(E_CreateStruct_FBasedPosition(), false)
		{
		}

		public FBasedPosition(AActor InBase, FVector InPosition) :
			base(E_CreateStruct_FBasedPosition_AActor_FVector(InBase, InPosition), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedPosition();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedPosition_AActor_FVector(IntPtr InBase, IntPtr InPosition);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBasedPosition_Clear(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBasedPosition_Set(IntPtr Self, IntPtr InBase, IntPtr InPosition);
		
		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FBasedPosition_Clear(this);
		
		public void Set(AActor InBase, FVector InPosition)
			=> E_FBasedPosition_Set(this, InBase, InPosition);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedPosition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBasedPosition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBasedPosition(Adress, false);
		}}}
