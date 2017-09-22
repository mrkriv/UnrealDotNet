using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
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
