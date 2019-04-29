// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Canvas.h:154

namespace UnrealEngine
{
	[ManageType("ManageCanvas")]
	public partial class ManageCanvas : UCanvas
	{
		public ManageCanvas(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageCanvas self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCanvas(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCanvas>(PtrDesc);
		}}}
