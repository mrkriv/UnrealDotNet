// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Edge.h:11

namespace UnrealEngine
{
	public partial class FEdge : NativeStructWrapper
	{
		public FEdge(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FEdge() :
			base(E_CreateStruct_FEdge(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new edge from two vertices.
		/// </summary>
		/// <param name="v1">The first vertex.</param>
		/// <param name="v2">The second vertex.</param>
		public FEdge(FVector v1, FVector v2) :
			base(E_CreateStruct_FEdge_FVector_FVector(v1, v2), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEdge_Count_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEdge_Count_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEdge();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEdge_FVector_FVector(IntPtr v1, IntPtr v2);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds a temporary variable used when creating arrays of unique edges.
		/// </summary>
		public int Count
		{
			get => E_PROP_FEdge_Count_GET(NativePointer);
			set => E_PROP_FEdge_Count_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FEdge self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEdge(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEdge(adress, false);
		}}}
