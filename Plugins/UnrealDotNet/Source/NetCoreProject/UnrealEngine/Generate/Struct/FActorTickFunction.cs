using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorTickFunction : FTickFunction
	{
		public FActorTickFunction() : base(E_CreateStruct_FActorTickFunction(), false)
		{
		}

		internal FActorTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FActorTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FActorTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>AActor  that is the target of this tick </para>
		/// </summary>
		public AActor Target
		{
			get => E_PROP_FActorTickFunction_Target_GET(NativePointer);
			set => E_PROP_FActorTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActorTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorTickFunction(Adress, false);
		}}}
