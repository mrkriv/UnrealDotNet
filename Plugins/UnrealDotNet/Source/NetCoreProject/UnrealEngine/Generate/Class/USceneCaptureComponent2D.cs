using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:19

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent2D : USceneCaptureComponent
	{
		public USceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponent2D(UObject Parent = null, string Name = "SceneCaptureComponent2D")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent2D(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent2D(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent2D>(PtrDesc);
		}}}
