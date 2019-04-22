// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformCalculus2D.h:234

namespace UnrealEngine
{
	public  partial class FQuat2D : NativeStructWrapper
	{
		internal FQuat2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Ctor. initialize to an identity rotation. </para>
		/// </summary>
		public FQuat2D() :
			base(E_CreateStruct_FQuat2D(), false)
		{
		}

		
		/// <summary>
		/// <para>Ctor. initialize from a rotation in radians. </para>
		/// </summary>
		public FQuat2D(float rotRadians) :
			base(E_CreateStruct_FQuat2D_float(rotRadians), false)
		{
		}

		
		/// <summary>
		/// <para>Ctor. initialize from an FVector2D, representing a complex number. </para>
		/// </summary>
		public FQuat2D(FVector2D inRot) :
			base(E_CreateStruct_FQuat2D_FVector2D(inRot), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat2D();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat2D_float(float rotRadians);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat2D_FVector2D(IntPtr inRot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat2D_Concatenate(IntPtr self, IntPtr rHS);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat2D_GetVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat2D_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat2D_TransformPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat2D_TransformVector(IntPtr self, IntPtr vector);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Transform 2 rotations defined by complex numbers: </para>
		/// <para>In imaginary land: (A + Bi) * (C + Di) == (AC - BD) + (AD + BC)i </para>
		/// <para>Looking at this as a matrix, A == cos(theta), B == sin(theta), C == cos(sigma), D == sin(sigma): </para>
		/// <para>[ A B] * [ C D] == [  AC-BD  AD+BC] </para>
		/// <para>[-B A]   [-D C]    [-(AD+BC) AC-BD] </para>
		/// <para>If you look at how the vector multiply works out: [X(AC-BD)+Y(-BC-AD)  X(AD+BC)+Y(-BD+AC)] </para>
		/// <para>you can see it follows the same form of the imaginary form. Indeed, check out how the matrix nicely works </para>
		/// <para>out to [ A B] for a visual proof of the results. </para>
		/// <para>[-B A] </para>
		/// </summary>
		public FQuat2D Concatenate(FQuat2D rHS)
			=> E_FQuat2D_Concatenate(this, rHS);
		
		
		/// <summary>
		/// <para>Access to the underlying FVector2D that stores the complex number. </para>
		/// </summary>
		public FVector2D GetVector()
			=> E_FQuat2D_GetVector(this);
		
		
		/// <summary>
		/// <para>Invert the rotation  defined by complex numbers: </para>
		/// <para>In imaginary land, an inverse is a complex conjugate, which is equivalent to reflecting about the X axis: </para>
		/// <para>Conj(A + Bi) == A - Bi </para>
		/// </summary>
		public FQuat2D Inverse()
			=> E_FQuat2D_Inverse(this);
		
		
		/// <summary>
		/// <para>Transform a 2D point by the 2D complex number representing the rotation: </para>
		/// <para>In imaginary land: (x + yi) * (u + vi) == (xu - yv) + (xv + yu)i </para>
		/// <para>Looking at this as a matrix, x == cos(A), y == sin(A) </para>
		/// <para>[x y] * [ cosA  sinA] == [x y] * [ u v] == [xu-yv xv+yu] </para>
		/// <para>[-sinA  cosA]            [-v u] </para>
		/// <para>Looking at the above results, we see the equivalence with matrix multiplication. </para>
		/// </summary>
		public FVector2D TransformPoint(FVector2D point)
			=> E_FQuat2D_TransformPoint(this, point);
		
		
		/// <summary>
		/// <para>Vector rotation is equivalent to rotating a point. </para>
		/// </summary>
		public FVector2D TransformVector(FVector2D vector)
			=> E_FQuat2D_TransformVector(this, vector);
		
		#endregion
		
		public static implicit operator IntPtr(FQuat2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator FQuat2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuat2D(Adress, false);
		}}}
