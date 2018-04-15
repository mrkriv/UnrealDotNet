using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:528

namespace UnrealEngine
{
	public  partial class FClassRedirect : NativeStructWrapper
	{
		internal FClassRedirect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClassRedirect() :
			base(E_CreateStruct_FClassRedirect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClassRedirect();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FClassRedirect_InstanceOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_InstanceOnly_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_NewClassClass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_NewClassClass_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_NewClassName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_NewClassName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_NewClassPackage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_NewClassPackage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_NewSubobjName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_NewSubobjName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_ObjectName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_ObjectName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_OldClassName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_OldClassName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClassRedirect_OldSubobjName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClassRedirect_OldSubobjName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public bool InstanceOnly
		{
			get => E_PROP_FClassRedirect_InstanceOnly_GET(NativePointer);
			set => E_PROP_FClassRedirect_InstanceOnly_SET(NativePointer, value);
		}

		public string NewClassClass
		{
			get => E_PROP_FClassRedirect_NewClassClass_GET(NativePointer);
			set => E_PROP_FClassRedirect_NewClassClass_SET(NativePointer, value);
		}

		public string NewClassName
		{
			get => E_PROP_FClassRedirect_NewClassName_GET(NativePointer);
			set => E_PROP_FClassRedirect_NewClassName_SET(NativePointer, value);
		}

		public string NewClassPackage
		{
			get => E_PROP_FClassRedirect_NewClassPackage_GET(NativePointer);
			set => E_PROP_FClassRedirect_NewClassPackage_SET(NativePointer, value);
		}

		public string NewSubobjName
		{
			get => E_PROP_FClassRedirect_NewSubobjName_GET(NativePointer);
			set => E_PROP_FClassRedirect_NewSubobjName_SET(NativePointer, value);
		}

		public string ObjectName
		{
			get => E_PROP_FClassRedirect_ObjectName_GET(NativePointer);
			set => E_PROP_FClassRedirect_ObjectName_SET(NativePointer, value);
		}

		public string OldClassName
		{
			get => E_PROP_FClassRedirect_OldClassName_GET(NativePointer);
			set => E_PROP_FClassRedirect_OldClassName_SET(NativePointer, value);
		}

		public string OldSubobjName
		{
			get => E_PROP_FClassRedirect_OldSubobjName_GET(NativePointer);
			set => E_PROP_FClassRedirect_OldSubobjName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClassRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClassRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClassRedirect(Adress, false);
		}}}
