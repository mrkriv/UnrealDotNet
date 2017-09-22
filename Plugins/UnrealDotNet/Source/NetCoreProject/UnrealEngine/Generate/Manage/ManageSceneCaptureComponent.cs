using System;
using System.Runtime.InteropServices;

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
