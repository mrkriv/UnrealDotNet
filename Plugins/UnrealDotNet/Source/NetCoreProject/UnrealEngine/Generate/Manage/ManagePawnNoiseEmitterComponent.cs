using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\PawnNoiseEmitterComponent.h:19

namespace UnrealEngine
{
	public partial class ManagePawnNoiseEmitterComponent : UPawnNoiseEmitterComponent
	{
		public ManagePawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePawnNoiseEmitterComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePawnNoiseEmitterComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawnNoiseEmitterComponent>(PtrDesc);
		}}}
