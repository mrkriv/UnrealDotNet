using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:59

namespace UnrealEngine
{
	public partial class ManageSceneCaptureComponent : USceneCaptureComponent
	{
		public ManageSceneCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponent>(PtrDesc);
		}}}
