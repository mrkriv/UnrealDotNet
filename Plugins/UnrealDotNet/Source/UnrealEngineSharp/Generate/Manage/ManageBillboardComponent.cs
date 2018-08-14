using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManageBillboardComponent")]
	public partial class ManageBillboardComponent : UBillboardComponent
	{
		public ManageBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageBillboardComponent>(PtrDesc);
		}}}
