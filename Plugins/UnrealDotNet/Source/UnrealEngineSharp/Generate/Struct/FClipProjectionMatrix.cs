// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\ClipProjectionMatrix.h:15

namespace UnrealEngine
{
	public  partial class FClipProjectionMatrix : FMatrix
	{
		internal FClipProjectionMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="SrcProjMat">source projection matrix to premultiply with the clip matrix </param>
		/// <param name="Plane">clipping plane used to build the clip matrix (assumed to be in camera space) </param>
		/// </summary>
		public FClipProjectionMatrix(FMatrix srcProjMat, FPlane plane) :
			base(E_CreateStruct_FClipProjectionMatrix_FMatrix_FPlane(srcProjMat, plane), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClipProjectionMatrix_FMatrix_FPlane(IntPtr srcProjMat, IntPtr plane);
		
		#endregion
		
		public static implicit operator IntPtr(FClipProjectionMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FClipProjectionMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClipProjectionMatrix(Adress, false);
		}}}
