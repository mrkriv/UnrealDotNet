using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageSphereComponent : USphereComponent
	{
		public ManageSphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSphereComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSphereComponent>(PtrDesc);
		}}}
