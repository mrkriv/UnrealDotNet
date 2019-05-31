// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\OrientedBox.h:12

namespace UnrealEngine
{
	public  partial class FOrientedBox : NativeStructWrapper
	{
		internal FOrientedBox(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor.
		/// <para>Constructs a unit-sized, origin-centered box with axes aligned to the coordinate system. </para>
		/// </summary>
		public FOrientedBox() :
			base(E_CreateStruct_FOrientedBox(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FOrientedBox_AxisX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_AxisX_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FOrientedBox_AxisY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_AxisY_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FOrientedBox_AxisZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_AxisZ_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FOrientedBox_Center_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_Center_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FOrientedBox_ExtentX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_ExtentX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FOrientedBox_ExtentY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_ExtentY_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FOrientedBox_ExtentZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOrientedBox_ExtentZ_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOrientedBox();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FOrientedBox_CalcVertices(IntPtr self, IntPtr verts);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds the x-axis vector of the box. Must be a unit vector.
		/// </summary>
		public FVector AxisX
		{
			get => E_PROP_FOrientedBox_AxisX_GET(NativePointer);
			set => E_PROP_FOrientedBox_AxisX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the y-axis vector of the box. Must be a unit vector.
		/// </summary>
		public FVector AxisY
		{
			get => E_PROP_FOrientedBox_AxisY_GET(NativePointer);
			set => E_PROP_FOrientedBox_AxisY_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the z-axis vector of the box. Must be a unit vector.
		/// </summary>
		public FVector AxisZ
		{
			get => E_PROP_FOrientedBox_AxisZ_GET(NativePointer);
			set => E_PROP_FOrientedBox_AxisZ_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the center of the box.
		/// </summary>
		public FVector Center
		{
			get => E_PROP_FOrientedBox_Center_GET(NativePointer);
			set => E_PROP_FOrientedBox_Center_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the extent of the box along its x-axis.
		/// </summary>
		public float ExtentX
		{
			get => E_PROP_FOrientedBox_ExtentX_GET(NativePointer);
			set => E_PROP_FOrientedBox_ExtentX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the extent of the box along its y-axis.
		/// </summary>
		public float ExtentY
		{
			get => E_PROP_FOrientedBox_ExtentY_GET(NativePointer);
			set => E_PROP_FOrientedBox_ExtentY_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the extent of the box along its z-axis.
		/// </summary>
		public float ExtentZ
		{
			get => E_PROP_FOrientedBox_ExtentZ_GET(NativePointer);
			set => E_PROP_FOrientedBox_ExtentZ_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Fills in the Verts array with the eight vertices of the box.
		/// </summary>
		/// <param name="verts">The array to fill in with the vertices.</param>
		public void CalcVertices(FVector verts)
			=> E_FOrientedBox_CalcVertices(this, verts);
		
		#endregion
		
		public static implicit operator IntPtr(FOrientedBox self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FOrientedBox(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FOrientedBox(adress, false);
		}}}
