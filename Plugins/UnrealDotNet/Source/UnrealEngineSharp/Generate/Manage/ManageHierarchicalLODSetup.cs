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
	[ManageType("ManageHierarchicalLODSetup")]
	public partial class ManageHierarchicalLODSetup : UHierarchicalLODSetup
	{
		public ManageHierarchicalLODSetup(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageHierarchicalLODSetup self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageHierarchicalLODSetup(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageHierarchicalLODSetup>(PtrDesc);
		}}}
