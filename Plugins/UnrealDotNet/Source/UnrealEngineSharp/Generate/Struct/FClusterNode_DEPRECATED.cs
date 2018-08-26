// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\HierarchicalInstancedStaticMeshComponent.h:19

namespace UnrealEngine
{
	public  partial class FClusterNode_DEPRECATED : NativeStructWrapper
	{
		internal FClusterNode_DEPRECATED(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClusterNode_DEPRECATED() :
			base(E_CreateStruct_FClusterNode_DEPRECATED(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClusterNode_DEPRECATED();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClusterNode_DEPRECATED_BoundMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_BoundMax_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClusterNode_DEPRECATED_BoundMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_BoundMin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_DEPRECATED_FirstChild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_FirstChild_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_DEPRECATED_FirstInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_FirstInstance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_DEPRECATED_LastChild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_LastChild_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_DEPRECATED_LastInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_DEPRECATED_LastInstance_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		public FVector BoundMax
		{
			get => E_PROP_FClusterNode_DEPRECATED_BoundMax_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_BoundMax_SET(NativePointer, value);
		}

		public FVector BoundMin
		{
			get => E_PROP_FClusterNode_DEPRECATED_BoundMin_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_BoundMin_SET(NativePointer, value);
		}

		public int FirstChild
		{
			get => E_PROP_FClusterNode_DEPRECATED_FirstChild_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_FirstChild_SET(NativePointer, value);
		}

		public int FirstInstance
		{
			get => E_PROP_FClusterNode_DEPRECATED_FirstInstance_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_FirstInstance_SET(NativePointer, value);
		}

		public int LastChild
		{
			get => E_PROP_FClusterNode_DEPRECATED_LastChild_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_LastChild_SET(NativePointer, value);
		}

		public int LastInstance
		{
			get => E_PROP_FClusterNode_DEPRECATED_LastInstance_GET(NativePointer);
			set => E_PROP_FClusterNode_DEPRECATED_LastInstance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClusterNode_DEPRECATED self)
		{
			return self.NativePointer;
		}

		public static implicit operator FClusterNode_DEPRECATED(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClusterNode_DEPRECATED(Adress, false);
		}}}
