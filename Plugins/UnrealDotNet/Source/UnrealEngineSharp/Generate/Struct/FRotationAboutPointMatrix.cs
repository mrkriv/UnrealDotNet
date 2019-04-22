// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\RotationAboutPointMatrix.h:11

namespace UnrealEngine
{
	public  partial class FRotationAboutPointMatrix : FRotationTranslationMatrix
	{
		internal FRotationAboutPointMatrix(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="Rot">rotation </param>
		/// <param name="Origin">about which to rotate. </param>
		/// </summary>
		public FRotationAboutPointMatrix(FRotator rot, FVector origin) :
			base(E_CreateStruct_FRotationAboutPointMatrix_FRotator_FVector(rot, origin), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotationAboutPointMatrix_FRotator_FVector(IntPtr rot, IntPtr origin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationAboutPointMatrix_Make(IntPtr self, IntPtr rot, IntPtr origin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotationAboutPointMatrix_Make_o1(IntPtr self, IntPtr rot, IntPtr origin);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions. </para>
		/// </summary>
		public FMatrix Make(FRotator rot, FVector origin)
			=> E_FRotationAboutPointMatrix_Make(this, rot, origin);
		
		
		/// <summary>
		/// <para>Matrix factory. Return an FMatrix so we don't have type conversion issues in expressions. </para>
		/// </summary>
		public FMatrix Make(FQuat rot, FVector origin)
			=> E_FRotationAboutPointMatrix_Make_o1(this, rot, origin);
		
		#endregion
		
		public static implicit operator IntPtr(FRotationAboutPointMatrix self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRotationAboutPointMatrix(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotationAboutPointMatrix(Adress, false);
		}}}
