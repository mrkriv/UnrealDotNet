// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformCalculus3D.h:37

namespace UnrealEngine
{
	public  partial class FScale : NativeStructWrapper
	{
		internal FScale(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Ctor. initialize to an identity scale, 1.0.
		/// </summary>
		public FScale() :
			base(E_CreateStruct_FScale(), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a uniform scale.
		/// </summary>
		public FScale(float inScale) :
			base(E_CreateStruct_FScale_float(inScale), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from an FVector defining the 3D scale.
		/// </summary>
		public FScale(FVector inScale) :
			base(E_CreateStruct_FScale_FVector(inScale), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale_float(float inScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale_FVector(IntPtr inScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale_GetVector(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Access to the underlying FVector that stores the scale.
		/// </summary>
		public FVector GetVector()
			=> E_FScale_GetVector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FScale self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FScale(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScale(Adress, false);
		}}}
