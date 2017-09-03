using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageBasedMovementInfo
	/// <para>Struct to hold information about the "base" object the character is standing on. </para>
	/// </summary>
	public  partial class FBasedMovementInfo : NativeStructWrapper
	{
		public FBasedMovementInfo() : base(E_CreateStruct_FBasedMovementInfo(), false)
		{
		}

		internal FBasedMovementInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBasedMovementInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FBasedMovementInfo_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FBasedMovementInfo_bRelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern UPrimitiveComponent E_PROP_FBasedMovementInfo_MovementBase_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_MovementBase_SET(IntPtr Ptr, UPrimitiveComponent Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FRotator E_PROP_FBasedMovementInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBasedMovementInfo_Rotation_SET(IntPtr Ptr, FRotator Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBasedMovementInfo_HasRelativeLocation(FBasedMovementInfo Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBasedMovementInfo_HasRelativePosition(FBasedMovementInfo Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBasedMovementInfo_HasRelativeRotation(FBasedMovementInfo Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBasedMovementInfo_IsBaseUnresolved(FBasedMovementInfo Self);
		
		#endregion
		
		#region Property
		public string BoneName
		{
			get => E_PROP_FBasedMovementInfo_BoneName_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_BoneName_SET(NativePointer, value);
		}

		public bool bRelativeRotation
		{
			get => E_PROP_FBasedMovementInfo_bRelativeRotation_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bRelativeRotation_SET(NativePointer, value);
		}

		public bool bServerHasBaseComponent
		{
			get => E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(NativePointer, value);
		}

		public bool bServerHasVelocity
		{
			get => E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(NativePointer, value);
		}

		public UPrimitiveComponent MovementBase
		{
			get => E_PROP_FBasedMovementInfo_MovementBase_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_MovementBase_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FBasedMovementInfo_Rotation_GET(NativePointer);
			set => E_PROP_FBasedMovementInfo_Rotation_SET(NativePointer, value);
		}

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
