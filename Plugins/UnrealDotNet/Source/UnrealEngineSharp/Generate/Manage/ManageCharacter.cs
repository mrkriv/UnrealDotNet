// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

namespace UnrealEngine
{
	[ManageType("ManageCharacter")]
	public partial class ManageCharacter : ACharacter
	{
		public ManageCharacter(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageCharacter self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCharacter>(PtrDesc);
		}}}
