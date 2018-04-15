using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\HierarchicalInstancedStaticMeshComponent.h:18

namespace UnrealEngine
{
	public  partial class FClusterNode : NativeStructWrapper
	{
		internal FClusterNode(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClusterNode() :
			base(E_CreateStruct_FClusterNode(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClusterNode();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClusterNode_BoundMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_BoundMax_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FClusterNode_BoundMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_BoundMin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_FirstChild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_FirstChild_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_FirstInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_FirstInstance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_LastChild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_LastChild_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClusterNode_LastInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClusterNode_LastInstance_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		public FVector BoundMax
		{
			get => E_PROP_FClusterNode_BoundMax_GET(NativePointer);
			set => E_PROP_FClusterNode_BoundMax_SET(NativePointer, value);
		}

		public FVector BoundMin
		{
			get => E_PROP_FClusterNode_BoundMin_GET(NativePointer);
			set => E_PROP_FClusterNode_BoundMin_SET(NativePointer, value);
		}

		public int FirstChild
		{
			get => E_PROP_FClusterNode_FirstChild_GET(NativePointer);
			set => E_PROP_FClusterNode_FirstChild_SET(NativePointer, value);
		}

		public int FirstInstance
		{
			get => E_PROP_FClusterNode_FirstInstance_GET(NativePointer);
			set => E_PROP_FClusterNode_FirstInstance_SET(NativePointer, value);
		}

		public int LastChild
		{
			get => E_PROP_FClusterNode_LastChild_GET(NativePointer);
			set => E_PROP_FClusterNode_LastChild_SET(NativePointer, value);
		}

		public int LastInstance
		{
			get => E_PROP_FClusterNode_LastInstance_GET(NativePointer);
			set => E_PROP_FClusterNode_LastInstance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClusterNode Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClusterNode(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClusterNode(Adress, false);
		}}}
