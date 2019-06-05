// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\CapsuleShape.h:13

namespace UnrealEngine
{
	public partial class FCapsuleShape : NativeStructWrapper
	{
		public FCapsuleShape(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor.
		/// </summary>
		public FCapsuleShape() :
			base(E_CreateStruct_FCapsuleShape(), false)
		{
		}

		
		/// <summary>
		/// Create and inintialize a new instance.
		/// </summary>
		/// <param name="inCenter">The capsule's center point.</param>
		/// <param name="inRadius">The capsule's radius.</param>
		/// <param name="inOrientation">The capsule's orientation in space.</param>
		/// <param name="inLength">The capsule's length.</param>
		public FCapsuleShape(FVector inCenter, float inRadius, FVector inOrientation, float inLength) :
			base(E_CreateStruct_FCapsuleShape_FVector_float_FVector_float(inCenter, inRadius, inOrientation, inLength), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCapsuleShape_Center_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCapsuleShape_Center_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCapsuleShape_Length_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCapsuleShape_Length_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCapsuleShape_Orientation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCapsuleShape_Orientation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCapsuleShape_Radius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCapsuleShape_Radius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCapsuleShape();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCapsuleShape_FVector_float_FVector_float(IntPtr inCenter, float inRadius, IntPtr inOrientation, float inLength);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The capsule's center point.
		/// </summary>
		public FVector Center
		{
			get => E_PROP_FCapsuleShape_Center_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Center_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The capsule's length.
		/// </summary>
		public float Length
		{
			get => E_PROP_FCapsuleShape_Length_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Length_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The capsule's orientation in space.
		/// </summary>
		public FVector Orientation
		{
			get => E_PROP_FCapsuleShape_Orientation_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Orientation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The capsule's radius.
		/// </summary>
		public float Radius
		{
			get => E_PROP_FCapsuleShape_Radius_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Radius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCapsuleShape self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCapsuleShape(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCapsuleShape(adress, false);
		}}}
