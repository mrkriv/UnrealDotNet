using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponentCube.h:17

namespace UnrealEngine
{
	public partial class ManageSceneCaptureComponentCube : USceneCaptureComponentCube
	{
		public ManageSceneCaptureComponentCube(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponentCube Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponentCube(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponentCube>(PtrDesc);
		}}}
