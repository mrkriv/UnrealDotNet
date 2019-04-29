// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Public\CollisionQueryParams.h:236

namespace UnrealEngine
{
	public  partial class FCollisionResponseParams : NativeStructWrapper
	{
		internal FCollisionResponseParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCollisionResponseParams(ECollisionResponse defaultResponse) :
			base(E_CreateStruct_FCollisionResponseParams_ECollisionResponse((byte)defaultResponse), false)
		{
		}

		public FCollisionResponseParams(FCollisionResponseContainer responseContainer) :
			base(E_CreateStruct_FCollisionResponseParams_FCollisionResponseContainer(responseContainer), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCollisionResponseParams_CollisionResponse_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionResponseParams_CollisionResponse_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCollisionResponseParams_DefaultResponseParam_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseParams_ECollisionResponse(byte defaultResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionResponseParams_FCollisionResponseContainer(IntPtr responseContainer);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Collision Response container for trace filtering. If you'd like to ignore certain channel for this trace, use this struct.
		/// <para>By default, every channel will be blocked </para>
		/// </summary>
		public FCollisionResponseContainer CollisionResponse
		{
			get => E_PROP_FCollisionResponseParams_CollisionResponse_GET(NativePointer);
			set => E_PROP_FCollisionResponseParams_CollisionResponse_SET(NativePointer, value);
		}

		
		/// <summary>
		/// static variable for default data to be used without reconstructing everytime
		/// </summary>
		public static FCollisionResponseParams DefaultResponseParam
		{
			get => E_PROP_FCollisionResponseParams_DefaultResponseParam_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(FCollisionResponseParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCollisionResponseParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCollisionResponseParams(Adress, false);
		}}}
