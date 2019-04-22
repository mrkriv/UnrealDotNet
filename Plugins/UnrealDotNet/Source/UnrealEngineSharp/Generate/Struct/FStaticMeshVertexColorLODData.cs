// This file was created automatically, do not modify the contents of this file.

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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FStaticMeshVertexColorLODData_PaintedVertices_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStaticMeshVertexColorLODData_PaintedVertices_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStaticMeshVertexColorLODData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FStaticMeshVertexColorLODData_IsValid(IntPtr self);
		
		#endregion
		
		#region Property
		public TArray<FPaintedVertex> PaintedVertices
		{
			get => E_PROP_FStaticMeshVertexColorLODData_PaintedVertices_GET(NativePointer);
			set => E_PROP_FStaticMeshVertexColorLODData_PaintedVertices_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Check whether this contains valid data </para>
		/// </summary>
		public bool IsValid()
			=> E_FStaticMeshVertexColorLODData_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FStaticMeshVertexColorLODData self)
		{
			return self.NativePointer;
		}

		public static implicit operator FStaticMeshVertexColorLODData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStaticMeshVertexColorLODData(Adress, false);
		}}}
