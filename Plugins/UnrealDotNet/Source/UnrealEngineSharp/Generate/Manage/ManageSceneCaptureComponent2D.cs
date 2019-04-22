// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

namespace UnrealEngine
{
	[ManageType("ManageSceneCaptureComponent2D")]
	public partial class ManageSceneCaptureComponent2D : USceneCaptureComponent2D
	{
		public ManageSceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponent2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponent2D(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponent2D>(PtrDesc);
		}}}
