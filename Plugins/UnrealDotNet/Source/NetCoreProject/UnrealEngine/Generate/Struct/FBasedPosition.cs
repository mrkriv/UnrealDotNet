using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1343

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedPosition();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedBaseLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedBaseLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedBaseRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedBaseRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedTransPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedTransPosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_Position_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBasedPosition_Clear(IntPtr Self);
		
		#endregion
		
		#region Property
		public FVector CachedBaseLocation
		{
			get => E_PROP_FBasedPosition_CachedBaseLocation_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedBaseLocation_SET(NativePointer, value);
		}

		public FRotator CachedBaseRotation
		{
			get => E_PROP_FBasedPosition_CachedBaseRotation_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedBaseRotation_SET(NativePointer, value);
		}

		public FVector CachedTransPosition
		{
			get => E_PROP_FBasedPosition_CachedTransPosition_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedTransPosition_SET(NativePointer, value);
		}

		public FVector Position
		{
			get => E_PROP_FBasedPosition_Position_GET(NativePointer);
			set => E_PROP_FBasedPosition_Position_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FBasedPosition_Clear(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedPosition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBasedPosition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBasedPosition(Adress, false);
		}}}
