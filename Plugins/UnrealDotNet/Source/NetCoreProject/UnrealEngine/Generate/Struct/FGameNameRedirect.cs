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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FGameNameRedirect();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FGameNameRedirect_OldGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FGameNameRedirect_OldGameName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FGameNameRedirect_NewGameName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FGameNameRedirect_NewGameName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string OldGameName
		{
			get => E_PROP_FGameNameRedirect_OldGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_OldGameName_SET(NativePointer, value);
		}

		public string NewGameName
		{
			get => E_PROP_FGameNameRedirect_NewGameName_GET(NativePointer);
			set => E_PROP_FGameNameRedirect_NewGameName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FGameNameRedirect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FGameNameRedirect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameNameRedirect(Adress, false);
		}}}
