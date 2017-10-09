using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Engine.h:176

namespace UnrealEngine
{
	public  partial class FNetDriverDefinition : NativeStructWrapper
	{
		internal FNetDriverDefinition(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FNetDriverDefinition() :
			base(E_CreateStruct_FNetDriverDefinition(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FNetDriverDefinition();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DefName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetDriverDefinition_DefName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DriverClassName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FNetDriverDefinition_DriverClassName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FNetDriverDefinition_DriverClassNameFallback_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
