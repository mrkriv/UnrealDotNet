// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\RotationMatrix.h:12

namespace UnrealEngine
{
	public  partial class FRotationMatrix : FRotationTranslationMatrix
	{
		internal FRotationMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="rot">rotation</param>
		public FRotationMatrix(FRotator rot) :
			base(E_CreateStruct_FRotationMatrix_FRotator(rot), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationMatrix_FRotator(IntPtr rot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_Make(IntPtr self, IntPtr rot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_Make_o1(IntPtr self, IntPtr rot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromX(IntPtr self, IntPtr xAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromXY(IntPtr self, IntPtr xAxis, IntPtr yAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromXZ(IntPtr self, IntPtr xAxis, IntPtr zAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromY(IntPtr self, IntPtr yAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromYX(IntPtr self, IntPtr yAxis, IntPtr xAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromYZ(IntPtr self, IntPtr yAxis, IntPtr zAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromZ(IntPtr self, IntPtr zAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromZX(IntPtr self, IntPtr zAxis, IntPtr xAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationMatrix_MakeFromZY(IntPtr self, IntPtr zAxis, IntPtr yAxis);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FRotator rot)
			=> E_FRotationMatrix_Make(this, rot);
		
		
		/// <summary>
		/// Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions.
		/// </summary>
		public FMatrix Make(FQuat rot)
			=> E_FRotationMatrix_Make_o1(this, rot);
		
		
		/// <summary>
		/// Builds a rotation matrix given only a XAxis. Y and Z are unspecified but will be orthonormal. XAxis need not be normalized.
		/// </summary>
		public FMatrix MakeFromX(FVector xAxis)
			=> E_FRotationMatrix_MakeFromX(this, xAxis);
		
		
		/// <summary>
		/// Builds a matrix with given X and Y axes. X will remain fixed, Y may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromXY(FVector xAxis, FVector yAxis)
			=> E_FRotationMatrix_MakeFromXY(this, xAxis, yAxis);
		
		
		/// <summary>
		/// Builds a matrix with given X and Z axes. X will remain fixed, Z may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromXZ(FVector xAxis, FVector zAxis)
			=> E_FRotationMatrix_MakeFromXZ(this, xAxis, zAxis);
		
		
		/// <summary>
		/// Builds a rotation matrix given only a YAxis. X and Z are unspecified but will be orthonormal. YAxis need not be normalized.
		/// </summary>
		public FMatrix MakeFromY(FVector yAxis)
			=> E_FRotationMatrix_MakeFromY(this, yAxis);
		
		
		/// <summary>
		/// Builds a matrix with given Y and X axes. Y will remain fixed, X may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromYX(FVector yAxis, FVector xAxis)
			=> E_FRotationMatrix_MakeFromYX(this, yAxis, xAxis);
		
		
		/// <summary>
		/// Builds a matrix with given Y and Z axes. Y will remain fixed, Z may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromYZ(FVector yAxis, FVector zAxis)
			=> E_FRotationMatrix_MakeFromYZ(this, yAxis, zAxis);
		
		
		/// <summary>
		/// Builds a rotation matrix given only a ZAxis. X and Y are unspecified but will be orthonormal. ZAxis need not be normalized.
		/// </summary>
		public FMatrix MakeFromZ(FVector zAxis)
			=> E_FRotationMatrix_MakeFromZ(this, zAxis);
		
		
		/// <summary>
		/// Builds a matrix with given Z and X axes. Z will remain fixed, X may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromZX(FVector zAxis, FVector xAxis)
			=> E_FRotationMatrix_MakeFromZX(this, zAxis, xAxis);
		
		
		/// <summary>
		/// Builds a matrix with given Z and Y axes. Z will remain fixed, Y may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.
		/// </summary>
		public FMatrix MakeFromZY(FVector zAxis, FVector yAxis)
			=> E_FRotationMatrix_MakeFromZY(this, zAxis, yAxis);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationMatrix self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRotationMatrix(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRotationMatrix(adress, false);
		}}}
