// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:181

namespace UnrealEngine
{
	public  partial class FLevelStreamingStatus : NativeStructWrapper
	{
		internal FLevelStreamingStatus(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructors </para>
		/// </summary>
		public FLevelStreamingStatus(string inPackageName, bool bInShouldBeLoaded, bool bInShouldBeVisible, int inLODIndex) :
			base(E_CreateStruct_FLevelStreamingStatus_FName_bool_bool_int32(inPackageName, bInShouldBeLoaded, bInShouldBeVisible, inLODIndex), false)
		{
		}

		public FLevelStreamingStatus() :
			base(E_CreateStruct_FLevelStreamingStatus(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FLevelStreamingStatus_PackageName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelStreamingStatus_PackageName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus_FName_bool_bool_int32(string inPackageName, bool bInShouldBeLoaded, bool bInShouldBeVisible, int inLODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus();
		
		#endregion
		
		#region Property
		public string PackageName
		{
			get => E_PROP_FLevelStreamingStatus_PackageName_GET(NativePointer);
			set => E_PROP_FLevelStreamingStatus_PackageName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLevelStreamingStatus self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLevelStreamingStatus(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingStatus(Adress, false);
		}}}
