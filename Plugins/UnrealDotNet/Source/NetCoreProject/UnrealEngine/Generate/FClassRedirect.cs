using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FClassRedirect
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FClassRedirect()
		{
			NativePointer = E_CreateStruct_FClassRedirect();
			IsRef = false;
		}

		internal FClassRedirect(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FClassRedirect();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_FClassRedirect_InstanceOnly_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FClassRedirect_InstanceOnly_SET(IntPtr Ptr, bool Value);
		
		#endregion
		
		#region Property
		public bool InstanceOnly
		{
			get => E_PROP_FClassRedirect_InstanceOnly_GET(NativePointer);
			set => E_PROP_FClassRedirect_InstanceOnly_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		#endregion
		
		public static implicit operator IntPtr(FClassRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClassRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClassRedirect(Adress, false);
		}}}
