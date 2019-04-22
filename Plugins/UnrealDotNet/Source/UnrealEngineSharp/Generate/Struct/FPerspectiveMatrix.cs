// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\PerspectiveMatrix.h:10

namespace UnrealEngine
{
	public  partial class FPerspectiveMatrix : FMatrix
	{
		internal FPerspectiveMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="HalfFOVX">Half FOV in the X axis </param>
		/// <param name="HalfFOVY">Half FOV in the Y axis </param>
		/// <param name="MultFOVX">multiplier on the X axis </param>
		/// <param name="MultFOVY">multiplier on the y axis </param>
		/// <param name="MinZ">distance to the near Z plane </param>
		/// <param name="MaxZ">distance to the far Z plane </param>
		/// </summary>
		public FPerspectiveMatrix(float halfFOVX, float halfFOVY, float multFOVX, float multFOVY, float minZ, float maxZ) :
			base(E_CreateStruct_FPerspectiveMatrix_float_float_float_float_float_float(halfFOVX, halfFOVY, multFOVX, multFOVY, minZ, maxZ), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="HalfFOV">half Field of View in the Y direction </param>
		/// <param name="Width">view space width </param>
		/// <param name="Height">view space height </param>
		/// <param name="MinZ">distance to the near Z plane </param>
		/// <param name="MaxZ">distance to the far Z plane </param>
		/// <para>@note that the FOV you pass in is actually half the FOV, unlike most perspective matrix functions (D3DXMatrixPerspectiveFovLH). </para>
		/// </summary>
		public FPerspectiveMatrix(float halfFOV, float width, float height, float minZ, float maxZ) :
			base(E_CreateStruct_FPerspectiveMatrix_float_float_float_float_float(halfFOV, width, height, minZ, maxZ), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="HalfFOV">half Field of View in the Y direction </param>
		/// <param name="Width">view space width </param>
		/// <param name="Height">view space height </param>
		/// <param name="MinZ">distance to the near Z plane </param>
		/// <para>@note that the FOV you pass in is actually half the FOV, unlike most perspective matrix functions (D3DXMatrixPerspectiveFovLH). </para>
		/// </summary>
		public FPerspectiveMatrix(float halfFOV, float width, float height, float minZ) :
			base(E_CreateStruct_FPerspectiveMatrix_float_float_float_float(halfFOV, width, height, minZ), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerspectiveMatrix_float_float_float_float_float_float(float halfFOVX, float halfFOVY, float multFOVX, float multFOVY, float minZ, float maxZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerspectiveMatrix_float_float_float_float_float(float halfFOV, float width, float height, float minZ, float maxZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerspectiveMatrix_float_float_float_float(float halfFOV, float width, float height, float minZ);
		
		#endregion
		
		public static implicit operator IntPtr(FPerspectiveMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FPerspectiveMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPerspectiveMatrix(Adress, false);
		}}}
