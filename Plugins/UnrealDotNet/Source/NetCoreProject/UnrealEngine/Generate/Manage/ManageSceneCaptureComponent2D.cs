using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageSceneCaptureComponent2D : USceneCaptureComponent2D
	{
		public ManageSceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSceneCaptureComponent2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSceneCaptureComponent2D(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSceneCaptureComponent2D>(PtrDesc);
		}}}
