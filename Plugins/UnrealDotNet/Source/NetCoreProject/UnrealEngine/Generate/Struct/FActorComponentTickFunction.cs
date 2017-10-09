using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:453

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorComponentTickFunction();
		
		#endregion
		
		public static implicit operator IntPtr(FActorComponentTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorComponentTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorComponentTickFunction(Adress, false);
		}}}
