using System;
using System.Runtime.InteropServices;

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
