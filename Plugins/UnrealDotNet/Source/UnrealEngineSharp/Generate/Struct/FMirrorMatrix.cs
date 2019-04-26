// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\MirrorMatrix.h:12

namespace UnrealEngine
{
	public  partial class FMirrorMatrix : FMatrix
	{
		internal FMirrorMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor. Updated for the fact that our FPlane uses Ax+By+Cz=D. </para>
		/// <param name="Plane">source plane for mirroring (assumed normalized) </param>
		/// </summary>
		public FMirrorMatrix(FPlane plane) :
			base(E_CreateStruct_FMirrorMatrix_FPlane(plane), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMirrorMatrix_FPlane(IntPtr plane);
		
		#endregion
		
		public static implicit operator IntPtr(FMirrorMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FMirrorMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMirrorMatrix(Adress, false);
		}