// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AITypes.h:430

namespace UnrealEngine
{
	public partial class FAIRequestID : NativeStructWrapper
	{
		public FAIRequestID(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIRequestID() :
			base(E_CreateStruct_FAIRequestID(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIRequestID_AnyRequest_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIRequestID_CurrentRequest_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIRequestID_InvalidRequest_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIRequestID();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIRequestID_IsEquivalent(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIRequestID_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIRequestID_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		public static FAIRequestID AnyRequest
		{
			get => E_PROP_FAIRequestID_AnyRequest_GET();
		}

		public static FAIRequestID CurrentRequest
		{
			get => E_PROP_FAIRequestID_CurrentRequest_GET();
		}

		public static FAIRequestID InvalidRequest
		{
			get => E_PROP_FAIRequestID_InvalidRequest_GET();
		}

		#endregion
		
		#region ExternMethods
		public bool IsEquivalent(FAIRequestID other)
			=> E_FAIRequestID_IsEquivalent(this, other);
		
		public bool IsValid()
			=> E_FAIRequestID_IsValid(this);
		
		public override string ToString()
			=> E_FAIRequestID_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIRequestID self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIRequestID(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIRequestID(adress, false);
		}}}
