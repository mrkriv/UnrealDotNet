using System;
using System.Runtime.InteropServices;

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
