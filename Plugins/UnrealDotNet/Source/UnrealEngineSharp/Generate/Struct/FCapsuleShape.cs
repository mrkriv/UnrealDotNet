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
	public  partial class FCapsuleShape : NativeStructWrapper
	{
		internal FCapsuleShape(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FCapsuleShape() :
			base(E_CreateStruct_FCapsuleShape(), false)
		{
		}

		
		/// <summary>
		/// <para>Create and inintialize a new instance. </para>
		/// <param name="InCenter">The capsule's center point. </param>
		/// <param name="InRadius">The capsule's radius. </param>
		/// <param name="InOrientation">The capsule's orientation in space. </param>
		/// <param name="InLength">The capsule's length. </param>
		/// </summary>
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
		/// <para>The capsule's center point. </para>
		/// </summary>
		public FVector Center
		{
			get => E_PROP_FCapsuleShape_Center_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Center_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The capsule's length. </para>
		/// </summary>
		public float Length
		{
			get => E_PROP_FCapsuleShape_Length_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Length_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The capsule's orientation in space. </para>
		/// </summary>
		public FVector Orientation
		{
			get => E_PROP_FCapsuleShape_Orientation_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Orientation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The capsule's radius. </para>
		/// </summary>
		public float Radius
		{
			get => E_PROP_FCapsuleShape_Radius_GET(NativePointer);
			set => E_PROP_FCapsuleShape_Radius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCapsuleShape self)
		{
			return self.NativePointer;
		}

		public static implicit operator FCapsuleShape(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCapsuleShape(Adress, false);
		}}}
