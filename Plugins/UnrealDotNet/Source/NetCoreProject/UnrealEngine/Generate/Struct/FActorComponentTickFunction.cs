using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorComponentTickFunction : FTickFunction
	{
		public FActorComponentTickFunction() : base(E_CreateStruct_FActorComponentTickFunction(), false)
		{
		}

		internal FActorComponentTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FActorComponentTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FActorComponentTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
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
