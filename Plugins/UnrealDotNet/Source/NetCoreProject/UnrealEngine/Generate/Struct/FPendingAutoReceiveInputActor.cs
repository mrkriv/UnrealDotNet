using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Struct that holds on to information about Actors that wish to be auto enabled for input before the player controller has been created
	/// </summary>
	public partial class FPendingAutoReceiveInputActor
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPendingAutoReceiveInputActor()
		{
			NativePointer = E_CreateStruct_FPendingAutoReceiveInputActor();
			IsRef = false;
		}

		internal FPendingAutoReceiveInputActor(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPendingAutoReceiveInputActor();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FPendingAutoReceiveInputActor_PlayerIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPendingAutoReceiveInputActor_PlayerIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		public int PlayerIndex
		{
			get => E_PROP_FPendingAutoReceiveInputActor_PlayerIndex_GET(NativePointer);
			set => E_PROP_FPendingAutoReceiveInputActor_PlayerIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPendingAutoReceiveInputActor Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPendingAutoReceiveInputActor(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPendingAutoReceiveInputActor(Adress, false);
		}}}
