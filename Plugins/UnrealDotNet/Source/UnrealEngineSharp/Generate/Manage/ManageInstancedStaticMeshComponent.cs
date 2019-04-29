// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

namespace UnrealEngine
{
	[ManageType("ManageInstancedStaticMeshComponent")]
	public partial class ManageInstancedStaticMeshComponent : UInstancedStaticMeshComponent
	{
		public ManageInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Clear all instances being rendered by this component.
		/// </summary>
		public override void ClearInstances() { }
		
		
		/// <summary>
		/// Preallocated memory to include the new added instances count, to prevent reallloc during the add operation.
		/// </summary>
		public override void PreAllocateInstancesMemory(int addedInstanceCount) { }
		
		public static implicit operator IntPtr(ManageInstancedStaticMeshComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInstancedStaticMeshComponent>(PtrDesc);
		}}}
