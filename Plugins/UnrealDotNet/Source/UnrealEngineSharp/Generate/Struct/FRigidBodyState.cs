// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1127

namespace UnrealEngine
{
	public partial class FRigidBodyState : NativeStructWrapper
	{
		public FRigidBodyState(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FRigidBodyState() :
			base(E_CreateStruct_FRigidBodyState(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRigidBodyState_Flags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyState_Flags_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRigidBodyState_Quaternion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyState_Quaternion_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRigidBodyState();
		
		#endregion
		
		#region Property
		public byte Flags
		{
			get => E_PROP_FRigidBodyState_Flags_GET(NativePointer);
			set => E_PROP_FRigidBodyState_Flags_SET(NativePointer, value);
		}

		public FQuat Quaternion
		{
			get => E_PROP_FRigidBodyState_Quaternion_GET(NativePointer);
			set => E_PROP_FRigidBodyState_Quaternion_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRigidBodyState self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRigidBodyState(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRigidBodyState(adress, false);
		}}}
