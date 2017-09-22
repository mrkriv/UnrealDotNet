using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageDestructibleComponent : UDestructibleComponent
	{
		public ManageDestructibleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDestructibleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageDestructibleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDestructibleComponent>(PtrDesc);
		}}}
