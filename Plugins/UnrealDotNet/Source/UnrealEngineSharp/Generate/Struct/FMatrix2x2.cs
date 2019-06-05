// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformCalculus2D.h:320

namespace UnrealEngine
{
	public partial class FMatrix2x2 : NativeStructWrapper
	{
		public FMatrix2x2(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Ctor. initialize to an identity.
		/// </summary>
		public FMatrix2x2() :
			base(E_CreateStruct_FMatrix2x2(), false)
		{
		}

		public FMatrix2x2(float m00, float m01, float m10, float m11) :
			base(E_CreateStruct_FMatrix2x2_float_float_float_float(m00, m01, m10, m11), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a scale.
		/// </summary>
		public FMatrix2x2(float uniformScale) :
			base(E_CreateStruct_FMatrix2x2_float(uniformScale), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a scale.
		/// </summary>
		public FMatrix2x2(FScale2D scale) :
			base(E_CreateStruct_FMatrix2x2_FScale2D(scale), false)
		{
		}

		
		/// <summary>
		/// Factory function. initialize from a 2D shear.
		/// </summary>
		public FMatrix2x2(FShear2D shear) :
			base(E_CreateStruct_FMatrix2x2_FShear2D(shear), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a rotation.
		/// </summary>
		public FMatrix2x2(FQuat2D rotation) :
			base(E_CreateStruct_FMatrix2x2_FQuat2D(rotation), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2_float_float_float_float(float m00, float m01, float m10, float m11);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2_float(float uniformScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2_FScale2D(IntPtr scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2_FShear2D(IntPtr shear);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMatrix2x2_FQuat2D(IntPtr rotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_Concatenate(IntPtr self, IntPtr rHS);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FMatrix2x2_Determinant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FMatrix2x2_GetMatrix(IntPtr self, float a, float b, float c, float d);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FMatrix2x2_GetRotationAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_GetScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_GetScaleSquared(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FMatrix2x2_InverseDeterminant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FMatrix2x2_IsIdentity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FMatrix2x2_IsNearlyIdentity(IntPtr self, float errorTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_TransformPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FMatrix2x2_TransformVector(IntPtr self, IntPtr vector);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Concatenate 2 matrices:
		/// <para>[A B] * [E F] == [AE+BG AF+BH] </para>
		/// [C D]   [G H]    [CE+DG CF+DH]
		/// </summary>
		public FMatrix2x2 Concatenate(FMatrix2x2 rHS)
			=> E_FMatrix2x2_Concatenate(this, rHS);
		
		public float Determinant()
			=> E_FMatrix2x2_Determinant(this);
		
		public void GetMatrix(float a, float b, float c, float d)
			=> E_FMatrix2x2_GetMatrix(this, a, b, c, d);
		
		
		/// <summary>
		/// Gets the rotation angle of the matrix.
		/// </summary>
		public float GetRotationAngle()
			=> E_FMatrix2x2_GetRotationAngle(this);
		
		
		/// <summary>
		/// Gets the scale from the matrix.
		/// </summary>
		public FScale2D GetScale()
			=> E_FMatrix2x2_GetScale(this);
		
		
		/// <summary>
		/// Extracts the squared scale from the matrix (avoids sqrt).
		/// </summary>
		public FScale2D GetScaleSquared()
			=> E_FMatrix2x2_GetScaleSquared(this);
		
		
		/// <summary>
		/// Invert the transform.
		/// </summary>
		public FMatrix2x2 Inverse()
			=> E_FMatrix2x2_Inverse(this);
		
		public float InverseDeterminant()
			=> E_FMatrix2x2_InverseDeterminant(this);
		
		
		/// <summary>
		/// Determines if the matrix is identity or not. Uses exact float comparison, so rounding error is not considered.
		/// </summary>
		public bool IsIdentity()
			=> E_FMatrix2x2_IsIdentity(this);
		
		public bool IsNearlyIdentity(float errorTolerance)
			=> E_FMatrix2x2_IsNearlyIdentity(this, errorTolerance);
		
		
		/// <summary>
		/// Transform a 2D point
		/// <para>[X Y] * [m00 m01] </para>
		/// [m10 m11]
		/// </summary>
		public FVector2D TransformPoint(FVector2D point)
			=> E_FMatrix2x2_TransformPoint(this, point);
		
		
		/// <summary>
		/// Vector transformation is equivalent to point transformation as our matrix is not homogeneous.
		/// </summary>
		public FVector2D TransformVector(FVector2D vector)
			=> E_FMatrix2x2_TransformVector(this, vector);
		
		#endregion
		
		public static implicit operator IntPtr(FMatrix2x2 self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMatrix2x2(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMatrix2x2(adress, false);
		}}}
