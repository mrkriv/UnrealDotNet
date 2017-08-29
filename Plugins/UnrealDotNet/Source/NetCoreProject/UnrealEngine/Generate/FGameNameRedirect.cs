using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FGameNameRedirect
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FGameNameRedirect()
		{
			NativePointer = E_CreateStruct_FGameNameRedirect();
			IsRef = false;
		}

		internal FGameNameRedirect(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FGameNameRedirect();
		
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
		
		public static implicit operator IntPtr(FGameNameRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FGameNameRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameNameRedirect(Adress, false);
		}}}
