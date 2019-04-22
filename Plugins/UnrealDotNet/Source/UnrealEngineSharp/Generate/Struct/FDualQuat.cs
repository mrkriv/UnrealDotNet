// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\DualQuat.h:12

namespace UnrealEngine
{
	public  partial class FDualQuat : NativeStructWrapper
	{
		internal FDualQuat(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDualQuat(FQuat inR, FQuat inD) :
			base(E_CreateStruct_FDualQuat_FQuat_FQuat(inR, inD), false)
		{
		}

		public FDualQuat(FTransform t) :
			base(E_CreateStruct_FDualQuat_FTransform(t), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDualQuat_D_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDualQuat_D_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDualQuat_R_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDualQuat_R_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDualQuat_FQuat_FQuat(IntPtr inR, IntPtr inD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDualQuat_FTransform(IntPtr t);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FDualQuat_AsFTransform(IntPtr self, IntPtr scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FDualQuat_Normalized(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>half trans or dual part </para>
		/// </summary>
		public FQuat D
		{
			get => E_PROP_FDualQuat_D_GET(NativePointer);
			set => E_PROP_FDualQuat_D_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>rotation or real part </para>
		/// </summary>
		public FQuat R
		{
			get => E_PROP_FDualQuat_R_GET(NativePointer);
			set => E_PROP_FDualQuat_R_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Convert dual quat to transform </para>
		/// </summary>
		public FTransform AsFTransform(FVector scale)
			=> E_FDualQuat_AsFTransform(this, scale);
		
		
		/// <summary>
		/// <para>Return normalized dual quat </para>
		/// </summary>
		public FDualQuat Normalized()
			=> E_FDualQuat_Normalized(this);
		
		#endregion
		
		public static implicit operator IntPtr(FDualQuat self)
		{
			return self.NativePointer;
		}

		public static implicit operator FDualQuat(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDualQuat(Adress, false);
		}}}
