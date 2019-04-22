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
	public  partial class FIntVector : NativeStructWrapper
	{
		internal FIntVector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FIntVector() :
			base(E_CreateStruct_FIntVector(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance with the specified coordinates. </para>
		/// <param name="InX">The x-coordinate. </param>
		/// <param name="InY">The y-coordinate. </param>
		/// <param name="InZ">The z-coordinate. </param>
		/// </summary>
		public FIntVector(int inX, int inY, int inZ) :
			base(E_CreateStruct_FIntVector_int32_int32_int32(inX, inY, inZ), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="InValue">replicated to all components </param>
		/// </summary>
		public FIntVector(int inValue) :
			base(E_CreateStruct_FIntVector_int32(inValue), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="InVector">float vector converted to int </param>
		/// </summary>
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
		/// <para>Holds the point's x-coordinate. </para>
		/// </summary>
		public int X
		{
			get => E_PROP_FIntVector_X_GET(NativePointer);
			set => E_PROP_FIntVector_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the point's y-coordinate. </para>
		/// </summary>
		public int Y
		{
			get => E_PROP_FIntVector_Y_GET(NativePointer);
			set => E_PROP_FIntVector_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the point's z-coordinate. </para>
		/// </summary>
		public int Z
		{
			get => E_PROP_FIntVector_Z_GET(NativePointer);
			set => E_PROP_FIntVector_Z_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FIntVector self)
		{
			return self.NativePointer;
		}

		public static implicit operator FIntVector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FIntVector(Adress, false);
		}}}
