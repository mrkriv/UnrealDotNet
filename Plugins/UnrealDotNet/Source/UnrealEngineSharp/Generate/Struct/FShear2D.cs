// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformCalculus2D.h:150

namespace UnrealEngine
{
	public  partial class FShear2D : NativeStructWrapper
	{
		internal FShear2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Ctor. initialize to an identity.
		/// </summary>
		public FShear2D() :
			base(E_CreateStruct_FShear2D(), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a set of shears parallel to the X and Y axis, respectively.
		/// </summary>
		public FShear2D(float shearX, float shearY) :
			base(E_CreateStruct_FShear2D_float_float(shearX, shearY), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a 2D vector representing a set of shears parallel to the X and Y axis, respectively.
		/// </summary>
		public FShear2D(FVector2D inShear) :
			base(E_CreateStruct_FShear2D_FVector2D(inShear), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FShear2D();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FShear2D_float_float(float shearX, float shearY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FShear2D_FVector2D(IntPtr inShear);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_Concatenate(IntPtr self, IntPtr rHS);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_FromShearAngles(IntPtr self, IntPtr inShearAngles);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_GetVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_TransformPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FShear2D_TransformVector(IntPtr self, IntPtr vector);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Concatenate two shears. The result is NOT a shear, but must be represented by a generalized 2x2 transform.
		/// <para>Defer the implementation until we can declare a 2x2 matrix. </para>
		/// [1 YYA] * [1 YYB] == [1+YYA*XXB YYB*YYA]
		/// <para>[XXA 1]   [XXB 1]    [XXA+XXB XXA*XXB+1] </para>
		/// </summary>
		public FMatrix2x2 Concatenate(FShear2D rHS)
			=> E_FShear2D_Concatenate(this, rHS);
		
		
		/// <summary>
		/// Generates a shear structure based on angles instead of slope.
		/// </summary>
		/// <param name="inShearAngles">The angles of shear.</param>
		/// <return>the</return>
		public FShear2D FromShearAngles(FVector2D inShearAngles)
			=> E_FShear2D_FromShearAngles(this, inShearAngles);
		
		
		/// <summary>
		/// Access to the underlying FVector2D that stores the scale.
		/// </summary>
		public FVector2D GetVector()
			=> E_FShear2D_GetVector(this);
		
		
		/// <summary>
		/// Invert the shear. The result is NOT a shear, but must be represented by a generalized 2x2 transform.
		/// <para>Defer the implementation until we can declare a 2x2 matrix. </para>
		/// [1 YY]^-1  == 1/(1-YY*XX) * [1 -YY]
		/// <para>[XX 1]                      [-XX 1] </para>
		/// </summary>
		public FMatrix2x2 Inverse()
			=> E_FShear2D_Inverse(this);
		
		
		/// <summary>
		/// Transform 2D Point
		/// <para>[X Y] * [1 YY] == [X+Y*XX Y+X*YY] </para>
		/// [XX 1]
		/// </summary>
		public FVector2D TransformPoint(FVector2D point)
			=> E_FShear2D_TransformPoint(this, point);
		
		
		/// <summary>
		/// Transform 2D Vector
		/// </summary>
		public FVector2D TransformVector(FVector2D vector)
			=> E_FShear2D_TransformVector(this, vector);
		
		#endregion
		
		public static implicit operator IntPtr(FShear2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator FShear2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FShear2D(Adress, false);
		}}}
