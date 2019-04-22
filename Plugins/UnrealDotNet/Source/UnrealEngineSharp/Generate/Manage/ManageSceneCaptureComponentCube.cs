// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

namespace UnrealEngine
{
	[ManageType("ManageSceneCaptureComponentCube")]
	public partial class ManageSceneCaptureComponentCube : USceneCaptureComponentCube
	{
		public ManageSceneCaptureComponentCube(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponentCube self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponentCube(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponentCube>(PtrDesc);
		}}}
