using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBasedMovementInfo : NativeStructWrapper
	{
		internal FBasedMovementInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBasedMovementInfo() :
			base(E_CreateStruct_FBasedMovementInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedMovementInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_HasRelativeLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_HasRelativePosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_HasRelativeRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_IsBaseUnresolved(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Is location relative? </para>
		/// </summary>
		public bool HasRelativeLocation()
			=> E_FBasedMovementInfo_HasRelativeLocation(this);
		
		public bool HasRelativePosition()
			=> E_FBasedMovementInfo_HasRelativePosition(this);
		
		
		/// <summary>
		/// <para>Is rotation relative or absolute? It can only be relative if location is also relative. </para>
		/// </summary>
		public bool HasRelativeRotation()
			=> E_FBasedMovementInfo_HasRelativeRotation(this);
		
		
		/// <summary>
		/// <para>Return true if the client should have MovementBase, but it hasn't replicated (possibly component has not streamed in). </para>
		/// </summary>
		public bool IsBaseUnresolved()
			=> E_FBasedMovementInfo_IsBaseUnresolved(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedMovementInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBasedMovementInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBasedMovementInfo(Adress, false);
		}}}
