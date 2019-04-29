// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:691

namespace UnrealEngine
{
	public  partial class FLevelStreamingWrapper : NativeStructWrapper
	{
		internal FLevelStreamingWrapper(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLevelStreamingWrapper() :
			base(E_CreateStruct_FLevelStreamingWrapper(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingWrapper();
		
		#endregion
		
		public static implicit operator IntPtr(FLevelStreamingWrapper self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLevelStreamingWrapper(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingWrapper(Adress, false);
		}}}
