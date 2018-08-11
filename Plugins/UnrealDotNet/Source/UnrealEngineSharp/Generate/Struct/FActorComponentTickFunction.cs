using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:453

namespace UnrealEngine
{
	public  partial class FActorComponentTickFunction : FTickFunction
	{
		internal FActorComponentTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorComponentTickFunction() :
			base(E_CreateStruct_FActorComponentTickFunction(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorComponentTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FActorComponentTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorComponentTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>AActor  component that is the target of this tick </para>
		/// </summary>
		public UActorComponent Target
		{
			get => E_PROP_FActorComponentTickFunction_Target_GET(NativePointer);
			set => E_PROP_FActorComponentTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActorComponentTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorComponentTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorComponentTickFunction(Adress, false);
		}}}
