// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:79

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshInstanceData : NativeStructWrapper
	{
		internal FInstancedStaticMeshInstanceData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInstancedStaticMeshInstanceData() :
			base(E_CreateStruct_FInstancedStaticMeshInstanceData(), false)
		{
		}

		public FInstancedStaticMeshInstanceData(FMatrix inTransform) :
			base(E_CreateStruct_FInstancedStaticMeshInstanceData_FMatrix(inTransform), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FInstancedStaticMeshInstanceData_Transform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FInstancedStaticMeshInstanceData_Transform_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData_FMatrix(IntPtr inTransform);
		
		#endregion
		
		#region Property
		public FMatrix Transform
		{
			get => E_PROP_FInstancedStaticMeshInstanceData_Transform_GET(NativePointer);
			set => E_PROP_FInstancedStaticMeshInstanceData_Transform_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshInstanceData self)
		{
			return self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshInstanceData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshInstanceData(Adress, false);
		}}}
