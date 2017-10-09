using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ExponentialHeightFogComponent.h:15

namespace UnrealEngine
{
	public partial class ManageExponentialHeightFogComponent : UExponentialHeightFogComponent
	{
		public ManageExponentialHeightFogComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageExponentialHeightFogComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageExponentialHeightFogComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageExponentialHeightFogComponent>(PtrDesc);
		}}}
