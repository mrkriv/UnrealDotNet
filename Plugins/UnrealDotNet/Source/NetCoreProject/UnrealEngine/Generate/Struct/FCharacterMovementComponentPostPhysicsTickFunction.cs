using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:105

namespace UnrealEngine
{
	public  partial class FCharacterMovementComponentPostPhysicsTickFunction : FTickFunction
	{
		internal FCharacterMovementComponentPostPhysicsTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCharacterMovementComponentPostPhysicsTickFunction() :
			base(E_CreateStruct_FCharacterMovementComponentPostPhysicsTickFunction(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCharacterMovementComponentPostPhysicsTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FCharacterMovementComponentPostPhysicsTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCharacterMovementComponentPostPhysicsTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>CharacterMovementComponent that is the target of this tick </para>
		/// </summary>
		public UCharacterMovementComponent Target
		{
			get => E_PROP_FCharacterMovementComponentPostPhysicsTickFunction_Target_GET(NativePointer);
			set => E_PROP_FCharacterMovementComponentPostPhysicsTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCharacterMovementComponentPostPhysicsTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCharacterMovementComponentPostPhysicsTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCharacterMovementComponentPostPhysicsTickFunction(Adress, false);
		}}}
