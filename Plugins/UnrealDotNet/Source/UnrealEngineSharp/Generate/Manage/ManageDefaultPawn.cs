// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

namespace UnrealEngine
{
	[ManageType("ManageDefaultPawn")]
	public partial class ManageDefaultPawn : ADefaultPawn
	{
		public ManageDefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDefaultPawn self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageDefaultPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDefaultPawn>(PtrDesc);
		}}}
