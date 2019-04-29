// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:56

namespace UnrealEngine
{
	[ManageType("ManageTouchInterface")]
	public partial class ManageTouchInterface : UTouchInterface
	{
		public ManageTouchInterface(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageTouchInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageTouchInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageTouchInterface>(PtrDesc);
		}}}
