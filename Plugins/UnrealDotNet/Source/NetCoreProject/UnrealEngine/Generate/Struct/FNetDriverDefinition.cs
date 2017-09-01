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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FNetDriverDefinition();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FNetDriverDefinition_DefName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FNetDriverDefinition_DefName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FNetDriverDefinition_DriverClassName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FNetDriverDefinition_DriverClassName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string DefName
		{
			get => E_PROP_FNetDriverDefinition_DefName_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DefName_SET(NativePointer, value);
		}

		public string DriverClassName
		{
			get => E_PROP_FNetDriverDefinition_DriverClassName_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DriverClassName_SET(NativePointer, value);
		}

		public string DriverClassNameFallback
		{
			get => E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(NativePointer);
			set => E_PROP_FNetDriverDefinition_DriverClassNameFallback_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FNetDriverDefinition Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNetDriverDefinition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNetDriverDefinition(Adress, false);
		}}}
