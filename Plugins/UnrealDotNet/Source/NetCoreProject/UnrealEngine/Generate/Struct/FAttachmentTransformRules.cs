using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAttachmentTransformRules : NativeStructWrapper
	{
		internal FAttachmentTransformRules(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule InRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool((byte)InRule, bInWeldSimulatedBodies), false)
		{
		}

		public FAttachmentTransformRules(EAttachmentRule InLocationRule, EAttachmentRule InRotationRule, EAttachmentRule InScaleRule, bool bInWeldSimulatedBodies) :
			base(E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool((byte)InLocationRule, (byte)InRotationRule, (byte)InScaleRule, bInWeldSimulatedBodies), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_bool(byte InRule, bool bInWeldSimulatedBodies);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAttachmentTransformRules_EAttachmentRule_EAttachmentRule_EAttachmentRule_bool(byte InLocationRule, byte InRotationRule, byte InScaleRule, bool bInWeldSimulatedBodies);
		
		#endregion
		
		public static implicit operator IntPtr(FAttachmentTransformRules Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAttachmentTransformRules(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAttachmentTransformRules(Adress, false);
		}}}
