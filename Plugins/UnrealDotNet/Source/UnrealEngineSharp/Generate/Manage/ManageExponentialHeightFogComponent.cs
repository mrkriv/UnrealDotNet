using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:15

namespace UnrealEngine
{
	[ManageType("ManageExponentialHeightFogComponent")]
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
