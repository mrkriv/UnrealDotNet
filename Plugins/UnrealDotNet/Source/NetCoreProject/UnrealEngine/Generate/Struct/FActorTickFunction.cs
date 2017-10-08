using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorTickFunction : FTickFunction
	{
		internal FActorTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorTickFunction() :
			base(E_CreateStruct_FActorTickFunction(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorTickFunction();
		
		#endregion
		
		public static implicit operator IntPtr(FActorTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorTickFunction(Adress, false);
		}}}
