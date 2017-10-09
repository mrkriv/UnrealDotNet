using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRepAttachment : NativeStructWrapper
	{
		internal FRepAttachment(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepAttachment() :
			base(E_CreateStruct_FRepAttachment(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepAttachment();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRepAttachment_AttachSocket_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_AttachSocket_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepAttachment_RotationOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_RotationOffset_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public string AttachSocket
		{
			get => E_PROP_FRepAttachment_AttachSocket_GET(NativePointer);
			set => E_PROP_FRepAttachment_AttachSocket_SET(NativePointer, value);
		}

		public FRotator RotationOffset
		{
			get => E_PROP_FRepAttachment_RotationOffset_GET(NativePointer);
			set => E_PROP_FRepAttachment_RotationOffset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRepAttachment Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRepAttachment(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepAttachment(Adress, false);
		}}}
