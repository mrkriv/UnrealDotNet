using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1347

namespace UnrealEngine
{
	public  partial class FFractureEffect : NativeStructWrapper
	{
		internal FFractureEffect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFractureEffect() :
			base(E_CreateStruct_FFractureEffect(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFractureEffect();
		
		#endregion
		
		public static implicit operator IntPtr(FFractureEffect Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFractureEffect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFractureEffect(Adress, false);
		}}}
