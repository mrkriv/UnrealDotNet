// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Light.h:13

namespace UnrealEngine
{
	[ManageType("ManageLight")]
	public partial class ManageLight : ALight
	{
		public ManageLight(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageLight self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageLight(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLight>(PtrDesc);
		}}}
