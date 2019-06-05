// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\IntPoint.h:16

namespace UnrealEngine
{
	public partial class FIntPoint : NativeStructWrapper
	{
		public FIntPoint(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FIntPoint() :
			base(E_CreateStruct_FIntPoint(), false)
		{
		}

		
		/// <summary>
		/// Create and initialize a new instance with the specified coordinates.
		/// </summary>
		/// <param name="inX">The x-coordinate.</param>
		/// <param name="inY">The y-coordinate.</param>
		public FIntPoint(int inX, int inY) :
			base(E_CreateStruct_FIntPoint_int32_int32(inX, inY), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FIntPoint_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntPoint_X_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FIntPoint_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntPoint_Y_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntPoint();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntPoint_int32_int32(int inX, int inY);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds the point's x-coordinate.
		/// </summary>
		public int X
		{
			get => E_PROP_FIntPoint_X_GET(NativePointer);
			set => E_PROP_FIntPoint_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the point's y-coordinate.
		/// </summary>
		public int Y
		{
			get => E_PROP_FIntPoint_Y_GET(NativePointer);
			set => E_PROP_FIntPoint_Y_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FIntPoint self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FIntPoint(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FIntPoint(adress, false);
		}}}
