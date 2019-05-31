// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Pawn.h:37

namespace UnrealEngine
{
	[ManageType("ManagePawn")]
	public partial class ManagePawn : APawn
	{
		public ManagePawn(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManagePawn self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawn>(PtrDesc);
		}}}
