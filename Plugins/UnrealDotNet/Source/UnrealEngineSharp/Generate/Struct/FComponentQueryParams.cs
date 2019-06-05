// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Public\CollisionQueryParams.h:212

namespace UnrealEngine
{
	public partial class FComponentQueryParams : FCollisionQueryParams
	{
		public FComponentQueryParams(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FComponentQueryParams() :
			base(E_CreateStruct_FComponentQueryParams(), false)
		{
		}

		public FComponentQueryParams(string inTraceTag, AActor inIgnoreActor) :
			base(E_CreateStruct_FComponentQueryParams_FName_AActor(inTraceTag, inIgnoreActor), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FComponentQueryParams_DefaultComponentQueryParams_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentQueryParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentQueryParams_FName_AActor(string inTraceTag, IntPtr inIgnoreActor);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// static variable for default data to be used without reconstructing everytime
		/// </summary>
		public static FComponentQueryParams DefaultComponentQueryParams
		{
			get => E_PROP_FComponentQueryParams_DefaultComponentQueryParams_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(FComponentQueryParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FComponentQueryParams(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FComponentQueryParams(adress, false);
		}}}
