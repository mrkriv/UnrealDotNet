using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:562

namespace UnrealEngine
{
	public  partial class FGameModeEvents : NativeStructWrapper
	{
		internal FGameModeEvents(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FGameModeEvents() :
			base(E_CreateStruct_FGameModeEvents(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGameModeEvents();
		
		#endregion
		
		public static implicit operator IntPtr(FGameModeEvents Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FGameModeEvents(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FGameModeEvents(Adress, false);
		}}}
