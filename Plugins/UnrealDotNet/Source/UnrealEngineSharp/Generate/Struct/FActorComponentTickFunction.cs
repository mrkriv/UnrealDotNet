// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:461

namespace UnrealEngine
{
	public  partial class FActorComponentTickFunction : FTickFunction
	{
		internal FActorComponentTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorComponentTickFunction() :
			base(E_CreateStruct_FActorComponentTickFunction(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FActorComponentTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorComponentTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorComponentTickFunction();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// AActor  component that is the target of this tick
		/// </summary>
		public UActorComponent Target
		{
			get => E_PROP_FActorComponentTickFunction_Target_GET(NativePointer);
			set => E_PROP_FActorComponentTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActorComponentTickFunction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FActorComponentTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorComponentTickFunction(Adress, false);
		}}}
