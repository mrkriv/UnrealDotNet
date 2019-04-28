// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformCalculus2D.h:86

namespace UnrealEngine
{
	public  partial class FScale2D : NativeStructWrapper
	{
		internal FScale2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Ctor. initialize to an identity scale, 1.0.
		/// </summary>
		public FScale2D() :
			base(E_CreateStruct_FScale2D(), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a uniform scale.
		/// </summary>
		public FScale2D(float inScale) :
			base(E_CreateStruct_FScale2D_float(inScale), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from a non-uniform scale.
		/// </summary>
		public FScale2D(float inScaleX, float inScaleY) :
			base(E_CreateStruct_FScale2D_float_float(inScaleX, inScaleY), false)
		{
		}

		
		/// <summary>
		/// Ctor. initialize from an FVector defining the 3D scale.
		/// </summary>
		public FScale2D(FVector2D inScale) :
			base(E_CreateStruct_FScale2D_FVector2D(inScale), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale2D();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale2D_float(float inScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale2D_float_float(float inScaleX, float inScaleY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScale2D_FVector2D(IntPtr inScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale2D_Concatenate(IntPtr self, IntPtr rHS);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale2D_GetVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale2D_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale2D_TransformPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FScale2D_TransformVector(IntPtr self, IntPtr vector);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Concatenate two scales.
		/// </summary>
		public FScale2D Concatenate(FScale2D rHS)
			=> E_FScale2D_Concatenate(this, rHS);
		
		
		/// <summary>
		/// Access to the underlying FVector2D that stores the scale.
		/// </summary>
		public FVector2D GetVector()
			=> E_FScale2D_GetVector(this);
		
		
		/// <summary>
		/// Invert the scale.
		/// </summary>
		public FScale2D Inverse()
			=> E_FScale2D_Inverse(this);
		
		
		/// <summary>
		/// Transform 2D Point
		/// </summary>
		public FVector2D TransformPoint(FVector2D point)
			=> E_FScale2D_TransformPoint(this, point);
		
		
		/// <summary>
		/// Transform 2D Vector
		/// </summary>
		public FVector2D TransformVector(FVector2D vector)
			=> E_FScale2D_TransformVector(this, vector);
		
		#endregion
		
		public static implicit operator IntPtr(FScale2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator FScale2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScale2D(Adress, false);
		}}}
