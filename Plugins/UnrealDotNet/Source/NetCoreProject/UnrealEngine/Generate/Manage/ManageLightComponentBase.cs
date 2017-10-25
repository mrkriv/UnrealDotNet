using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

namespace UnrealEngine
{
	public partial class ManageLightComponentBase : ULightComponentBase
	{
		public ManageLightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLightComponentBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLightComponentBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLightComponentBase>(PtrDesc);
		}}}
