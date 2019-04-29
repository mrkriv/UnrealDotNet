// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Float16Color.h:12

namespace UnrealEngine
{
	public  partial class FFloat16Color : NativeStructWrapper
	{
		internal FFloat16Color(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor
		/// </summary>
		public FFloat16Color() :
			base(E_CreateStruct_FFloat16Color(), false)
		{
		}

		
		/// <summary>
		/// Copy constructor.
		/// </summary>
		public FFloat16Color(FFloat16Color src) :
			base(E_CreateStruct_FFloat16Color_FFloat16Color(src), false)
		{
		}

		
		/// <summary>
		/// Constructor from a linear color.
		/// </summary>
		public FFloat16Color(FLinearColor src) :
			base(E_CreateStruct_FFloat16Color_FLinearColor(src), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFloat16Color_A_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloat16Color_A_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFloat16Color_B_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloat16Color_B_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFloat16Color_G_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloat16Color_G_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFloat16Color_R_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFloat16Color_R_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16Color();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16Color_FFloat16Color(IntPtr src);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFloat16Color_FLinearColor(IntPtr src);
		
		#endregion
		
		#region Property
		public FFloat16 A
		{
			get => E_PROP_FFloat16Color_A_GET(NativePointer);
			set => E_PROP_FFloat16Color_A_SET(NativePointer, value);
		}

		public FFloat16 B
		{
			get => E_PROP_FFloat16Color_B_GET(NativePointer);
			set => E_PROP_FFloat16Color_B_SET(NativePointer, value);
		}

		public FFloat16 G
		{
			get => E_PROP_FFloat16Color_G_GET(NativePointer);
			set => E_PROP_FFloat16Color_G_SET(NativePointer, value);
		}

		public FFloat16 R
		{
			get => E_PROP_FFloat16Color_R_GET(NativePointer);
			set => E_PROP_FFloat16Color_R_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFloat16Color self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFloat16Color(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFloat16Color(Adress, false);
		}}}
