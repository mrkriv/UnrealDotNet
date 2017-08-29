using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FPluginRedirect
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPluginRedirect()
		{
			NativePointer = E_CreateStruct_FPluginRedirect();
			IsRef = false;
		}

		internal FPluginRedirect(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FPluginRedirect();
		
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
		
		public static implicit operator IntPtr(FPluginRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPluginRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPluginRedirect(Adress, false);
		}}}
