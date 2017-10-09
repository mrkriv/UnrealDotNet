using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:3548

namespace UnrealEngine
{
	public  partial class FRedirector : NativeStructWrapper
	{
		internal FRedirector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRedirector() :
			base(E_CreateStruct_FRedirector(), false)
		{
		}

		public FRedirector(string InOldName, string InNewName) :
			base(E_CreateStruct_FRedirector_FName_FName(InOldName, InNewName), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRedirector_FName_FName(string InOldName, string InNewName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRedirector_NewName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRedirector_NewName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRedirector_OldName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRedirector_OldName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string NewName
		{
			get => E_PROP_FRedirector_NewName_GET(NativePointer);
			set => E_PROP_FRedirector_NewName_SET(NativePointer, value);
		}

		public string OldName
		{
			get => E_PROP_FRedirector_OldName_GET(NativePointer);
			set => E_PROP_FRedirector_OldName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRedirector Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRedirector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRedirector(Adress, false);
		}}}
