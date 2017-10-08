using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDetachmentTransformRules : NativeStructWrapper
	{
		internal FDetachmentTransformRules(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDetachmentTransformRules(EDetachmentRule InRule, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool((byte)InRule, bInCallModify), false)
		{
		}

		public FDetachmentTransformRules(EDetachmentRule InLocationRule, EDetachmentRule InRotationRule, EDetachmentRule InScaleRule, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool((byte)InLocationRule, (byte)InRotationRule, (byte)InScaleRule, bInCallModify), false)
		{
		}

		public FDetachmentTransformRules(FAttachmentTransformRules AttachmentRules, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(AttachmentRules, bInCallModify), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool(byte InRule, bool bInCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool(byte InLocationRule, byte InRotationRule, byte InScaleRule, bool bInCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(IntPtr AttachmentRules, bool bInCallModify);
		
		#endregion
		
		public static implicit operator IntPtr(FDetachmentTransformRules Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDetachmentTransformRules(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDetachmentTransformRules(Adress, false);
		}}}
