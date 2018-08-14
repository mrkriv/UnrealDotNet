using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LineBatchComponent.h:120

namespace UnrealEngine
{
	[ManageType("ManageLineBatchComponent")]
	public partial class ManageLineBatchComponent : ULineBatchComponent
	{
		public ManageLineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLineBatchComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLineBatchComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLineBatchComponent>(PtrDesc);
		}}}
