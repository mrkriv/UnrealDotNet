using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// level streaming updates that should be applied immediately after committing the map change
	/// </summary>
	public partial class FLevelStreamingStatus
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLevelStreamingStatus()
		{
			NativePointer = E_CreateStruct_FLevelStreamingStatus();
			IsRef = false;
		}

		internal FLevelStreamingStatus(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus();
		
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
		
		public static implicit operator IntPtr(FLevelStreamingStatus Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelStreamingStatus(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingStatus(Adress, false);
		}}}
