using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

namespace UnrealEngine
{
	public partial class ManageAudioComponent : UAudioComponent
	{
		public ManageAudioComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageAudioComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageAudioComponent>(PtrDesc);
		}}}
