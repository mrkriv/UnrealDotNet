// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:149

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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FBasedMovementInfo_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBasedMovementInfo_bRelativeRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_bRelativeRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasBaseComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_bServerHasBaseComponent_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBasedMovementInfo_bServerHasVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_bServerHasVelocity_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBasedMovementInfo_MovementBase_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_MovementBase_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedMovementInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedMovementInfo_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedMovementInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_HasRelativeLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_HasRelativeRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBasedMovementInfo_IsBaseUnresolved(IntPtr self);
		
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
		/// Is location relative?
		/// </summary>
		public bool HasRelativeLocation()
			=> E_FBasedMovementInfo_HasRelativeLocation(this);
		
		
		/// <summary>
		/// Is rotation relative or absolute? It can only be relative if location is also relative.
		/// </summary>
		public bool HasRelativeRotation()
			=> E_FBasedMovementInfo_HasRelativeRotation(this);
		
		
		/// <summary>
		/// Return true if the client should have MovementBase, but it hasn't replicated (possibly component has not streamed in).
		/// </summary>
		public bool IsBaseUnresolved()
			=> E_FBasedMovementInfo_IsBaseUnresolved(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedMovementInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBasedMovementInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBasedMovementInfo(adress, false);
		}}}
