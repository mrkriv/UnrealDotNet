using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Container for describing various types of netdrivers available to the engine
	/// The engine will try to construct a netdriver of a given type and, failing that,
	/// the fallback version.
	/// </summary>
	public partial class FNetDriverDefinition
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FNetDriverDefinition()
		{
			NativePointer = E_CreateStruct_FNetDriverDefinition();
			IsRef = false;
		}

		internal FNetDriverDefinition(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FNetDriverDefinition();
		
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
		
		public static implicit operator IntPtr(FNetDriverDefinition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNetDriverDefinition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNetDriverDefinition(Adress, false);
		}}}
