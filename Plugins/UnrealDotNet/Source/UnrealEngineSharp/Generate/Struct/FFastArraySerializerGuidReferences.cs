// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:360

namespace UnrealEngine
{
	public partial class FFastArraySerializerGuidReferences : NativeStructWrapper
	{
		public FFastArraySerializerGuidReferences(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFastArraySerializerGuidReferences() :
			base(E_CreateStruct_FFastArraySerializerGuidReferences(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializerGuidReferences_NumBufferBits_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializerGuidReferences_NumBufferBits_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFastArraySerializerGuidReferences();
		
		#endregion
		
		#region Property
		public int NumBufferBits
		{
			get => E_PROP_FFastArraySerializerGuidReferences_NumBufferBits_GET(NativePointer);
			set => E_PROP_FFastArraySerializerGuidReferences_NumBufferBits_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFastArraySerializerGuidReferences self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFastArraySerializerGuidReferences(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFastArraySerializerGuidReferences(adress, false);
		}}}
