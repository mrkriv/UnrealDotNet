using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FStructRedirect
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FStructRedirect()
		{
			NativePointer = E_CreateStruct_FStructRedirect();
			IsRef = false;
		}

		internal FStructRedirect(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FStructRedirect();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		#endregion
		
		public static implicit operator IntPtr(FStructRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStructRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStructRedirect(Adress, false);
		}}}
