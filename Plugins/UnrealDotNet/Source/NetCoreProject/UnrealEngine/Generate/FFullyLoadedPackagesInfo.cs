using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct to help hold information about packages needing to be fully-loaded for DLC, etc.
	/// </summary>
	public partial class FFullyLoadedPackagesInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FFullyLoadedPackagesInfo()
		{
			NativePointer = E_CreateStruct_FFullyLoadedPackagesInfo();
			IsRef = false;
		}

		internal FFullyLoadedPackagesInfo(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FFullyLoadedPackagesInfo();
		
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
		
		public static implicit operator IntPtr(FFullyLoadedPackagesInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFullyLoadedPackagesInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFullyLoadedPackagesInfo(Adress, false);
		}}}
