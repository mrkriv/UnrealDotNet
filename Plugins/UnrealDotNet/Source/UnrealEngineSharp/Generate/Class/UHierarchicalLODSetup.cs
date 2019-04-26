// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:338

namespace UnrealEngine
{
	public  partial class UHierarchicalLODSetup : UObject
	{
		public UHierarchicalLODSetup(IntPtr Adress)
			: base(Adress)
		{
		}

		public UHierarchicalLODSetup(UObject Parent = null, string Name = "HierarchicalLODSetup")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UHierarchicalLODSetup(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UHierarchicalLODSetup(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UHierarchicalLODSetup self)
		{
			return self.NativePointer;
		}

		public static implicit operator UHierarchicalLODSetup(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UHierarchicalLODSetup>(PtrDesc);
		}}}
