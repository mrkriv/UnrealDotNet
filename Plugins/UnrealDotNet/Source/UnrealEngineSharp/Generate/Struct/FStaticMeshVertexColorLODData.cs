// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:685

namespace UnrealEngine
{
	public  partial class FStaticMeshVertexColorLODData : NativeStructWrapper
	{
		internal FStaticMeshVertexColorLODData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStaticMeshVertexColorLODData() :
			base(E_CreateStruct_FStaticMeshVertexColorLODData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStaticMeshVertexColorLODData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FStaticMeshVertexColorLODData_IsValid(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Check whether this contains valid data
		/// </summary>
		public bool IsValid()
			=> E_FStaticMeshVertexColorLODData_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FStaticMeshVertexColorLODData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FStaticMeshVertexColorLODData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStaticMeshVertexColorLODData(Adress, false);
		}}}
