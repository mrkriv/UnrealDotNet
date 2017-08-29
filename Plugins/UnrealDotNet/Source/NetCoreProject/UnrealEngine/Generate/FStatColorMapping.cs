using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FStatColorMapping
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FStatColorMapping()
		{
			NativePointer = E_CreateStruct_FStatColorMapping();
			IsRef = false;
		}

		internal FStatColorMapping(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FStatColorMapping();
		
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
		
		public static implicit operator IntPtr(FStatColorMapping Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStatColorMapping(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapping(Adress, false);
		}}}
