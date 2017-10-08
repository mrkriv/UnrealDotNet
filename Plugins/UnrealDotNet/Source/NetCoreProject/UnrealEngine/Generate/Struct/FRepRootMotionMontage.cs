using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepRootMotionMontage : NativeStructWrapper
	{
		internal FRepRootMotionMontage(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepRootMotionMontage() :
			base(E_CreateStruct_FRepRootMotionMontage(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepRootMotionMontage();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRepRootMotionMontage_Clear(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRepRootMotionMontage_HasRootMotion(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear root motion sources and root motion montage </para>
		/// </summary>
		public void Clear()
			=> E_FRepRootMotionMontage_Clear(this);
		
		
		/// <summary>
		/// <para>Is Valid - animation root motion only </para>
		/// </summary>
		public bool HasRootMotion()
			=> E_FRepRootMotionMontage_HasRootMotion(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRepRootMotionMontage Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepRootMotionMontage(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepRootMotionMontage(Adress, false);
		}}}
