using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Active and named net drivers instantiated from an FNetDriverDefinition
	/// The net driver will remain instantiated on this struct until it is destroyed
	/// </summary>
	public partial class FNamedNetDriver
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FNamedNetDriver()
		{
			NativePointer = E_CreateStruct_FNamedNetDriver();
			IsRef = false;
		}

		internal FNamedNetDriver(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FNamedNetDriver();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		public static implicit operator IntPtr(FNamedNetDriver Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FNamedNetDriver(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FNamedNetDriver(Adress, false);
		}}}
