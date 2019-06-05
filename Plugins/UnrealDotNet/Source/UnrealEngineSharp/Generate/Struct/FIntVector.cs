// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\IntVector.h:14

namespace UnrealEngine
{
	public partial class FIntVector : NativeStructWrapper
	{
		public FIntVector(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FIntVector() :
			base(E_CreateStruct_FIntVector(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new instance with the specified coordinates.
		/// </summary>
		/// <param name="inX">The x-coordinate.</param>
		/// <param name="inY">The y-coordinate.</param>
		/// <param name="inZ">The z-coordinate.</param>
		public FIntVector(int inX, int inY, int inZ) :
			base(E_CreateStruct_FIntVector_int32_int32_int32(inX, inY, inZ), false)
		{
		}

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="inValue">replicated to all components</param>
		public FIntVector(int inValue) :
			base(E_CreateStruct_FIntVector_int32(inValue), false)
		{
		}

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="inVector">float vector converted to int</param>
		public FIntVector(FVector inVector) :
			base(E_CreateStruct_FIntVector_FVector(inVector), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FIntVector_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntVector_X_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FIntVector_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntVector_Y_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FIntVector_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FIntVector_Z_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntVector();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntVector_int32_int32_int32(int inX, int inY, int inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntVector_int32(int inValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FIntVector_FVector(IntPtr inVector);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds the point's x-coordinate.
		/// </summary>
		public int X
		{
			get => E_PROP_FIntVector_X_GET(NativePointer);
			set => E_PROP_FIntVector_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the point's y-coordinate.
		/// </summary>
		public int Y
		{
			get => E_PROP_FIntVector_Y_GET(NativePointer);
			set => E_PROP_FIntVector_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the point's z-coordinate.
		/// </summary>
		public int Z
		{
			get => E_PROP_FIntVector_Z_GET(NativePointer);
			set => E_PROP_FIntVector_Z_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FIntVector self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FIntVector(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FIntVector(adress, false);
		}}}
